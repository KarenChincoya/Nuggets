using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuggets
{
    public partial class PnlUpdateCard : Form
    {
        public PnlUser pnlPadre { get; set; }
        public User user { get; set; }
        public PnlUpdateCard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlPadre.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Card card = DAOCard.readCard(id);
            PnlUpdateCard1 pnl = new PnlUpdateCard1();
            pnl.pnlPadre = this.pnlPadre;
            pnl.card = card;
            pnl.updateData();
            pnl.Show();
            this.Hide();

        }
    }
}
