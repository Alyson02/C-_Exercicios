
namespace InfinityGames
{
    partial class frmConsultaCli
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
            this.txbEndCli = new System.Windows.Forms.TextBox();
            this.txbCpfCli = new System.Windows.Forms.TextBox();
            this.txbNomeCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCli = new System.Windows.Forms.DataGridView();
            this.txbCodCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            this.SuspendLayout();
            // 
            // txbEndCli
            // 
            this.txbEndCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbEndCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEndCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndCli.Location = new System.Drawing.Point(640, 434);
            this.txbEndCli.Multiline = true;
            this.txbEndCli.Name = "txbEndCli";
            this.txbEndCli.Size = new System.Drawing.Size(509, 32);
            this.txbEndCli.TabIndex = 33;
            this.txbEndCli.TextChanged += new System.EventHandler(this.txbEndCli_TextChanged);
            // 
            // txbCpfCli
            // 
            this.txbCpfCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCpfCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCpfCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpfCli.Location = new System.Drawing.Point(640, 379);
            this.txbCpfCli.Multiline = true;
            this.txbCpfCli.Name = "txbCpfCli";
            this.txbCpfCli.Size = new System.Drawing.Size(509, 32);
            this.txbCpfCli.TabIndex = 32;
            this.txbCpfCli.TextChanged += new System.EventHandler(this.txbCpfCli_TextChanged);
            // 
            // txbNomeCli
            // 
            this.txbNomeCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCli.Location = new System.Drawing.Point(640, 325);
            this.txbNomeCli.Multiline = true;
            this.txbNomeCli.Name = "txbNomeCli";
            this.txbNomeCli.Size = new System.Drawing.Size(509, 32);
            this.txbNomeCli.TabIndex = 31;
            this.txbNomeCli.TextChanged += new System.EventHandler(this.txbNomeCli_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(510, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(510, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(510, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // dgvCli
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvCli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli.GridColor = System.Drawing.Color.Black;
            this.dgvCli.Location = new System.Drawing.Point(516, 515);
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.Size = new System.Drawing.Size(633, 240);
            this.dgvCli.TabIndex = 36;
            // 
            // txbCodCli
            // 
            this.txbCodCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCodCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodCli.Location = new System.Drawing.Point(183, 37);
            this.txbCodCli.Multiline = true;
            this.txbCodCli.Name = "txbCodCli";
            this.txbCodCli.Size = new System.Drawing.Size(81, 32);
            this.txbCodCli.TabIndex = 38;
            this.txbCodCli.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(53, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "Código:";
            this.label4.Visible = false;
            // 
            // frmConsultaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1658, 1080);
            this.Controls.Add(this.txbCodCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCli);
            this.Controls.Add(this.txbEndCli);
            this.Controls.Add(this.txbCpfCli);
            this.Controls.Add(this.txbNomeCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaCli";
            this.Text = "frmConsultaCli";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbEndCli;
        private System.Windows.Forms.TextBox txbCpfCli;
        private System.Windows.Forms.TextBox txbNomeCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCli;
        private System.Windows.Forms.TextBox txbCodCli;
        private System.Windows.Forms.Label label4;
    }
}