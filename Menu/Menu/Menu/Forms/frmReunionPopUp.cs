﻿using System;
using System.Collections;
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
        ArrayList liste_perso = new ArrayList();

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            lblInfo.Text = String.Empty;    //remet à zero le lblInfo
        }

        public void messagePopUp(String butReunion)
        {
            if(butReunion == "Faire connaissance")
            {
                lblInfo.Text = "Vous pourrez maintenant mettre un nom sur ces visages mystérieux..";
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
                lblInfo.Text = "A la fin de la réunion, les affinités de chacun seront révélées. A vous d'assigner correctement les tâches maintenant !";
            }

            if(butReunion == "Découvrir le projet")
            {
                lblInfo.Text = "Il vous est demandé de réaliser la simulation d'une gestion de projet T3.";
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
