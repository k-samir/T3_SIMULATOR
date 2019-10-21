using System;
using System.Collections.Generic;
//using System.Collections.ArrayList;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Text;
using Menu.classePersonnage;

namespace Menu
{
    public class ControleurJeu
    {
        public Projet Projet
        {
            get => default;
            set
            {
            }
        }



        Projet proj1;

        //variable globale
        Personnage p1;
        Personnage p2;
        Personnage p3;
        Personnage p4;


        //Fonctionnalite

        Fonctionnalites f1 = new Fonctionnalites("Recherche dans Cahier des Charges", 7, 0, 0, "Recherche");
        Fonctionnalites f2 = new Fonctionnalites("Recherche Objectifs Pédagogiques", 5, 0, 0, "Recherche");
        Fonctionnalites f3 = new Fonctionnalites("Recherche code", 8, 0, 0, "Recherche");
        Fonctionnalites f4 = new Fonctionnalites("MCD", 8, 0, 0, "Conception");
        Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 5, 0, 0, "Conception");
        Fonctionnalites f6 = new Fonctionnalites("Conception3", 3, 0, 0, "Conception");
        Fonctionnalites f7 = new Fonctionnalites("Developpement des classes", 10, 0, 0, "Développement");
        Fonctionnalites f8 = new Fonctionnalites("Developpement controleur", 10, 0, 0, "Développement");
        Fonctionnalites f9 = new Fonctionnalites("Developpement ", 10, 0, 0, "Développement");


        public ArrayList listFonctionnalite = new ArrayList();

        /*
        listFonctionnalite.Add(f1);
        listFonctionnalite.Add(f2);
        listFonctionnalite.Add(f3);
        listFonctionnalite.Add(f4);
        listFonctionnalite.Add(f5);
        */
        // frmJeu jeu;

        private int compteurTours = 0;
        private Boolean gameON = true;


        public void lancerJeu(frmMenu f)
        {
            f.Hide();
            //creation personnage
            p1 = remplirPersonnage("Valentin", 2.0, 0, 82);
            p2 = remplirPersonnage("Aymeric", 2.0, 20, 80);
            p3 = remplirPersonnage("Mathieu", 3.3, 40, 50);
            p4 = remplirPersonnage("Samir", 4.2, 10, 45);

            frmJeu jeu = new frmJeu(p1, p2, p3, p4);
            jeu.Show();
        }

        public Personnage remplirPersonnage(string prenom, double productivite, int stress, int sociabilite) //créer personnage avec attributs en paramètres
        {
            // TEST A EFFECTUER 
            return new Personnage(prenom, productivite, stress, sociabilite);
        }
        /*
        public Projet remplirProjet(string prenom, double productivite, int stress, int sociabilite) //créer projet avec attributs en paramètres
        {
           // return new Projet(prenom, productivite, stress, sociabilite);
        }
        */

        public void arreterJeu()
        {
            throw new System.NotImplementedException();
        }

        public static void remplirComboBox(ComboBox cb, String action)
        {
           /* foreach (Fonctionnalites f in listFonctionnalite)
            {
                if (f.getAction() == action)
                {
                    cb.Items.Add(f.getNom());
                }
            }*/
        }

        public void main()
        {
            arreterJeu();
        }

        public static void lancerNouveauTour()
        {
            calculsAttributs();


        }

        public static void calculsAttributs()
        {
            String prenom = "";
            //integer 
            //p1.setPrenom(prenom); //string
            
            //p1.setFatigue(fatigue); //int
            //p1.setStress(stress); //int
            //p1.setConnaissances(connaissances); //int
            //p1.setSociabilite(sociabilite); //int
            //p1.setProductivite(productivite); //int

        }


        /* ----------------------Accesseurs----------------------------------- */
        public int getCompteurTours()
        {
            return this.compteurTours;
        }
        private void setCompteurTours(int noUse)
        {
            this.compteurTours = noUse;
        }

        public bool getGameON()
        {
            return this.gameON;
        }
        public void setGameON(bool game)
        {
            this.gameON = game;
        }


        /* -------------------------------------------------------------- */
    }
}