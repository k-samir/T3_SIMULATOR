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

namespace Menu
{
    public partial class UC_Personnage : UserControl
    {


        ArrayList listfonctionnalite = ControleurJeu.getListeFonctionnalite();
        Boolean reunion = false;
        private Personnage perso { get; set; }
        public int nbrActionFaite = 0;

        /**
         * Retourne l'instance du personnage du User_Control
         */
        public Personnage getPersonnage()
        {
            return this.perso;
        }

        /**
         * Rend la cbo du matin invisible
         */
        public void rendreInvisibleTacheMatin()
        {
            lblAction1.Visible = false;
            btnSupprimerTache1.Visible = false;
            cboFonctionnalite1.Visible = false;
            this.reunion = true;

        }

        /**
         * Constructeur du UC_Personnage
         */
        public UC_Personnage()
        {
            InitializeComponent();


            cboFonctionnalite1.Items.Clear();
            cboFonctionnalite1.Items.Clear();
            cboFonctionnalite1.Items.Clear();

        }


        /**
         * Remise à zero des combobox
         */
        public void cleanCBO()
        {
            cboFonctionnalite1.Controls.Clear();
            cboFonctionnalite1.SelectedIndex = -1;
            cboFonctionnalite2.Controls.Clear();
            cboFonctionnalite2.SelectedIndex = -1;
            cboFonctionnalite3.Controls.Clear();
            cboFonctionnalite3.SelectedIndex = -1;
        }

        /**
         * Vide les comboboxs
         */
        public void viderCBO()
        {
            listfonctionnalite.Clear();

        }
        /**
         * Initialisation des UC_Personnages
         */
        public void initialisationUCPerso(Personnage p, Image img)
        {
            this.perso = p;
            this.pictureBox1.Image = img;

            ArrayList qualite = p.getQualite();
            ArrayList defaut = p.getDefaut();
            ArrayList pointFort = p.getPointFort();
            ArrayList pointFaible = p.getPointFaible();


            this.setPrenom(perso.getPrenom());
            this.setConnaissance(perso.getConnaissances());
            this.setStress(perso.getStress());
            this.setFatigue(perso.getFatigue());
            this.setAffinite(perso.getAffinite());
            this.setDeteste(perso.getDeteste());
            this.cboFonctionnalite1.Visible = true;
            this.cboFonctionnalite2.Visible = true;
            lblAction1.Visible = true;
            btnSupprimerTache1.Visible = true;
            btnSupprimerTache2.Visible = true;

            listfonctionnalite = ControleurJeu.getListeFonctionnalite(); //remet à jour la liste de fonctionnalité

            if (this.perso.getFatigue() == 100)
            {
                this.Enabled = false;
            }
            else
            {
                if (perso.estDisponible() == false && perso.getMalade() == true)
                {
                    this.Enabled = false;
                    this.BackColor = Color.Violet;
                    perso.setMalade(false);
                    perso.setDisponible(true);
                    this.cboFonctionnalite1.Visible = false;
                    this.btnSupprimerTache1.Visible = false;
                    this.cboFonctionnalite2.Visible = false;
                    this.btnSupprimerTache2.Visible = false;
                    this.lblPrenom.Text = "Absent";

                    frmReunionPopUp frm = new frmReunionPopUp();
                    frm.messagePopUp(perso.getPrenom());
                    frm.Show();

                }

                else if (perso.estDisponible() == false && perso.getMalade() == false)
                {

                    this.BackColor = Color.SpringGreen;
                    perso.setDisponible(true);
                }
                else
                {
                    this.Enabled = true;
                    this.BackColor = Color.AliceBlue;
                }

            }
            if (this.perso.getStress() == 100)
            {
                //this.setProductivite();
                this.Enabled = false;

            }
            copiFonc();


            lblAction1.Visible = true;
            this.reunion = false;

        }
        public void addNbrAction()
        {
            perso.setnbrActionFaite(perso.getnbrActionFaite() + 1);

        }

        public int getNbrAction()
        {
            return nbrActionFaite;
        }

