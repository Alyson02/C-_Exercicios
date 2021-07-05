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
    public partial class frmAgenda : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string texto = "";
        int digcalc;

        public frmAgenda()
        {
            InitializeComponent();
            PreencherGrid();
        }

        /*Método para preencher o datagrid na consulta*/

        public void PreencherGrid()
        {
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("", con.Abrir());
            /*Usando o "as" para trazer insformação ´para o datagrid diferente do bd*/
            da.SelectCommand.CommandText = "SELECT agenda.cod_agenda as Agenda, cod_produto as Código_prod, nome_produto as Nome, cod_cliente as Código_cli , data_agenda as Data , horario_agenda as Horario from agenda";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAgenda.DataSource = dt;
            con.Fechar();
        }

        private void dgvAgenda_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvAgenda.SelectedRows[0];
            txbCod.Text = dr.Cells[0].Value.ToString();
            txbCodCli.Text = dr.Cells[3].Value.ToString();
            txbCodProd.Text = dr.Cells[1].Value.ToString();
            cmbProd.Text = dr.Cells[2].Value.ToString();
            cmbHora.Text = dr.Cells[5].Value.ToString();
            //dtpData.Text = dr.Cells[5].Value.ToString();
            cmbProd.Focus();
        }

        /*Método para numerar os campos no dr*/

        private void dgvCadastraProd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvAgenda.RowHeadersWidth < Convert.ToInt32((size.Width
                 + 20)))
            {
                dgvAgenda.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void limpaCampos()
        {
            txbCod.Text = "";
            cmbProd.Text = "";
            //txbCod.Text = "";
            txbCpf.Text = "";
            txbCodProd.Text = "";
            txbCodCli.Text = "";
            cmbHora.Text = "";
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            cmbProd.Enabled = true;
            //txbCod.Enabled = true;
            txbCpf.Enabled = true;
            txbCodProd.Enabled = true;
            txbCodCli.Enabled = true;
            cmbHora.Enabled = true;
            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnDel.Enabled = true;
        }

        private void desativaBtn()
        {
            btnAdd.Enabled = true;
            cmbProd.Enabled = false;
            //txbCod.Enabled = false;
            txbCpf.Enabled = false;
            txbCodProd.Enabled = false;
            txbCodCli.Enabled = false;
            cmbHora.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnDel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            cmbProd.Enabled = true;
            //txbCod.Enabled = true;
            txbCpf.Enabled = true;
            txbCodProd.Enabled = true;
            txbCodCli.Enabled = true;
            cmbHora.Enabled = true;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnDel.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Concistencia

            char[] cpf = new char[11];
            cpf = txbCpf.Text.ToCharArray();

            if (txbCpf.Text == "")
            {
                MessageBox.Show("Por  favor informe o cpf");
                txbCpf.Focus();
                return;
            }

            /* if (txbCod.Text == "")
             {
                 MessageBox.Show("Por  favor informe o nome");
                 txbCod.Focus();
                 return;
             }*/

            else if (cmbProd.Text == "")
            {
                MessageBox.Show("Por  favor selecione um produto");
                cmbProd.Focus();
                return;
            }

            else if (cmbHora.Text == "")
            {
                MessageBox.Show("Por  favor informe a hora da agenda");
                cmbHora.Focus();
                return;
            }
            else if (CPFvalido(cpf))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con.Abrir();
                        cmd.CommandText = "insert into agenda(COD_PRODUTO ,COD_CLIENTE, NOME_PRODUTO, DATA_AGENDA, HORARIO_AGENDA) values(@codProd, @codCli, @prod, @data, @hora)";

                        cmd.Parameters.AddWithValue("@codProd", txbCodProd.Text);
                        cmd.Parameters.AddWithValue("@codCli", txbCodCli.Text);
                        cmd.Parameters.AddWithValue("@prod", cmbProd.Text);
                        cmd.Parameters.AddWithValue("@data", dtpData.Value.Date);
                        cmd.Parameters.AddWithValue("@hora", cmbHora.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Agenda cadastrada com sucesso!!");
                    limpaCampos();
                    PreencherGrid();
                    desativaBtn();
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("CPF inválido!");
                txbCpf.Focus();
            }

        }

        private void CarregaProduto()
        {
            try
            {
                con.Abrir();
                cmd.Connection = con.Abrir();
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
                con.Fechar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro==> " + erro.Message, "frmAssociado - CarregaComboCurso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Fechar();
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CarregaProduto();
            desativaBtn();
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbCodProd.Text = cmbProd.SelectedValue.ToString();
        }

        private void txbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // só aceita números e backspace
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }

            if (e.KeyChar == 13)
            {
                if(naoExiste())
                    try
                    {
                        SqlCommand cm = new SqlCommand("select * from cliente where cpf_cliente = @cpf", con.Abrir());
                        cm.Parameters.AddWithValue("@cpf", txbCpf.Text);

                        con.Abrir();
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
                        con.Fechar();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }
                else
                {
                    MessageBox.Show("CPF não cadastrado!");
                    txbCpf.Focus();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
                aletera();
        }

        private void aletera()
        {
            char[] cpf = new char[11];
            cpf = txbCpf.Text.ToCharArray();

            if (CPFvalido(cpf))
            {
                try
                {
                    con.Abrir();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con.Abrir();
                        cmd.CommandText = "update agenda set COD_PRODUTO = @codProd, COD_CLIENTE = @codCli, NOME_PRODUTO = @prod, DATA_AGENDA = @data, HORARIO_AGENDA = @hora where cod_agenda = @agenda";

                        cmd.Parameters.AddWithValue("agenda", txbCod.Text);
                        cmd.Parameters.AddWithValue("@codProd", txbCodProd.Text);
                        cmd.Parameters.AddWithValue("@codCli", txbCodCli.Text);
                        cmd.Parameters.AddWithValue("@prod", cmbProd.Text);
                        cmd.Parameters.AddWithValue("@data", dtpData.Value.Date);
                        cmd.Parameters.AddWithValue("@hora", cmbHora.Text);
                        cmd.ExecuteNonQuery();
                    }
                    //PreencherGrid();
                    con.Fechar();
                    limpaCampos();
                    desativaBtn();
                    PreencherGrid();
                    MessageBox.Show("Agenda alterada com sucesso");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente deletar essa agenda?";
            string caption = "Deletar agenda";
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
                    cmd.CommandText = "delete from agenda where  horario_agenda = @hora";

                    cmd.Parameters.AddWithValue("@hora", cmbHora.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Agenda deletado com Sucesso!");
                PreencherGrid();
                limpaCampos();
                con.Fechar();
            }
            else
                return;
        }

        /*private void txbCodCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // só aceita números e backspace
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }

            if (e.KeyChar == 13)
            {
                SqlDataReader ddr;
                try
                {
                    SqlCommand cmdd = new SqlCommand("select * from cliente where cod_cliente = @cod", con.Abrir());
                    cmdd.Parameters.AddWithValue("@cod", txbCodCli.Text);

                    con.Abrir();
                    ddr = cmdd.ExecuteReader();
                    ddr.Read();
                    txbCpf.Text = ddr["cpf_cliente"].ToString();
                    con.Fechar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }*/

        public bool naoExiste()
        {
            DataTable dados = new DataTable();
            int qtdRegistros;
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("SELECT cpf_cliente FROM cliente where cpf_cliente = '" +
                    txbCpf.Text + "'", con.Abrir());
            da.Fill(dados);
            qtdRegistros = dados.Rows.Count;
            con.Fechar();
            if (qtdRegistros > 0)
                return true;
            else
                texto = "";
            return false;
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
            digcalc = dv1 * 10 + dv2;
            if (dv1 == cpf[9] && dv2 == cpf[10]) return true;
            else return false;
        }
    }
}
