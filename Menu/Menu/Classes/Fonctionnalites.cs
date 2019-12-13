using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Menu
{
    public class Fonctionnalites
    {
        //Attributs de fonctionnalite
        private string nom;
        private int paNecess;
        private float pourcentNote;
        private int nvConnaissNecess;
        private int paDepense;
        private string type;




        //false si incomplete , true complete

        private Boolean status = false;

        /**
         * Constructeur de la classe Fonctionnalites : possède un nom, un niveau de connaissances nécessaires
         */
        public Fonctionnalites(string nom, int paNecess, float pourcentNote, int nvConnaissNeces, string type)
        {
            this.nom = nom;
            this.paNecess = paNecess;
            this.pourcentNote = pourcentNote;
            this.nvConnaissNecess = nvConnaissNeces;
            this.paDepense = 0;
            this.type = type;
        }


        /**
         * Retourne le nom 
         */
        public string getNom()
        {
            return this.nom;
        }

        /**
         * Retourne le pourcentage de la note
         */
        public float getPourcentNote()
        {
            return this.pourcentNote;
        }
        /**
         * Modifie le pourcentage de la note
         */
        public void setPourcentNote(float pN)
        {
            this.pourcentNote = pN;
        }
        /**
         * Retourne le nombre de points d'actions dépensés
         */
        public int getPaDepense()
        {
            return this.paDepense;
        }
        /**
         * Modifie le nombre de PA dépensés par action 
         */
        public void setPaDepense(int paDepense)
        {
            this.paDepense = paDepense;
        }

        /**
         * Retourne le niveau de connaissances nécessaires
         */
        public int getNvConnaissNecces()
        {
            return this.nvConnaissNecess;
        }
        /**
         * Modifie le niveau de connaissances nécessaires
         */
        public void setNvConnaissNecces(int cN)
        {
            this.nvConnaissNecess = cN;
        }



        /**
         * Modifie le nombre de PA nécessaires
         */
        public void setPaNecess(int pA)
        {
            this.paNecess = pA;
        }

        /**
         * Retourne le nombre de PA nécessaires
         */
        public int getPaNecess()
        {
            return this.paNecess;
        }


        /**
         * Retourne le statut de la fonctionnalité
         */
        public Boolean getStatus()
        {
            return this.status;
        }
        /**
         * Modifie le statut de la fonctionnalité
         */
        public void setStatus(Boolean status)
        {
            this.status = status;
        }

        /**
         * Retourne le type de la fonctionnalité
         */
        public String getType()
        {
            return this.type;
        }

        /**
         * Verifie si les fonctionnalités de recherche sont terminées pour effectuer les fonctionnalites de conception 
         */
        public bool estRealisable()
        {
            bool res = true;
            if (getType() == "Concevoir")
            {
                foreach (Fonctionnalites f1 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f1.getStatus()) && f1.getType() == "Spécification")
                    {
                        res = false;
                    }
                }
            }
            if (getType() == "Développer")
            {
                foreach (Fonctionnalites f2 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f2.getStatus()) && f2.getType() == "Concevoir")
                    {
                        res = false;
                    }
                }
            }
            if (getType() == "Recette")
            {
                foreach (Fonctionnalites f3 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f3.getStatus()) && f3.getType() == "Développer")
                    {
                        res = false;
                    }
                }
            }

            if (getType() == "Livraison")
            {
                foreach (Fonctionnalites f3 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f3.getStatus()) && f3.getType() == "Recette")
                    {
                        res = false;
                    }
                }
            }
            return res;
        }








    }
}