﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.classePersonnage;
using System.Collections.Generic;
using Menu.Forms;
using Menu.Classes;
using System.IO;

namespace Menu
{
    public partial class frmJeu : Form
    {
        public static List<Personnage> listRepos = new List<Personnage>();

        ImageList imgLst = new ImageList
        {
            ImageSize = new Size(119, 119)
        };


        int nbTour = 0; //nb de tour pour le projet
        
        int nbTourMax;
        bool crunchBool = false;
        // String d'affichage des actions / jour
        public static string s = "";
        // Avancement de la progressbar
        private static float avancement = 0;
        List<Personnage> listPersonnage = new List<Personnage>();
        public frmJeu(Personnage p1, Personnage p2, Personnage p3, Personnage p4,int tourmax)
        {
            InitializeComponent();

            nbTourMax = tourmax;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
     
            this.Size = new Size(screenWidth, screenHeight);


            lblTacheReal.Size = new Size(((screenWidth - lblTacheReal.Location.X) - lblTacheReal.Size.Width) + lblTacheReal.Size.Width, lblTacheReal.Size.Height - 5);
            pnlProgressBarTache.Size = new Size(((screenWidth - pnlProgressBarTache.Location.X) - pnlProgressBarTache.Size.Width) + pnlProgressBarTache.Size.Width, pnlProgressBarTache.Size.Height - 5);
            panel2.Size = new Size(screenWidth, panel2.Height);

            
            foreach (Fonctionnalites f in ControleurJeu.getListeFonctionnalite())
            {
                if (f.getPaDepense() < f.getPaNecess() && f.getStatus() == false)
                {
                    lstTache.Items.Add(f.getNom() + " (" + f.getNvConnaissNecces() + ")");
                }

            }
            lstTache.AllowDrop = true;
            uC_Personnage1.AllowDrop = true;
            uC_Personnage2.AllowDrop = true;
            uC_Personnage3.AllowDrop = true;
            uC_Personnage4.AllowDrop = true;

            this.Refresh();

            listPersonnage.Clear();
            crunchBool = false;


            ArrayList listPerso = ControleurJeu.getListePersonnage();

            listPersonnage.Add(p1);
            listPersonnage.Add(p2);
            listPersonnage.Add(p3);
            listPersonnage.Add(p4);


            initUC(uC_Personnage1, p1);
            initUC(uC_Personnage2, p2);
            initUC(uC_Personnage3, p3);
            initUC(uC_Personnage4, p4);

            foreach (Object o in Controls)
            {
                if (o is UC_Personnage)
                {
                    UC_Personnage uC_Perso = new UC_Personnage();
                    uC_Perso.Enabled = true;

                }
            }

            ArrayList listTache = ControleurJeu.getListeFonctionnalite();
            int posBas = 5;
            Fonctionnalites fPrecedent = null;
            //Initialisation ProgressBar pour chaque tache
            for (int i = 0; i <= listTache.Count-1; i++)
            {
                Bunifu.Framework.UI.BunifuProgressBar progressBar = new Bunifu.Framework.UI.BunifuProgressBar();
                Label l = new Label();
                Fonctionnalites f = (Fonctionnalites)listTache[i];

                if(f.getNom() != "Formation")
                {
                    if (fPrecedent == null || f.getType() != fPrecedent.getType())
                    {
                        posBas += 25;
                        Label lblaffichageType = new Label();
                        lblaffichageType.Text = f.getType();
                        lblaffichageType.Location = new System.Drawing.Point(0, posBas);
                        lblaffichageType.Font = new System.Drawing.Font("Cooper Black", 19F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblaffichageType.Size = new System.Drawing.Size(200, 45);
                        lblaffichageType.Tag = 10;  //permet d'identifier les labels titres
                        posBas += 50;
                        pnlProgressBarTache.Controls.Add(lblaffichageType);
                    }

                    fPrecedent = f;     //remet à jour la fonctionnalités précédente

                    l.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    l.BackColor = pnlProgressBarTache.BackColor;
                    l.Location = new System.Drawing.Point(0, posBas);
                    l.Size = new System.Drawing.Size(220, 20);
                    l.Text = f.getNom();
                    if (f.getType() == "Spécification")
                    {
                        l.ForeColor = Color.DarkRed;
                    }
                    if (f.getType() == "Concevoir")
                    {
                        l.ForeColor = Color.Green;
                    }
                    if (f.getType() == "Développer")
                    {
                        l.ForeColor = Color.Purple;
                    }
                    if (f.getType() == "Recette")
                    {
                        l.ForeColor = Color.DarkGray;
                    }
                    if (f.getType() == "Livraison")
                    {
                        l.ForeColor = Color.Maroon;
                    }


                    progressBar.BackColor = System.Drawing.Color.Silver;
                    progressBar.BorderRadius = 5;
                    progressBar.ProgressColor = System.Drawing.Color.Teal;
                    progressBar.Size = new System.Drawing.Size(pnlProgressBarTache.Width - 200, 20);
                    progressBar.Location = new System.Drawing.Point(l.Location.X + 200, l.Location.Y);
                    progressBar.Tag = i;
                    progressBar.Value = 0;

                    pnlProgressBarTache.Controls.Add(progressBar);
                    pnlProgressBarTache.Controls.Add(l);
                    posBas += 25;
                }
            }
                

        }

        public static string Path = Application.StartupPath.ToString();
        public void initUC(UC_Personnage uC, Personnage p)
        {
            string p2 = Directory.GetParent(Path).ToString() + "\\image\\";
         //  string p3 = Directory.GetParent(p2).ToString() +"\\image\\"; 
            // MessageBox.Show(p3+"\\image\\");
            /* Emplacement des images à revoir IMPORTANT */
            imgLst.Images.Add("perso1", Image.FromFile(p2 + "perso1.png"));
            imgLst.Images.Add("perso2", Image.FromFile(p2 + "perso2.png"));
            imgLst.Images.Add("perso3", Image.FromFile(p2 + "perso3.png"));
            imgLst.Images.Add("perso4", Image.FromFile(p2 + "perso4.png"));
            imgLst.Images.RemoveAt(0);
            uC.initialisationUCPerso(p, imgLst.Images[0]);
            
        }

        public void augmenterNbTour()
        {
            /* ------- COMPLETEMENT RANDOM, C'EST A FAIRE ------- */
            Random rnd = new Random();
            int s = rnd.Next(10);
            //score.Value += score.Value + s;
            nbTour++;
        }

        public int getNbTour()
        {
            return this.nbTour;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();

            //this.Dispose();
            this.Close();


        }


        private void btnTourSuivant_Click(object sender, EventArgs e) {

            uC_Personnage1.arreterClignotant();
            uC_Personnage2.arreterClignotant();
            uC_Personnage3.arreterClignotant();
            uC_Personnage4.arreterClignotant();


            lblTour.Text = "Tour " + nbTour.ToString() + "/10";
            lblTour.Visible = true;
            btnReunion.Enabled = true;
            
            btnRepos.Enabled = true;
            if (crunchBool == true)
            {
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {
                                UC_Personnage up = (UC_Personnage)c;
                                up.Enabled = true;
                                up.crunchDesactive();
                                crunchBool = false;
                            }
                        }
                    }
                }
            }


