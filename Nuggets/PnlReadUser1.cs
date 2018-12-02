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
    public partial class PnlReadUser1 : Form
    {
        public User user { get; set; }
        public PnlUser pnlPadre = new PnlUser();
        public void updateData()
        {
            txtID.Text = user.id.ToString();
            txtEmail.Text = user.email;
            txtFb.Text = user.fb;
            txtLastName.Text = user.lastName;
            txtName.Text = user.name;
            txtNickname.Text = user.nickname;
            txtPwd.Text = user.password;
            txtTel.Text = user.tel;
        }
        public PnlReadUser1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPadre.Show();            
            this.Hide();
        }
    }
}
