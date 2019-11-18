using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class frmReunionPopUp : Form
    {
        public frmReunionPopUp()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            lblInfo.Text = String.Empty;    //remet à zero le lblInfo
        }

        public void messagePopUp(String butReunion)
        {
            if(butReunion == "Faire connaissance")
            {
                lblInfo.Text = "Les noms des personnages sont révelés";
            }

            if (butReunion == "Évaluer le potentiel du groupe")
            {
                lblInfo.Text = "Les attributs des personnages sont révelés";
            }

            if (butReunion == "Révèle les qualités et les défauts")
            {
                lblInfo.Text = "Les qualités et les défauts de chaque personnage sont révelés";
            }

            if (butReunion == "Analyse des affinités de chacun")
            {
                lblInfo.Text = "Les affinités entre les personnages sont révelées.\nCliquer sur l'image du personnage dont vous voulez savoir les affinités avec les autres personnages";
            }

            if(butReunion == "Découvrir le projet")
            {
                lblInfo.Text = "Le projet consiste à faire un programme consistant à faire apprendre à l'utilisateur de gérer un projet T3";
            }

            if(butReunion == "Analyse de la demande du client et de ses besoins + Définir un cahier des charges")
            {
                lblInfo.Text = "Vous savez maintenant quelles sont les fonctionnalités dont le client a besoin";
            }

            if(butReunion == "Mettre en place un système d'organisation")
            {
                lblInfo.Text = "Vous pouvez maintenant faire le point pendant vos réunions";
            }

            if (butReunion == "Mettre en commun le travail et l'avancement de chacun")
            {
                lblInfo.Text = "Vous pouvez voir toutes les tâches terminées sur la console";
            };
        }
    }
}
