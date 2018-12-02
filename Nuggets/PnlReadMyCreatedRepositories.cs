using System;
using System.Collections;
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
    public partial class PnlReadMyCreatedRepositories : Form
    {
        public PnlUser pnlPadre { get; set; }
        public User user { get; set; }

        public void updateData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID del repositorio");
            dt.Columns.Add("Id del creador");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Imagen 1");
            dt.Columns.Add("Imagen 2");
            dt.Columns.Add("Imagen 3");

            ArrayList repos = DAORepository.readMyCreatedRepos(user.id);
 
            foreach (Repository repo in repos)
            {
                dt.Rows.Add(new object[] { repo.id, repo.id_creator, repo.name, repo.description, repo.picture1, repo.picture2, repo.picture3 });
            }

            dataGridView1.DataSource = dt;
        }
        public PnlReadMyCreatedRepositories()
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
