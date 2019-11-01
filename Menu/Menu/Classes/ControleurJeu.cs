using System;
using System.Collections.Generic;
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
        private static ArrayList listfonctionnalite = new ArrayList();
        private static ArrayList listPersonnage = new ArrayList();

        Personnage p1;
        Personnage p2;
        Personnage p3;
        Personnage p4;


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


            Fonctionnalites f1 = new Fonctionnalites("Recherche dans Cahier des Charges", 7, 0, 0, "Recherche");
            Fonctionnalites f2 = new Fonctionnalites("Recherche Objectifs Pédagogiques", 5, 0, 0, "Recherche");
            Fonctionnalites f3 = new Fonctionnalites("Recherche code", 8, 0, 0, "Recherche");
            Fonctionnalites f4 = new Fonctionnalites("MCD", 8, 0, 0, "Conception");
            Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 5, 0, 0, "Conception");
            Fonctionnalites f6 = new Fonctionnalites("Conception3", 3, 0, 0, "Conception");
            Fonctionnalites f7 = new Fonctionnalites("Développement des classes", 10, 0, 0, "Développement");
            Fonctionnalites f8 = new Fonctionnalites("Développement Controleur", 10, 0, 0, "Développement");
            Fonctionnalites f9 = new Fonctionnalites("Moteur de jeu", 10, 0, 0, "Développement");


            listfonctionnalite.Add(f1);
            listfonctionnalite.Add(f2);
            listfonctionnalite.Add(f3);
            listfonctionnalite.Add(f4);
            listfonctionnalite.Add(f5);
            listfonctionnalite.Add(f6);
            listfonctionnalite.Add(f7);
            listfonctionnalite.Add(f8);
            listfonctionnalite.Add(f9);

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);

            frmJeu jeu = new frmJeu(p1, p2, p3, p4);
            jeu.Show();
        }

        public Personnage remplirPersonnage(string prenom, double productivite, int stress, int sociabilite) //créer personnage avec attributs en paramètres
        {
            // TEST A EFFECTUER 
            return new Personnage(prenom, productivite, stress, sociabilite);
        }

        public void arreterJeu()
        {
            Application.Exit();
        }

        public void main()
        {
            arreterJeu();
        }

        public static void nouveauTour()
        {
            calculsAttributs();
        }

        public static void calculsAttributs()
        {
            foreach (Personnage p in listPersonnage)
            {
                p.setFatigue(p.getFatigue() + 10);
                if (p.getFatigue() > 100)
                {
                    p.setFatigue(100);
                }
                int coeffStress = (p.getFatigue() / 100) + 1;     //plus la personnne sera fatigué plus elle sera stressé d'ou le but de ce coeff
                p.setStress(p.getStress() + 1 * coeffStress);
                if (p.getStress() > 100)
                {
                    p.setStress(100);
                }
            }
            //String prenom = "";
            //integer 
            //p1.setPrenom(prenom); //string

            //p1.setFatigue(fatigue); //int
            //p1.setStress(stress); //int
            //p1.setConnaissances(connaissances); //int
            //p1.setSociabilite(sociabilite); //int
            //p1.setProductivite(productivite); //int

        }

        public static void crunch()
        {
            foreach (Personnage p in listPersonnage)
            {
                p.setFatigue(0);
                p.setStress(0);
            }
        }

        public static ArrayList getListeFonctionnalite()
        {
            return listfonctionnalite;
        }

        public static ArrayList getListePersonnage()
        {
            return listPersonnage;
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