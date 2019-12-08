using System;
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

namespace Menu
{
    public partial class frmJeu : Form
    {

        ArrayList listPerso = new ArrayList();
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

            int X = lblActu.Location.X;
            int Y = lblActu.Location.Y;

            lblActu.Size = new Size(((screenWidth - lblActu.Location.X) - lblActu.Size.Width) + lblActu.Size.Width, lblActu.Size.Height);       
            rtbActu.Size = new Size(((screenWidth - rtbActu.Location.X) - rtbActu.Size.Width) + rtbActu.Size.Width - 9, rtbActu.Size.Height);
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
            //Initialisation ProgressBar pour chaque tache
            for (int i = 0; i <= listTache.Count-1; i++)
            {
                Bunifu.Framework.UI.BunifuProgressBar progressBar = new Bunifu.Framework.UI.BunifuProgressBar();
                Label l = new Label();
                Fonctionnalites f = (Fonctionnalites)listTache[i];

                progressBar.BackColor = System.Drawing.Color.Silver;
                progressBar.BorderRadius = 5;
                progressBar.Location = new System.Drawing.Point(0, posBas);
                progressBar.ProgressColor = System.Drawing.Color.Teal;
                progressBar.Size = new System.Drawing.Size(pnlProgressBarTache.Width-200, 20);
                progressBar.Tag = i;
                progressBar.Value = 0;

                l.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                l.Location = new System.Drawing.Point(pnlProgressBarTache.Width - 200, progressBar.Location.Y);
                l.Size = new System.Drawing.Size(200, 20);
                l.Text = f.getNom();

                pnlProgressBarTache.Controls.Add(progressBar);
                pnlProgressBarTache.Controls.Add(l);
                posBas += 25;
            }

        }

        public void tombeMalade(Personnage p)
        {
            p.setMalade(true);
        }

        public void initUC(UC_Personnage uC, Personnage p)
        {
            
            /* IMAGES DES PERSOS */
            imgLst.Images.Add("perso1", Image.FromFile(@"perso1.png"));
            imgLst.Images.Add("perso2", Image.FromFile(@"perso2.png"));
            imgLst.Images.Add("perso3", Image.FromFile(@"perso3.png"));
            imgLst.Images.Add("perso4", Image.FromFile(@"perso4.png"));

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



        public void ecrireSurConsole()       //controleur de jeu écrit sur le fil d'actualité
        {
            
            rtbActu.Text += ControleurJeu.filActualite();
            rtbActu.Text += "\nTour effectué " + this.getNbTour() + " / " + nbTourMax.ToString();
            this.augmenterNbTour();   //incremente nb de tour

        }

        private void btnTourSuivant_Click(object sender, EventArgs e) {
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

            /*-----------------TEST MALADIE ------------------------ */
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
                            up.getPersonnage().setMalade(false);
                            crunchBool = false;
                            
                            if (getAvancement() >= 0 && getAvancement() <= 100)
                            {

                                Random aleatoire = new Random();
                                int rnd = aleatoire.Next(9);
                                if (rnd == 0)
                                {
                                    //up.getPersonnage().setMalade(true);
                                    //up.Enabled = false;
                                }
                            }
                            else
                            {
                                up.Enabled = true;
                                up.getPersonnage().setMalade(false);
                                up.getPersonnage().setDisponible(true);
                                up.BackColor = Color.AliceBlue;
                            }

                        }
                    }
                }
            }




            // FIN SI DEADLINE OU TOUTES LES FONCTIONS SONT FINIES
            // A REVOIR ( VERIFIER SI LE POURCENTAGE DU PROJET == 100 --> FIN )
            if ((nbTour >= nbTourMax) || ((ControleurJeu.getListeFonctionnalite().Count == 0)) || lstTache.Items.Count == 0)
            {
                ControleurJeu.arreterJeu(rtbListeF.Text);
                this.Close();
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

                ecrireSurConsole();

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

                uC_Personnage1.cleanCBO();
                uC_Personnage2.cleanCBO();
                uC_Personnage3.cleanCBO();
                uC_Personnage4.cleanCBO();

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
            List<Personnage> listRepos = new List<Personnage>();
            frmRepos repos = new frmRepos(listPersonnage, this);
            DialogResult dr = new DialogResult();
           
            btnRepos.Enabled = false;

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
                            up.crunchActive();
                            crunchBool = true;
                        }
                    }
                }
            }
        }

        public void setRepos(Personnage p)
        {
            p.setFatigue(0);
            p.setDisponible(false);
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
                    if (r.getThemeReunion() == "Découvrir le projet")
                    {
                        rtbActu.Text += "\nIl vous est demandé de réaliser la simulation d'une gestion de projet T3\n";
                    }
                    if (r.getThemeReunion() == "Révèle les qualités et les défauts")
                    {
                        //à FAIRE
                    }
                    if (r.getThemeReunion() == "Mettre en place un système d'organisation")
                    {
                        rtbActu.Text += "\n\nLe chef étant désigné, vous pouvez faire les points sur votre avancement du projet lors des réunions";
                    }
                    if (r.getThemeReunion() == "Analyse de la demande du client et de ses besoins + Définir un cahier des charges")
                    {
                        lstTache.Visible = true;
                        btnVider.Visible = true;
                        lblLstTache.Visible = true;
                        rtbActu.Text += "\nLa liste des tâches à effectuer est disponible";
                    }
                    if (r.getThemeReunion() == "Mettre en commun le travail et l'avancement de chacun")
                    {
                        lblTacheReal.Visible = true;
                        pnlProgressBarTache.Visible = true;
                        rtbActu.Text += "\nGrâce à la mise en commun lors de la réunion, vous pouvez voir toutes les tâches effectuées";
                    }
                    uC_Personnage1.rendreInvisibleTacheMatin();
                    uC_Personnage2.rendreInvisibleTacheMatin();
                    uC_Personnage3.rendreInvisibleTacheMatin();
                    uC_Personnage4.rendreInvisibleTacheMatin();
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
                MessageBox.Show("Veuillez drag & drop les tâches sur des personnages !");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void switchColor_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.PaleTurquoise)
            {
                this.BackColor = Color.Black;
                lblTacheReal.ForeColor = Color.White;
                lblActu.ForeColor = Color.White;
                panel2.BackColor = Color.Gray;
                rtbActu.BackColor = Color.Gray;
                rtbListeF.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = Color.PaleTurquoise;
                lblTacheReal.ForeColor = Color.Black;
                lblActu.ForeColor = Color.Black;
                panel2.BackColor = Color.DarkCyan;

                rtbActu.BackColor = Color.White;
                rtbListeF.BackColor = Color.White;
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

    }
}