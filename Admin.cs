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
    public partial class Admin : Form
    {
        EquipeDAL pba = new EquipeDAL();
        EquipeBLL pda = new EquipeBLL();
        MembreBLL NMB = new MembreBLL();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #region Charger le datagridview
        private void LoadData()
        {
            try
            {
                // Appeler la méthode UserSelect pour récupérer les données des utilisateurs
                DataTable dt = pba.EquipeSelect(pda);
                // Effacer le dataGridView pour y ajouter des données à jour
                dgv2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dgv2.Rows.Add();
                    dgv2.Rows[n].Cells["dgvId"].Value = item["Id"].ToString();
                    dgv2.Rows[n].Cells["dgvEquipeNettoyage"].Value = item["IdEquipe"].ToString();
                    dgv2.Rows[n].Cells["dgvNom"].Value = item["nom"].ToString();
                    dgv2.Rows[n].Cells["dgvPrenom"].Value = item["Prenom"].ToString();
                    dgv2.Rows[n].Cells["dgvResidence"].Value = item["Residence"].ToString();
                    dgv2.Rows[n].Cells["dgvEmail"].Value = item["Email"].ToString();
                          }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion




    }
}
