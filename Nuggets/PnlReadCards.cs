using System;
using System.Collections;
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
    public partial class PnlReadCards : Form
    {
        public PnlUser pnlPadre { get; set; }
        
        public User user { get; set; }
        public void updateData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Id del usuario");
            dt.Columns.Add("Número");
            dt.Columns.Add("Propietario");
            dt.Columns.Add("Código de seguridad");
            dt.Columns.Add("Fecha de expiración");

            ArrayList cards = DAOCard.readMyCards(user.id);

            foreach(Card card in cards)
            {
                dt.Rows.Add(new object[] { card.id, card.user_id, card.number, card.holdername, card.securityCode, card.expirationDate });
            }
            
            dataGridView1.DataSource = dt;

        }
        public PnlReadCards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listener
            pnlPadre.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
