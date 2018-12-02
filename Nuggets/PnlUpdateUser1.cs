using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuggets
{
    public partial class PnlUpdateUser1 : Form
    {
        public User user { get; set; }
        public PnlUser pnlPadre { get; set; }
        public void updateData()
        {
            txtId.Text = user.id.ToString();
            txtEmail.Text = user.email;
            txtFb.Text = user.fb;
            txtLastName.Text = user.lastName;
            txtName.Text = user.name;
            txtNickname.Text = user.nickname;
            txtTel.Text = user.tel;
        }
        public PnlUpdateUser1()
        {
            InitializeComponent();
        }

        static string ComputeSha1Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA1 sha1Hash = SHA1.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwd1 = txtPwd.Text.Trim();
            string pwd2 = txtPwd2.Text.Trim();

            int id = int.Parse(txtId.Text.Trim());
            string pwd = ComputeSha1Hash(txtPwd.Text.Trim());
            string name = txtName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string fb = txtFb.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tel = txtEmail.Text.Trim();
            string nickname = txtNickname.Text.Trim();

            User u = new User(id, pwd, name, lastname, fb, email, tel, nickname);

            int result = 0;
            if (pwd1 == "")
            {
                result = DAOUser.updatWithoutPassword(u);                
            }else 
            {
                if (pwd1 == pwd2)
                {
                    result = DAOUser.updateUser(u);
                }else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Fallo al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    
            }
            //Para todas
            if (result > 0)
            {

                MessageBox.Show("Datos actualizados con éxito.", "Actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlPadre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se realizó el registro.", "Fallos en actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlPadre.Show();
            this.Hide();
        }
    }
}
