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
    public partial class frmCadastraProd : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public static int quantidade;

        public frmCadastraProd()
        {
            InitializeComponent();
            cmd.Connection = con.Abrir();
            PreencherGrid();
        }

        /*Método para preencher o datagrid na consulta*/

        public void PreencherGrid()
        {
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("", con.Abrir());
            /*Usando o "as" para trazer insformação ´para o datagrid diferente do bd*/
            da.SelectCommand.CommandText = "SELECT PRODUTO.cod_produto as Código, nome_produto as Nome, VALOR as Valor ,Quantidade as Quantidade , CATEGORIA_PRODUTO as Categoria from PRODUTO";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCadastraProd.DataSource = dt;
            con.Fechar();
        }

        private void impedeNaoNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // só aceita números e backspace
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        /*Método do datagrid*/

        private void dgvCadastraProd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvCadastraProd.SelectedRows[0];
            txbCod.Text = dr.Cells[0].Value.ToString();
            txbNome.Text = dr.Cells[1].Value.ToString();
            txbQuanti.Text = dr.Cells[3].Value.ToString();
            txbValor.Text = dr.Cells[2].Value.ToString();
            txbCat.Text = dr.Cells[4].Value.ToString();
            txbNome.Focus();
        }

        /*Método para numerar os campos no dr*/

        private void dgvCadastraProd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvCadastraProd.RowHeadersWidth < Convert.ToInt32((size.Width
                 + 20)))
            {
                dgvCadastraProd.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        /*Metodo para cadastrar os dados no BD*/

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Consistencia de campos vazios

            if (txbNome.Text == "")
            {
                MessageBox.Show("Por  favor informe o nome");
                txbNome.Focus();
                return;
            }

            /* if (txbCod.Text == "")
             {
                 MessageBox.Show("Por  favor informe o nome");
                 txbCod.Focus();
                 return;
             }*/

            else if (txbQuanti.Text == "")
            {
                MessageBox.Show("Por  favor informe a quantidade");
                txbQuanti.Focus();
                return;
            }

            else if (txbValor.Text == "")
            {
                MessageBox.Show("Por  favor informe o valor");
                txbValor.Focus();
                return;
            }
            //Inserir produto

            else
            {

                string txt;

                txt = pnCat.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                txbCat.Text = txt;

                con.Abrir();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.Abrir();
                    cmd.CommandText = "insert into produto(nome_produto,VALOR,Quantidade,CATEGORIA_PRODUTO) values(@nome_produto,@VALOR,@Quantidade,@CATEGORIA_PRODUTO)";
                    cmd.Parameters.AddWithValue("@VALOR", txbValor.Text.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@Quantidade", txbQuanti.Text);
                    cmd.Parameters.AddWithValue("@CATEGORIA_PRODUTO", txbCat.Text);
                    cmd.Parameters.AddWithValue("@nome_produto", txbNome.Text);
                    //cmd.Parameters.AddWithValue("@cod_produto", txbCod);

                    //MessageBox.Show(cmd.CommandText);

                    cmd.ExecuteNonQuery();
                }
                con.Fechar();
                PreencherGrid();
                //Limpar campos
                limpaCamposProduto();
                desativaBtn();

                MessageBox.Show("Produto cadastrado com sucesso!");
                return;
            }
        }

        private void limpaCamposProduto()
        {
            txbNome.Text = "";
            txbCod.Text = "";
            txbQuanti.Text = "";
            txbValor.Text = "";
        }


        // Método para atualizar dados 
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Consistencia de campos vazios

            if (txbNome.Text == "")
            {
                MessageBox.Show("Por  favor informe o nome");
                txbNome.Focus();
                return;
            }

            /*if (txbCod.Text == "")
            {
                MessageBox.Show("Por  favor informe o nome");
                txbCod.Focus();
                return;
            }*/

            else if (txbQuanti.Text == "")
            {
                MessageBox.Show("Por  favor informe a quantidade");
                txbQuanti.Focus();
                return;
            }

            else if (txbValor.Text == "")
            {
                MessageBox.Show("Por  favor informe o valor");
                txbValor.Focus();
                return;
            }
            //Inserir produto
            con.Abrir();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con.Abrir();
                cmd.CommandText = "update produto set nome_produto = @nome_produto,VALOR = @VALOR, Quantidade = @quantidade, CATEGORIA_PRODUTO = @CATEGORIA_PRODUTO where cod_produto = @cod_produto; ";

                cmd.Parameters.AddWithValue("@nome_produto", txbNome.Text);
                cmd.Parameters.AddWithValue("@cod_produto", txbCod.Text);
                cmd.Parameters.AddWithValue("@VALOR", txbValor.Text.Replace(",", "."));
                cmd.Parameters.AddWithValue("@Quantidade", txbQuanti.Text);
                cmd.Parameters.AddWithValue("@CATEGORIA_PRODUTO", txbCat.Text);
                cmd.ExecuteNonQuery();
            }
            PreencherGrid();
            con.Fechar();
            limpaCamposProduto();
            desativaBtn();
            MessageBox.Show("Produto alterado com sucesso");
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
                    cmd.CommandText = "delete from produto where cod_produto = @cod_produto";

                    cmd.Parameters.AddWithValue("@cod_produto", txbCod.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Produto deletado com Sucesso!");
                PreencherGrid();
                con.Fechar();
            }
            else
                return;
        }

        private void desativaBtn()
        {
            btnAdd.Enabled = true;

            pnCat.Enabled = false;
            txbNome.Enabled = false;
            txbQuanti.Enabled = false;
            txbValor.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnDel.Enabled = false;
        }
        private void frmCadastraProd_Load(object sender, EventArgs e)
        {
            desativaBtn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            pnCat.Enabled = true;
            txbNome.Enabled = true;
            txbQuanti.Enabled = true;
            txbValor.Enabled = true;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnDel.Enabled = false;
            txbNome.Focus();
        }

        private void dgvCadastraProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            pnCat.Enabled = true;
            txbNome.Enabled = true;
            txbQuanti.Enabled = true;
            txbValor.Enabled = true;
            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnDel.Enabled = true;
        }
    }
}