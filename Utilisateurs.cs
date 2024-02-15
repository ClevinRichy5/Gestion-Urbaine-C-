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

namespace ProjetHygiene
{
    public partial class Utilisateurs : Form
    {
        UsersBLL usBLL = new UsersBLL();
        UserDAL usDAL = new UserDAL();
        public Utilisateurs()
        {
            InitializeComponent();
        }

        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        # region method load permet de remplir le datatgridView

        private void LoadData()
        {
            try
            {
                //appele la methode stockselect pour recuperer les donnees du stock
                DataTable dt = usDAL.UserSelect(usBLL);
                //Assurez-vous que datagridview existe deja dans votre code
                dgv1.Rows.Clear();
                //trier le datatable par l'id(prodId) de la plus petite a la plus grande
                DataView dv = dt.DefaultView;
                dv.Sort = "ID ASC";
                DataTable sorteDt = dv.ToTable();
                //assurer vous que la datagridview  existe deja dans votre code
                dgv1.Rows.Clear();
                foreach (DataRow item in sorteDt.Rows)
                {
                    int n = dgv1.Rows.Add();
                    dgv1.Rows[n].Cells["dgvId"].Value = item["ID"].ToString();

                    dgv1.Rows[n].Cells["dgvNom"].Value = item["Nom"].ToString();
                    dgv1.Rows[n].Cells["dgvPrenom"].Value = item["Prenom"].ToString();
                    dgv1.Rows[n].Cells["dgvEmail"].Value = item["Email"].ToString();
                    dgv1.Rows[n].Cells["dgvMdp"].Value = item["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur lors du chargement des donnes " + ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
