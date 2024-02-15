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
    public partial class AdminFormulaire : Form
    {
        public AdminFormulaire()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ChoixAdministrateur cx = new  ChoixAdministrateur();
            cx.Show();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Rapport rp = new Rapport();
            rp.Show();
            this.Hide();
        }
    }
}
