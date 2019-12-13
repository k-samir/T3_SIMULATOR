using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Text;
using Menu.Forms;

namespace Menu.classePersonnage
{
   
    public class Personnage
    {
        //Attributs d'un personnage 
        //private int id;
        private string prenom;
        private int fatigue = 0;
      //  private double productivite;
     
        private int stress;
        private int connaissances = 0;
        private int sociabilite;
        private bool malade = false;
        private bool estDispo = true;
        private Personnage affinite;
        private Personnage deteste;

        public int nbrActionFaite = 0;

        public ArrayList qualites = new ArrayList();
        public ArrayList defauts = new ArrayList();

        public ArrayList pointsForts = new ArrayList();
        public ArrayList pointsFaibles = new ArrayList();

        public List<Fonctionnalites> tacheTour = new List<Fonctionnalites>();


        /**
         * Constructeur de personnage, possédant un prénom, un niveau de compétences, du stress, de la sociabilité,
         * des affinités..
         */
        public Personnage(string prenom, int connaissance, int stress, int sociabilite, Personnage affinite, Personnage deteste)
        {
            this.prenom = prenom;
            this.connaissances = connaissance;
            this.stress = stress;
            this.sociabilite = sociabilite;
            this.affinite = affinite;
            this.deteste = deteste;

        }
        /**
         * Modifie le personnage détesté par l'instance actuelle
         */
        public void setDeteste(Personnage p)
        {
            this.deteste = p;
        }

        /**
         * Retourne la liste des fonctionnalités effectuées par l'instance au tour actuel
         */
        public List<Fonctionnalites> getTacheTour()
        {
            return tacheTour;
        }
        /**
         * Met le nombre de tache effectué par l'instance à 1
         */
        public void setTacheTour(List<Fonctionnalites> l)
        {
            tacheTour = l;
        }
        /**
         * Vide la liste de tâches effectuées ce tour
         */
        public void viderTacheTour()
        {
            tacheTour.Clear();
        }
        /**
         * Retourne le personnage détesté par l'instance
         */
        public Personnage getDeteste()
        {
            return this.deteste;
        }

        /**
         * Retourne le nombre d'action faites par l'instance
         */
        public int getnbrActionFaite()
        {
            return nbrActionFaite;
        }
        /**
         * Modifie le nombre d'action faites par l'instance
         */
        public void setnbrActionFaite(int a)
        {
            nbrActionFaite = a;
        }

        /**
         * Modifie l'attribut malade de l'instance
         * true : le personnage est malade, false sinon.
         */
        public void setMalade(bool malade)
        {
            this.malade = malade;
        }
        /**
         * Retourne true si l'instance est malade
         */
        public bool getMalade()
        {
            return this.malade;
        }
        /**
         * Modifie le personnage avec qui l'instance s'entend bien
         */
        public void setAffinite(Personnage p)
        {
            this.affinite = p;


        }
        /**
         * retourne le personnage avec qui l'instance s'entend bien
         */
        public Personnage getAffinite()
        {
            return this.affinite;
        }
        /**
         * Retourne si l'instance est disponible ou non
         */
        public bool estDisponible()
        {
            if (this.malade == false && this.estDispo == true)
            {
                return true;
            }
            else
            {
                this.estDispo = false;
                return false;
            }


        }
        /**
         * Modifie la valeur de l'attribut 'disponible' de l'instance
         */
        public void setDisponible(bool res)
        {
            this.estDispo = res;
        }


        /* ------Accesseurs (pour les set, les valeurs acceptées sont comprises entre 0 et 100)  ------------------ */
        /**
         * Retourne le prénom de l'instance
         */
        public string getPrenom()
        {
            return this.prenom;
        }
        



        /**
         * Retourne le niveau de fatigue de l'instance
         */
        public int getFatigue()
        {
            return this.fatigue;
        }
        /**
         * Modifie la fatigue du personnage (ne dépasse pas 100)
         */
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
        /**
         * Retourne le stress du personnage
         */
        public int getStress()
        {
            return this.stress;
        }
        /**
         * Modifie le niveau de stress 
         */
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
        /**
         * Retourne le niveau de connaissances
         */
        public int getConnaissances()
        {
            return this.connaissances;
        }
        /**
         * Modifie le niveau de connaissances
         */
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
        /**
         * Retourne le niveau de sociabilité
         */
        public int getSociabilite()
        {
            return this.sociabilite;
        }
      
        /**
         * Retourne la qualité du personnage
         */
        public ArrayList getQualite()
        {
            return this.qualites;
        }

