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
    public partial class frmConsultaCli : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public frmConsultaCli()
        {
            InitializeComponent();
        }

        private void txbNomeCli_TextChanged(object sender, EventArgs e)
        {
            if (txbNomeCli.Text != "")
            {
                try
                {
                    con.Abrir();
                    cmd.CommandText = "select * from cliente where nome_cliente like ('%" + txbNomeCli.Text + "%')";
                    cmd.Connection = con.Abrir();

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    dgvCli.DataSource = dt;
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
                dgvCli.DataSource = null;
        }

        private void txbCpfCli_TextChanged(object sender, EventArgs e)
        {
            if (txbCpfCli.Text != "")
            {
                try
                {
                    con.Abrir();
                    cmd.CommandText = "select * from cliente where cpf_cliente like ('%" + txbCpfCli.Text + "%')";
                    cmd.Connection = con.Abrir();

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvCli.DataSource = dt;
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
                dgvCli.DataSource = null;
        }

        private void txbEndCli_TextChanged(object sender, EventArgs e)
        {
            if (txbEndCli.Text != "")
            {
                try
                {
                    con.Abrir();
                    cmd.CommandText = "select * from cliente where endereço_cliente like ('%" + txbEndCli.Text + "%')";
                    cmd.Connection = con.Abrir();

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvCli.DataSource = dt;
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
                dgvCli.DataSource = null;
        }
    }
}
