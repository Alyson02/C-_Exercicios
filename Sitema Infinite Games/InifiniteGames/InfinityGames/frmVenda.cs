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
    public partial class frmVenda : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public frmVenda()
        {
            InitializeComponent();
            PreencherGrid();
            PreencherGridVenda();
        }

        public void PreencherGrid()
        {
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("", con.Abrir());
            /*Usando o "as" para trazer insformação ´para o datagrid diferente do bd*/
            da.SelectCommand.CommandText = "SELECT PEDIDO.COD_PEDIDO as código,COD_CLIENTE as códigoCliente, VALOR as valor from PEDIDO";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPedido.DataSource = dt;
            con.Fechar();
        }

        public void PreencherGridVenda()
        {
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("", con.Abrir());
            /*Usando o "as" para trazer insformação ´para o datagrid diferente do bd*/
            da.SelectCommand.CommandText = "SELECT venda.COD_VENDA as código,COD_CLIENTE as códigoCliente, FORMA_PAGAMENTO as Forma, COD_PEDIDO as Pedido, VALOR_VENDA as Valor from Venda";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVenda.DataSource = dt;
            con.Fechar();
        }


        private void dgvPedido_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvPedido.SelectedRows[0];
            txbCodPedido.Text = dr.Cells[0].Value.ToString();
            txbCodCli.Text = dr.Cells[1].Value.ToString();
            //txbQuantPedido.Text = dr.Cells[2].Value.ToString();
            txbValor.Text = dr.Cells[2].Value.ToString();
        }
    
        private void dgvPedido_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            string txt;
            txt = pnPag.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            txbPanelPag.Text = txt;

            
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    con.Abrir();
                    cmd.Connection = con.Abrir();

                    cmd.CommandText = "insert into venda( cod_pedido, cod_cliente, valor_venda, forma_pagamento) " +
                        "values( @pedido, @cliente, @valor, @forma)";

                    //cmd.Parameters.AddWithValue("@venda", txbCodVenda.Text);
                    cmd.Parameters.AddWithValue("@pedido", txbCodPedido.Text);
                    cmd.Parameters.AddWithValue("@cliente", txbCodCli.Text);
                    cmd.Parameters.AddWithValue("@valor", txbValor.Text);
                    cmd.Parameters.AddWithValue("@forma", txbPanelPag.Text);
                    //MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    if(rdbSim.Checked)
                    {
                        SqlCommand cm = new SqlCommand();
                        con.Abrir();
                        cm.Connection = con.Abrir();
                        cm.CommandText = "insert into entrega(ENDEREÇO_CLIENTE, DATA_ENTREGA)" +
                            "values(@end, @data)";

                        //cmd.Parameters.AddWithValue("@entrega,", txbCodEnd.Text);
                        cm.Parameters.AddWithValue("@end", txbEndCli.Text);
                        cm.Parameters.AddWithValue("@data", dtEnt.Value.Date);
                        //MessageBox.Show(cm.CommandText);
                        cm.ExecuteNonQuery();
                    }

                    con.Fechar();
                    MessageBox.Show("Venda realiza e registrada com sucesso");
                    PreencherGridVenda();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro no cadastro da tabela venda ou entrega");
                }
            }
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            txbEndCli.Enabled = true;
            txbNomeCli.Enabled = true;
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            txbEndCli.Enabled = false;
            txbNomeCli.Enabled = !true;
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            txbEndCli.Enabled = false;
            txbNomeCli.Enabled = !true;
        }

        private void txbCodCli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand("select * from cliente where cod_cliente = @cliente", con.Abrir());
                cm.Parameters.AddWithValue("@cliente", txbCodCli.Text);

                con.Abrir();
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    txbNomeCli.Text = dr["nome_cliente"].ToString();
                    txbEndCli.Text = dr["ENDEREÇO_CLIENTE"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!");
                }
                con.Fechar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
