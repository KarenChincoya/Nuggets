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
    public partial class PnlCreateRepository : Form
    {
        public User user { get; set; }
        public PnlUser pnlPadre { get; set; }
        public PnlCreateRepository()
        {
            InitializeComponent();
        }

        public void updateData(int id)
        {
            this.txtID.Text = id.ToString();
            this.txtAutor.Text = user.id.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlPadre.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listener para creacion
            int creator_id = user.id;
            string name = txtNombre.Text;
            string descripcion = txtDescripción.Text;
            string picture1 = txtPicture1.Text;
            string picture2 = txtPicture2.Text;
            string picture3 = txtPicture3.Text;

            //Crear los objetos
            Repository repo = new Repository(creator_id, name, descripcion, picture1, picture2, picture3);
            //Insertar
            int result = DAORepository.create(repo);

            if (result > 0)
            {
                MessageBox.Show("Repositorio agregado.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
