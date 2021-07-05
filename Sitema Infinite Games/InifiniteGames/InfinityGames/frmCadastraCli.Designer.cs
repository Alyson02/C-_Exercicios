
namespace InfinityGames
{
    partial class frmCadastraCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeCli = new System.Windows.Forms.TextBox();
            this.txbCpfCli = new System.Windows.Forms.TextBox();
            this.txbEndCli = new System.Windows.Forms.TextBox();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(73, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código:";
            this.label4.Visible = false;
            // 
            // txbCod
            // 
            this.txbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCod.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCod.Location = new System.Drawing.Point(176, 30);
            this.txbCod.Multiline = true;
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(57, 32);
            this.txbCod.TabIndex = 6;
            this.txbCod.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(135, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(641, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(1021, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Endereço";
            // 
            // txbNomeCli
            // 
            this.txbNomeCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCli.Location = new System.Drawing.Point(252, 310);
            this.txbNomeCli.MaxLength = 50;
            this.txbNomeCli.Multiline = true;
            this.txbNomeCli.Name = "txbNomeCli";
            this.txbNomeCli.Size = new System.Drawing.Size(358, 32);
            this.txbNomeCli.TabIndex = 11;
            // 
            // txbCpfCli
            // 
            this.txbCpfCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCpfCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCpfCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpfCli.Location = new System.Drawing.Point(732, 310);
            this.txbCpfCli.MaxLength = 11;
            this.txbCpfCli.Multiline = true;
            this.txbCpfCli.Name = "txbCpfCli";
            this.txbCpfCli.Size = new System.Drawing.Size(258, 32);
            this.txbCpfCli.TabIndex = 12;
            this.txbCpfCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedeNaoNumero);
            // 
            // txbEndCli
            // 
            this.txbEndCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbEndCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEndCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndCli.Location = new System.Drawing.Point(1166, 310);
            this.txbEndCli.MaxLength = 50;
            this.txbEndCli.Multiline = true;
            this.txbEndCli.Name = "txbEndCli";
            this.txbEndCli.Size = new System.Drawing.Size(358, 32);
            this.txbEndCli.TabIndex = 13;
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCadCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadCli.FlatAppearance.BorderSize = 3;
            this.btnCadCli.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCli.ForeColor = System.Drawing.Color.Black;
            this.btnCadCli.Location = new System.Drawing.Point(1293, 495);
            this.btnCadCli.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(231, 49);
            this.btnCadCli.TabIndex = 15;
            this.btnCadCli.Text = "CADASTRAR";
            this.btnCadCli.UseVisualStyleBackColor = false;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // dgvCliente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCliente.GridColor = System.Drawing.Color.Black;
            this.dgvCliente.Location = new System.Drawing.Point(141, 382);
            this.dgvCliente.Name = "dgvCliente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.Size = new System.Drawing.Size(1099, 389);
            this.dgvCliente.TabIndex = 20;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick_1);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_RowHeaderMouseClick);
            this.dgvCliente.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCliente_RowPostPaint);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(175)))), ((int)(((byte)(20)))));
            this.btnAdd.Location = new System.Drawing.Point(1293, 382);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 49);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.BorderSize = 3;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAlterar.Location = new System.Drawing.Point(1293, 608);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(231, 49);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDell
            // 
            this.btnDell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDell.FlatAppearance.BorderSize = 3;
            this.btnDell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDell.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDell.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDell.Location = new System.Drawing.Point(1293, 721);
            this.btnDell.Margin = new System.Windows.Forms.Padding(2);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(231, 49);
            this.btnDell.TabIndex = 19;
            this.btnDell.Text = "Excluir";
            this.btnDell.UseVisualStyleBackColor = false;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCpf.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(732, 309);
            this.txbCpf.Mask = "000.000.000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(258, 33);
            this.txbCpf.TabIndex = 21;
            this.txbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // frmCadastraCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1658, 1080);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.txbEndCli);
            this.Controls.Add(this.txbCpfCli);
            this.Controls.Add(this.txbNomeCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastraCli";
            this.Text = "frmCadastraCli";
            this.Load += new System.EventHandler(this.frmCadastraCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeCli;
        private System.Windows.Forms.TextBox txbCpfCli;
        private System.Windows.Forms.TextBox txbEndCli;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.MaskedTextBox txbCpf;
    }
}