        /**
         * Retourne le défaut du personnage
         */
        public ArrayList getDefaut()
        {
            return this.defauts;
        }

        /**
         * Retourne le point fort du personnage
         */
        public ArrayList getPointFort()
        {
            return this.pointsForts;
        }

        /**
         * Retourne le point faible du personnage
         */
        public ArrayList getPointFaible()
        {
            return this.pointsFaibles;
        }

        /**
         * Fais faire une action au personnage
         */
        public void faireAction(Fonctionnalites action)
        {    //tache que le personnage va effectuer
            /*************************************************************************************/
            int ajoutPA = 10;

            if (action.getNom() == "Formation")  //donne des compétences aux personnages qui font de la recherche
            {
                this.setConnaissances(this.getConnaissances() + 10);
                if (this.getConnaissances() > 100)
                {
                    this.setConnaissances(100);
                }
            }

            if (action.getPaDepense() >= action.getPaNecess() && action.getStatus() == false)
            {
                action.setStatus(true); //modif du status pour dire que la tache est terminée
            }

            
            if (this.connaissances < action.getNvConnaissNecces())
            {
                int diff = action.getNvConnaissNecces() - this.connaissances;
                ajoutPA -= (diff / 2);           //-10% tous les 2pts

            }
            else if (this.connaissances >= action.getNvConnaissNecces())
            {
                int diff = this.connaissances - action.getNvConnaissNecces();
                ajoutPA += (diff / 4);                          //+10% tous les 4pts
            }

            if (action.getStatus() == false && action.estRealisable())
            {


                if (this.getDeteste().getPrenom() != "-")
                {
                    for (int i = 0; i < this.getDeteste().getTacheTour().Count; i++)
                    {
                        if (this.getDeteste().getTacheTour()[i] == action)
                        {
                            ajoutPA -= ajoutPA / 2;
                        }
                    }
                }
                if (this.getAffinite().getPrenom() != "-")
                {

                    for (int i = 0; i < this.getAffinite().getTacheTour().Count; i++)

                    {

                        if (this.getAffinite().getTacheTour()[i] == action)
                        {
                            //MessageBox.Show("MULTIPLICATION PAR 2 car" + this.prenom + "travail avec" + this.getAffinite().getPrenom());
                            ajoutPA += ajoutPA / 2;
                        }
                    }
                }


                for (int i = 0; i < pointsForts.Count; i++)
                {
                    if (pointsForts[i].ToString() == "Talentueux")
                    {
                        ajoutPA += (ajoutPA / 2); //+50%
                    }
                    if (pointsForts[i].ToString() == "Développement")
                    {
                        if (action.getType() == "Développer")
                        {
                            ajoutPA += (ajoutPA / 2); //+50%
                        }
                    }
                    if (pointsForts[i].ToString() == "Conception")
                    {
                        if (action.getType() == "Concevoir")
                        {
                            ajoutPA += (ajoutPA / 2); //+50%
                        }
                    }
                    if (pointsForts[i].ToString() == "Recherche")
                    {
                        if (action.getType() == "Spécification")
                        {
                            ajoutPA += (ajoutPA / 2); //+50%
                        }
                    }
                }
                for (int i = 0; i < pointsFaibles.Count; i++)
                {
                    if (pointsFaibles[i].ToString() == "Faiénant")
                    {
                        ajoutPA -= (ajoutPA / 2); //-50%
                    }
                    if (pointsFaibles[i].ToString() == "Développement")
                    {
                        if (action.getType() == "Développer")
                        {
                            ajoutPA -= (ajoutPA / 2); //-50%
                        }
                    }
                    if (pointsFaibles[i].ToString() == "Conception")
                    {
                        if (action.getType() == "Concevoir")
                        {
                            ajoutPA -= (ajoutPA / 2); //-50%
                        }
                    }
                    if (pointsFaibles[i].ToString() == "Recherche")
                    {
                        if (action.getType() == "Spécification")
                        {
                            ajoutPA -= (ajoutPA / 2); //-50%
                        }
                    }
                }

                if (this.connaissances + 20 < action.getNvConnaissNecces())
                {
                    ajoutPA = 0;
                }

                foreach (Fonctionnalites f in ControleurJeu.getListeFonctionnalite())
                {
                    //int index = 0;
                    if (f.getNom() == action.getNom())
                    {
                        f.setPaDepense(action.getPaDepense() + ajoutPA);  //permet de modifier les pa dépensés
                    }
                }


                if (action.getPaDepense() >= action.getPaNecess())
                {
                    action.setStatus(true); //modif du status pour dire que la tache est terminée
                }
            }
        }
    }
}

    





            

