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
using Menu.Forms;

namespace Menu
{
    public partial class frmJeu : Form
    {

        ArrayList listPerso = new ArrayList();
        int nbTour = 1; //nb de tour pour le projet
        int nbTourMax = 10;
        bool crunchBool = false;
        // String d'affichage des actoins / jour
        public static string s = "";
        // Avancement de la progressbar
        private static float avancement = 0;
        public frmJeu(Personnage p1, Personnage p2, Personnage p3, Personnage p4)
        {
            InitializeComponent();

            lblDeadLine.Text = pbAvancement.Value + "% Avancement";

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

        public void tombeMalade(Personnage p)
        {
            p.setMalade(true);
        }

        public void initUC(UC_Personnage uC, Personnage p)
        {
            uC.initialisationUCPerso(p);
        }

        public void augmenterNbTour()
        {
            pbAvancement.Value = (int)avancement;
            lblDeadLine.Text = pbAvancement.Value.ToString() + "% Avancement";
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



        public void ecrireSurConsole()       //controleur de jeu écrit sur le fil d'actualité
        {
            rtbActu.Text = String.Empty;
            rtbActu.Text = ControleurJeu.filActualite();
            rtbActu.Text += "Tour effectué " + this.getNbTour() + " / 10 ";
            this.augmenterNbTour();   //incremente nb de tour

        }

        private void btnTourSuivant_Click(object sender, EventArgs e)
        {
            if (crunchBool == true)
            {
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {
                                UC_Personnage up = (UC_Personnage)c;
                                up.Enabled = true;
                                up.crunchDesactive();
                                crunchBool = false;
                            }
                        }
                    }
                }
            }

                /*TEST MALADIE ------------------------ */
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {
                                UC_Personnage up = (UC_Personnage)c;

                                up.crunchDesactive();
                                up.getPersonnage().setMalade(false);
                                crunchBool = false;
                                //Si l'avancement est entre 20 et 90% on fait tomber malade un ou plusieurs perso
                                if (getAvancement() >= 20 && getAvancement() <= 90)
                                {
                                    
                                    Random aleatoire = new Random();
                                    int rnd = aleatoire.Next(6);
                                    if(rnd == 0)
                                {

                                    up.getPersonnage().setMalade(true);
                                    up.Enabled = false;
                                    
                                    
                                }
                                    
                                }
                            else
                            {
                                up.Enabled = true;
                                up.getPersonnage().setMalade(false);
                                up.BackColor = Color.AliceBlue;
                                

                            }

                            }
                        }
                    }
                }
        

            

            // FIN SI DEADLINE OU TOUTES LES FONCTIONS SONT FINIES
            // A REVOIR ( VERIFIER SI LE POURCENTAGE DU PROJET == 100 --> FIN )
            if ((nbTour >= nbTourMax) || ( (ControleurJeu.getListeFonctionnalite().Count == 0) && pbAvancement.Value == 100))
            {
                ControleurJeu.arreterJeu();
                this.Close();
            }

            //modification des taches des user controls
            foreach (Object o in Controls)
            {
                if (o is Panel)
                {
                    Panel p = (Panel)o;

                    foreach (Object c in p.Controls)
                    {
                        if (c is UC_Personnage)
                        {

                            UC_Personnage up = (UC_Personnage)c;               
                            up.donnerTachePerso();
                            // MessageBox.Show("affectation des taches");
             
                        }
                        
                        
                    }

                }

            }


            try
            {
                // REMPLISSAGE DEUXIEME "CONSOLE"
                rtbListeF.Text += "\nJournée " + nbTour.ToString() + ":\n";
                rtbListeF.Text += s;

                s = "";
                /** foreach (Fonctionnalites f in ControleurJeu.getListTache())
                 {
                     rtbListeF.Text += f.getNom() + "\n";

                 }**/


                // MISE A ZERO DES COMBOBOX POUR NE PLUS AVOIR LES ANCIENS CHOIX
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;

                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {

                                UC_Personnage up = (UC_Personnage)c;
                                up.cleanCBO();  
                            }


                        }

                    }

                }

                ControleurJeu.nouveauTour();

                ecrireSurConsole();

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

                // FIN SI DEADLINE OU TOUTES LES FONCTIONS SONT FINIES
                // A REVOIR ( VERIFIER SI LE POURCENTAGE DU PROJET == 100 --> FIN )
                if ((nbTour >= nbTourMax) || (ControleurJeu.getListeFonctionnalite().Count == 0))
                {
                    ControleurJeu.arreterJeu();
                    this.Close();
                }


            }
            catch (NullReferenceException)
            {
                
                MessageBox.Show("Selectionnez Action");
            }
        }


        // METHODE DE CONCATENATION DES ACTIONS DU JOUR
        public static void remplir(string s1)
        {
            s += s1;
            
            
        } 
        
        
        private void btnRepos_Click(object sender, EventArgs e)
        {
            if (crunchBool == true)
            {
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {
                                UC_Personnage up = (UC_Personnage)c;
                                up.crunchDesactive();
                                crunchBool = false;
                            }
                        }
                    }
                }
            }

            if (nbTour >= 10)
            {
                ControleurJeu.arreterJeu();
                this.Close();
            }

            //tous les persos se reposent

            rtbActu.Text = String.Empty;

            ControleurJeu.repos();
            rtbActu.Text = "Repos Activé\nTout le monde se repose\nPersonne ne s'avance sur le projet\nEt donc tout le monde revient moins fatigué et moins stressé\nTour effectué " + this.getNbTour() + " / 10 ";
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
        }

        public static float getAvancement()
        {
            return avancement;
        }

        public static void setAvancement(float a)
        {
            avancement = a;
        }




        private void btnCrunch_Click_1(object sender, EventArgs e)
        {
            foreach (Object o in Controls)
            {
                if (o is Panel)
                {
                    Panel p = (Panel)o;
                    foreach (Object c in p.Controls)
                    {
                        if (c is UC_Personnage)
                        {
                            UC_Personnage up = (UC_Personnage)c;
                            up.crunchActive();
                            crunchBool = true;
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uC_Personnage2_Load(object sender, EventArgs e)
        {

        }

        private void btnReunion_Click(object sender, EventArgs e)
        {
            frmReunion reunion = new frmReunion();
            reunion.ShowDialog();
        }
    }
}