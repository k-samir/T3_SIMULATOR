using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Projet
    {
        //Attributs d'un Projet
        private int tempsLimite;
        private string nom;
        private int nbFonctionnalite;

        //Constructeur de la classe Projet
        public Projet(string nom, int tempsLimite)
        {
            this.nom = nom;
            this.tempsLimite = tempsLimite;
        }


        //Accesseurs et Setter pour Projet

        public int getTempsLimite()
        {
            return this.tempsLimite;
        }
        public void setTempsLimite(int tempsLimite)
        {
            this.tempsLimite = tempsLimite;
        }

        public string getNom()
        {
            return this.nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }


        public int getNbFonctionnalite()
        {
            return this.nbFonctionnalite;
        }
        public void setNbFonctionnalite(int nb)
        {
            this.nbFonctionnalite = nb;
        }








    }
}