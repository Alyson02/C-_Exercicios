
namespace InfinityGames
{
    partial class frmConsultaProd
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCadastraProd = new System.Windows.Forms.DataGridView();
            this.rbtnPeriferico = new System.Windows.Forms.RadioButton();
            this.rbtnConsole = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.rbtnJogo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.txbValorProd = new System.Windows.Forms.TextBox();
            this.txbCat = new System.Windows.Forms.TextBox();
            this.pnCat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastraProd)).BeginInit();
            this.pnCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(408, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Categoria:";
            // 
            // dgvCadastraProd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvCadastraProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadastraProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadastraProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvCadastraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastraProd.Location = new System.Drawing.Point(416, 419);
            this.dgvCadastraProd.Name = "dgvCadastraProd";
            this.dgvCadastraProd.Size = new System.Drawing.Size(834, 382);
            this.dgvCadastraProd.TabIndex = 26;
            // 
            // rbtnPeriferico
            // 
            this.rbtnPeriferico.AutoSize = true;
            this.rbtnPeriferico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPeriferico.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbtnPeriferico.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPeriferico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbtnPeriferico.Location = new System.Drawing.Point(285, 16);
            this.rbtnPeriferico.Name = "rbtnPeriferico";
            this.rbtnPeriferico.Size = new System.Drawing.Size(133, 36);
            this.rbtnPeriferico.TabIndex = 23;
            this.rbtnPeriferico.TabStop = true;
            this.rbtnPeriferico.Text = "Periférico";
            this.rbtnPeriferico.UseVisualStyleBackColor = true;
            this.rbtnPeriferico.CheckedChanged += new System.EventHandler(this.rbtnPeriferico_CheckedChanged);
            // 
            // rbtnConsole
            // 
            this.rbtnConsole.AutoSize = true;
            this.rbtnConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnConsole.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbtnConsole.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbtnConsole.Location = new System.Drawing.Point(133, 16);
            this.rbtnConsole.Name = "rbtnConsole";
            this.rbtnConsole.Size = new System.Drawing.Size(119, 36);
            this.rbtnConsole.TabIndex = 22;
            this.rbtnConsole.TabStop = true;
            this.rbtnConsole.Text = "Console";
            this.rbtnConsole.UseVisualStyleBackColor = true;
            this.rbtnConsole.CheckedChanged += new System.EventHandler(this.rbtnConsole_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(999, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(410, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome:";
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbNomeProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeProd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeProd.Location = new System.Drawing.Point(502, 280);
            this.txbNomeProd.Multiline = true;
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(748, 32);
            this.txbNomeProd.TabIndex = 19;
            this.txbNomeProd.TextChanged += new System.EventHandler(this.txbNomeProd_TextChanged_1);
            // 
            // rbtnJogo
            // 
            this.rbtnJogo.AutoSize = true;
            this.rbtnJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnJogo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbtnJogo.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbtnJogo.Location = new System.Drawing.Point(16, 18);
            this.rbtnJogo.Name = "rbtnJogo";
            this.rbtnJogo.Size = new System.Drawing.Size(84, 36);
            this.rbtnJogo.TabIndex = 18;
            this.rbtnJogo.TabStop = true;
            this.rbtnJogo.Text = "Jogo";
            this.rbtnJogo.UseVisualStyleBackColor = true;
            this.rbtnJogo.CheckedChanged += new System.EventHandler(this.rbtnJogo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(70, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código:";
            this.label1.Visible = false;
            // 
            // txbCod
            // 
            this.txbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCod.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCod.Location = new System.Drawing.Point(176, 12);
            this.txbCod.Multiline = true;
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(54, 32);
            this.txbCod.TabIndex = 16;
            this.txbCod.Visible = false;
            // 
            // txbValorProd
            // 
            this.txbValorProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbValorProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValorProd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorProd.Location = new System.Drawing.Point(1108, 338);
            this.txbValorProd.Multiline = true;
            this.txbValorProd.Name = "txbValorProd";
            this.txbValorProd.Size = new System.Drawing.Size(142, 32);
            this.txbValorProd.TabIndex = 32;
            this.txbValorProd.TextChanged += new System.EventHandler(this.txbValorProd_TextChanged);
            // 
            // txbCat
            // 
            this.txbCat.Location = new System.Drawing.Point(249, 24);
            this.txbCat.Name = "txbCat";
            this.txbCat.Size = new System.Drawing.Size(217, 20);
            this.txbCat.TabIndex = 33;
            this.txbCat.Visible = false;
            // 
            // pnCat
            // 
            this.pnCat.AutoScroll = true;
            this.pnCat.Controls.Add(this.rbtnPeriferico);
            this.pnCat.Controls.Add(this.rbtnConsole);
            this.pnCat.Controls.Add(this.rbtnJogo);
            this.pnCat.Location = new System.Drawing.Point(548, 316);
            this.pnCat.Name = "pnCat";
            this.pnCat.Size = new System.Drawing.Size(426, 74);
            this.pnCat.TabIndex = 34;
            // 
            // frmConsultaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1658, 1080);
            this.Controls.Add(this.pnCat);
            this.Controls.Add(this.txbCat);
            this.Controls.Add(this.txbValorProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCadastraProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCod);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaProd";
            this.Text = "frmConsultaProd";
            this.Load += new System.EventHandler(this.frmConsultaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastraProd)).EndInit();
            this.pnCat.ResumeLayout(false);
            this.pnCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCadastraProd;
        private System.Windows.Forms.RadioButton rbtnPeriferico;
        private System.Windows.Forms.RadioButton rbtnConsole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.RadioButton rbtnJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.TextBox txbValorProd;
        private System.Windows.Forms.TextBox txbCat;
        private System.Windows.Forms.Panel pnCat;
    }
}