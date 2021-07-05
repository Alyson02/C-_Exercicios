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
    public partial class frmConsultaProd : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public frmConsultaProd()
        {
            InitializeComponent();

        }

        private void rdbConsulta()
        {
            try
            {
                string txt;
                txt = pnCat.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                txbCat.Text = txt;

                con.Abrir();
                cmd.CommandText = "select * from produto where categoria_produto like('%" + txbCat.Text + "%')";
                cmd.Connection = con.Abrir();

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);

                dgvCadastraProd.DataSource = dt;
                con.Fechar();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void rbtnJogo_CheckedChanged(object sender, EventArgs e)
        {
            rdbConsulta();
        }

        private void rbtnConsole_CheckedChanged(object sender, EventArgs e)
        {
            rdbConsulta();
        }

        private void rbtnPeriferico_CheckedChanged(object sender, EventArgs e)
        {
            rdbConsulta();
        }
        private void txbNomeProd_TextChanged_1(object sender, EventArgs e)
        { 
            if (txbNomeProd.Text != "")
            {
                try
                {
                    con.Abrir();
                    cmd.CommandText = "select * from produto where nome_produto like ('%" + txbNomeProd.Text + "%')";
                    cmd.Connection = con.Abrir();

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    dgvCadastraProd.DataSource = dt;
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
                dgvCadastraProd.DataSource = null;
        }

        private void txbValorProd_TextChanged(object sender, EventArgs e)
        {
            if (txbValorProd.Text != "")
            {
                try
                {
                    con.Abrir();
                    cmd.CommandText = "select * from produto where valor like ('%" + txbValorProd.Text + "%')";
                    cmd.Connection = con.Abrir();

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    dgvCadastraProd.DataSource = dt;
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
                dgvCadastraProd.DataSource = null;
        }

        private void frmConsultaProd_Load(object sender, EventArgs e)
        {

        }
    }
}
