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
        public PnlUser pnlPadre { get; set; }
        public User user { get; set; }
        public PnlDeleteRepository()
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
            int id = int.Parse(txtUser.Text);

            Repository repo = DAORepository.read(id);
            
            if(repo.id_creator == this.user.id)
            {
                //Funcion eliminar
                int result = DAORepository.delete(id);
                if (result > 0)
                {
                    MessageBox.Show("Repositorio eliminado.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlPadre.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Fin de la funcion eliminar
            }else
            {
                MessageBox.Show("No tienes permiso de eliminar.", "Fallo al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