            // FIN SI DEADLINE OU TOUTES LES FONCTIONS SONT FINIES
            // A REVOIR ( VERIFIER SI LE POURCENTAGE DU PROJET == 100 --> FIN )
            if ((nbTour >= nbTourMax) || ((ControleurJeu.verifierTacheTermine())))
            {
                ControleurJeu.arreterJeu(rtbListeF.Text);
                this.Close();
            }

            // Pre remplissage de toutes les taches pour le tour actuel pour chaque perso
            foreach (Object o in Controls)
            {
                if (o is Panel)
                {
                    Panel p = (Panel)o;

                    foreach (Object c in p.Controls)
                    {
                        if (c is UC_Personnage)
                        {

                            UC_Personnage up = (UC_Personnage)c;

                            up.remplirListeAffinite();

                        }
                    }
                }
            }
           


            //modification des taches des user controls
            foreach (Object o in Controls)
            {
                if (o is Panel)
                {
                    Panel p = (Panel)o;

                    foreach (Object c in p.Controls)
                    {
                        if (c is UC_Personnage)
                        {

                            UC_Personnage up = (UC_Personnage)c;
                            
                            up.donnerTachePerso();
                            
                        }
                    }
                }

            }

            foreach (Object o in Controls)
            {
                if (o is Panel)
                {
                    Panel p = (Panel)o;

                    foreach (Object c in p.Controls)
                    {
                        if (c is UC_Personnage)
                        {

                            UC_Personnage up = (UC_Personnage)c;

                            up.viderListeAffinite();

                        }
                    }
                }
            }




