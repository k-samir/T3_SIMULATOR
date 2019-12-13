using Menu.classePersonnage;
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
    public partial class frmStatPerso : Form
    {

        int TogMove;
        int MValX;
        int MValY;


        /**
         * Constructeur du frmStatPerso
         * Initialise les attributs des personnages
         */
        public frmStatPerso(UC_Personnage up)
        {
            InitializeComponent();

            pbPerso.Image = up.getImagePerso();

            //perso et ses qualités, défauts, points forts et points faibles
            Personnage p = up.getPersonnage();
            ArrayList qualite = p.getQualite();
            ArrayList defaut = p.getDefaut();
            ArrayList pointFort = p.getPointFort();
            ArrayList pointFaible = p.getPointFaible();

            //prenom
            lblPrenomPerso.Text = p.getPrenom();

            //fatigue
            pbFatigue.Value = p.getFatigue();
            if (pbFatigue.Value <= 45)
            {
                pbFatigue.ProgressColor = Color.Green;
            }
            if (pbFatigue.Value > 45 && pbFatigue.Value <= 75)
            {
                pbFatigue.ProgressColor = Color.Orange;
            }
            if (pbFatigue.Value > 75)
            {
                pbFatigue.ProgressColor = Color.Red;
            }

            //niveau de compétence
            pbCompetence.Value = p.getConnaissances() ;
            if (pbCompetence.Value <= 20)
            {
                pbCompetence.ProgressColor = Color.Red;
            }
            if (pbCompetence.Value > 20 && pbCompetence.Value <= 50)
            {
                pbCompetence.ProgressColor = Color.Orange;
            }
            if (pbCompetence.Value > 50)
            {
                pbCompetence.ProgressColor = Color.Green;
            }

            //stress
            pbStress.Value = p.getStress();
            if (pbStress.Value <= 45)
            {
                pbStress.ProgressColor = Color.Green;
            }
            if (pbStress.Value > 45 && pbStress.Value <= 75)
            {
                pbStress.ProgressColor = Color.Orange;
            }
            if (pbStress.Value > 75)
            {
                pbStress.ProgressColor = Color.Red;
            }

            //a des affinités avec qqn
            if (p.getAffinite().getPrenom() == "-")
            {
                lblAffinite.Text = "Affinité avec personne";
            }
            else
            {
                lblAffinite.Text = "Affinité avec " + p.getAffinite().getPrenom();
            }

            //déteste une personne
            if (p.getDeteste().getPrenom() == "-")
            {
                lblDeteste.Text = "Ne déteste personne";
            }
            else
            {
                lblDeteste.Text = "Déteste " + p.getDeteste().getPrenom();
            }

            //qualite
            for (int i = 0; i <= qualite.Count - 1; i++)
            {
                lblQualite.Text += "\n  " + qualite[i];
            }

            //defaut
            for (int i = 0; i <= defaut.Count - 1; i++)
            {
                lblDefaut.Text += "\n   " + defaut[i];
            }

            //point fort
            for (int i = 0; i <= pointFort.Count - 1; i++)
            {
                lblPointFort.Text += "\n    " + pointFort[i];
            }

            //point faible
            for (int i = 0; i <= pointFaible.Count - 1; i++)
            {
                lblPointFaible.Text += "\n  " + pointFaible[i];
            }
        }
        /**
         * Ferme le formulaire de statistiques
         */
        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**
         * MouseDown du panel en haut
         */
        private void pnlHaut_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }
        
        /**
         * Permet de bouger la fenetre
         */

        private void pnlHaut_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        /**
         * Permet de bouger la fenetre
         */
        private void pnlHaut_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

    }
}
