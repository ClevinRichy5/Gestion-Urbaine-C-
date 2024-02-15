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
    public partial class FormSplash : Form
    {
        
            
        public FormSplash()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;//arret du timer
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(100);
            }
            Accueil f = new Accueil();
            f.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FormSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
