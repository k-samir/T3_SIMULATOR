using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.classePersonnage;
using System.Collections;

namespace Menu
{
    public partial class frmJeu : Form
    {

        ArrayList listPerso = new ArrayList();
        int nbTour = 1; //nb de tour pour le projet
        public frmJeu(Personnage p1, Personnage p2, Personnage p3, Personnage p4)
        {
            InitializeComponent();

            ArrayList listPerso = ControleurJeu.getListeFonctionnalite();

            initUC(uC_Personnage1, p1);
            initUC(uC_Personnage2, p2);
            initUC(uC_Personnage3, p3);
            initUC(uC_Personnage4, p4);

            foreach (Object o in Controls)
            {
                if (o is UC_Personnage)
                {
                    UC_Personnage uC_Perso = new UC_Personnage();
                    uC_Perso.Enabled = true;
                }
            }
        }
        
        public void initUC(UC_Personnage uC, Personnage p)
        {
            uC.initialisationUCPerso(p);
        }

        public void augmenterNbTour()
        {
            nbTour++;
        }

        public int getNbTour()
        {
            return this.nbTour;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        public String recupTxtFichier(String nomFichier, String typeFichier)
        {
            String texte = System.IO.File.ReadAllText(@"C:\Users\tieut\myt3\Menu\Menu\"+nomFichier+"."+typeFichier);
            return texte;
        }


        

        private void btnTourSuivant_Click(object sender, EventArgs e)
        {
            rtbActu.Text = String.Empty;

            ControleurJeu.nouveauTour();
            rtbActu.Text = "Tour effectué " + this.getNbTour() + " / 30 ";
            this.augmenterNbTour();   //incremente nb de tour

            ArrayList listPerso = ControleurJeu.getListePersonnage();

            Personnage p1 = (Personnage)listPerso[0];
            Personnage p2 = (Personnage)listPerso[1];
            Personnage p3 = (Personnage)listPerso[2];
            Personnage p4 = (Personnage)listPerso[3];

            //mise a jour des persos apres avoir effectue les taches
            initUC(uC_Personnage1, p1 );
            initUC(uC_Personnage2, p2 );
            initUC(uC_Personnage3, p3 );
            initUC(uC_Personnage4, p4 );

            foreach (Object o in Controls)
            {
                if (o is UC_Personnage)
                {
                    UC_Personnage uC_Perso = new UC_Personnage();
                    uC_Perso.Enabled = true;
                }
            }

        }

        private void btnCrunch_Click(object sender, EventArgs e)
        {
            //tout les persos se reposent
            rtbActu.Text = String.Empty;

            ControleurJeu.crunch();
            rtbActu.Text = "Crunch Activé\nTout le monde se repose\nPersonne ne s'avance sur le projet\nEt donc tout le monde revient en pleine forme et sans être stressé\nTour effectué " + this.getNbTour() + " / 30 ";
            this.augmenterNbTour();   //incremente nb de tour

            ArrayList listPerso = ControleurJeu.getListePersonnage();

            Personnage p1 = (Personnage)listPerso[0];
            Personnage p2 = (Personnage)listPerso[1];
            Personnage p3 = (Personnage)listPerso[2];
            Personnage p4 = (Personnage)listPerso[3];

            //mise a jour des persos apres avoir effectue les taches
            initUC(uC_Personnage1, p1);
            initUC(uC_Personnage2, p2);
            initUC(uC_Personnage3, p3);
            initUC(uC_Personnage4, p4);

            foreach (Object o in Controls)
            {
                if (o is UC_Personnage)
                {
                    UC_Personnage uC_Perso = new UC_Personnage();
                    uC_Perso.Enabled = true;
                }
            }
        }
    }
}
