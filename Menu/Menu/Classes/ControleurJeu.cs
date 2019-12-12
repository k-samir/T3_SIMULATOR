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
        public void lancerJeu(frmMenu fm)
        {
            fm.Hide();

            /*
             */
           
            /* ---------------- qualites et defauts ---------------- */
            Random aleatoire = new Random();
            
            //creation personnage
            p1 = remplirPersonnage("Valentin", 20, 0, 82, null,null);
            p2 = remplirPersonnage("Aymeric", 20, 20, 80, null,null);
            p3 = remplirPersonnage("Mathieu", 30, 40, 50, null,null);
            p4 = remplirPersonnage("Samir", 40, 10, 45, null,null);



            /*
            FONCTIONNALITES ( NOM , PANECESS , POURCENTNOTE , NVCONNAIS , PADEPENSE , TYPE) */

            /* SUR 900 */

            /* Recherche sur 240*/
            Fonctionnalites f1 = new Fonctionnalites("Cahier des charges", 100, 0, 0, "Rechercher");
            Fonctionnalites f2 = new Fonctionnalites("Objectifs pédagogiques", 60, 0, 0, "Rechercher");
            Fonctionnalites f3 = new Fonctionnalites("Documentation", 40, 0, 0, "Rechercher");


            /* Conception sur 120*/
            Fonctionnalites f4 = new Fonctionnalites("MCD", 20, 0, 0, "Concevoir");
            Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 80, 0, 0, "Concevoir");
            Fonctionnalites f6 = new Fonctionnalites("GIT", 20, 0, 0, "Concevoir");

            /* Developpement sur 450*/
            Fonctionnalites f7 = new Fonctionnalites("Classes", 150, 0, 0, "Développer");
            Fonctionnalites f8 = new Fonctionnalites("Controleur", 150, 0, 0, "Développer");
            Fonctionnalites f9 = new Fonctionnalites("Moteur de jeu", 150, 0, 0, "Développer");

            /* Recette */
            Fonctionnalites f11 = new Fonctionnalites("Test du code", 20, 0, 0, "Recette");
            Fonctionnalites f12 = new Fonctionnalites("Faire le point avec le client", 10, 0, 0, "Recette");

            /* Livraison */
            Fonctionnalites f13 = new Fonctionnalites("Livraison", 10, 0, 0, "Livraison");


            //REUNION(THEME DE LA REUNION) et le statut de cette réunion est par défaut à false
            Reunion r1 = new Reunion("Faire connaissance", "Découvir l'équipe");
            Reunion r2 = new Reunion("Évaluer le potentiel du groupe", "Découvir l'équipe");
            Reunion r3 = new Reunion("Révèle les qualités et les défauts", "Découvir l'équipe");
            Reunion r4 = new Reunion("Analyse des affinités de chacun", "Découvir l'équipe");
            Reunion r5 = new Reunion("Découvrir le projet", "Examiner le projet");
            Reunion r6 = new Reunion("Analyse de la demande du client et de ses besoins + Définir un cahier des charges", "Examiner le projet");
            Reunion r7 = new Reunion("Mettre en place un système d'organisation", "Examiner le projet");
            Reunion r8 = new Reunion("Mettre en commun le travail et l'avancement de chacun", "Faire le point");


            listReunion.Add(r1);
            listReunion.Add(r2);
            listReunion.Add(r3);
            listReunion.Add(r4);
            listReunion.Add(r5);
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
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                listtransmise.Add(f);
            }

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);




            foreach (Personnage p in listPersonnage)
            {
                

                int randAffinite = aleatoire.Next(4);
                int randDeteste = aleatoire.Next(4);

                if (listPersonnage[randAffinite] != p)
                {
                    p.setAffinite((Personnage)listPersonnage[randAffinite]);
                }




                if (listPersonnage[randDeteste] != p && listPersonnage[randDeteste] != p.getAffinite())
                {
                    p.setDeteste((Personnage)listPersonnage[randDeteste]);
                }




            }

            Personnage persov;
            persov = new Personnage("-", 0, 0, 0, null, null);
            foreach (Personnage p in listPersonnage)
            {
                if(p.getAffinite() == null)
                {
                    p.setAffinite(persov);
                }
                if(p.getDeteste() == null)
                {
                    p.setDeteste(persov);
                }

            }

            attributionQualitesDefautsPointsFortsEtFaibles();

            jeu = new frmJeu(p1, p2, p3, p4,10);
            
            jeu.Refresh();
            jeu.Show();
            //frmReunionPopUp popup = new frmReunionPopUp();
            //popup.ShowDialog();
        }

        public static Boolean verifierTacheTermine()
        {
            Boolean res = true;
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                if (!(f.getStatus()))
                {
                    res = false;
                }
            }
            return res;
        }

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
            listePointsForts.Add("Développeur né");    //dv *1,5
            listePointsForts.Add("Concepteur né");        //conception *1,5
            listePointsForts.Add("Chercheur né");        //recherche *1,5

            listePointsFaibles.Add("Incompétent notoire");    //ttes les actions *1,5
            listePointsFaibles.Add("Mauvais développeur");    //dv * 0,5
            listePointsFaibles.Add("Mauvais concepteur");     //conception * 0,5
            listePointsFaibles.Add("Mauvaise chercheur");     //recherche * 0,5

            /*
            //bug si les listeRand sont vides : donc on initialise une valeur
            listeRand1.Add(-1);
            listeRand2.Add(-1);
            */
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


        public void lancerJeu2(frmMenu fm)
        {
            fm.Hide();

            /*
             */

            /* ---------------- qualites et defauts ---------------- */
            Random aleatoire = new Random();



            listeQualites.Add("Sang-froid");        //stress monte moins vite
            listeQualites.Add("Inépuisable");       //fatigue monte moins vite
            listeQualites.Add("Talentueux");        //ttes les actions *1,5
            listeQualites.Add("Développeur né");    //dv *1,5
            listeQualites.Add("Concepteur né");        //conception *1,5
            listeQualites.Add("Chercheur né");        //recherche *1,5
            listeQualites.Add("Diplomate");            //relations +10 points


            listeDefauts.Add("Stressé");                    //stress monte plus vite
            listeDefauts.Add("Fatigué");                //fatigue monte plus vite
            listeDefauts.Add("Incompétent notoire");    //ttes les actions *1,5
            listeDefauts.Add("Mauvais développeur");    //dv * 0,5
            listeDefauts.Add("Mauvais concepteur");     //conception * 0,5
            listeDefauts.Add("Mauvaise chercheur");     //recherche * 0,5
            listeDefauts.Add("Asocial");                //relations -10 points




            //creation personnage
            p1 = remplirPersonnage("Valentin", 20, 0, 82, null, null);
            p2 = remplirPersonnage("Aymeric", 20, 20, 80, null, null);
            p3 = remplirPersonnage("Mathieu", 33, 40, 50, null, null);
            p4 = remplirPersonnage("Samir", 42, 10, 45, null, null);



            /*
            FONCTIONNALITES ( NOM , PANECESS , POURCENTNOTE , NVCONNAIS , PADEPENSE , TYPE) */

            // 88 sans le crunch donc en tout 900 

            Fonctionnalites f1 = new Fonctionnalites("Cahier des charges", 120, 0, 0, "Rechercher");
            Fonctionnalites f2 = new Fonctionnalites("Objectifs pédagogiques", 40, 0, 0, "Rechercher");
            Fonctionnalites f3 = new Fonctionnalites("Documentation", 40, 0, 0, "Rechercher");
            Fonctionnalites f4 = new Fonctionnalites("MCD", 40, 0, 0, "Concevoir");
            Fonctionnalites f5 = new Fonctionnalites("Interface graphique ", 40, 0, 0, "Concevoir");
            Fonctionnalites f6 = new Fonctionnalites("GIT", 40, 0, 0, "Concevoir");
            Fonctionnalites f7 = new Fonctionnalites("Classes", 40, 0, 0, "Développer");
            Fonctionnalites f8 = new Fonctionnalites("Controleur", 250, 0, 0, "Développer");
            Fonctionnalites f9 = new Fonctionnalites("Moteur de jeu", 100, 0, 0, "Développer");

            //REUNION(THEME DE LA REUNION) et le statut de cette réunion est par défaut à false
            Reunion r1 = new Reunion("Faire connaissance", "Découvir l'équipe");
            Reunion r2 = new Reunion("Évaluer le potentiel du groupe", "Découvir l'équipe");
            Reunion r3 = new Reunion("Révèle les qualités et les défauts", "Découvir l'équipe");
            Reunion r4 = new Reunion("Analyse des affinités de chacun", "Découvir l'équipe");
            Reunion r5 = new Reunion("Découvrir le projet", "Examiner le projet");
            Reunion r6 = new Reunion("Analyse de la demande du client et de ses besoins + Définir un cahier des charges", "Examiner le projet");
            Reunion r7 = new Reunion("Mettre en place un système d'organisation", "Examiner le projet");
            Reunion r8 = new Reunion("Mettre en commun le travail et l'avancement de chacun", "Faire le point");


            listReunion.Add(r1);
            listReunion.Add(r2);
            listReunion.Add(r3);
            listReunion.Add(r4);
            listReunion.Add(r5);
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
            verifPourcentNote();

            foreach (Fonctionnalites f in listfonctionnalite)
            {
                listtransmise.Add(f);
            }

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);




            foreach (Personnage p in listPersonnage)
            {
                for (int i = 0; i < nbQualites; i++)
                {
                    int rand1 = aleatoire.Next(listeQualites.Count);   //de 0 à X-1
                    p.qualites.Add(listeQualites[rand1]);
                }

                for (int i = 0; i < nbDefauts; i++)
                {
                    int rand2 = aleatoire.Next(listeDefauts.Count);   //de 0 à X-1
                                                                      //while (rand2 == rand1)
                                                                      //{
                                                                      //rand2 = aleatoire.Next(listeDefauts.Count);  //on fait cela car les qualites et defauts avec le meme argument sont opposés et incompatibles irl
                                                                      //}
                    p.defauts.Add(listeDefauts[rand2]);
                }

                int randAffinite = aleatoire.Next(4);
                int randDeteste = aleatoire.Next(4);

                if (listPersonnage[randAffinite] != p)
                {
                    p.setAffinite((Personnage)listPersonnage[randAffinite]);
                }




                if (listPersonnage[randDeteste] != p && listPersonnage[randDeteste] != p.getAffinite())
                {
                    p.setDeteste((Personnage)listPersonnage[randDeteste]);
                }

            }

            attributionQualitesDefautsPointsFortsEtFaibles();


            jeu = new frmJeu(p1, p2, p3, p4,20);

            jeu.Refresh();
            jeu.Show();
        }



        public Personnage remplirPersonnage(string prenom, int connaissance, int stress, int sociabilite, Personnage affinite, Personnage deteste) //créer personnage avec attributs en paramètres
        {
            return new Personnage(prenom, connaissance, stress, sociabilite, affinite,deteste);
        }

        public static ArrayList getListeReunion()
        {
            return listReunion;
        }

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

        public static void arreterJeu(String s)
        {



            //crée une liste stockant tous les taches non effectué
            ArrayList tacheNonCodé = new ArrayList();
            foreach(Fonctionnalites f in getListeFonctionnalite())
            {
                if( !(f.getStatus()) )
                {
                    tacheNonCodé.Add(f);
                }
            }


            Forms.FrmEnd e = new Forms.FrmEnd(s,tacheNonCodé,frmJeu.getAvancement(),200);
            e.Show();

            
            
        }

       

        public static void nouveauTour()
        {
            calculsAttributs();     //actualise les attributs des persos après avoir effectué des taches

            Random aleatoire = new Random();
            int rnd = aleatoire.Next(5);
            if(rnd == 0)
            {
                Fonctionnalites f10 = new Fonctionnalites("Nouvelle demande client", 10, 0, 0, "Développer");
                listfonctionnalite.Add(f10);
                listtransmise.Add(f10);
            }
        }

        //Modification de tous les attributs
        public static void calculsAttributs()
        {
            foreach (Personnage p in listPersonnage)
            {
              
                // PARCOURS DES ACTIONS SELECTIONNEES

                int v = p.getnbrActionFaite();
                //MessageBox.Show(p.getPrenom() + " : " + p.getnbrActionFaite().ToString());
                
               


                for (int i =0;i< v; i++)
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
            foreach (Fonctionnalites f in ControleurJeu.getListeFonctionnalite())
            {
                if(f.getNom() == "Nouvelle demande client")
                {
                    actu += "Nouvelle demande du client à traiter ! \n";
                }
            }
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

        

       
    }
}