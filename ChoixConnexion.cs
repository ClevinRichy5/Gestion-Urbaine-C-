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
    public partial class ChoixConnexion : Form
    {
        public ChoixConnexion()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            CreerCompteUsers ccu = new CreerCompteUsers();
            ccu.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ConnectAdmin ca =  new ConnectAdmin();
            ca.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
