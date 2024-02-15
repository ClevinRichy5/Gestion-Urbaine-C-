using BLL;
using CrystalDecisions.CrystalReports.Engine;
using DAL;
//using ProjetHygiene.BLL;
//using ProjetHygiene.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetHygiene.ReportsForm
{
    public partial class UserReport : Form
    {
        UserDAL ba = new UserDAL();
        UsersBLL da = new UsersBLL();

        ReportDocument rpt = new ReportDocument();
        public UserReport()
        {
            InitializeComponent();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            // Charge un rapport Crystal Reports depuis un chemin spécifié.
            rpt.Load(@"G:\PAM2\Support de cours\PDF\C#\ProjetHygiene\ProjetHygiene\Reports\CrystalReport1.rpt");

            // Appelle une méthode pour récupérer des données depuis la base de données et les stocke dans un DataTable.
            DataTable dt = ba.UserSelect(da);

            // Définit le DataTable comme la source de données pour le rapport Crystal Reports.
            rpt.SetDataSource(dt);

            // Associe le rapport Crystal Reports au contrôle CrystalReportViewer pour l'afficher à l'utilisateur.
            crystalReportViewer1.ReportSource = rpt;
        }

        public Rapport Rapport { get; set; }
    }
}
