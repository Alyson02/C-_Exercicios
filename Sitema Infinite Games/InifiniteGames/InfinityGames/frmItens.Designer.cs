
namespace InfinityGames
{
    partial class frmItens
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
            this.txbQuantiProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCadPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCodPedi = new System.Windows.Forms.TextBox();
            this.txbCodItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCodProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbQnt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txbQuantiProd
            // 
            this.txbQuantiProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbQuantiProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbQuantiProd.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantiProd.Location = new System.Drawing.Point(297, 116);
            this.txbQuantiProd.Name = "txbQuantiProd";
            this.txbQuantiProd.Size = new System.Drawing.Size(98, 40);
            this.txbQuantiProd.TabIndex = 32;
            this.txbQuantiProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedeNaoNumero);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label7.Location = new System.Drawing.Point(18, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quantidade do produto:";
            // 
            // cmbProd
            // 
            this.cmbProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(128, 54);
            this.cmbProd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(316, 40);
            this.cmbProd.TabIndex = 30;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Produto:";
            // 
            // txbValor
            // 
            this.txbValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbValor.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(624, 116);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(148, 40);
            this.txbValor.TabIndex = 34;
            this.txbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.impedeNaoNumero);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(488, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 33;
            this.label5.Text = "Valor total:";
            // 
            // dgvItem
            // 
            this.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(7, 180);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(813, 245);
            this.dgvItem.TabIndex = 35;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPedido_RowPostPaint);
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
            this.btnDel.Location = new System.Drawing.Point(319, 441);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(174, 49);
            this.btnDel.TabIndex = 39;
            this.btnDel.Text = "EXCLUIR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.Location = new System.Drawing.Point(111, 441);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 49);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCadPedido
            // 
            this.btnCadPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCadPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatAppearance.BorderSize = 3;
            this.btnCadPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCadPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPedido.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(175)))), ((int)(((byte)(20)))));
            this.btnCadPedido.Location = new System.Drawing.Point(527, 441);
            this.btnCadPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadPedido.Name = "btnCadPedido";
            this.btnCadPedido.Size = new System.Drawing.Size(174, 49);
            this.btnCadPedido.TabIndex = 36;
            this.btnCadPedido.Text = "CONFIRMAR";
            this.btnCadPedido.UseVisualStyleBackColor = false;
            this.btnCadPedido.Click += new System.EventHandler(this.btnCadPedido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label6.Location = new System.Drawing.Point(425, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "Item:";
            // 
            // txbCodPedi
            // 
            this.txbCodPedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.txbCodPedi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodPedi.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodPedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txbCodPedi.Location = new System.Drawing.Point(360, 9);
            this.txbCodPedi.Multiline = true;
            this.txbCodPedi.Name = "txbCodPedi";
            this.txbCodPedi.ReadOnly = true;
            this.txbCodPedi.Size = new System.Drawing.Size(53, 32);
            this.txbCodPedi.TabIndex = 44;
            this.txbCodPedi.Text = "0";
            // 
            // txbCodItem
            // 
            this.txbCodItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.txbCodItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodItem.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txbCodItem.Location = new System.Drawing.Point(499, 9);
            this.txbCodItem.Multiline = true;
            this.txbCodItem.Name = "txbCodItem";
            this.txbCodItem.ReadOnly = true;
            this.txbCodItem.Size = new System.Drawing.Size(53, 32);
            this.txbCodItem.TabIndex = 45;
            this.txbCodItem.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Pedido:";
            // 
            // txbCodProd
            // 
            this.txbCodProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txbCodProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodProd.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProd.Location = new System.Drawing.Point(719, 54);
            this.txbCodProd.Multiline = true;
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.ReadOnly = true;
            this.txbCodProd.Size = new System.Drawing.Size(53, 40);
            this.txbCodProd.TabIndex = 28;
            this.txbCodProd.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.label4.Location = new System.Drawing.Point(488, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Código do produto:";
            this.label4.Visible = false;
            // 
            // txbQnt
            // 
            this.txbQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.txbQnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbQnt.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQnt.ForeColor = System.Drawing.Color.Goldenrod;
            this.txbQnt.Location = new System.Drawing.Point(401, 123);
            this.txbQnt.Multiline = true;
            this.txbQnt.Name = "txbQnt";
            this.txbQnt.ReadOnly = true;
            this.txbQnt.Size = new System.Drawing.Size(53, 32);
            this.txbQnt.TabIndex = 48;
            this.txbQnt.Text = "0";
            // 
            // frmItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(813, 511);
            this.Controls.Add(this.txbQnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCodItem);
            this.Controls.Add(this.txbCodPedi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCadPedido);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbQuantiProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodProd);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItens";
            this.Load += new System.EventHandler(this.frmItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbQuantiProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCadPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCodPedi;
        private System.Windows.Forms.TextBox txbCodItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCodProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbQnt;
    }
}