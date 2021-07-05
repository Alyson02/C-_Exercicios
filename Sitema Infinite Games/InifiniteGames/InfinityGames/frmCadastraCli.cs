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
    public partial class frmCadastraCli : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        string texto = "";

        int digcalc;

        public frmCadastraCli()
        {
            InitializeComponent();
            PreencherGrid();
        }

        private void impedeNaoNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // só aceita números e backspace
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
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
            digcalc = dv1 * 10 + dv2;
            if (dv1 == cpf[9] && dv2 == cpf[10]) return true;
            else return false;
        }

        private void limpaCampos()
        {
            txbNomeCli.Text = "";
            txbCod.Text = "";
            txbEndCli.Text = "";
            txbCpf.Text = "";
            txbCpf.Text = "";

        }

        public void PreencherGrid()
        {
            con.Abrir();
            SqlDataAdapter da = new SqlDataAdapter("", con.Abrir());
            /*Usando o "as" para trazer insformação ´para o datagrid diferente do bd*/
            da.SelectCommand.CommandText = "SELECT cliente.cod_cliente as Código, nome_cliente as Nome, endereço_cliente as Endereço, cpf_cliente as CPF from cliente";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCliente.DataSource = dt;
            con.Fechar();
        }

        private void dgvCliente_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvCliente.RowHeadersWidth < Convert.ToInt32((size.Width
                 + 20)))
            {
                dgvCliente.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }


        private void dgvCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            DataGridViewRow dr = dgvCliente.SelectedRows[0];
            txbCod.Text = dr.Cells[0].Value.ToString();
            txbNomeCli.Text = dr.Cells[1].Value.ToString();
            txbCpf.Text = dr.Cells[3].Value.ToString();
            txbEndCli.Text = dr.Cells[2].Value.ToString();
            txbCpf.Focus();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            if (naoExiste() == true)
                incluiCli();
            else
                MessageBox.Show("CPF já cadastrado");
            //txbCpfCli.Clear();

        }

        public void incluiCli()
        {
            //Concistencia 
            char[] cpf = new char[11];
            cpf = txbCpf.Text.ToCharArray();

            //MessageBox.Show(txbCpf.Text);

            if (txbNomeCli.Text == "")
            {
                MessageBox.Show("Por  favor informe o nome");
                txbNomeCli.Focus();
                return;
            }

            else if (txbCpf.Text == "")
            {
                MessageBox.Show("Por  favor informe o cpf");
                txbCpf.Focus();
                return;
            }

            else if (txbEndCli.Text == "")
            {
                MessageBox.Show("Por  favor informe o endereço");
                txbEndCli.Focus();
                return;
            }

            else if (CPFvalido(cpf))
            {
                try
                {
                    //MessageBox.Show(txbCpf.Text);

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con.Abrir();
                        cmd.CommandText = "insert into cliente(nome_cliente, cpf_cliente, endereço_cliente) values(@nome, @cpf, @endereco)";

                        cmd.Parameters.AddWithValue("@nome", txbNomeCli.Text);
                        cmd.Parameters.AddWithValue("@cpf", txbCpf.Text);
                        cmd.Parameters.AddWithValue("@endereco", txbEndCli.Text);
                        //MessageBox.Show(txbCpf.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                MessageBox.Show("Cliente cadastrado com sucesso!!");
                limpaCampos();
                PreencherGrid();
                desativaBtn();
                con.Fechar();
            }
            else
            {
                MessageBox.Show("CPF invalido!");
                txbCpf.Focus();
                texto = "";
            }
        }

        private void frmCadastraCli_Load(object sender, EventArgs e)
        {
            desativaBtn();
        }
        private void desativaBtn()
        {
            btnAdd.Enabled = true;

            txbNomeCli.Enabled = false;
            txbEndCli.Enabled = false;
            txbCpf.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadCli.Enabled = false;
            btnDell.Enabled = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txbNomeCli.Enabled = true;
            txbEndCli.Enabled = true;
            txbCpf.Enabled = true;
            btnAlterar.Enabled = false;
            btnCadCli.Enabled = true;
            btnDell.Enabled = false;
            txbNomeCli.Focus();
        }

        private void dgvCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txbCpf.Focus();
            btnAdd.Enabled = false;
            txbNomeCli.Enabled = true;
            txbEndCli.Enabled = true;
            txbCpf.Enabled = true;
            btnAlterar.Enabled = true;
            btnCadCli.Enabled = true;
            btnDell.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvCliente.SelectedRows[0];
            txbCpf.Text = dr.Cells[3].Value.ToString();

            if (naoExiste() || this.txbCpf.Text == dr.Cells[3].Value.ToString())
                altera();
            else
                MessageBox.Show("CPF já cadastrado");
        }

        private void altera()
        {
            char[] cpf = new char[11];
            cpf = txbCpf.Text.ToCharArray();

            if (txbNomeCli.Text == "")
            {
                MessageBox.Show("Por  favor informe o nome");
                txbNomeCli.Focus();
                return;
            }

            else if (txbCpf.Text == "")
            {
                MessageBox.Show("Por  favor informe o cpf");
                txbCpf.Focus();
                return;
            }

            else if (txbEndCli.Text == "")
            {
                MessageBox.Show("Por  favor informe o endereço");
                txbEndCli.Focus();
                return;
            }

            else if (CPFvalido(cpf))
            {
                try
                {
                    con.Abrir();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con.Abrir();
                        cmd.CommandText = "update cliente set nome_cliente = @nome, endereço_cliente = @endereco, cpf_cliente = @cpf where cod_cliente = @cod_cliente; ";

                        cmd.Parameters.AddWithValue("@nome", txbNomeCli.Text);
                        cmd.Parameters.AddWithValue("@cod_cliente", txbCod.Text);
                        cmd.Parameters.AddWithValue("@endereco", txbEndCli.Text);
                        cmd.Parameters.AddWithValue("@cpf", txbCpf.Text);
                        cmd.ExecuteNonQuery();
                    }
                    PreencherGrid();
                    con.Fechar();
                    limpaCampos();
                    desativaBtn();
                    MessageBox.Show("Cliente alterado com sucesso");
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
        }

        private void btnDell_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from cliente where cod_cliente = @cod_cliente";

                    cmd.Parameters.AddWithValue("@cod_cliente", txbCod.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cliente deletado com Sucesso!");
                PreencherGrid();
                limpaCampos();
                con.Fechar();
            }
            else
            return;
        }

        /*private void txbCpf_Leave(object sender, EventArgs e)
        {
            char[] digito = txbCpf.Text.ToCharArray();
            int tam = digito.Length;
            for (int i = 0; i < tam; i++)
                if (digito[i] != ',' && digito[i] != '-')
                    texto = texto + digito[i].ToString();
            //txbCpfCli.Clear();
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
            if (qtdRegistros == 0)
                return true;
            else
                texto = "";
                return false;
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCpf.Focus();
        }
    }
}
