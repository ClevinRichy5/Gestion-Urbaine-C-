using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetHygiene
{
    public partial class ChoixAdministrateur : Form
    {
        public ChoixAdministrateur()
        {
            InitializeComponent();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Utilisateurs ut = new Utilisateurs();
            ut.MdiParent = this;
            ut.Show();
            /*ut.StartPosition = FormStartPosition.CenterScreen;
            ut.FormBorderStyle = FormBorderStyle.None;
            ut.Dock = DockStyle.Fill;*/
            
        }

        private void ordureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordures or = new Ordures();
            or.MdiParent = this;
            or.Show();
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipe or = new Equipe();
            or.MdiParent = this;
            or.Show();
        }
    }
}
