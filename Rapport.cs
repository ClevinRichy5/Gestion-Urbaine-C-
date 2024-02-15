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
    public partial class Rapport : Form
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            AdminFormulaire Af = new AdminFormulaire();
            Af.Show();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            // Crée une nouvelle instance de la classe ProductsReport dans l'espace de noms ReportsForm.
            ReportsForm.UserReport prd = new ReportsForm.UserReport();
            // Définit la fenêtre parente de la nouvelle instance de ProductsReport comme étant "this",
            // qui fait référence à la fenêtre actuelle où le gestionnaire d'événements est exécuté.
            prd.Rapport = this;
            // Définit la position de départ de la fenêtre ProductsReport au centre de la fenêtre parente.
            prd.StartPosition = FormStartPosition.CenterScreen;
            // Affiche la fenêtre ProductsReport. Cela affiche la fenêtre enfant à l'intérieur de la fenêtre principale.
            prd.Show();
        }
    }
}
