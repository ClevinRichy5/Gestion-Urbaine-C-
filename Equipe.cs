using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Data.SqlClient;

namespace ProjetHygiene
{
    public partial class Equipe : Form
    {

        EquipeDAL pba = new EquipeDAL();
        EquipeBLL pda = new EquipeBLL();
        MembreBLL NMB = new MembreBLL();
        public Equipe()
        {
            InitializeComponent();
        }

        private void Equipe_Load(object sender, EventArgs e)
        {
            groupBox1.AutoSize = true;
            groupBox2.AutoSize = true;
            groupBox3.AutoSize = true;
            groupBox4.AutoSize = true;
            loadData();
        }

        #region Enabled
        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true; groupBox1.Enabled = true;
            radioButton2.Enabled = true; groupBox2.Enabled = false;
            radioButton3.Enabled = true; groupBox3.Enabled = false;
            radioButton4.Enabled = true; groupBox4.Enabled = false;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true; groupBox1.Enabled = false;
            radioButton2.Enabled = true; groupBox2.Enabled = true;
            radioButton3.Enabled = true; groupBox3.Enabled = false;
            radioButton4.Enabled = true; groupBox4.Enabled = false;

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true; groupBox1.Enabled = false;
            radioButton2.Enabled = true; groupBox2.Enabled = false;
            radioButton3.Enabled = true; groupBox3.Enabled = true;
            radioButton4.Enabled = true; groupBox4.Enabled = false;

        }
        private void radioButton4_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true; groupBox1.Enabled = false;
            radioButton2.Enabled = true; groupBox2.Enabled = false;
            radioButton3.Enabled = true; groupBox3.Enabled = false;
            radioButton4.Enabled = true; groupBox4.Enabled = true;

        }
        #endregion

        public void evaluation()
        {
            DialogResult result = MessageBox.Show("Voulez-vous evaluer le service?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("pas encore disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Nous allons vous demander de si vous voullez evaluer le service demain a la meme heure", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void loadData()
        {
            DataTable dt = pba.EquipeSelect(pda);
            foreach (DataRow item in dt.Rows)
            {
                //int n = dataGridView1.Rows.Add();
                label2.Text = item["NOM"].ToString() + " " + item["PRENOM"].ToString();
                label3.Text = item["NOM"].ToString();
                label4.Text = item["NOM"].ToString();
            }
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            evaluation();
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
            adm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            NMB.NBZone = NMB.NBZone + 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NMB.NBZone = NMB.NBZone + 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            NMB.NBZone = NMB.NBZone + 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            NMB.NBZone = NMB.NBZone + 1;
        }
        public static int NBZone;
        public int nombre()
        {
            NBZone = NBZone + 1;
            return NBZone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*test te = new test();
            te.Show();
            NBZone = nombre();
            label14.Text = NBZone.ToString();
            string txt = textBox1.ToString();*/
            //pba.productupdate(NMB, txt, NMB.Id);
            Accueil ac = new Accueil();
            ac.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
