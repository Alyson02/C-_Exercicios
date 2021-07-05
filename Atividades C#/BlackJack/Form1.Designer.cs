
namespace BlackJack
{
    partial class lblCarta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCartas = new System.Windows.Forms.Label();
            this.lbPontos = new System.Windows.Forms.Label();
            this.bntHitMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCartas
            // 
            this.lbCartas.AutoSize = true;
            this.lbCartas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartas.Location = new System.Drawing.Point(124, 9);
            this.lbCartas.Name = "lbCartas";
            this.lbCartas.Size = new System.Drawing.Size(57, 63);
            this.lbCartas.TabIndex = 0;
            this.lbCartas.Text = "0";
            // 
            // lbPontos
            // 
            this.lbPontos.AutoSize = true;
            this.lbPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontos.Location = new System.Drawing.Point(135, 117);
            this.lbPontos.Name = "lbPontos";
            this.lbPontos.Size = new System.Drawing.Size(29, 31);
            this.lbPontos.TabIndex = 1;
            this.lbPontos.Text = "0";
            // 
            // bntHitMe
            // 
            this.bntHitMe.Location = new System.Drawing.Point(115, 180);
            this.bntHitMe.Name = "bntHitMe";
            this.bntHitMe.Size = new System.Drawing.Size(75, 23);
            this.bntHitMe.TabIndex = 2;
            this.bntHitMe.Text = "Hite Me";
            this.bntHitMe.UseVisualStyleBackColor = true;
            this.bntHitMe.Click += new System.EventHandler(this.bntHitMe_Click);
            // 
            // lblCarta
            // 
            this.ClientSize = new System.Drawing.Size(317, 287);
            this.Controls.Add(this.bntHitMe);
            this.Controls.Add(this.lbPontos);
            this.Controls.Add(this.lbCartas);
            this.Name = "lblCarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button btnHitMe;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lbCartas;
        private System.Windows.Forms.Label lbPontos;
        private System.Windows.Forms.Button bntHitMe;
    }
}

