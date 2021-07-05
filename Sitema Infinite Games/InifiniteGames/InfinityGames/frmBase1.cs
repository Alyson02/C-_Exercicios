using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityGames
{
    public partial class frmBase1 : Form
    {
        string pastaApp = "";

        public frmBase1()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            pastaApp = Application.StartupPath;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirJanela(object conteudo)
        {
            if (this.panelfake.Controls.Count > 0)
                this.panelfake.Controls.RemoveAt(0);
            Form janela = conteudo as Form;
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;
            this.panelfake.Controls.Add(janela);
            this.panelfake.Tag = janela;
            janela.Show();
        }

        private void Home (object conteudo)
        {
            if (this.panelBase.Controls.Count > 0)
                this.panelBase.Controls.RemoveAt(0);
            Form janela = conteudo as Form;
            janela.TopLevel = false;
            janela.Dock = DockStyle.None;
            this.panelBase.Controls.Add(janela);
            this.panelBase.Tag = janela;
            janela.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home(new frmBase1());
        }

        private void btnCadastraProd_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmCadastraProd());
            sidePanel.Height = btnCadastraProd.Height;
            sidePanel.Top = btnCadastraProd.Top;
        }

        private void btnCadastraCli_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmCadastraCli());
            sidePanel.Height = btnCadastraCli.Height;
            sidePanel.Top = btnCadastraCli.Top;
        }

        private void btnCadastraPedido_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmCadastraPedido());
            sidePanel.Height = btnCadastraPedido.Height;
            sidePanel.Top = btnCadastraPedido.Top;
        }

        private void btnCadastraFunc_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmCadastraFunc());
            sidePanel.Height = btnCadastraFunc.Height;
            sidePanel.Top = btnCadastraFunc.Top;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmAgenda());
            sidePanel.Height = btnAgenda.Height;
            sidePanel.Top = btnAgenda.Top;
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmVenda());
            sidePanel.Height = btnVenda.Height;
            sidePanel.Top = btnVenda.Top;
        }

        private void btnConsultarProd_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmConsultaProd());
            sidePanel.Height = btnConsultarProd.Height;
            sidePanel.Top = btnConsultarProd.Top;
        }

        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            abrirJanela(new frmConsultaCli());
            sidePanel.Height = btnConsultarCli.Height;
            sidePanel.Top = btnConsultarCli.Top;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Usuário Logado: " + frmLogin.usuarioConectado;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja desconectar?!", "Alert", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelfake.BackgroundImage = Image.FromFile(pastaApp + @"\imagens\pls3.jpg");
        }
    }
}
