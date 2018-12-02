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
    public partial class PnlDeleteUser : Form
    {
        public User user { get; set; }
        public PnlUser pnlPadre { get; set; }
        public PnlDeleteUser()
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
            //            int id = int.Parse(txtUser.Text);
            int id = user.id;
            int result = DAOUser.delete(id);

            if (result > 0)
            {
                MessageBox.Show("Usuario eliminado con éxito.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro", "Error de eliminación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            pnlPadre.Show();
            this.Hide();
        }
    }
}
