using System;
using System.Collections.Generic;
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

        // frmJeu jeu;


        private ArrayList liste_fonctionnalites_Recherche = new ArrayList();
        private ArrayList liste_fonctionnalites_Developpement = new ArrayList();
        private ArrayList liste_fonctionnalites_Conception = new ArrayList();

        public void lancerJeu(frmMenu f)
        {
            f.Hide();
            

            //creation personnage
            p1 = remplirPersonnage("Valentin", 2.0, 0, 82);
            p2 = remplirPersonnage("Aymeric", 2.0, 20, 80);
            p3 = remplirPersonnage("Mathieu", 3.3, 40, 50);
            p4 = remplirPersonnage("Samir", 4.2, 10, 45);

            //creation actions
            /*
            Action a1 = remplirActions("Conception");
            Action a2 = remplirActions("Design");
            Action a3 = remplirActions("Code");
            Action a4 = remplirActions("Réunion");
            Action a5 = remplirActions("Repos");
            Action a6 = remplirActions("Git");


            public ArrayList<Actions> actions = new ArrayList<Actions;
            actions.add(a1, a2, a3, a4, a5, a6);
            */
            frmJeu jeu = new frmJeu(p1, p2, p3, p4);
            jeu.Show();
        }
        
        public Personnage remplirPersonnage(string prenom, double productivite, int stress, int sociabilite)
        {
            return new Personnage(prenom, productivite, stress, sociabilite);
        }

        public Action remplirActions(string nom)
        {
            return new Action(nom);
        }
        
        public void arreterJeu()
        {
            throw new System.NotImplementedException();
        }

        public void nouveauTour()
        {
            throw new System.NotImplementedException();
        }
    }
}