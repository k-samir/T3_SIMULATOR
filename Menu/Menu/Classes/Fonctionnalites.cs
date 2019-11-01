using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Menu
{
    public class Fonctionnalites
    {
        //Attributs d'un personnage
        private string nom;
        private int paNecess;
        private int pourcentNote;
        private int nvConnaissNecess;
        private int paDepense;
        private string type;
        private string action { get; set; }



        //false si complete , true complete
        private Boolean status;

        //Constructeur de la classe Fonctionnalites
        public Fonctionnalites(string nom, int paNecess, int pourcentNote, int nvConnaissNeces, string action)
        {
            this.nom = nom;
            this.paNecess = paNecess;
            this.pourcentNote = pourcentNote;
            this.nvConnaissNecess = nvConnaissNeces;
            this.action = action;
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


        public int getPourcentNote()
        {
            return this.pourcentNote;
        }
        public void setPourcentNote(int pN)
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

        public String getAction()
        {
            return this.action;
        }








    }
}