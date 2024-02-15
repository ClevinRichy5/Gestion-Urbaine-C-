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
    public partial class ConnectAdmin : Form
    {
        public ConnectAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFormulaire af = new AdminFormulaire();
            af.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void ConnectAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
