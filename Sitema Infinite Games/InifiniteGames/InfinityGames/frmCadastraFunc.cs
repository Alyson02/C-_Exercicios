using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityGames
{
    public partial class frmCadastraFunc : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public frmCadastraFunc()
        {
            InitializeComponent();
            PreencherGrid();
            desativaBtn();
        }

        public void PreencherGrid()
        {
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("", con.Abrir());
            /*Usando o "as" para trazer insformação ´para o datagrid diferente do bd*/
            da.SelectCommand.CommandText = "SELECT funcionario.cod_funcionario as Código, nome_funcionario as Nome, usuario_funcionario as Usuário, senha_funcionario as Senha from funcionario";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFunc.DataSource = dt;
            con.Fechar();
        }

        private void limpaCampos()
        {
            txbNomeFunc.Text = "";
            txbCod.Text = "";
            txbUser.Text = "";
            txbSenha.Text = "";

        }

        private void dgvFunc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvFunc.SelectedRows[0];
            txbCod.Text = dr.Cells[0].Value.ToString();
            txbNomeFunc.Text = dr.Cells[1].Value.ToString();
            txbUser.Text = dr.Cells[2].Value.ToString();
            txbSenha.Text = dr.Cells[3].Value.ToString();
            txbNomeFunc.Focus();
        }

        private void dgvFunc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvFunc.RowHeadersWidth < Convert.ToInt32((size.Width
                 + 20)))
            {
                dgvFunc.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            txbNomeFunc.Enabled = true;
            txbSenha.Enabled = true;
            txbUser.Enabled = true;
            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnDel.Enabled = true;
        }

        private void desativaBtn()
        {
            btnAdd.Enabled = true;
            txbNomeFunc.Enabled = false;
            txbSenha.Enabled = false;
            txbUser.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnDel.Enabled = false;
        }

        /*private void btnCadFunc_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con.Abrir();
                cmd.CommandText = "insert into funcionario(nome_funcionario, usuario_funcionario, senha_funcionario) values(@nome, @usuario, @senha)";

                cmd.Parameters.AddWithValue("@nome", txbNomeFunc.Text);
                cmd.Parameters.AddWithValue("@usuario", txbUser.Text);
                cmd.Parameters.AddWithValue("@senha", txbSenha.Text);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Funcionario cadastrado com sucesso!!");
            limpaCampos();
            con.Fechar();
        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txbNomeFunc.Enabled = true;
            txbSenha.Enabled = true;
            txbUser.Enabled = true;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnDel.Enabled = false;
            txbNomeFunc.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Concistencia

            if (txbNomeFunc.Text == "")
            {
                MessageBox.Show("Por  favor informe o nome");
                txbNomeFunc.Focus();
                return;
            }

            /* if (txbCod.Text == "")
             {
                 MessageBox.Show("Por  favor informe o nome");
                 txbCod.Focus();
                 return;
             }*/

            if (txbUser.Text == "")
            {
                MessageBox.Show("Por  favor informe o usuário do funcionário");
                txbUser.Focus();
                return;
            }

            if (txbSenha.Text == "")
            {
                MessageBox.Show("Por  favor informe a senha do funcionário");
                txbSenha.Focus();
                return;
            }

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con.Abrir();
                cmd.CommandText = "insert into funcionario(nome_funcionario, usuario_funcionario, senha_funcionario) values(@nome, @user, @senha)";

                cmd.Parameters.AddWithValue("@nome", txbNomeFunc.Text);
                cmd.Parameters.AddWithValue("@senha", txbSenha.Text);
                cmd.Parameters.AddWithValue("@user", txbUser.Text);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Cliente cadastrado com sucesso!!");
            limpaCampos();
            PreencherGrid();
            desativaBtn();
            con.Fechar();

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
                    cmd.CommandText = "delete from funcionario where cod_funcionario = @cod_funcionario";

                    cmd.Parameters.AddWithValue("@cod_funcionario", txbCod.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Funcionario deletado com Sucesso!");
                PreencherGrid();
                limpaCampos();
                con.Fechar();
            }
            else
            return;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Abrir();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.Abrir();
                    cmd.CommandText = "update funcionario set nome_funcionario = @nome, usuario_funcionario = @user, senha_funcionario = @senha where cod_funcionario = @cod_funcionario; ";

                    cmd.Parameters.AddWithValue("@nome", txbNomeFunc.Text);
                    cmd.Parameters.AddWithValue("@cod_funcionario", txbCod.Text);
                    cmd.Parameters.AddWithValue("@user", txbUser.Text);
                    cmd.Parameters.AddWithValue("@senha", txbSenha.Text);
                    cmd.ExecuteNonQuery();
                }
                PreencherGrid();
                con.Fechar();
                limpaCampos();
                desativaBtn();
                MessageBox.Show("funcionario alterado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
