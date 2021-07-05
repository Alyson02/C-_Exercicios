
namespace InfinityGames
{
    partial class frmCadastraPedido
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
            this.txbCodCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCodPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnCadPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCodCli
            // 
            this.txbCodCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCodCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodCli.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodCli.Location = new System.Drawing.Point(1014, 377);
            this.txbCodCli.Multiline = true;
            this.txbCodCli.Name = "txbCodCli";
            this.txbCodCli.Size = new System.Drawing.Size(53, 33);
            this.txbCodCli.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(784, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Código do cliente:";
            // 
            // txbValor
            // 
            this.txbValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValor.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(167, 58);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(98, 32);
            this.txbValor.TabIndex = 18;
            this.txbValor.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(31, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor total:";
            this.label5.Visible = false;
            // 
            // txbCodPedido
            // 
            this.txbCodPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCodPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodPedido.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodPedido.Location = new System.Drawing.Point(134, 9);
            this.txbCodPedido.Multiline = true;
            this.txbCodPedido.Name = "txbCodPedido";
            this.txbCodPedido.Size = new System.Drawing.Size(53, 32);
            this.txbCodPedido.TabIndex = 20;
            this.txbCodPedido.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label6.Location = new System.Drawing.Point(31, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Código:";
            this.label6.Visible = false;
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(320, 432);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(747, 273);
            this.dgvPedido.TabIndex = 21;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            this.dgvPedido.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedido_RowHeaderMouseClick_1);
            // 
            // btnCadPedido
            // 
            this.btnCadPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCadPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatAppearance.BorderSize = 3;
            this.btnCadPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPedido.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPedido.ForeColor = System.Drawing.Color.Black;
            this.btnCadPedido.Location = new System.Drawing.Point(1115, 515);
            this.btnCadPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadPedido.Name = "btnCadPedido";
            this.btnCadPedido.Size = new System.Drawing.Size(230, 49);
            this.btnCadPedido.TabIndex = 22;
            this.btnCadPedido.Text = "CADASTRAR";
            this.btnCadPedido.UseVisualStyleBackColor = false;
            this.btnCadPedido.Click += new System.EventHandler(this.btnCadPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(314, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "CPF do cliente:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(175)))), ((int)(((byte)(20)))));
            this.btnAdd.Location = new System.Drawing.Point(1115, 377);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 49);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "ADD ITENS";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.BorderSize = 3;
            this.btnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDel.Location = new System.Drawing.Point(1115, 653);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(230, 49);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "EXCLUIR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCpf.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.Location = new System.Drawing.Point(493, 376);
            this.txbCpf.Mask = "000.000.000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(227, 33);
            this.txbCpf.TabIndex = 30;
            this.txbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCpf_KeyPress);
            // 
            // frmCadastraPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1658, 1080);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadPedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.txbCodPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCodCli);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastraPedido";
            this.Text = "frmCadastraPedido";
            this.Load += new System.EventHandler(this.frmCadastraPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbCodCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCodPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnCadPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.MaskedTextBox txbCpf;
    }
}