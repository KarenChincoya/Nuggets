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
    public partial class PnlReadRepository : Form
    {
        public PnlUser pnlPadre { get; set; }
        public User user { get; set; }
        public PnlReadRepository()
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

            //Read repository
            int id = int.Parse(txtUser.Text.Trim());


            //Comprobar si es suyo o si lo compro 
            if (DAOUser.getPermisoVista(user.id, id) == true)
            {
                Repository repo = DAORepository.read(id);
                PnlReadRepository1 pnl = new PnlReadRepository1();
                pnl.repo = repo;
                pnl.user = this.user;
                pnl.pnlPadre = this.pnlPadre;
                pnl.updateData();
                pnl.Show();
                this.Hide();
            }
            else
            {
                //No tienes permiso
                MessageBox.Show("No tienes permisos.", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