            try
            {
                // REMPLISSAGE DEUXIEME "CONSOLE"
                rtbListeF.Text += "\nJournée " + nbTour.ToString() + ":\n";
                rtbListeF.Text += s;

                s = "";


                // MISE A ZERO DES COMBOBOX POUR NE PLUS AVOIR LES ANCIENS CHOIX
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;

                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {

                                UC_Personnage up = (UC_Personnage)c;
                                up.cleanCBO();
                            }

                        }

                    }

                }

                ControleurJeu.nouveauTour();



                this.augmenterNbTour();   //incremente nb de tour

                ArrayList listPerso = ControleurJeu.getListePersonnage();

                Personnage p1 = (Personnage)listPerso[0];
                Personnage p2 = (Personnage)listPerso[1];
                Personnage p3 = (Personnage)listPerso[2];
                Personnage p4 = (Personnage)listPerso[3];

                //mise a jour des persos apres avoir effectue les taches
                initUC(uC_Personnage1, p1);
                initUC(uC_Personnage2, p2);
                initUC(uC_Personnage3, p3);
                initUC(uC_Personnage4, p4);

                List<UC_Personnage> listUC = new List<UC_Personnage>();
                listUC.Add(uC_Personnage1);
                listUC.Add(uC_Personnage2);
                listUC.Add(uC_Personnage3);
                listUC.Add(uC_Personnage4);

                uC_Personnage1.cleanCBO();
                uC_Personnage2.cleanCBO();
                uC_Personnage3.cleanCBO();
                uC_Personnage4.cleanCBO();

                Random rnd = new Random();
                int alea = rnd.Next(20);
                if(alea <= 3)
                {
                    UC_Personnage u = listUC[alea];
                    u.getPersonnage().setMalade(true);
                    u.getPersonnage().setDisponible(false);
                }


                // FIN SI DEADLINE OU TOUTES LES FONCTIONS SONT FINIES
                // A REVOIR ( VERIFIER SI LE POURCENTAGE DU PROJET == 100 --> FIN )


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selectionnez Action");
            }


            //Mettre à jour la liste des tâches à effectuer, c'est-à-dire que l'on vérifie si la tâche est complété ou non. Si c'est le cas alors on l'enlève de la liste
            lstTache.Items.Clear();
            foreach (Fonctionnalites f in ControleurJeu.getListeFonctionnalite())
            {
                
                if (f.getPaDepense() < f.getPaNecess() && f.getStatus() == false)
                {
                    lstTache.Items.Add(f.getNom() + " (" + f.getNvConnaissNecces() + ")");
                }
            }



            //Actualiser les progressBars pour chaque tache
            ArrayList listFonctionnalite = ControleurJeu.getListeFonctionnalite();
            for (int i = 0; i <= listFonctionnalite.Count - 1; i++)
            {
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object ob in p.Controls)
                        {
                            if (ob is Bunifu.Framework.UI.BunifuProgressBar)
                            {
                                Bunifu.Framework.UI.BunifuProgressBar pb = (Bunifu.Framework.UI.BunifuProgressBar)ob;
                                if ((int)pb.Tag == i)
                                {
                                    Fonctionnalites f = (Fonctionnalites)listFonctionnalite[i];
                                    foreach (Fonctionnalites ft in ControleurJeu.getListeFonctionnalite())
                                    {
                                        if (f.getNom() == ft.getNom())
                                        {
                                            float val1 = (float)ft.getPaDepense();
                                            float val2 = (float)ft.getPaNecess();
                                            float res = (val1 / val2) * 100;
                                            if (res >= 100)
                                            {
                                                res = 100;
                                            }
                                            pb.Value = (int)res;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }     
        }


        // METHODE DE CONCATENATION DES ACTIONS DU JOUR
        public static void remplir(string s1)
        {
            s += s1;
        }



        public void viderCBO()
        {
            uC_Personnage1.viderCBO();

            uC_Personnage2.viderCBO();

            uC_Personnage3.viderCBO();
        }
        private void btnRepos_Click(object sender, EventArgs e)
        {
            
            frmRepos repos = new frmRepos(listPersonnage, this);
            DialogResult dr = new DialogResult();
           
            

            dr = repos.ShowDialog();
            if (crunchBool == true)
            {
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {
                                UC_Personnage up = (UC_Personnage)c;
                                up.crunchDesactive();
                                crunchBool = false;
                            }
                        }
                    }
                }
            }


            if (nbTour >= 10)
            {
                viderCBO();
                
                ControleurJeu.arreterJeu(rtbListeF.Text);
                
                this.Close();
            }

            if (dr == DialogResult.OK)
            {
                if(listRepos.Count() != 0)
                {
                    btnRepos.Enabled = false;
                }
                
                ArrayList listPerso = ControleurJeu.getListePersonnage();

                Personnage p1 = (Personnage)listPerso[0];
                Personnage p2 = (Personnage)listPerso[1];
                Personnage p3 = (Personnage)listPerso[2];
                Personnage p4 = (Personnage)listPerso[3];

                //mise a jour des persos apres avoir effectue les taches

                
                //On met a jour les uC concernés 
                foreach(Personnage perso in listRepos)
                {
                    if(uC_Personnage1.getPersonnage() == perso)
                    {
                        initUC(uC_Personnage1, perso);
                        uC_Personnage1.rendreCBO1Visible();
                    }
                    else if(uC_Personnage2.getPersonnage() == perso)
                    {
                        initUC(uC_Personnage2, perso);
                        uC_Personnage2.rendreCBO1Visible();
                    }
                    else if (uC_Personnage3.getPersonnage() == perso)
                    {
                        initUC(uC_Personnage3, perso);
                        uC_Personnage3.rendreCBO1Visible();
                    }
                    else if (uC_Personnage4.getPersonnage() == perso)
                    {
                        initUC(uC_Personnage4, perso);
                        uC_Personnage4.rendreCBO1Visible();
                    }
                    else
                    {
                        MessageBox.Show("PERSONNE NE DOIT SE REPOSER, TROP DE TRAVAIL");
                    }
                }
                listRepos.Clear();

            }

            
        }

        public static float getAvancement()
        {
            return avancement;
        }

        public static void setAvancement(float a)
        {
            avancement = a;
        }



        private void btnCrunch_Click_1(object sender, EventArgs e)
        {
            frmCrunch frm = new frmCrunch();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                btnCrunch.Enabled = false;
                foreach (Object o in Controls)
                {
                    if (o is Panel)
                    {
                        Panel p = (Panel)o;
                        foreach (Object c in p.Controls)
                        {
                            if (c is UC_Personnage)
                            {
                                UC_Personnage up = (UC_Personnage)c;
                                if (up.getPersonnage().getMalade() == false)
                                {
                                    up.crunchActive();
                                    crunchBool = true;
                                }

                            }
                        }
                    }
                }
            }

        }

        public void setRepos(Personnage p)
        {
            p.setFatigue(p.getFatigue()/2);
            p.setStress(p.getStress() / 2);
            p.setDisponible(false);
            p.setMalade(false);
            listRepos.Add(p);
        }




        private void btnReunion_Click(object sender, EventArgs e)
        {

            frmReunion reunion = new frmReunion();
            
            if(reunion.ShowDialog() == DialogResult.OK)
            {
                reunion.remettreCompteurAZero();
            }
            lblIntro.Visible = false;
           
            
            btnTourSuivant.Visible = true;
            btnRepos.Visible = true;
            btnCrunch.Visible = true;
            timerRepos.Enabled = false;
            foreach (Reunion r in ControleurJeu.getListeReunion())
            {
                if (r.getStatut())       //active les effets des achievements débloqués lors de la réunion
                {
                    btnReunion.Enabled = false;

                    if (r.getThemeReunion() == "Faire connaissance")
                    {
                        foreach (Object o in Controls)
                        {
                            if (o is Panel)
                            {
                                Panel p = (Panel)o;
                                foreach (Object c in p.Controls)
                                {
                                    if (c is UC_Personnage)
                                    {
                                        UC_Personnage up = (UC_Personnage)c;

                                        up.rendrePrenomsVisible();
                                    }
                                }
                            }
                        }
                    }
                    if (r.getThemeReunion() == "Évaluer le potentiel du groupe")
                    {
                        foreach (Object o in Controls)
                        {
                            if (o is Panel)
                            {
                                Panel p = (Panel)o;
                                foreach (Object c in p.Controls)
                                {
                                    if (c is UC_Personnage)
                                    {
                                        UC_Personnage up = (UC_Personnage)c;

                                        up.rendreAttributsVisible();
                                    }
                                }
                            }
                        }
                    }
                    if (r.getThemeReunion() == "Analyse des affinités de chacun")
                    {
                        foreach (Object o in Controls)
                        {
                            if (o is Panel)
                            {
                                Panel p = (Panel)o;
                                foreach (Object c in p.Controls)
                                {
                                    if (c is UC_Personnage)
                                    {
                                        UC_Personnage up = (UC_Personnage)c;

                                        up.rendreAffinitesVisible();
                                    }
                                }
                            }
                        }
                    }
                    if (r.getThemeReunion() == "Révèle les qualités et les défauts")
                    {;
                        uC_Personnage1.afficherQualiteDefaut();
                        uC_Personnage2.afficherQualiteDefaut();
                        uC_Personnage3.afficherQualiteDefaut();
                        uC_Personnage4.afficherQualiteDefaut();
                    }
                    if (r.getThemeReunion() == "Analyse de la demande du client et de ses besoins + Définir un cahier des charges")
                    {
                        lstTache.Visible = true;
                        btnVider.Visible = true;
                        lblLstTache.Visible = true;
                    }
                    if (r.getThemeReunion() == "Mettre en commun le travail et l'avancement de chacun")
                    {
                        lblTacheReal.Visible = true;
                        pnlProgressBarTache.Visible = true;
                    }
                    uC_Personnage1.rendreInvisibleTacheMatin();
                    uC_Personnage2.rendreInvisibleTacheMatin();
                    uC_Personnage3.rendreInvisibleTacheMatin();
                    uC_Personnage4.rendreInvisibleTacheMatin();
                }
                //verifie si toutes les réunions ont été faites si c'est le cas alors on rend invisible le bouton Réunion
                Boolean etatReunion = true;
                foreach (Reunion re in ControleurJeu.getListeReunion())
                {
                    if (re.getStatut() == false)
                    {
                        etatReunion = false;
                    }               }
                if (etatReunion)
                {
                    btnReunion.Visible = false;
                }
            }
           

        }



        private void btnVider_Click(object sender, EventArgs e)
        {
            uC_Personnage1.cleanCBO();
            uC_Personnage2.cleanCBO();
            uC_Personnage3.cleanCBO();
            uC_Personnage4.cleanCBO();
        }

        

        //SYSTEME GLISSER DÉPOSER

        private void lstTache_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                uC_Personnage3.DoDragDrop(lstTache.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            
            catch(System.NullReferenceException exception)
            {
                MessageBox.Show("Veuillez drag & drop les tâches sur des personnages !" + exception.ToString());
            }
        }

        //Systeme Glisser-Déposer pour le UC_Personnage3 --> 1er en haut à gauche
        private void uC_Personnage3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void uC_Personnage3_DragDrop(object sender, DragEventArgs e)
        {
            uC_Personnage3.addNbrAction();
            uC_Personnage3.remplirComboBox((String)e.Data.GetData(DataFormats.Text));
        }

        //Systeme Glisser-Déposer pour le UC_Personnage2
        private void uC_Personnage2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void uC_Personnage2_DragDrop(object sender, DragEventArgs e)
        {
            uC_Personnage2.addNbrAction();
            uC_Personnage2.remplirComboBox((String)e.Data.GetData(DataFormats.Text));
        }

        //Systeme Glisser-Déposer pour le UC_Personnage1
        private void uC_Personnage1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void uC_Personnage1_DragDrop(object sender, DragEventArgs e)
        {
            uC_Personnage1.addNbrAction();
            uC_Personnage1.remplirComboBox((String)e.Data.GetData(DataFormats.Text));
        }

        //Systeme Glisser-Déposer pour le UC_Personnage4
        private void uC_Personnage4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void uC_Personnage4_DragDrop(object sender, DragEventArgs e)
        {
            uC_Personnage4.addNbrAction();
            uC_Personnage4.remplirComboBox((String)e.Data.GetData(DataFormats.Text));
        }


        private void switchColor_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.PaleTurquoise)
            {
                this.BackColor = Color.Black;
                lblTacheReal.ForeColor = Color.White;
                panel2.BackColor = Color.Gray;
                rtbListeF.BackColor = Color.Gray;
                foreach(Object o in pnlProgressBarTache.Controls)
                {
                    if(o is Label)
                    {
                        Label l = (Label)o;
                        l.BackColor = pnlProgressBarTache.BackColor;
                        if( (l.Tag != null) && ((int)l.Tag == 10) )
                        {
                            l.ForeColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                this.BackColor = Color.PaleTurquoise;
                lblTacheReal.ForeColor = Color.Black;
                panel2.BackColor = Color.DarkCyan;
                rtbListeF.BackColor = Color.White;
                foreach (Object o in pnlProgressBarTache.Controls)
                {
                    if (o is Label)
                    {
                        Label l = (Label)o;
                        l.BackColor = pnlProgressBarTache.BackColor;
                        if ((l.Tag != null) && ((int)l.Tag == 10))
                        {
                            l.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }


        private void timerRepos_Tick(object sender, EventArgs e)
        {
           
            if (this.nbTour == 0)        //permet de signaler à l'utilisateur que lors du premier tour il est conseillé de faire des réunions
            {
                timerRepos.Start();
                if (btnReunion.ForeColor == System.Drawing.Color.OrangeRed)
                {
                    btnReunion.ForeColor = System.Drawing.Color.Yellow;
                    btnReunion.FlatAppearance.BorderSize = 3;
                }
                else
                {
                    btnReunion.ForeColor = System.Drawing.Color.OrangeRed;
                    btnReunion.FlatAppearance.BorderSize = 1;
                }
            }
            else
            {
                btnReunion.ForeColor = System.Drawing.Color.OrangeRed;
                btnReunion.FlatAppearance.BorderSize = 1;
                timerRepos.Dispose();       //libère les ressources liés au timer quand on en a plus besoin
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTacheReal_Click(object sender, EventArgs e)
        {

        }
    }
}