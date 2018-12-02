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
    public partial class PnlUser : Form
    {
        public User user { get; set; }
        
        public PnlUser()
        {
            InitializeComponent();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadCatalogo pnl = new PnlReadCatalogo();
            pnl.user = this.user;
            pnl.pnlPadre = this;
            pnl.updateData();
            pnl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Actualiza los dato de este usuario
            PnlUpdateUser1 pnl = new PnlUpdateUser1();
            pnl.pnlPadre = this;
            pnl.user = this.user;
            pnl.updateData();
            pnl.Show();
            this.Hide();
        }

        private void leerMisDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadUser1 pnl = new PnlReadUser1();
            pnl.pnlPadre = this;
            pnl.user = this.user;
            pnl.updateData();
            pnl.Show();
            this.Hide();
        }

        private void eliminarMiCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDeleteUser pnl = new PnlDeleteUser();
            pnl.user = this.user;
            pnl.pnlPadre = this;
            pnl.Show();
            this.Hide();
        }

        private void agregarForaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlCreateCard pnl = new PnlCreateCard();
            pnl.id = DAOCard.getMaxId()+1;
            pnl.user = this.user;
            pnl.updateIdView();
            pnl.Show();
            this.Hide();
        }

        private void leerDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadCards pnl = new PnlReadCards();
            pnl.user = this.user;
            pnl.pnlPadre = this;
            pnl.updateData();
            pnl.Show();
            this.Hide();
        }

        private void actualizarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PnlUpdateCard pnl = new PnlUpdateCard();
            pnl.pnlPadre = this;
            pnl.Show();
            this.Hide();
        }

        private void eliminarFormaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDeleteCard pnl = new PnlDeleteCard();
            pnl.pnlPadre = this;
            pnl.Show();
            this.Hide();
        }

        private void crearUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlCreateRepository pnl = new PnlCreateRepository();
            pnl.pnlPadre = this;
            pnl.user = user;
            int id = DAORepository.getCountAll();
            if (id == 0)
            {
                pnl.updateData(1);
            }
            else
            {
                pnl.updateData(DAORepository.getMaxId()+1);
            }
            pnl.Show();
            this.Hide();
        }

        private void leerMisRepositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadRepository pnl = new PnlReadRepository();
            pnl.pnlPadre = this;
            pnl.user = user;
            pnl.Show();
            this.Hide();
        }

        private void actualizarMisRespositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarMisRepositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlDeleteRepository pnl = new PnlDeleteRepository();
            pnl.user = this.user;
            pnl.pnlPadre = this;
            pnl.Show();
            this.Hide();
        }

        private void verListaDeRepositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadMyCreatedRepositories pnl = new PnlReadMyCreatedRepositories();
            pnl.pnlPadre = this;
            pnl.user = user;
            pnl.updateData();
            pnl.Show();
            this.Hide();
        }

        private void repositoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadMyPurchases pnl = new PnlReadMyPurchases();
            pnl.pnlPadre = this;
            pnl.user = user; 
            pnl.updateData();
            pnl.Show();
            this.Hide();

        }

        private void verRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlReadRepository pnl = new PnlReadRepository();
            pnl.user = user;
            pnl.pnlPadre = this;
            pnl.Show();
            this.Hide();
        }

        private void misComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
