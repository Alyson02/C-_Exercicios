using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class lblCarta : Form
    {
        public lblCarta()
        {
            InitializeComponent();
        }

        private void bntHitMe_Click(object sender, EventArgs e)
        {
            Random aleat = new Random();
            int carta = aleat.Next(11);
            lbCartas.Text = carta.ToString();
            int pontos = 0;
            pontos = pontos + carta;
            lblPontos.Text = pontos.ToString();
        }
    }
}
