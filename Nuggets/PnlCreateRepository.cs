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
        public PnlCreateRepository()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int creator_id = int.Parse(txtAutor.Text);
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
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
