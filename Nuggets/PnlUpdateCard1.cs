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
    public partial class PnlUpdateCard1 : Form
    {
        public PnlUser pnlPadre = new PnlUser();
        public Card card { get; set; }
        public User user { get; set; }
        public void updateData()
        {
            this.txtCardNumber.Text = card.number;
            this.txtCardPlaceholderName.Text = card.holdername;
            this.txtecurityCode.Text = card.securityCode;
            this.txtExpeditionDate.Text = card.expirationDate;
            this.txtId.Text = card.id.ToString();
        }
        public PnlUpdateCard1()
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
            int id = int.Parse(txtId.Text.Trim());
            string number = txtCardNumber.Text.Trim();
            string placeholdername = txtCardPlaceholderName.Text.Trim();
            string securityCode = txtecurityCode.Text.Trim();
            string expeditionDate = txtExpeditionDate.Text.Trim();

            Card cardAux = new Card(id, card.user_id, number, placeholdername, securityCode, expeditionDate);
            int result = DAOCard.updateCard(cardAux);

            if (result > 0)
            {

                MessageBox.Show("Datos actualizados con éxito.", "Actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlPadre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la actualización", "Fallo en actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
