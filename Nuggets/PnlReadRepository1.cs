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
        public PnlUser pnlPadre { get; set; }
        public User user { get; set; }
        public Repository repo { get; set; }
        public void updateData()
        {
            txtID.Text = repo.id.ToString();
            txtAutor.Text = repo.id_creator.ToString();
            txtNombre.Text = repo.name;
            txtDescripción.Text = repo.description;

            string p1 = repo.picture1.Trim();
            string p2 = repo.picture2.Trim();
            string p3 = repo.picture3.Trim();

            //Las imagenes deben estar en la carpeta bin 
            picture1.Image = Image.FromFile(p1);
            picture2.Image = Image.FromFile(p2);
            picture3.Image = Image.FromFile(p3);    
        }
        public PnlReadRepository1()
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
