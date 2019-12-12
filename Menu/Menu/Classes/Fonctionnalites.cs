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

        //Constructeur de la classe Fonctionnalites
        public Fonctionnalites(string nom, int paNecess, float pourcentNote, int nvConnaissNeces, string type)
        {
            this.nom = nom;
            this.paNecess = paNecess;
            this.pourcentNote = pourcentNote;
            this.nvConnaissNecess = nvConnaissNeces;
            this.paDepense = 0;
            this.type = type;
        }
                       
        public ControleurJeu ControleurJeu
        {
            get => default;
            set
            {
            }
        }

        //Getter et Setter de la classe Fonctionnalites
        public string getNom()
        {
            return this.nom;
        }
        public void setNom(string n)
        {
            this.nom = n;
        }


        public float getPourcentNote()
        {
            return this.pourcentNote;
        }
        public void setPourcentNote(float pN)
        {
            this.pourcentNote = pN;
        }

        public int getPaDepense()
        {
            return this.paDepense;
        }
        public void setPaDepense(int paDepense)
        {
            this.paDepense = paDepense;
        }

        public int getNvConnaissNecces()
        {
            return this.nvConnaissNecess;
        }
        public void setNvConnaissNecces(int cN)
        {
            this.nvConnaissNecess = cN;
        }



        public void setPaNecess(int pA)
        {
            this.paNecess = pA;
        }

        public int getPaNecess()
        {
            return this.paNecess;
        }



        public Boolean getStatus()
        {
            return this.status;
        }
        public void setStatus(Boolean status)
        {
            this.status = status;
        }

        public String getType()
        {
            return this.type;
        }

        /* Verifie si les fonctionnalités de recherche sont terminées pour effectuer les fonctionnalites de conception */
        public bool estRealisable()
        {
            bool res = true;
            if (getType() == "Concevoir")
            {
                foreach (Fonctionnalites f1 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f1.getStatus()) && f1.getType() == "Rechercher")
                    {
                        res = false;
                    }
                }
            }
            if (getType() == "Développer")
            {
                foreach (Fonctionnalites f1 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f1.getStatus()) && f1.getType() == "Concevoir")
                    {
                        res = false;
                    }
                }
            }
            if (getType() == "Recette")
            {
                foreach (Fonctionnalites f1 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f1.getStatus()) && f1.getType() == "Développer")
                    {
                        res = false;
                    }
                }
            }

            if (getType() == "Livraison")
            {
                foreach (Fonctionnalites f1 in ControleurJeu.getListeFonctionnalite())
                {
                    if (!(f1.getStatus()) && f1.getType() == "Recette")
                    {
                        res = false;
                    }
                }
            }
            return res;
        }








    }
}