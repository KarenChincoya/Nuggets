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
    public partial class PnlCreateCard : Form
    {
        public PnlUser pnlPadre = new PnlUser();
        public User user { get; set; }
        public int id { get; set; }
        public PnlCreateCard()
        {
            InitializeComponent();
        }
        public void updateIdView()
        {
            this.txtId.Text = this.id.ToString();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlPadre.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listener para creacion 
            int user_id = user.id;
            string number = txtCardNumber.Text;
            string placeholder = txtCardPlaceholderName.Text;
            string securityCode = txtecurityCode.Text;
            string expeditionDate = txtExpeditionDate.Text;

            Card card = new Card(user_id, number, placeholder, securityCode, expeditionDate);
            //Insertar
            int result = DAOCard.create(card);

            if (result > 0)
            {
                MessageBox.Show("Tarjeta ingresada con éxito.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlPadre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
