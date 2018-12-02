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
    public partial class PnlDeleteCard : Form
    {
        public PnlUser pnlPadre { get; set; }
        public PnlDeleteCard()
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
            //listener para eliminar
            int id = int.Parse(txtID.Text.Trim());
            int result = DAOCard.delete(id);

            if (result > 0)
            {
                MessageBox.Show("Tarjeta eliminada con éxito.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la tarjeta", "Error de eliminación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            pnlPadre.Show();
            this.Hide();
        }
    }
}
