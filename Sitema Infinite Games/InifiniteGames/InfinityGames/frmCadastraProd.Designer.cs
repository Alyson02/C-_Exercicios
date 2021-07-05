
namespace InfinityGames
{
    partial class frmCadastraProd
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
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnJogo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnConsole = new System.Windows.Forms.RadioButton();
            this.rbtnPeriferico = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.dgvCadastraProd = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQuanti = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbCat = new System.Windows.Forms.TextBox();
            this.pnCat = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastraProd)).BeginInit();
            this.pnCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCod
            // 
            this.txbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCod.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCod.Location = new System.Drawing.Point(109, 51);
            this.txbCod.Multiline = true;
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(54, 32);
            this.txbCod.TabIndex = 0;
            this.txbCod.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            this.label1.Visible = false;
            // 
            // rbtnJogo
            // 
            this.rbtnJogo.AutoSize = true;
            this.rbtnJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnJogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rbtnJogo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbtnJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnJogo.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbtnJogo.Location = new System.Drawing.Point(9, 16);
            this.rbtnJogo.Name = "rbtnJogo";
            this.rbtnJogo.Size = new System.Drawing.Size(84, 36);
            this.rbtnJogo.TabIndex = 2;
            this.rbtnJogo.TabStop = true;
            this.rbtnJogo.Text = "Jogo";
            this.rbtnJogo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(220, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(312, 289);
            this.txbNome.MaxLength = 50;
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(837, 32);
            this.txbNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(693, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // rbtnConsole
            // 
            this.rbtnConsole.AutoSize = true;
            this.rbtnConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnConsole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rbtnConsole.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbtnConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnConsole.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbtnConsole.Location = new System.Drawing.Point(90, 16);
            this.rbtnConsole.Name = "rbtnConsole";
            this.rbtnConsole.Size = new System.Drawing.Size(119, 36);
            this.rbtnConsole.TabIndex = 6;
            this.rbtnConsole.TabStop = true;
            this.rbtnConsole.Text = "Console";
            this.rbtnConsole.UseVisualStyleBackColor = true;
            // 
            // rbtnPeriferico
            // 
            this.rbtnPeriferico.AutoSize = true;
            this.rbtnPeriferico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPeriferico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rbtnPeriferico.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbtnPeriferico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnPeriferico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnPeriferico.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPeriferico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbtnPeriferico.Location = new System.Drawing.Point(209, 16);
            this.rbtnPeriferico.Name = "rbtnPeriferico";
            this.rbtnPeriferico.Size = new System.Drawing.Size(133, 36);
            this.rbtnPeriferico.TabIndex = 7;
            this.rbtnPeriferico.TabStop = true;
            this.rbtnPeriferico.Text = "Periférico";
            this.rbtnPeriferico.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(495, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor:";
            // 
            // txbValor
            // 
            this.txbValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValor.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(576, 345);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(101, 32);
            this.txbValor.TabIndex = 8;
            this.txbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedeNaoNumero);
            // 
            // dgvCadastraProd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvCadastraProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadastraProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadastraProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvCadastraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastraProd.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCadastraProd.Location = new System.Drawing.Point(229, 410);
            this.dgvCadastraProd.Name = "dgvCadastraProd";
            this.dgvCadastraProd.Size = new System.Drawing.Size(920, 382);
            this.dgvCadastraProd.TabIndex = 10;
            this.dgvCadastraProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastraProd_CellClick);
            this.dgvCadastraProd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCadastraProd_RowHeaderMouseClick);
            this.dgvCadastraProd.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCadastraProd_RowPostPaint);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 3;
            this.btnCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(1202, 437);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(236, 59);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(221, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade:";
            // 
            // txbQuanti
            // 
            this.txbQuanti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbQuanti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbQuanti.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuanti.Location = new System.Drawing.Point(372, 345);
            this.txbQuanti.Multiline = true;
            this.txbQuanti.Name = "txbQuanti";
            this.txbQuanti.Size = new System.Drawing.Size(101, 32);
            this.txbQuanti.TabIndex = 12;
            this.txbQuanti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedeNaoNumero);
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
            this.btnDel.Location = new System.Drawing.Point(1202, 733);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(236, 59);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "DELETAR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.BorderSize = 3;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAlterar.Location = new System.Drawing.Point(1202, 585);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(236, 59);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txbCat
            // 
            this.txbCat.Location = new System.Drawing.Point(187, 63);
            this.txbCat.Name = "txbCat";
            this.txbCat.Size = new System.Drawing.Size(10, 20);
            this.txbCat.TabIndex = 16;
            this.txbCat.Visible = false;
            // 
            // pnCat
            // 
            this.pnCat.Controls.Add(this.rbtnPeriferico);
            this.pnCat.Controls.Add(this.rbtnConsole);
            this.pnCat.Controls.Add(this.rbtnJogo);
            this.pnCat.Location = new System.Drawing.Point(808, 327);
            this.pnCat.Name = "pnCat";
            this.pnCat.Size = new System.Drawing.Size(362, 66);
            this.pnCat.TabIndex = 17;
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
            this.btnAdd.Location = new System.Drawing.Point(1202, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(236, 59);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCadastraProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1658, 1080);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnCat);
            this.Controls.Add(this.txbCat);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbQuanti);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvCadastraProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastraProd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCadastraProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastraProd)).EndInit();
            this.pnCat.ResumeLayout(false);
            this.pnCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnJogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnConsole;
        private System.Windows.Forms.RadioButton rbtnPeriferico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.DataGridView dgvCadastraProd;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbQuanti;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txbCat;
        private System.Windows.Forms.Panel pnCat;
        private System.Windows.Forms.Button btnAdd;
    }
}