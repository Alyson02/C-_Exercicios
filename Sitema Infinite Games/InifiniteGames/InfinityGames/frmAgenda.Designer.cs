
namespace InfinityGames
{
    partial class frmAgenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCodCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCodProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(326, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(850, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(326, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data:";
            // 
            // txbCodCli
            // 
            this.txbCodCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCodCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodCli.Location = new System.Drawing.Point(1074, 337);
            this.txbCodCli.Name = "txbCodCli";
            this.txbCodCli.Size = new System.Drawing.Size(57, 33);
            this.txbCodCli.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label6.Location = new System.Drawing.Point(845, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Código do cliente:";
            // 
            // txbCodProd
            // 
            this.txbCodProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCodProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodProd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProd.Location = new System.Drawing.Point(1263, 268);
            this.txbCodProd.Multiline = true;
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.ReadOnly = true;
            this.txbCodProd.Size = new System.Drawing.Size(57, 40);
            this.txbCodProd.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label7.Location = new System.Drawing.Point(1032, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Código do produto:";
            // 
            // dgvAgenda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(332, 471);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(1001, 235);
            this.dgvAgenda.TabIndex = 21;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            this.dgvAgenda.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAgenda_RowHeaderMouseClick);
            // 
            // dtpData
            // 
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dtpData.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dtpData.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpData.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(414, 400);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(339, 40);
            this.dtpData.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(326, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "CPF do cliente:\r\n";
            // 
            // cmbHora
            // 
            this.cmbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHora.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbHora.Location = new System.Drawing.Point(926, 399);
            this.cmbHora.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(316, 40);
            this.cmbHora.TabIndex = 30;
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
            this.btnAdd.Location = new System.Drawing.Point(332, 753);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(236, 59);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnAlterar.Location = new System.Drawing.Point(1097, 753);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(236, 59);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.BorderSize = 3;
            this.btnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDel.Location = new System.Drawing.Point(842, 753);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(236, 59);
            this.btnDel.TabIndex = 34;
            this.btnDel.Text = "DELETAR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 3;
            this.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(587, 753);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(236, 59);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbProd
            // 
            this.cmbProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbProd.Location = new System.Drawing.Point(545, 268);
            this.cmbProd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(465, 40);
            this.cmbProd.TabIndex = 37;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCpf.BeepOnError = true;
            this.txbCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCpf.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(505, 337);
            this.txbCpf.Mask = "999.999.999-99";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(304, 33);
            this.txbCpf.TabIndex = 38;
            this.txbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCpf_KeyPress);
            // 
            // txbCod
            // 
            this.txbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCod.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCod.Location = new System.Drawing.Point(107, 979);
            this.txbCod.Multiline = true;
            this.txbCod.Name = "txbCod";
            this.txbCod.ReadOnly = true;
            this.txbCod.Size = new System.Drawing.Size(57, 40);
            this.txbCod.TabIndex = 39;
            this.txbCod.Visible = false;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1658, 1080);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.txbCodProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCodCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgenda";
            this.Text = "frmAgenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCodCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCodProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.TextBox txbCod;
    }
}