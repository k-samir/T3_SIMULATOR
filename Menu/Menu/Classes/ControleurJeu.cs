using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Text;
using Menu.classePersonnage;
using Menu.Classes;
using Menu.Forms;

namespace Menu
{

    public class ControleurJeu
    {


        //variable globale
        private static ArrayList listfonctionnalite = new ArrayList();
        private static ArrayList listtransmise = new ArrayList();
        private static ArrayList listPersonnage = new ArrayList();
        private static ArrayList listReunion = new ArrayList();

        private static ArrayList listeQualites = new ArrayList();
        private static int nbQualites = 1;
        private static ArrayList listeDefauts = new ArrayList();
        private static int nbDefauts = nbQualites;   //deux variables pour pouvoir mettre plus de qualites que de defauts ou inversement


        //a priori on n'aura qu'un seul point fort et point faible : on met sous forme d'arraylist pour l'évolutivité de l'application, si j'amais on décide d'en metre plus d'un
        private static ArrayList listePointsForts = new ArrayList();
        private static int nbPointsForts = 1;
        private static ArrayList listePointsFaibles = new ArrayList();
        private static int nbPointsFaibles = nbPointsForts;   //deux variables pour pouvoir mettre plus de points forts que de points faibles ou inversement

        //on y stockera les indices de chaque qualites et defauts afin de ne pas avoir de qualités/défauts doublons ou opposés
        private static ArrayList listeRand1 = new ArrayList();
        private static ArrayList listeRand2 = new ArrayList();


        Personnage p1;
        Personnage p2;
        Personnage p3;
        Personnage p4;

        public frmJeu jeu;


        // frmJeu jeu;

        private int compteurTours = 0;

        /**
         * Vide les listes de fonctionnalités, de personnages, de réunion, de points forts et de points faibles. Tous les personnages sont initialisés à null.
         * 
         */
        public void init()
        {
            listfonctionnalite.Clear();
            listtransmise.Clear();
            listPersonnage.Clear();
            listReunion.Clear();
            listeQualites.Clear();
            nbQualites = 1;
            listeDefauts.Clear();
            nbDefauts = nbQualites;
            listePointsForts.Clear();
            nbPointsForts = 1;
            listePointsFaibles.Clear();
            nbPointsFaibles = nbPointsForts;
            listeRand1.Clear();
            listeRand2.Clear();

            p1 = null;
            p2 = null;
            p3 = null;
            p4 = null;
            jeu = null;
            compteurTours = 0;
        }
        /** 
         * remplissage des personnages (affinités et détestés sont à null), initialisation de toutes les fonctionnalités et de 
         * toutes les réunions.Assignation des affinités aléatoirement.
         * Assignation des points forts/points faibles aléatoirement.
         */
        public void lancerJeu(frmMenu fm)
        {
            fm.Hide();

            //creation personnage
            p1 = remplirPersonnage("Valentin", 20, 20, 71, null, null);
            p2 = remplirPersonnage("Aymeric", 20, 45, 61, null, null);
            p3 = remplirPersonnage("Mathieu", 30, 25, 32, null, null);
            p4 = remplirPersonnage("Samir", 40, 10, 23, null, null);
            Personnage persov;
            persov = new Personnage("-", -1, -1, -1, null, null);

            p1.setAffinite(p4);
            p2.setAffinite(p3);
            p3.setAffinite(p2);
            p4.setAffinite(p1);

            p1.setDeteste(p3);
            p2.setDeteste(p4);
            p3.setDeteste(persov);
            p4.setDeteste(p2);

            p1.qualites.Add("Sang-froid");
            p2.qualites.Add("Diplomate");
            p3.qualites.Add("Inépuisable");
            p4.qualites.Add("Inépuisable");

            p1.defauts.Add("Fatigué");
            p2.defauts.Add("Fatigué");
            p3.defauts.Add("Stressé");
            p4.defauts.Add("Asocial");

            p1.pointsForts.Add("Recherche");
            p2.pointsForts.Add("Conception");
            p3.pointsForts.Add("Développement");
            p4.pointsForts.Add("Développement");

            p1.pointsFaibles.Add("Conception");
            p2.pointsFaibles.Add("Développement");
            p3.pointsFaibles.Add("Conception");
            p4.pointsFaibles.Add("Recherche");

            /*
            FONCTIONNALITES ( NOM , PANECESS , POURCENTNOTE , NVCONNAIS , PADEPENSE , TYPE) */
            /* SUR 900 */



            /* Recherche pour obtenir plus de niveau de compétences */
            Fonctionnalites f0 = new Fonctionnalites("Formation", 100000, 0, 0, "Rechercher");    //n'impacte pas l'avancement du projet, elle sert juste à obtenir plus de compétences

            /* Spécification sur 240*/
            Fonctionnalites f1 = new Fonctionnalites("Cahier des charges", 100, 0, 20, "Spécification");
            Fonctionnalites f2 = new Fonctionnalites("Objectifs pédagogiques", 60, 0, 10, "Spécification");
            Fonctionnalites f3 = new Fonctionnalites("Documentation", 40, 0, 20, "Spécification");


            /* Conception sur 120*/
            Fonctionnalites f4 = new Fonctionnalites("MCD", 20, 0, 40, "Concevoir");
            Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 80, 0, 50, "Concevoir");
            Fonctionnalites f6 = new Fonctionnalites("GIT", 20, 0, 20, "Concevoir");

