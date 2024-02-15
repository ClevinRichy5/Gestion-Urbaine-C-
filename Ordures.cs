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
using System.Drawing.Imaging;
using System.IO;

namespace ProjetHygiene
{
    public partial class Ordures : Form
    {
        OrdureBLL orBLL = new OrdureBLL();
        OrdureDAL orDAL = new OrdureDAL();
        public Ordures()
        {
            InitializeComponent();
        }

        private void Ordures_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Charger le datagridview
        private void LoadData()
        {
            try
            {
                // Appeler la méthode UserSelect pour récupérer les données des utilisateurs
                DataTable dt = orDAL.OrdureSelect(orBLL);
                // Effacer le dataGridView pour y ajouter des données à jour
                dgv2.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dgv2.Rows.Add();
                    dgv2.Rows[n].Cells["dgvVille"].Value = item["Ville"].ToString();
                    dgv2.Rows[n].Cells["dgvQuartier"].Value = item["Quartier"].ToString();
                    dgv2.Rows[n].Cells["dgvNiveau"].Value = item["NiveauOrdure"].ToString();
                    dgv2.Rows[n].Cells["dgvZone"].Value = item["Zone"].ToString();
                    dgv2.Rows[n].Cells["dgvCommentaire"].Value = item["Commentaire"].ToString();
                    // Récupérer les données binaires de la colonne PHOTO
                    if (item["PHOTO"] != DBNull.Value)
                    {
                        byte[] photoBytes = (byte[])item["PHOTO"];

                        // Convertir les données binaires en une image
                        using (MemoryStream ms = new MemoryStream(photoBytes))
                        {
                            Image originalImage = Image.FromStream(ms);

                            // Redimensionner l'image pour correspondre à la taille de la colonne
                            int imageSize = 64; // Taille souhaitée de l'image (64x64, par exemple)
                            Image resizedImage = ResizeImage(originalImage, imageSize, imageSize);

                            dgv2.Rows[n].Cells["dgvImg"].Value = resizedImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region redimensionner l'image

        private Image ResizeImage(Image sourceImage, int width, int height)
        {
            // Crée une nouvelle instance de la classe Bitmap 
            //pour l'image redimensionnée avec la largeur et la hauteur spécifiées.
            Bitmap resizedImage = new Bitmap(width, height);
            // Crée un objet Graphics à partir de l'image redimensionnée, 
            //ce qui permet de dessiner sur cette image.
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                // Définit le mode d'interpolation pour le redimensionnement. 
                //L'interpolation Bicubique de haute qualité produit un résultat lisse.
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                // Dessine l'image source (non redimensionnée) sur l'image redimensionnée 
                //avec les dimensions spécifiées (0, 0, width, height).
                g.DrawImage(sourceImage, 0, 0, width, height);
            }
            // Retourne l'image redimensionnée.
            return resizedImage;
        }

        #endregion
    }
}
