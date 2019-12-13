﻿using Menu.classePersonnage;
using System;
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
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            
            this.Close();

            lblInfo.Text = String.Empty;    //remet à zero le lblInfo
        }

        public void messagePopUp(String butReunion)
        {
            lblNotification.Text = "Félicitations";

            if (butReunion == "Évaluer le potentiel du groupe")
            {
                lblInfo.Text = "Les attributs des personnages seront révelés";
            }

            if (butReunion == "Révèle les qualités et les défauts")
            {
                lblInfo.Text = "Les qualités et les défauts de chaque personnage seront révelés";
            }

            if (butReunion == "Analyse des affinités de chacun")
            {
                lblInfo.Text = "Les éventuelles affinités de chacun seront révélées.\nVous devrez assigner les tâches correctement !";
            }

            if (butReunion == "Analyse de la demande du client et de ses besoins + Définir un cahier des charges")
            {
                lblInfo.Text = "Vous savez maintenant quelles sont les fonctionnalités dont le client a besoin.\nMais attention les tâches sont à faire dans un ordre précis";
            }

            if (butReunion == "Mettre en place un système d'organisation")
            {
                Random r = new Random();
                int numPerso = r.Next(4);
                ArrayList tmp = ControleurJeu.getListePersonnage();
                Personnage p = (Personnage)tmp[numPerso];

                lblInfo.Text = p.getPrenom() + " a été désigné en tant que chef de projet.\nVous pouvez faire les points sur votre avancement du projet lors des réunions";
            }

            if (butReunion == "Mettre en commun le travail et l'avancement de chacun")
            {
                lblInfo.Text = "Vous pouvez voir l'avancement de chaque tâches à réaliser";
            }

            if(butReunion == "Nombre de réunion dépassé")
            {
                lblNotification.Text = "Limite atteinte";
                lblInfo.Text = "Vous ne pouvez pas aborder plus de 3 thématiques lors des réunions";
            }

            if (butReunion == "Aymeric")
            {
                lblNotification.Text = "Malheureusement..";
                lblInfo.Text = "Aymeric a sûrement trop joué hier soir. Il faudra se passer de lui pour ce tour !";
            }
            if (butReunion == "Samir")
            {
                lblNotification.Text = "Malheureusement..";
                lblInfo.Text = "Samir a un rendez-vous chez le dentiste. Il sera absent aujourd'hui !";
            }
            if (butReunion == "Mathieu")
            {
                lblNotification.Text = "Malheureusement..";
                lblInfo.Text = "Mathieu est tellement sous pression qu'il hésite à démissionner.. Ne comptez pas sur lui pour ce tour.";
            }
            if(butReunion == "Valentin")
            {
                lblNotification.Text = "Malheureusement..";
                lblInfo.Text = "Valentin est en plein burn out, il est tombé malade à force de travailler.";
            }

            if(butReunion == "picturebox")
            {
               lblNotification.Text = "Astuce";
               lblInfo.Text = "Faites connaissance avec les membres du projet, puis revenez ici..";
            }

            if(butReunion == "formation")
            {
                lblNotification.Text = "Astuce";
                lblInfo.Text = "La formation sert à obtenir des compétences pour effectuer certaines tâches qui nécessitent un certain niveau de compétence";
            }

        }

        private void frmReunionPopUp_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
