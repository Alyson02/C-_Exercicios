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
    public partial class frmLogin : Form
    {
        //String de conexão com o banco de dados
        //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-VRHP59O\SQLEXPRESS; Initial Catalog = infinitegames6; Integrated Security = True");
        //Comandos do sql
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public bool logado = false;
        public static string usuarioConectado;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            try
            {
                con.Abrir();
                DataTable dados = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from FUNCIONARIO where usuario_FUNCIONARIO = @user and SENHA_FUNCIONARIO = @senha", con.Abrir());
                da.SelectCommand.Parameters.AddWithValue("@user", txtBoxUsertxtBoxUser.Text);
                da.SelectCommand.Parameters.AddWithValue("@senha", txtBoxSenha.Text);
                da.Fill(dados);
                if (dados.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário/senha inválidos!\n Tente novamente.");
                    logado = false;
                }
                else
                {
                    logado = true;
                    usuarioConectado = txtBoxUsertxtBoxUser.Text;
                    frmBase menu = new frmBase();
                    menu.Show();
                    this.Hide();
                }
                con.Fechar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro! " + erro.Message, "No login ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Fechar();
            }
        }

        void showPassword(TextBox textBox, bool show)
        {
            if (show)
                textBox.PasswordChar = '\0';
            else
                textBox.PasswordChar = '*';
        }

        private void btnMostrarSenha_MouseEnter(object sender, EventArgs e)
        {
            showPassword(txtBoxSenha, true);
        }

        private void btnMostrarSenha_MouseLeave(object sender, EventArgs e)
        {
            showPassword(txtBoxSenha, false);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMin.Visible = true;
        }

        private void txtBoxSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Login();
        }
    }
}
