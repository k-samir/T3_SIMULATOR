using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
                             

        //variable globale
        private static ArrayList listfonctionnalite = new ArrayList();
        private static ArrayList listPersonnage = new ArrayList();
         

        Personnage p1;
        Personnage p2;
        Personnage p3;
        Personnage p4;



        // frmJeu jeu;

        private int compteurTours = 0;

        frmJeu jeu;
        
        public void lancerJeu(frmMenu fm)
        {
            fm.Hide();

            /*
             */
            //creation personnage
            p1 = remplirPersonnage("Valentin", 2.0, 0, 82);
            p2 = remplirPersonnage("Aymeric", 2.0, 20, 80);
            p3 = remplirPersonnage("Mathieu", 3.3, 40, 50);
            p4 = remplirPersonnage("Samir", 4.2, 10, 45);


            /*
            FONCTIONNALITES ( NOM , PANECESS , POURCENTNOTE , NVCONNAIS , PADEPENSE , TYPE) */

        

            Fonctionnalites f1 = new Fonctionnalites("Cahier des charges", 1, 0, 0, "Rechercher");
            Fonctionnalites f2 = new Fonctionnalites("Objectifs pédagogiques", 1, 0, 0, "Rechercher");
            Fonctionnalites f3 = new Fonctionnalites("Code", 1, 0, 0, "Rechercher");
            Fonctionnalites f4 = new Fonctionnalites("MCD", 1, 0, 0, "Concevoir");
            Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 1, 0, 0, "Concevoir");
            Fonctionnalites f6 = new Fonctionnalites("GIT", 1, 0, 0, "Concevoir");
            Fonctionnalites f7 = new Fonctionnalites("Classes", 1, 0, 0, "Développer");
            Fonctionnalites f8 = new Fonctionnalites("Controleur", 1, 0, 0, "Développer");
            Fonctionnalites f9 = new Fonctionnalites("Moteur de jeu", 1, 0, 0, "Développer");


            listfonctionnalite.Add(f1);
            listfonctionnalite.Add(f2);
            listfonctionnalite.Add(f3);
            listfonctionnalite.Add(f4);
            listfonctionnalite.Add(f5);
            listfonctionnalite.Add(f6);
            listfonctionnalite.Add(f7);
            listfonctionnalite.Add(f8);
            listfonctionnalite.Add(f9);
            verifPourcentNote();

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);

            jeu = new frmJeu(p1, p2, p3, p4);
            jeu.Refresh();
            jeu.Show();
        }
        

        public Personnage remplirPersonnage(string prenom, double productivite, int stress, int sociabilite) //créer personnage avec attributs en paramètres
        {
            return new Personnage(prenom, productivite, stress, sociabilite);
        }

        public static void arreterJeu()
        {
            listfonctionnalite.Clear();
            listPersonnage.Clear();

            
            MessageBox.Show("Fin de la partie");
            frmMenu fm = new frmMenu();
            fm.Show();
        }

       


        public void main()
        {
            arreterJeu();
        }

        public static void nouveauTour()
        {
            calculsAttributs();     //actualise les attributs des persos après avoir effectué des taches
        }

        //Modification de tous les attributs
        public static void calculsAttributs()
        {
            foreach (Personnage p in listPersonnage)
            {
                p.setFatigue(p.getFatigue() + 10);
                // PARCOURS DES ACTIONS SELECTIONNEES

                int v = frmJeu.getNbrActionFaite(p);
               
                for (int i =0;i< v; i++)
                {
                    p.setFatigue(p.getFatigue() + 5);
                }
            
                


                if (p.getFatigue() > 100)
                {
                    p.setFatigue(100);

                }
                //stress
                int coeffStress = (p.getFatigue() / 100) + 1;     //plus la personnne sera fatigué plus elle sera stressé d'ou le but de ce coeff
                p.setStress(p.getStress() + 1 * coeffStress);
                if (p.getStress() > 100)
                {

                    p.setStress(100);
                }

            } 

        }

        public static void verifPourcentNote()  //on vérifie l'addition du pourcentage de note de toute les fonctionnalits soit egal a 100, sinon on appelle nouveauPourcentNote
        {
            float pourcentageActuel = 0;  //addition du pourcentage de la note de chaque fonctionnalite
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                pourcentageActuel = pourcentageActuel + f.getPourcentNote();
            }

            if (pourcentageActuel != 100)
            {
                nouveauPourcentNote();
            }

        }
        public static void nouveauPourcentNote()  //On donne le meme pourcentage de la note a chaque fonctionnalite
        {
            float pourcentageNouveau = 0;
            pourcentageNouveau = 100 / listfonctionnalite.Count;
                foreach (Fonctionnalites f in listfonctionnalite)
            {
                f.setPourcentNote(pourcentageNouveau);
            }
        }

        public static String filActualite()     //renvoi toute les info à savoir sur l'actu du projet et des perso 
        {
            string actu = "";
            foreach (Personnage p in listPersonnage)
            {
                if (p.getFatigue() == 100)
                {
                    actu += "\n" + p.getPrenom() + " est trop fatigué\nIl ne peut rien faire tant qu'il\nne se repose pas\n\n";
                }

                if (p.getStress() == 100)
                {
                    actu += "\n" + p.getPrenom() + " est trop stressé\nIl ne peut rien faire\n\n";
                }
                if (p.estDisponible() == false && p.getMalade() == true)
                {
                    actu += "Oh non ! " + p.getPrenom() + " est tombé malade.. \n\n"; 
                }

                if (p.estDisponible() == false && p.getMalade() == false)
                {
                    actu += p.getPrenom() + " se repose, sa fatigue a diminué ! \n\n";
                }
            }
            return actu;
        }

        public static void crunch(Personnage p, List<Fonctionnalites> f1)
        {
            calculsAttributs();

            // Parcours de toutes les fonctionallités 
            foreach (Fonctionnalites f in f1 )
            {
            
                    if (f.getType() == "Rechercher")
                    {
                    ////////////////////////////////////////////////////////////
                        p.faireAction(f);
                        p.recherche();
                    }
                    else
                    {
                        p.faireAction(f);
                    }
               
            }
        }

        public static void tache(Personnage p, List<Fonctionnalites> listeTache)
        {

            string afficher = "";

            for (int i = 0; i < listfonctionnalite.Count; i++)
            {
                Fonctionnalites ajout = (Fonctionnalites)listfonctionnalite[i];
                afficher += "\n" + ajout.getNom();
            }

            if (afficher != "")
            {
                //MessageBox.Show(afficher);
            }


            String texte = "";
            // Parcours de toutes les fonctionalités pour que le perso p les fasse
            foreach (Fonctionnalites f in listeTache)
            {
                p.faireAction(f);

            }

            string fonc = "";

            foreach (Fonctionnalites f in listeTache)
            {
                // Si la fonction est finie on l'enleve de la liste et on affiche qui l'a fini
                if (f.getStatus() == true)
                {
                    frmJeu.setAvancement(f.getPourcentNote() + (float)frmJeu.getAvancement());

                    texte += f.getNom() + " " + f.getPaDepense() + "/" + f.getPaNecess() + " Terminé par " + p.getPrenom() + "\n";
                    listfonctionnalite.Remove(f);


                    fonc = f.getNom();
                }
                else
                {
                    texte += f.getNom() + " " + f.getPaDepense() + "/" + f.getPaNecess() + " " + p.getPrenom() + "\n";
                }
            }

            // SUPPRESION DANS LA LISTE DES FONCTIONNALITES LES FONCTION FINIES
            if (fonc != "")
            {
                for (int i = 0; i < listeTache.Count; i++)
                {
                    if (listeTache[i].getNom() == fonc)
                    {
                        listeTache.RemoveAt(i);

                    }
                }
            }

            // ENVOIE DU TEXTE A AFFICHER DANS LE FRMJEU
            frmJeu.remplir(texte);


        }

        public static void repos()
        {
            foreach (Personnage p in listPersonnage)
            {
               
                p.repos();
            }
        }

  

        public static ArrayList getListeFonctionnalite()
        {
            return listfonctionnalite;
        }

        public static ArrayList getListePersonnage()
        {
            return listPersonnage;
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

        /* -------------------------------------------------------------- */
    }
}