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
    public partial class PnlCreateUser : Form
    {
        public User user { get; set; }
        public void updateUserId(int id)
        {
            txtId.Text = id.ToString();
            txtId.Enabled = false;
        }
        public PnlCreateUser()
        {
            InitializeComponent();
        }

        private void PnlCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear los objetos
            int id = int.Parse(txtId.Text);
            string pwd = txtPwd.Text;
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string fb = txtFb.Text;
            string email = txtEmail.Text;
            string tel = txtTel.Text;
            string nickname = txtNickname.Text;

            //Insertar
            int result = DAOUser.create(new User(id, pwd, name, lastname, fb, email, tel, nickname));

            if (result > 0)
            {
                
                MessageBox.Show("Usuario guardado con éxito.", "Usuario registrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
