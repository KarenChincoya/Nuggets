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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlCreateUser pnl = new PnlCreateUser();
            int id = DAOUser.getLastId();
            pnl.updateUserId(id+1);
            pnl.Show();
            this.Hide();
        }

        static string ComputeSha1Hash(string rawData)
        {
            // Crea SHA256   
            using (SHA1 sha1Hash = SHA1.Create())
            {
                // retorna byte array  
                byte[] bytes = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convierte byte array to a string   
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
            string user = txtUser.Text.Trim();
            int id = int.Parse(user);
            string pwd = txtPwd.Text.Trim();

            string hash = ComputeSha1Hash(pwd);
            string registro = DAOUser.getPwd(id);

            if (hash == registro)
            {
                //Mostarr el pnl
                User u = DAOUser.readUser(id);
                PnlUser pnl = new PnlUser();
                pnl.user = u;
                pnl.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuario o contraseña incorrecta.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
