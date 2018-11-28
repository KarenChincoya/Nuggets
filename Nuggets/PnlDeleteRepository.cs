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
    public partial class PnlDeleteRepository : Form
    {
        public PnlDeleteRepository()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pnl = new Form1();
            pnl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUser.Text);
            int result = DAORepository.delete(id);

            if (result > 0)
            {
                MessageBox.Show("Repositorio eliminado.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
