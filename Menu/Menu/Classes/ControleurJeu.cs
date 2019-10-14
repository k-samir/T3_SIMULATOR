using System;
using System.Collections.Generic;
using System.Collections.ArrayList;
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

        public Fonctionnalites Fonctionnalites
        {
            get => default;
            set
            {
                ArrayList listFonctionnalite = new ArrayList();
            }
        }

        Projet proj1;

        //variable globale
        Personnage p1;
        Personnage p2;
        Personnage p3;
        Personnage p4;


        //Fonctionnalite
        Fonctionnalite f1 = new Fonctionnalite();
        Fonctionnalite f2 = new Fonctionnalite();
        Fonctionnalite f3 = new Fonctionnalite();
        Fonctionnalite f4 = new Fonctionnalite();
        Fonctionnalite f5 = new Fonctionnalite();
        Fonctionnalite f6 = new Fonctionnalite();
        Fonctionnalite f7 = new Fonctionnalite();

        // frmJeu jeu;

        private int compteurTours = 0;
        private bool gameON = true;

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

        public Fonctionnalites remplirFonctionnalites(string nom, int paNecess, int pourcentNote, int nvConnaissNecces) //créer fonctionnalites avec attributs en paramètres
        {
            return new Fonctionnalites(nom, paNecess, pourcentNote, nvConnaissNecess);
        }

        public Projet remplirProjet(string prenom, double productivite, int stress, int sociabilite) //créer projet avec attributs en paramètres
        {
            return new Personnage(prenom, productivite, stress, sociabilite);
        }


        public void arreterJeu()
        {
            throw new System.NotImplementedException();
        }


        public void main()
        {
            //lancerJeu(get ?);
            while (compteurTours < proj1.getTempsLimite() && gameON == true){
                // 12 => nb de tours associés au projet , gameON : bouton quitter set false

                /* une while par attente de l'utilisateur ?
                while (done == 0)
                {

                    
                }
                */

                compteurTours = 13; //pour pas bloquer les tests


                compteurTours += 1;
            }
            arreterJeu();
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