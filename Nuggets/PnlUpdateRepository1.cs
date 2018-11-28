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
    public partial class PnlUpdateRepository1 : Form
    {
        public Repository repo { get; set; }
        public void updateData()
        {
            txtID.Text = repo.id.ToString();
            txtAutor.Text = repo.id_creator.ToString();
            txtDescripción.Text = repo.description;
            txtPicture1.Text = repo.picture1;
            txtPicture2.Text = repo.picture2;
            txtPicture3.Text = repo.picture3;
        }
        public PnlUpdateRepository1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pnl = new Form1();
            pnl.Show();
            this.Hide();
        }
    }
}
