using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menu.classePersonnage
{
    public class Personnage
    {
        //Attributs d'un personnage 
        private int id;
        private string prenom;
        private int fatigue = 0;
        private double productivite;
        private int stress;
        private int connaissances = 0;
        private int sociabilite;
        private int pA;


        //Constructeur de la classe personnage
        public Personnage(string prenom, double productivite, int stress, int sociabilite)
        {
            this.prenom = prenom;
            this.productivite = productivite;
            this.stress = stress;
            this.sociabilite = sociabilite;
        }

        /* ------------------------------------------- actions ---------------------------- */
        public void realisation(Menu.Fonctionnalites fct, int nbPa)
        {
            if (fct.getPaNecess() > fct.getPaDepense() + nbPa)
            {
                fct.setPaDepense(fct.getPaDepense() + nbPa);
            }
            else
            {
                fct.setPaDepense(fct.getPaNecess());
            }
        }

        public void recherche()
        {
            this.setConnaissances(this.getConnaissances() + 10);
        }


        public void repos()
        {

            this.setStress(this.getStress() - 10);
            this.setFatigue(this.getFatigue() - 10);
        }


        /* ---------------------------------------------------------------------- */

        /* ------Accesseurs (pour les set, les valeurs acceptées sont comprises entre 0 et 100)  ------------------ */
        public string getPrenom()
        {
            return this.prenom;
        }
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public int getId()
        {
            return this.id;
        }


        public int getPA()
        {
            return this.pA;
        }
        public void setPA(int pA)
        {
            this.pA = pA;
        }


        public int getFatigue()
        {
            return this.fatigue;
        }
        public void setFatigue(int fatigue)
        {
            if (fatigue >= 0 && fatigue <= 100)
            {
                this.fatigue = fatigue;
            }
            else if (fatigue < 0)
            {
                this.fatigue = 0;
            }
            else
            {
                this.fatigue = 100;
            }

        }
        public int getStress()
        {
            return this.stress;
        }
        public void setStress(int stress)
        {
            if (stress >= 0 && stress <= 100)
            {
                this.stress = stress;
            }
            else if (stress < 0)
            {
                this.stress = 0;
            }
            else
            {
                this.stress = 100;
            }
        }

        public int getConnaissances()
        {
            return this.connaissances;
        }
        public void setConnaissances(int connaissances)
        {
            if (connaissances >= 0 && connaissances <= 100)
            {
                this.connaissances = connaissances;
            }
            else if (connaissances < 0)
            {
                this.connaissances = 0;
            }
            else
            {
                this.connaissances = 100;
            }
        }

        public int getSociabilite()
        {
            return this.sociabilite;
        }
        public void setSociabilite(int sociabilite)
        {
            if (sociabilite >= 0 && sociabilite <= 100)
            {
                this.sociabilite = sociabilite;
            }
            else if (sociabilite < 0)
            {
                this.sociabilite = 0;
            }
            else
            {
                this.sociabilite = 100;
            }
        }

        public double getProductivite()
        {
            return this.productivite;
        }
        public void setProductivite(double productivite)
        {
            this.productivite = productivite;
        }

        public void faireAction(Fonctionnalites action){    //tache que le personnage va effectuer
            if(action.getPaDepense() >= action.getPaNecess())
            {
                action.setStatus(true); //modif du status pour dire que la tache est terminée
            }
            
            if(action.getStatus() == false)
            {
                action.setPaDepense(action.getPaDepense() + 1);
                if (action.getPaDepense() >= action.getPaNecess())
                {
                    action.setStatus(true); //modif du status pour dire que la tache est terminée
                }
            }
            ControleurJeu.mettreAJourListeTache(action);

        }



    }

}