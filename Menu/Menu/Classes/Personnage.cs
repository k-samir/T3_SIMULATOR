using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Text;
using Menu.Forms;

namespace Menu.classePersonnage
{
    /*
     * 
     * \brief Exemple de Commentaire
     * 
     */
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


        //Constructeur de la classe personnage
        /*
         * Constructeur Personnage
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
        public void setDeteste(Personnage p)
        {
            this.deteste = p;
        }

        public List<Fonctionnalites> getTacheTour()
        {
            return tacheTour;
        }
        public void setTacheTour(List<Fonctionnalites> l)
        {
            tacheTour = l;
        }
        public void viderTacheTour()
        {
            tacheTour.Clear();
        }

        public Personnage getDeteste()
        {
            return this.deteste;
        }

        public int getnbrActionFaite()
        {
            return nbrActionFaite;
        }

        public void setnbrActionFaite(int a)
        {
            nbrActionFaite = a;
        }

        public void setMalade(bool malade)
        {
            this.malade = malade;
        }

        public bool getMalade()
        {
            return this.malade;
        }

        public void setAffinite(Personnage p)
        {
            this.affinite = p;


        }

        public Personnage getAffinite()
        {
            return this.affinite;
        }
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

        public void setDisponible(bool res)
        {
            this.estDispo = res;
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

        /* ------------------------------------------- personnage particularité  ---------------------------- */



        /* ----------------------------------------------------------------------- */



        /* ------Accesseurs (pour les set, les valeurs acceptées sont comprises entre 0 et 100)  ------------------ */
        public string getPrenom()
        {
            return this.prenom;
        }
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
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

       

        public ArrayList getQualite()
        {
            return this.qualites;
        }

        public ArrayList getDefaut()
        {
            return this.defauts;
        }

        public ArrayList getPointFort()
        {
            return this.pointsForts;
        }

        public ArrayList getPointFaible()
        {
            return this.pointsFaibles;
        }

        public void faireAction(Fonctionnalites action)
        {    //tache que le personnage va effectuer
            /*************************************************************************************/
            int ajoutPA = 10;

            if(action.getNom() == "Formation")  //donne des compétences aux personnages qui font de la recherche
            {
                this.setConnaissances(this.getConnaissances() + 10);
                if(this.getConnaissances() > 100)
                {
                    this.setConnaissances(100);
                }
            }


            if (action.getPaDepense() >= action.getPaNecess() && action.getStatus() == false)
            {
                action.setStatus(true); //modif du status pour dire que la tache est terminée
            }

            if (action.getStatus() == false && action.estRealisable() && getConnaissances() > action.getNvConnaissNecces())
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
                else if (this.connaissances < action.getNvConnaissNecces())
                {
                    int diff = action.getNvConnaissNecces() - this.connaissances;
                    ajoutPA = ajoutPA * (1 - (diff * 5 / 100));  //pour chaque points de connaissance manquant on perd 5% d'efficacite
                }
                else if (this.connaissances > action.getNvConnaissNecces())
                {
                    int diff = action.getNvConnaissNecces() - this.connaissances;
                    ajoutPA = ajoutPA * 1 + ((diff * 5 / 100) / 2);  //pour chaque points de connaissance supplementaire on gagne 2,5% d'efficacite
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

    





            