            /* Developpement sur 450*/
            Fonctionnalites f7 = new Fonctionnalites("Classes", 150, 0, 50, "Développer");
            Fonctionnalites f8 = new Fonctionnalites("Controleur", 150, 0, 65, "Développer");
            Fonctionnalites f9 = new Fonctionnalites("Moteur de jeu", 150, 0, 50, "Développer");

            /* Recette */
            Fonctionnalites f11 = new Fonctionnalites("Test du code", 20, 0, 40, "Recette");
            Fonctionnalites f12 = new Fonctionnalites("Faire le point avec le client", 10, 0, 20, "Recette");

            /* Livraison */
            Fonctionnalites f13 = new Fonctionnalites("Livraison", 10, 0, 5, "Livraison");


            //REUNION(THEME DE LA REUNION) et le statut de cette réunion est par défaut à false
            // Reunion r1 = new Reunion("Faire connaissance", "Découvir l'équipe");
            Reunion r2 = new Reunion("Évaluer le potentiel du groupe", "Découvir l'équipe");
            Reunion r3 = new Reunion("Révèle les qualités et les défauts", "Découvir l'équipe");
            Reunion r4 = new Reunion("Analyse des affinités de chacun", "Découvir l'équipe");
            // Reunion r5 = new Reunion("Découvrir le projet", "Examiner le projet");
            Reunion r6 = new Reunion("Analyse de la demande du client et de ses besoins + Définir un cahier des charges", "Examiner le projet");
            Reunion r7 = new Reunion("Mettre en place un système d'organisation", "Examiner le projet");
            Reunion r8 = new Reunion("Mettre en commun le travail et l'avancement de chacun", "Faire le point");


           // listReunion.Add(r1);
            listReunion.Add(r2);
            listReunion.Add(r3);
            listReunion.Add(r4);
          //  listReunion.Add(r5);
            listReunion.Add(r6);
            listReunion.Add(r7);
            listReunion.Add(r8);



