using Menu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class frmButReunion : Form
    {
        private frmReunion reunion;
        private static int compteurEquipe = 0;
        private frmReunionPopUp f;
        /**
         * Constructeur 
         */
        public frmButReunion(frmReunion fr)
        {
            InitializeComponent();
            this.reunion = fr;
            update();
        }

        /**
         * Retourne le nombre de réunions de découverte de l'équipe effectué
         */
        public static int getCompteurEquipe()
        {
            return compteurEquipe;
        }

        /**
         * Détermine le thème de la réunion en fonction du bouton cliqué
         */
        public void themeReunion(String theme)
        {
            int posGauche = 66;

            if (theme == "Découvir l'équipe")
            {



                Button button2 = new Button();
                button2.Size = new System.Drawing.Size(494, 78);
                button2.Location = new System.Drawing.Point(posGauche, 138);
                button2.Text = "Évaluer le potentiel du groupe";
                button2.Cursor = System.Windows.Forms.Cursors.Hand;
                button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.ForeColor = System.Drawing.Color.Orange;
                button2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button2.Click += new System.EventHandler(this.lancerNotification);
                if (verifierThemeAborde(button2.Text))   //grise le bouton car le theme de cette réunion a déjà été abordé
                {
                    button2.Enabled = false;
                }

                Button button3 = new Button();
                button3.Size = new System.Drawing.Size(494, 78);
                button3.Location = new System.Drawing.Point(posGauche, 238);
                button3.Text = "Révèle les qualités et les défauts";
                button3.Cursor = System.Windows.Forms.Cursors.Hand;
                button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.ForeColor = System.Drawing.Color.Orange;
                button3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button3.Click += new System.EventHandler(this.lancerNotification);
                if (verifierThemeAborde(button3.Text))   //grise le bouton car le theme de cette réunion a déjà été abordé
                {
                    button3.Enabled = false;
                }

                Button button4 = new Button();
                button4.Size = new System.Drawing.Size(494, 78);
                button4.Location = new System.Drawing.Point(posGauche, 338);
                button4.Text = "Analyse des affinités de chacun";
                button4.Cursor = System.Windows.Forms.Cursors.Hand;
                button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button4.ForeColor = System.Drawing.Color.Orange;
                button4.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button4.Click += new System.EventHandler(this.lancerNotification);
                if (verifierThemeAborde(button4.Text))   //grise le bouton car le theme de cette réunion a déjà été abordé
                {
                    button4.Enabled = false;
                }


                this.Controls.Add(button2);
                this.Controls.Add(button3);
                this.Controls.Add(button4);
            }

            if (theme == "Examiner le projet")
            {


                Button button2 = new Button();
                button2.Size = new System.Drawing.Size(494, 78);
                button2.Location = new System.Drawing.Point(posGauche, 138);
                button2.Text = "Analyse de la demande du client et de ses besoins + Définir un cahier des charges";
                button2.Cursor = System.Windows.Forms.Cursors.Hand;
                button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.ForeColor = System.Drawing.Color.Orange;
                button2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button2.Click += new System.EventHandler(this.lancerNotification);
                if (verifierThemeAborde(button2.Text))   //grise le bouton car le theme de cette réunion a déjà été abordé
                {
                    button2.Enabled = false;
                }

                Button button3 = new Button();
                button3.Size = new System.Drawing.Size(494, 78);
                button3.Location = new System.Drawing.Point(posGauche, 238);
                button3.Text = "Mettre en place un système d'organisation";
                button3.Cursor = System.Windows.Forms.Cursors.Hand;
                button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.ForeColor = System.Drawing.Color.Orange;
                button3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button3.Click += new System.EventHandler(this.lancerNotification);
                if (verifierThemeAborde(button3.Text))   //grise le bouton car le theme de cette réunion a déjà été abordé
                {
                    button3.Enabled = false;
                }


                this.Controls.Add(button2);
                this.Controls.Add(button3);
            }

            if (theme == "Faire le point")
            {
                Button button1 = new Button();
                button1.Size = new System.Drawing.Size(494, 78);
                button1.Location = new System.Drawing.Point(posGauche, 38);
                button1.Text = "Mettre en commun le travail et l'avancement de chacun";
                button1.Cursor = System.Windows.Forms.Cursors.Hand;
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.ForeColor = System.Drawing.Color.Orange;
                button1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button1.Click += new System.EventHandler(this.lancerNotification);
                if (verifierThemeAborde(button1.Text))   //grise le bouton car le theme de cette réunion a déjà été abordé
                {
                    button1.Enabled = false;
                }

                this.Controls.Add(button1);
            }

        }

        /**
         * Lancement d'un popup qui disparait progressivement avec le timerPopUp 
         */
        public void lancerNotification(object sender, EventArgs e)
        {
            this.reunion.incrementerNbReunion();    //incrementer le nb de thématique de réunions abordé
            frmReunionPopUp popup = new frmReunionPopUp();
            this.f = popup;
            popup.TopMost = true;
            Button b = (Button)sender;
            /* Changer la position */
            popup.messagePopUp(b.Text);   //appel méthode du formulaire popup
            popup.Show();
            this.Focus();
            fonduPopUp();

            compteurEquipe++;

            //une fois l'achievement activé on bloque le boutton avec un enable pour dire à l'utilisateur 
            //qu'il n'a plus besoin de s'occuper de cet achievement et que cette derniere a été validé
            //puis dans la liste des thèmes des réunions du controleur de jeu on met le statut du theme de la réunion à true pour dire que cette derniere a été abordée
            b.Enabled = false;
            //MessageBox.Show("Texte bouton : " + b.Text); fonctionne
            ControleurJeu.changerStatutReunion(b.Text);
            update();
        }

        /**
         * Diminue l'opacité du popup de 0.1 à chaque Tick 
         */
        private void fonduPopUp()
        {

            if (f != null)
            {
                f.Opacity -= 0.1; //Peut être changer la valeur
                /* Egalement modifier la position des forms car superposés on y voit plus rien */
            }

        }
        /**
         * Ferme le formulaire
         */
        private void btnRevenir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Vérifie le thème abordé
         */
        public Boolean verifierThemeAborde(String themeReunion)     //verifie si le theme de la reunion a déjà été abordé
        {
            Boolean verif = false;
            foreach (Reunion r in ControleurJeu.getListeReunion())       //parcourt la liste des réunions pour voir si le thème de la réunion a déjà été abordé
            {
                if (r.getThemeReunion() == themeReunion)        //si le theme de la reunion a déjà été abordé alors on empece
                {
                    verif = r.getStatut();
                }
            }
            return verif;
        }

        /**
         * Mise a jour du nombre de réunions effectués et des thèmes 
         */
        public void update()
        {
            if (reunion.getNbReunion() >= 3)
            {
                frmReunionPopUp popup = new frmReunionPopUp();
                popup.messagePopUp("Nombre de réunion dépassé");
                popup.Show();
                foreach (Object o in Controls)
                {
                    if (o is Button)
                    {
                        Button b = (Button)o;
                        if (b.Name != "btnRevenir")
                        {
                            b.Enabled = false;
                        }
                    }
                }
            }
        }

        /**
         * Appelle la méthode fonduPopUp
         */
        private void timerPopUp_Tick(object sender, EventArgs e)
        {
            fonduPopUp();
        }

        /**
         * Timer qui ferme le popup au bout de 10 secondes
         */
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (f != null)
            {
                f.Close();
            }

        }
    }
}
