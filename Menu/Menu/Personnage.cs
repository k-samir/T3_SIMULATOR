using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnage
{
    public class Personnage
    {
        //Attributs d'un personnage 
        private int id;
        private string prenom;
        private int fatigue = 0;

        private int productivite;
        private int stress;
        private int connaissances = 0;
        private int sociabilite;
        private int pA;
               

        //Constructeur de la classe personnage
        public Personnage(string prenom, int productivite, int stress, int sociabilite)
        {
            this.prenom = prenom;
            this.productivite = productivite;
            this.stress = stress;
            this.sociabilite = sociabilite;
        }

        //Accesseurs (pour les set, les valeurs acceptées sont comprises entre 0 et 100)
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
    }

}