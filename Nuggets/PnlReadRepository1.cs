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
    public partial class PnlReadRepository1 : Form
    {
        public Repository repo { get; set; }
        public void update()
        {
            txtID.Text = repo.id.ToString();
            txtAutor.Text = repo.id_creator.ToString();
            txtDescripción.Text = repo.description;           
        }
        public PnlReadRepository1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 pnl = new Nuggets.Form1();
            pnl.Show();
            this.Hide();
        }
    }
}