            listfonctionnalite.Add(f1);
            listfonctionnalite.Add(f2);
            listfonctionnalite.Add(f3);
            listfonctionnalite.Add(f4);
            listfonctionnalite.Add(f5);
            listfonctionnalite.Add(f6);
            listfonctionnalite.Add(f7);
            listfonctionnalite.Add(f8);
            listfonctionnalite.Add(f9);
            listfonctionnalite.Add(f11);
            listfonctionnalite.Add(f12);
            listfonctionnalite.Add(f13);
            verifPourcentNote();
            listfonctionnalite.Add(f0);
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                listtransmise.Add(f);
            }

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);


            jeu = new frmJeu(p1, p2, p3, p4, 20);

            jeu.Refresh();
            jeu.Show();
            frmReunionPopUp popup = new frmReunionPopUp();
            popup.Show();
        }
        /**
         * Vérifie qu'une tâche est bien terminée, sauf si c'est la tâche formation.
         */
        public static Boolean verifierTacheTermine()
        {
            Boolean res = true;
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                if ((!(f.getStatus())) && f.getNom() == "Formation")
                {
                    res = false;
                }
            }
            return res;
        }
        /**
         * Attribution des qualités, défauts, points forts et points faibles aléatoirement
         */
        public static void attributionQualitesDefautsPointsFortsEtFaibles()
        {
            /* ---------------- qualites, defauts, points forts et faibles (setup listes) ---------------- */


            listeQualites.Add("Sang-froid");        //stress monte moins vite
            listeQualites.Add("Inépuisable");       //fatigue monte moins vite
            listeQualites.Add("Diplomate");         //sociabilité +20 points


            listeDefauts.Add("Stressé");                    //stress monte plus vite
            listeDefauts.Add("Fatigué");                //fatigue monte plus vite
            listeDefauts.Add("Asocial");                //sociabilité -20 points

            listePointsForts.Add("Talentueux");        //ttes les actions *1,5
            listePointsForts.Add("Développement");    //dv *1,5
            listePointsForts.Add("Conception");        //conception *1,5
            listePointsForts.Add("Recherche");        //recherche *1,5

            listePointsFaibles.Add("Fainéant");    //ttes les actions *1,5
            listePointsFaibles.Add("Développement");    //dv * 0,5
            listePointsFaibles.Add("Conception");     //conception * 0,5
            listePointsFaibles.Add("Recherche");     //recherche * 0,5


            /* -------------------------------- */

            /* ----------------  qualites, defauts, points forts et faibles (distribution) ---------------- */

            Random aleatoire = new Random();

            foreach (Personnage p in listPersonnage)
            {
                //qualités
                for (int i = 0; i < nbQualites; i++)
                {
                    int rand1 = aleatoire.Next(listeQualites.Count);   //de 0 à Count-1

                    //verifie nouvelle qualité
                    bool ok = false;
                    while (ok == false)
                    {
                        ok = true;
                        for (int j = 0; j < listeRand1.Count; j++)
                        {
                            if (rand1 == (int)listeRand1[j])
                            {
                                ok = false;
                                rand1 = aleatoire.Next(listeQualites.Count);
                            }
                        }

                    }
                    p.qualites.Add(listeQualites[rand1]);
                    listeRand1.Add(rand1);

                }
                //défauts
                for (int i = 0; i < nbDefauts; i++)
                {
                    int rand2 = aleatoire.Next(listeDefauts.Count);   //de 0 à Count-1
                    bool ok = false;

                    //dans cette boucle on vérifie que le défaut est nouveau pour ce personnage et qu'il est compatible avec les qualites de ce personnage (même argument (rand) => incompatibles)
                    while (ok == false)
                    {
                        ok = true;
                        //verifie compatible avec qualites
                        for (int j = 0; j < nbQualites; j++)
                        {
                            //MessageBox.Show(listeRand1[j].ToString());
                            if (rand2 == (int)listeRand1[j])
                            {
                                ok = false;
                                rand2 = aleatoire.Next(listeDefauts.Count);
                            }
                        }
                        //verifie nouveau defaut
                        for (int j = 0; j < listeRand2.Count; j++)
                        {
                            if (rand2 == (int)listeRand2[j])
                            {
                                ok = false;
                                rand2 = aleatoire.Next(listeDefauts.Count);
                            }
                        }
                    }
                    p.defauts.Add(listeDefauts[rand2]);
                    listeRand2.Add(rand2);
                }

                listeRand1.Clear();
                listeRand2.Clear();

                //points forts
                for (int i = 0; i < nbPointsForts; i++)
                {
                    int rand1 = aleatoire.Next(listePointsForts.Count);   //de 0 à Count-1

                    //verifie nouveau point fort
                    bool ok = false;
                    while (ok == false)
                    {
                        ok = true;
                        for (int j = 0; j < listeRand1.Count; j++)
                        {
                            if (rand1 == (int)listeRand1[j])
                            {
                                ok = false;
                                rand1 = aleatoire.Next(listePointsForts.Count);
                            }
                        }
                    }
                    p.pointsForts.Add(listePointsForts[rand1]);
                    listeRand1.Add(rand1);


                }

                //points faibles
                for (int i = 0; i < nbPointsFaibles; i++)
                {
                    int rand2 = aleatoire.Next(listePointsFaibles.Count);   //de 0 à Count-1

                    bool ok = false;
                    //dans cette boucle on vérifie que le point faible est nouveau pour ce personnage et qu'il est compatible avec les points forts de ce personnage (même argument (rand) => incompatibles)
                    while (ok == false)
                    {
                        ok = true;
                        //verifie compatible avec pointsForts
                        for (int j = 0; j < nbPointsForts; j++)
                        {
                            if (rand2 == (int)listeRand1[j])
                            {
                                ok = false;
                                rand2 = aleatoire.Next(listePointsFaibles.Count);
                            }
                        }
                        //verifie nouveau pointFaible
                        for (int j = 0; j < listeRand2.Count; j++)
                        {
                            if (rand2 == (int)listeRand2[j])
                            {
                                ok = false;
                                rand2 = aleatoire.Next(listePointsFaibles.Count);
                            }
                        }
                    }
                    p.pointsFaibles.Add(listePointsFaibles[rand2]);
                    listeRand2.Add(rand2);
                    //MessageBox.Show((string)p.pointsFaibles[i]);
                }

            }
        }

        /**
         * Mode hard : pas d'aide et pas de popup pour guider le joueur
         */
        public void lancerJeu2(frmMenu fm)
        {
            fm.Hide();


            Random aleatoire = new Random();

            ArrayList prenoms = new ArrayList();
            prenoms.Add("Pierre");
            prenoms.Add("Max");
            prenoms.Add("André");
            prenoms.Add("Alexandre");
            prenoms.Add("Gaël");
            prenoms.Add("Gilles");
            prenoms.Add("Georges");
            prenoms.Add("Viviane");
            prenoms.Add("Clémentine");
            prenoms.Add("Alice");
            prenoms.Add("Mathilde");
            prenoms.Add("Sophie");


            //creation personnage
            int randomise = aleatoire.Next(prenoms.Count);
            string name = (string)prenoms[randomise];
            randomise = aleatoire.Next(51);
            int connaissance = randomise;
            randomise = aleatoire.Next(51);
            int stress = randomise;
            randomise = aleatoire.Next(101);
            int sociabilite = randomise;
            p1 = remplirPersonnage(name, connaissance, stress, sociabilite, null, null);

            randomise = aleatoire.Next(prenoms.Count);
            name = (string)prenoms[randomise];
            randomise = aleatoire.Next(51);
            connaissance = randomise;
            randomise = aleatoire.Next(51);
            stress = randomise;
            randomise = aleatoire.Next(101);
            sociabilite = randomise;
            p2 = remplirPersonnage(name, connaissance, stress, sociabilite, null, null);

            randomise = aleatoire.Next(prenoms.Count);
            name = (string)prenoms[randomise];
            randomise = aleatoire.Next(51);
            connaissance = randomise;
            randomise = aleatoire.Next(51);
            stress = randomise;
            randomise = aleatoire.Next(101);
            sociabilite = randomise;
            p3 = remplirPersonnage(name, connaissance, stress, sociabilite, null, null);

            randomise = aleatoire.Next(prenoms.Count);
            name = (string)prenoms[randomise];
            randomise = aleatoire.Next(51);
            connaissance = randomise;
            randomise = aleatoire.Next(51);
            stress = randomise;
            randomise = aleatoire.Next(101);
            sociabilite = randomise;
            p4 = remplirPersonnage(name, connaissance, stress, sociabilite, null, null);



            /*
            FONCTIONNALITES ( NOM , PANECESS , POURCENTNOTE , NVCONNAIS , PADEPENSE , TYPE) */

            /* SUR 900 */



            /* Recherche pour obtenir plus de niveau de compétences */
            Fonctionnalites f0 = new Fonctionnalites("Formation", 100000, 0, 0, "Rechercher");    //n'impacte pas l'avancement du projet, elle sert juste à obtenir plus de compétences

            /* Spécification sur 240*/
            Fonctionnalites f1 = new Fonctionnalites("Cahier des charges", 100, 0, 20, "Spécification");
            Fonctionnalites f2 = new Fonctionnalites("Objectifs pédagogiques", 60, 0, 10, "Spécification");
            Fonctionnalites f3 = new Fonctionnalites("Documentation", 40, 0, 20, "Spécification");


            /* Conception sur 120*/
            Fonctionnalites f4 = new Fonctionnalites("MCD", 20, 0, 40, "Concevoir");
            Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 80, 0, 50, "Concevoir");
            Fonctionnalites f6 = new Fonctionnalites("GIT", 20, 0, 20, "Concevoir");

            /* Developpement sur 450*/
            Fonctionnalites f7 = new Fonctionnalites("Classes", 150, 0, 50, "Développer");
            Fonctionnalites f8 = new Fonctionnalites("Controleur", 150, 0, 65, "Développer");
            Fonctionnalites f9 = new Fonctionnalites("Moteur de jeu", 150, 0, 50, "Développer");

            /* Recette */
            Fonctionnalites f11 = new Fonctionnalites("Test du code", 20, 0, 40, "Recette");
            Fonctionnalites f12 = new Fonctionnalites("Faire le point avec le client", 10, 0, 20, "Recette");

            /* Livraison */
            Fonctionnalites f13 = new Fonctionnalites("Livraison", 10, 0, 5, "Livraison");


            //REUNION(THEME DE LA REUNION) et le statut de cette réunion est par défaut à false
          //  Reunion r1 = new Reunion("Faire connaissance", "Découvir l'équipe");
            Reunion r2 = new Reunion("Évaluer le potentiel du groupe", "Découvir l'équipe");
            Reunion r3 = new Reunion("Révèle les qualités et les défauts", "Découvir l'équipe");
            Reunion r4 = new Reunion("Analyse des affinités de chacun", "Découvir l'équipe");
         //   Reunion r5 = new Reunion("Découvrir le projet", "Examiner le projet");
            Reunion r6 = new Reunion("Analyse de la demande du client et de ses besoins + Définir un cahier des charges", "Examiner le projet");
            Reunion r7 = new Reunion("Mettre en place un système d'organisation", "Examiner le projet");
            Reunion r8 = new Reunion("Mettre en commun le travail et l'avancement de chacun", "Faire le point");


        //    listReunion.Add(r1);
            listReunion.Add(r2);
            listReunion.Add(r3);
            listReunion.Add(r4);
          //  listReunion.Add(r5);
            listReunion.Add(r6);
            listReunion.Add(r7);
            listReunion.Add(r8);


            listfonctionnalite.Add(f0);
            listfonctionnalite.Add(f1);
            listfonctionnalite.Add(f2);
            listfonctionnalite.Add(f3);
            listfonctionnalite.Add(f4);
            listfonctionnalite.Add(f5);
            listfonctionnalite.Add(f6);
            listfonctionnalite.Add(f7);
            listfonctionnalite.Add(f8);
            listfonctionnalite.Add(f9);
            listfonctionnalite.Add(f11);
            listfonctionnalite.Add(f12);
            listfonctionnalite.Add(f13);
            verifPourcentNote();
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                listtransmise.Add(f);
            }

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);


            Personnage persov;
            persov = new Personnage("-", -1, -1, -1, null, null);

            int besoinAffinite = 120;
            int besoinDeteste = 80;

            //les relations sont determinees a 50% par la chance et 50% la sociabilite
            foreach (Personnage p in listPersonnage)
            {
                Personnage meilleurAffinite = persov;
                Personnage pireDeteste = persov;

                foreach (Personnage p1 in listPersonnage)
                {
                    if (p1 != p)
                    {
                        int rand = aleatoire.Next(101);
                        if (p1.getSociabilite() + p.getSociabilite() + rand >= besoinAffinite)
                        {
                            meilleurAffinite = p1;

                        }
                        if (p1.getSociabilite() + p.getSociabilite() - rand <= besoinDeteste && p1 != meilleurAffinite && p1.getAffinite() != p)
                        {
                            pireDeteste = p1;
                        }

                    }

                }

                p.setAffinite(meilleurAffinite);
                p.setDeteste(pireDeteste);
            }

            //si affinite avec quelqu'un qui nous deteste : on enleve le deteste
            foreach (Personnage p in listPersonnage)
            {
                if ((p.getAffinite()).getDeteste() == p)
                {

                    (p.getAffinite()).setDeteste(persov);
                }

            }


            attributionQualitesDefautsPointsFortsEtFaibles();

            jeu = new frmJeu(p1, p2, p3, p4, 35);

            jeu.Refresh();
            jeu.Show();
            frmReunionPopUp popup = new frmReunionPopUp();
            popup.Show();
        }



        /**
         * Rempli les personnages avec toutes les valeurs définies, aucune n'est nulle
         */
        public Personnage remplirPersonnage(string prenom, int connaissance, int stress, int sociabilite, Personnage affinite, Personnage deteste) //créer personnage avec attributs en paramètres
        {
            return new Personnage(prenom, connaissance, stress, sociabilite, affinite, deteste);
        }
        /**
         * Retourne la liste des réunions
         */
        public static ArrayList getListeReunion()
        {
            return listReunion;
        }
        /**
         * Change le statut d'une réunion
         */
        public static void changerStatutReunion(String themeReunion)        //parcourt la liste des réunions pour changer son statut en true et pour dire que ce thème a été abordée
        {
            foreach (Reunion r in listReunion)
            {
                if (r.getThemeReunion() == themeReunion)
                {
                    //MessageBox.Show("Thème réunion : " + r.getThemeReunion()); fonctionne
                    r.setStatut(true);
                }
            }
        }
        /**
         * Arrête le jeu et affiche les tâches non codées
         */
        public static void arreterJeu(String s)
        {



            //crée une liste stockant tous les taches non effectué
            ArrayList tacheNonCodé = new ArrayList();
            foreach (Fonctionnalites f in getListeFonctionnalite())
            {
                if (!(f.getStatus()))
                {
                    tacheNonCodé.Add(f);
                }
            }


            Forms.FrmEnd e = new Forms.FrmEnd(s, tacheNonCodé, frmJeu.getAvancement(), 0);
            e.Show();



        }

        public static void arreterJeu(String s, int a)
        {



            //crée une liste stockant tous les taches non effectué
            ArrayList tacheNonCodé = new ArrayList();
            foreach (Fonctionnalites f in getListeFonctionnalite())
            {
                if (!(f.getStatus()))
                {
                    tacheNonCodé.Add(f);
                }
            }


            Forms.FrmEnd e = new Forms.FrmEnd(s, tacheNonCodé, frmJeu.getAvancement(), a);
            e.Show();



        }


        /**
         * Calcule les attributs et passe au tour suivant
         */
        public static void nouveauTour()
        {
            calculsAttributs();     //actualise les attributs des persos après avoir effectué des taches

            Random aleatoire = new Random();
            int rnd = aleatoire.Next(5);
            if (rnd == 0)
            {
                Fonctionnalites f10 = new Fonctionnalites("Nouvelle demande client", 10, 0, 0, "Développer");
                listfonctionnalite.Add(f10);
                listtransmise.Add(f10);
            }
        }

        /**
         * Modification de tous les attributs des personnages en fonction de leur évolution
         */
        public static void calculsAttributs()
        {
            foreach (Personnage p in listPersonnage)
            {

                // PARCOURS DES ACTIONS SELECTIONNEES

                int v = p.getnbrActionFaite();
                //MessageBox.Show(p.getPrenom() + " : " + p.getnbrActionFaite().ToString());




                for (int i = 0; i < v; i++)
                {
                    p.setFatigue(p.getFatigue() + 10);
                }
                p.setnbrActionFaite(0);



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
        /**
         * Vérification de la cohérence du pourcentage de la note attribué à chaque tâche
         */
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
        /**
         * Si les pourcentages des notes des tâches ne sont pas cohérentes, elles sont à nouveau calculées.
         */
        public static void nouveauPourcentNote()  //On donne le meme pourcentage de la note a chaque fonctionnalite
        {
            float pourcentageNouveau = 0;
            pourcentageNouveau = 100 / listfonctionnalite.Count;
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                f.setPourcentNote(pourcentageNouveau);
            }
        }



        /**
         * Fait faire les tâches aux personnages
         */
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


            /*****************   A FAIRE ****************/



            foreach (Fonctionnalites f in listeTache)
            {

                // MessageBox.Show("NORMAL");
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
                    //listfonctionnalite.Remove(f);
                    listtransmise.Remove(f);


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




        /**
        * Retourne la liste des fonctionnalités
        */
        public static ArrayList getListeFonctionnalite()
        {
            return listfonctionnalite;
        }

        /**
         * Retourne la liste des personnages
         */
        public static ArrayList getListePersonnage()
        {
            return listPersonnage;
        }
    }
}