using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityGames
{
    public partial class frmItens : Form
    {
        Conexao con = new Conexao();
        SqlConnection conexao = new SqlConnection(); // instancia um objeto de conexão
        String Strconexao = @"Data Source=DESKTOP-VRHP59O\SQLEXPRESS;Initial Catalog=infinitegames6;Integrated Security=True;";
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public int chavePedido, UltimoItem=0, xItem=0;
        public bool primvez = true;
        string texto = "";

        public frmItens(int  chave)
        {
            InitializeComponent();
            chavePedido = chave;
            
        }

        private void impedeNaoNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // só aceita números e backspace
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public void PreencherGrid()
        {
            bool TemItens = false;
            DataTable DtGenerico = new DataTable(); // instanciando uma tabela temporária

            cmd.CommandText = "SELECT a.COD_PRODUTO, b.nome_produto 'Produto', a.COD_PEDIDO, a.NUMERO_ITEM, a.QUANTIDADE, a.preco 'Preço'" +
                "from itenspedido a join produto b on a.cod_produto = b.cod_produto where a.cod_pedido = " + chavePedido;
            try
            {
                conexao.Open(); // Efetiva a abertura de uma conexão com o BD
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader(); // alimenta o DataReader com a execução do comando (select)
                if (dr.HasRows) TemItens = true;
                DtGenerico.Clear(); // limpa a tabela temporária caso tenha algum conteúdo anterior
                DtGenerico.Load(dr); // carrega tabela temporária com DataReader, ou seja, dados lidos (select)
                dgvItem.DataSource = "";
                dgvItem.DataSource = DtGenerico; // movimenta os dados da tabela temporária para o data grid view
                conexao.Close();
            }
            catch (Exception erro) // se deu erro executar:
            {
                MessageBox.Show(erro.Message);
                conexao.Close();
            }
            if (TemItens) PreparaProximoNumItem(); else UltimoItem = 1;
            DtGenerico.Dispose(); // Eliminação do Data Table DtGenerico
            dgvItem.ClearSelection();
            xItem = 0;
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            xItem = int.Parse(dgvItem.CurrentRow.Cells[3].Value.ToString());
            txbCodItem.Text = xItem.ToString();
            txbQuantiProd.Text = dgvItem.CurrentRow.Cells[4].Value.ToString();
            txbValor.Text = dgvItem.CurrentRow.Cells[5].Value.ToString();
            cmbProd.SelectedValue = dgvItem.CurrentRow.Cells[0].Value.ToString();
        }

        private void limpaCampos()
        {
            txbCodProd.Text = "";
            txbQuantiProd.Text = "";
            txbValor.Text = "";
        }

        private void dgvPedido_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (dgvItem.RowHeadersWidth < Convert.ToInt32((size.Width
                     + 20)))
                {
                    dgvItem.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbQuantiProd.Text != "" && cmbProd.SelectedIndex != -1)
            {
                if (int.Parse(txbQuantiProd.Text) < int.Parse(txbQnt.Text))
                {
                    try
                    {
                        int a = int.Parse(txbQnt.Text);
                        int b = int.Parse(txbQuantiProd.Text);
                        int resultado = a - b ;

                        conexao.Open();
                        cmd.CommandText = "insert into itenspedido(cod_produto, cod_pedido, numero_item, QUANTIDADE, preco)" +
                                "values(" + cmbProd.SelectedValue + "," + txbCodPedi.Text + "," + txbCodItem.Text + "," + txbQuantiProd.Text + "," + txbValor.Text.Replace(",", ".") + ")";

                        //MessageBox.Show(cmd.CommandText);

                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "Update pedido set valor = (select sum(quantidade*preco) " +
                        "from itenspedido where cod_pedido = " + txbCodPedi.Text + ") where cod_pedido = " + txbCodPedi.Text;

                        //MessageBox.Show(cmd.CommandText);

                        cmd.ExecuteNonQuery();

                        txbQnt.Text = resultado.ToString();
                        cmd.CommandText = "Update produto set quantidade = " + txbQnt.Text + " where cod_produto = " + txbCodProd.Text;
                        //cmd.Parameters.AddWithValue("@quanti", txbQnt.Text);

                        cmd.ExecuteNonQuery();

                        limpaCampos();
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - incluir modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (conexao.State == ConnectionState.Open)
                            conexao.Close();
                    }
                    PreencherGrid();
                    txbQuantiProd.Clear();
                    txbCodItem.Text = UltimoItem.ToString();
                    cmbProd.SelectedIndex = -1;
                    txbValor.Text = "";
                }
                else
                    MessageBox.Show("Quantidade superior a cadastrada!");

            }
            else MessageBox.Show("É necessário preencher todos campos corretamente antes de Incluir!", "Inclusão impossível", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmItens_Load(object sender, EventArgs e)
        {
            conexao.ConnectionString = Strconexao; // indicando o string de conexão
            cmd.Connection = conexao;  // indicando o objeto de conexão instanciado nas declarações globais
            PreencherGrid();
            CarregaProduto();
            txbCodPedi.Text = chavePedido.ToString();
            txbCodItem.Text = UltimoItem.ToString();
        }
        private void CarregaProduto()
        {
            try
            {
                conexao.Open();
                cmd.CommandText = "SELECT cod_produto, nome_produto FROM produto";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable da = new DataTable();
                    da.Load(dr);
                    cmbProd.ValueMember = "cod_produto";
                    cmbProd.DisplayMember = "nome_produto";
                    cmbProd.DataSource = da;
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - CarregaComboProdutos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
            cmbProd.SelectedIndex = -1;
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente deletar o Produto?";
            string caption = "Deleta Produto";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // mostras as mensagens de perguntas delete.

            result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.Abrir();
                    cmd.CommandText = "delete from itenspedido where numero_item = @pedido";

                    cmd.Parameters.AddWithValue("@pedido", txbCodItem.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Item deletado com Sucesso!");
                PreencherGrid();
                limpaCampos();
                con.Fechar();
            }
            else
                return;
        }

        private void btnCadPedido_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Tem certeza que finalizou de adicionar os itens", "Finalizar Itens", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Hide();
            else
                return;
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedIndex != -1 && (cmbProd.SelectedIndex != 0 || !primvez))
            {
                try
                {
                    conexao.Open();
                    cmd.CommandText = "SELECT valor FROM produto where cod_produto = '" + cmbProd.SelectedValue + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable da = new DataTable();
                        da.Load(dr);
                        txbValor.Text = da.Rows[0][0].ToString();
                    }
                    conexao.Close();
                    conexao.Close();

                    txbCodProd.Text = cmbProd.SelectedValue.ToString();
                    SqlCommand cm = new SqlCommand("select * from produto where cod_produto = @produto", conexao);
                    cm.Parameters.AddWithValue("@produto", txbCodProd.Text);

                    conexao.Open();
                    SqlDataReader dra = cm.ExecuteReader();
                    dra.Read();
                    txbQnt.Text = dra["quantidade"].ToString();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro==> " + erro.Message, "cmbProduto_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (conexao.State == ConnectionState.Open)
                        conexao.Close();
                }
            }
            else primvez = false;

            /*try
            {
                SqlCommand cmd = new SqlCommand("select * from produto where cod_produto = @produto", conexao);
                cmd.Parameters.AddWithValue("@produto", txbCodProd.Text);

                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                lbQnt.Text = dr["quantidade"].ToString();
                conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Carregar lbQnt");
                conexao.Close();
            }*/
        }

        private void PreparaProximoNumItem()
        {
            try
            {
                conexao.Open();
                cmd.CommandText = "SELECT count(*) FROM itenspedido where cod_Pedido = " + chavePedido;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable da = new DataTable();
                    da.Load(dr);
                    UltimoItem = int.Parse(da.Rows[0][0].ToString()) + 1;
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - PreparaProximoNumItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }
    }
}
