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
    public partial class Signalement : Form
    {
        OrdureBLL odBLL = new OrdureBLL();
        OrdureDAL odDAL = new OrdureDAL();
        public Signalement()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            txtVille.Text = string.Empty;
            txtQuartier.Text = string.Empty;
            txtCommentaire.Text = string.Empty;
            cmbRisque.SelectedIndex = -1;
            cmbNiveau.SelectedIndex = -1;
        }

        private void Signalement_Load(object sender, EventArgs e)
        {

        }

       

        private void btnAjouterOrdure_Click(object sender, EventArgs e)
        {
            //recuperer les valeurs des champs du formulaire
            odBLL.ville = txtVille.Text;
            odBLL.quartier = txtQuartier.Text;
            odBLL.commentaire = txtCommentaire.Text;
            if (string.IsNullOrEmpty(odBLL.ville) || string.IsNullOrEmpty(odBLL.quartier) || string.IsNullOrEmpty(odBLL.commentaire))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

             else
                {
                    //determination du status 
                    string risque = cmbRisque.SelectedItem.ToString();   //(cmbRisque.SelectedIndex == 0);
                    odBLL.zoneRisque = risque;
                    string niveau = cmbNiveau.SelectedItem.ToString();   //(cmbNiveau.SelectedIndex == 0);
                    odBLL.niveauOrdure = niveau;
                    //appel de la methode d'insertion de produit
                    try
                    {
                        odDAL.Prodinsert(odBLL);
                        MessageBox.Show("Produit  ajouter avec succes ","Ajout Produit",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Desole une erreur s'est produit lors de l'ajout du produit "+ex,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    clearForm();
                }
            }

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
#region Sélection l'image
//Le bouton ci-dessous permet à l'utilisateur de sélectionner une image depuis son système de fichiers. 
private void btnPacourir_Click(object sender, EventArgs e)
{
    // Créer une nouvelle instance de la classe OpenFileDialog, 
            //qui permet à l'utilisateur de sélectionner un fichier à ouvrir.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Définir un filtre pour spécifier quels types 
            //de fichiers l'utilisateur peut sélectionner. 
            //Dans ce cas, il est configuré pour permettre les fichiers
            //d'images aux formats .jpg, .jpeg, .png, .bmp ou .gif.
            openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // Afficher la boîte de dialogue de sélection de fichiers 
            //et attend que l'utilisateur fasse son choix. 
            //Si l'utilisateur appuie sur le bouton "OK" dans la boîte de dialogue, 
            //le code suivant est exécuté.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Charger l'image depuis le fichier sélectionné par l'utilisateur en créant une instance 
                //de la classe Image à partir du chemin du fichier (openFileDialog.FileName). 
                //L'utilisation de using nous garantit que les ressources 
                //sont libérées correctement après utilisation.
                using (Image img = Image.FromFile(openFileDialog.FileName))
                {
                    // Créer une instance de la classe MemoryStream, qui permet de stocker des données en mémoire.
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // On peut choisir le format approprié ici en fonction de l'extension du fichier sélectionné
                        ImageFormat imageFormat = ImageFormat.Jpeg; // Par défaut, nous utilisons le format JPEG.
                        string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower(); // Obtenir l'extension du fichier en minuscules.
                        // Vérifier l'extension du fichier pour déterminer le format de l'image.
                        if (fileExtension == ".png")
                        {
                            // Le fichier est une image PNG.
                            imageFormat = ImageFormat.Png;
                        }
                        else if (fileExtension == ".bmp")
                        {
                            // Le fichier est une image BMP.
                            imageFormat = ImageFormat.Bmp;
                        }
                        else if (fileExtension == ".gif")
                        {
                            // Le fichier est une image GIF.
                            imageFormat = ImageFormat.Gif;
                        }
                        // Sauvegarder l'image dans le format choisi dans le MemoryStream.
                        img.Save(ms, imageFormat);
                        // Convertir le contenu du MemoryStream en un tableau de bytes (byte[]) 
                        //et l'attribue à la propriété da.photo de UserBLL.
                        odBLL.photo = ms.ToArray();
                    }
                    // Afficher l'image dans un contrôle PictureBox pbx en créant une instance 
                    //de la classe Bitmap 
                    //à partir du chemin du fichier sélectionné.
                    pbx.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
        #endregion

private void label4_Click(object sender, EventArgs e)
{

}




}


        }

      
    

