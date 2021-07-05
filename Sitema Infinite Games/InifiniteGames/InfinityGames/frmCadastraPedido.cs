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
    public partial class frmCadastraPedido : Form
    {
        SqlConnection conexao = new SqlConnection(); // instancia um objeto de conexão
        String Strconexao = @"Data Source=DESKTOP-VRHP59O\SQLEXPRESS;Initial Catalog=infinitegames6;Integrated Security=True;";

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable DtGenerico = new DataTable();
        public int xCodPedido = 1;
        string texto = "";
        int digCalc;


        public frmCadastraPedido()
        {
            InitializeComponent();
            PreencherGrid();
        }

        private void frmCadastraPedido_Load(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            try
            {
                conexao.ConnectionString = Strconexao; // indicando o string de conexão
                cmd.Connection = conexao;  // indicando o objeto de conexão instanciado nas declarações globais
                conexao.Open();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro==> " + erro.Message, "FrmPrincipal_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
            PreencherGrid();
        }
        public void PreencherGrid()
        {
            conexao.ConnectionString = Strconexao;
            cmd.Connection = conexao;

            cmd.CommandText = "SELECT PEDIDO.COD_PEDIDO  'Código', COD_CLIENTE  'Código do cliente', VALOR  'Valor' from PEDIDO ";
            //MessageBox.Show(cmd.CommandText);
            try
            {
                conexao.Open(); // Efetiva a abertura de uma conexão com o BD
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader(); // alimenta o DataReader com a execução do comando (select)
                DtGenerico.Clear(); // limpa a tabela temporária caso tenha algum conteúdo anterior
                DtGenerico.Load(dr); // carrega tabela temporária com DataReader, ou seja, dados lidos (select)
                dgvPedido.DataSource = "";
                dgvPedido.DataSource = DtGenerico; // movimenta os dados da tabela temporária para o data grid view
                conexao.Close();
            }
            catch (Exception erro) // se deu erro executar:
            {
                MessageBox.Show("Erro==> " + erro.Message, "CarregarGrid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
            DtGenerico.Dispose(); // Eliminação do Data Table DtGenerico
            dgvPedido.ClearSelection();
            xCodPedido = 0;
        }


        private void dgvPedido_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvCadastraProd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvPedido.RowHeadersWidth < Convert.ToInt32((size.Width
                 + 20)))
            {
                dgvPedido.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        /*Limp campos*/

        private void limpaCamposProduto()
        {
            txbCodCli.Text = "";
            txbCodPedido.Text = "";
            txbValor.Text = "";

        }

        /*Cadastrar na tabela pedido*/


        private void txbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // só aceita números e backspace
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }


            if (e.KeyChar == 13)
            {
                if (naoExiste())
                {
                    try
                    {
                        SqlCommand cm = new SqlCommand("select * from cliente where cpf_cliente = @cpf", conexao);
                        cm.Parameters.AddWithValue("@cpf", txbCpf.Text);

                        conexao.Open();
                        SqlDataReader dr = cm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            txbCodCli.Text = dr["cod_cliente"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cpf não cadastrado");
                        }
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        conexao.Close();
                    }
                }
                else
                    MessageBox.Show("CPF não cadastrado!");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                cmd.CommandText = "INSERT INTO  pedido(valor) VALUES('0')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT max(cod_pedido) FROM pedido";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable da = new DataTable();
                    da.Load(dr);
                    xCodPedido = int.Parse(da.Rows[0][0].ToString());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "abrir tela item");
                if(conexao.State == ConnectionState.Open)conexao.Close();
            }
            frmItens frmItem = new frmItens(xCodPedido); // chama formulário e passa valor do numcomanda
            frmItem.ShowDialog();
            PreencherGrid();
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            xCodPedido = int.Parse(dgvPedido.CurrentRow.Cells[0].Value.ToString());
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Tem certeza que deseja deletar esse pedido", "Deletar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    txbCodPedido.Text = xCodPedido.ToString();
                    conexao.Open();
                    cmd.Connection = conexao;

                    cmd.CommandText = "delete from itenspedido where cod_pedido = @pedido";
                    cmd.Parameters.AddWithValue("@pedido", txbCodPedido.Text);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "delete from pedido where cod_pedido = @cod_pedido";
                    cmd.Parameters.AddWithValue("cod_pedido", txbCodPedido.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Produto deletado com sucesso");
                limpaCamposProduto();
                conexao.Close();
                PreencherGrid();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                conexao.Close();
            }
            
        }

        private bool CPFvalido(char[] charcpf)
        {
            int dv1, dv2, acum = 0;
            int[] cpf = new int[11];
            for (int i = 0; i < 11; i++) cpf[i] = int.Parse(charcpf[i].ToString());
            acum = cpf[0] * 10 + cpf[1] * 9 + cpf[2] * 8 + cpf[3] * 7 + cpf[4] * 6 + cpf[5] * 5 + cpf[6] * 4 + cpf[7] * 3 + cpf[8] * 2;
            dv1 = 11 - (acum % 11);
            if (dv1 >= 10) dv1 = 0; // finalizamos o digito verificar 1
            acum = cpf[0] * 11 + cpf[1] * 10 + cpf[2] * 9 + cpf[3] * 8 + cpf[4] * 7 + cpf[5] * 6 + cpf[6] * 5 + cpf[7] * 4 + cpf[8] * 3 + dv1 * 2;
            dv2 = 11 - (acum % 11);
            if (dv2 >= 10) dv2 = 0; // finalizamos o digito verificar 2
            //MessageBox.Show("dv1=" + dv1.ToString() + " dv2=" + dv2.ToString());
            digCalc = dv1 * 10 + dv2;
            if (dv1 == cpf[9] && dv2 == cpf[10]) return true;
            else return false;
        }

        public bool naoExiste()
        {
            DataTable dados = new DataTable();
            int qtdRegistros;
            conexao.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT cpf_cliente FROM cliente where cpf_cliente = '" +
                    txbCpf.Text + "'", conexao);
            da.Fill(dados);
            qtdRegistros = dados.Rows.Count;
            conexao.Close();
            if (qtdRegistros > 0)
                return true;
            else
            {
                texto = "";
                return false;
            }
        }

        /*private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (naoExiste())
                altera();
            else
                MessageBox.Show("CPF já cadastrado");
        }

        private void altera()
        {
            char[] cpf = new char[11];
            cpf = txbCpf.Text.ToCharArray();

            if (txbCpf.Text == "")
            {
                MessageBox.Show("Por  favor informe o cpf");
                txbCpf.Focus();
                return;
            }

            else if (CPFvalido(cpf))
            {
                try
                {
                    conexao.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandText = "update pedido set cod_cliente = @cliente ";
                        cmd.Parameters.AddWithValue("@cliente", txbCodCli.Text);
                        cmd.ExecuteNonQuery();
                    }
                    PreencherGrid();
                    limpaCamposProduto();
                    conexao.Close();
                    MessageBox.Show("Pedido alterado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na alteração");
                }
            }
            else
            {
                MessageBox.Show("CPF inválido!");
                texto = "";
            }
        }*/

        private void btnCadPedido_Click(object sender, EventArgs e)
        {
            char[] cpf = new char[11];
            cpf = txbCpf.Text.ToCharArray();

            //Consistencia de campos vazios

            if (txbCodCli.Text == "")
            {
                MessageBox.Show("Por  favor informe o código do cliente");
                txbCodCli.Focus();
                return;
            }
            //Inserir produto
            else if (txbCpf.Text == "")
            {
                MessageBox.Show("Informe um CPF!");
                txbCpf.Focus();
            }
            else if (CPFvalido(cpf))
            {
                conexao.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao;
                    cmd.CommandText = "update pedido set cod_cliente = @cliente where cod_pedido = "+ txbCodPedido.Text +"";
                    cmd.Parameters.AddWithValue("@cliente", txbCodCli.Text);

                    //MessageBox.Show(cmd.CommandText);

                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
                PreencherGrid();
                //Limpar campos
                limpaCamposProduto();

                MessageBox.Show("Pedido cadastrado com sucesso!");
                return;
            }
            else
            {
                MessageBox.Show("CPF inválido!");
                txbCpf.Focus();
            }
        }

        private void dgvPedido_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvPedido.SelectedRows[0];
            txbCodPedido.Text = dr.Cells[0].Value.ToString();
            txbCodCli.Text = dr.Cells[1].Value.ToString();
            txbValor.Text = dr.Cells[2].Value.ToString();
            txbCpf.Focus();
        }
    }
}