        public void setPrenom(string prenom)
        {

            lblPrenom.Text = String.Empty;
            lblPrenom.Text = prenom;
            lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void setFatigue(int fatigue)
        {
            lblValFatigue.Text = String.Empty;
            lblValFatigue.Text = fatigue.ToString() + "   /100";
        }

        public void setAffinite(Personnage p)
        {
            if (p is null)
            {
                affinite.Text = " - ";
            }
            else
            {
                affinite.Text = p.getPrenom();
            }


        }

        /**
         * Modifie le label du personnage détesté 
         */
        public void setDeteste(Personnage p)
        {
            if (p is null)
            {
                lblDeteste.Text = " - ";

            }
            else
            {
                lblDeteste.Text = p.getPrenom();
            }

        }
        /** Modifie le label de compétences du personnage
         */
        public void setConnaissance(int connaissance)
        {
            lblValCompetence.Text = String.Empty;
            lblValCompetence.Text = connaissance.ToString() + "   /100";
        }

        /**
         * Modifie le label de stress du personnage
         */
        public void setStress(int stress)
        {
            lblValStress.Text = String.Empty;
            lblValStress.Text = stress.ToString() + "   /100";
        }

        /** 
         * Affichage des fonctionnalités
         */
        public void copiFonc()
        {
            cboFonctionnalite1.Items.Clear();

            cboFonctionnalite2.Items.Clear();
            for (int i = 0; i < listfonctionnalite.Count; i++)
            {
                Fonctionnalites f = (Fonctionnalites)listfonctionnalite[i];

                cboFonctionnalite1.Items.Add(f.getNom() + " (" + f.getNvConnaissNecces() + ")");
                cboFonctionnalite2.Items.Add(f.getNom() + " (" + f.getNvConnaissNecces() + ")");
                cboFonctionnalite3.Items.Add(f.getNom() + " (" + f.getNvConnaissNecces() + ")");

            }

        }

        int index = -1;

        /**
         * Remplir combobox
         */
        public void remplirComboBox(String action)
        {

            //si le crunch est activé ajouté la tache dans cette derniere sauf si il n'y a rien dans les combox box précédents
            //int index = 0;

            foreach (String s in cboFonctionnalite1.Items)
            {
                if (s == action)
                {
                    index = cboFonctionnalite1.Items.IndexOf(s);
                }
            }

            if (cboFonctionnalite1.SelectedIndex == -1 && reunion == false && cboFonctionnalite1.Visible != false)
            {
                cboFonctionnalite1.SelectedIndex = index;
            }
            else if (cboFonctionnalite2.SelectedIndex == -1)
            {
                cboFonctionnalite2.SelectedIndex = index;
            }
            else if (cboFonctionnalite3.Visible && cboFonctionnalite3.SelectedIndex == -1)
            {
                cboFonctionnalite3.SelectedIndex = index;
            }

        }




        /**
         * Active le crunch
         */
        public void crunchActive()
        {
            this.lblAction3.Visible = true;
            this.cboFonctionnalite3.Visible = true;
            this.btnSupprimerTache3.Visible = true;
        }

        /**
         * Crunch desactivé
         */
        public void crunchDesactive()
        {
            this.lblAction3.Visible = false;
            this.cboFonctionnalite3.Visible = false;
            this.btnSupprimerTache3.Visible = false;
        }

        /**
         * Affinités visibles
         */
        public void rendreAffinitesVisible()
        {
            affinite.Visible = true;
            pbCoeur.Visible = true;
            lblDeteste.Visible = true;
            pbCoeurNoir.Visible = true;
            pbClic.Visible = true;
            pnlClignotant.Visible = true;
            timerClignotant.Start();
        }

        /**
         * Rend les prénoms des user_Controls visibles
         */
        public void rendrePrenomsVisible()
        {
            lblPrenom.Visible = true;

        }

        /** 
         * Rend les attributs des personnages visibles
         */
        public void rendreAttributsVisible()
        {
            pbCacheur.Visible = false;
        }

        /**
         * Rend la CBO1 du user_Control visible
         */
        public void rendreCBO1Visible()
        {
            cboFonctionnalite1.Visible = false;
            lblAction1.Visible = false;
            btnSupprimerTache1.Visible = false;
        }

        /**
         * Rempli la liste des affinités
         */
        public void remplirListeAffinite()
        {
            //List<Fonctionnalites> listT = new List<Fonctionnalites>();

            this.perso.getTacheTour().Clear();
            //arrayliste des taches que le personnage va effectuer

            foreach (Fonctionnalites f in listfonctionnalite)
            {
                //MessageBox.Show(cboFonctionnalite1.Text);

                if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite1.Text)  // dans une cboFonctionnale on a "nom (NvConnaissNecces)"
                {
                    this.perso.getTacheTour().Add(f);
                }
                if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite2.Text)
                {
                    this.perso.getTacheTour().Add(f);
                }
                if (cboFonctionnalite3.Visible != false)  //si le crunch est activé alors ajouter une tache en plus
                {
                    if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite3.Text)
                    {
                        this.perso.getTacheTour().Add(f);
                    }
                }
            }



        }
        /**
         * Vide la liste des affinités
         */
        public void viderListeAffinite()
        {
            this.perso.viderTacheTour();
        }

        /**
         * Donne une tache au personnage selectionné
         */
        public void donnerTachePerso()
        {
            List<Fonctionnalites> listeTache = new List<Fonctionnalites>();

            //arrayliste des taches que le personnage va effectuer

            foreach (Fonctionnalites f in listfonctionnalite)
            {
                //MessageBox.Show(cboFonctionnalite1.Text);

                if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite1.Text)  // dans une cboFonctionnale on a "nom (NvConnaissNecces)"
                {
                    listeTache.Add(f);
                }
                if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite2.Text)
                {
                    listeTache.Add(f);
                }
                if (cboFonctionnalite3.Visible != false)  //si le crunch est activé alors ajouter une tache en plus
                {
                    if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite3.Text)
                    {
                        listeTache.Add(f);
                    }
                }
            }

            ControleurJeu.tache(this.perso, listeTache);
        }


        /**
         * Supprime la tâche 1
         */
        private void btnSupprimerTache1_Click(object sender, EventArgs e)
        {
            cboFonctionnalite1.Controls.Clear();
            cboFonctionnalite1.SelectedIndex = -1;
        }

        /** 
         * Supprimer la tâche 2
         */
        private void btnSupprimerTache2_Click(object sender, EventArgs e)
        {
            cboFonctionnalite2.Controls.Clear();
            cboFonctionnalite2.SelectedIndex = -1;
        }

        /**
         * Supprimer la tâche 3
         */
        private void btnSupprimerTache3_Click(object sender, EventArgs e)
        {
            cboFonctionnalite3.Controls.Clear();
            cboFonctionnalite3.SelectedIndex = -1;
        }

        /** Affiche les qualités et défauts
         */
        public void afficherQualiteDefaut()     //et point fort et point faible
        {
            /*
            lblQualite.Visible = true;
            lblDefaut.Visible = true;
            lblPointFaible.Visible = true;
            lblPointFort.Visible = true;
            */
        }

        /**
         * Affiche stat perso au clic sur leur photo
         */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            arreterClignotant();
            if (frmButReunion.getCompteurEquipe() >= 2)
            {
                frmStatPerso f = new frmStatPerso(this);
                f.Show();
            }
            else
            {
                frmReunionPopUp fm = new frmReunionPopUp();
                fm.messagePopUp("picturebox");
                fm.ShowDialog();
            }

        }

        /**
         * Retourne l'image du uc_Personnage
         */
        public Image getImagePerso()
        {
            return pictureBox1.Image;
        }

        /**
         * Timer clignotant
         */
        private void timerClignotant_Tick(object sender, EventArgs e)
        {
            if (pnlClignotant.BackColor == Color.Yellow)
            {
                pnlClignotant.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            }
            else
            {
                pnlClignotant.BackColor = Color.Yellow;
            }
        }

        /**
         * Arrête le clignotant
         */
        public void arreterClignotant()
        {
            timerClignotant.Stop();
            timerClignotant.Dispose();
            pnlClignotant.Visible = false;
            pbClic.Visible = false;

        }

        private void lblPointFort_Click(object sender, EventArgs e)
        {

        }
    }


}

