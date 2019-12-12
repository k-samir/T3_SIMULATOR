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

        public Personnage getPersonnage()
        {
            return this.perso;
        }

        public void rendreInvisibleTacheMatin()
        {
            lblAction1.Visible = false;
            btnSupprimerTache1.Visible = false;
            cboFonctionnalite1.Visible = false;
            this.reunion = true;
            
        }

        public UC_Personnage()
        {
            InitializeComponent();


            cboFonctionnalite1.Items.Clear();
            cboFonctionnalite1.Items.Clear();
            cboFonctionnalite1.Items.Clear();

        }


        // Remise à zero des combobox
        public void cleanCBO()
        {
            cboFonctionnalite1.Controls.Clear();
            cboFonctionnalite1.SelectedIndex = -1;
            cboFonctionnalite2.Controls.Clear();
            cboFonctionnalite2.SelectedIndex = -1;
            cboFonctionnalite3.Controls.Clear();
            cboFonctionnalite3.SelectedIndex = -1;
        }

        public void viderCBO()
        {
            listfonctionnalite.Clear();

        }
        public void initialisationUCPerso(Personnage p, Image img)
        {
            this.perso = p;
            this.pictureBox1.Image = img;

            ArrayList qualite = p.getQualite();
            ArrayList defaut = p.getDefaut();
            ArrayList pointFort = p.getPointFort();
            ArrayList pointFaible = p.getPointFaible();

            lblQualite.Text = (String)qualite[0];
            lblDefaut.Text = (String)defaut[0];
            lblPointFort.Text = (String)pointFort[0];
            lblPointFaible.Text = (String)pointFaible[0];

            this.setPrenom(perso.getPrenom());
            this.setProductivite(perso.getProductivite());
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
        public void setProductivite(double productivite)
        {
            lblValProductivite.Text = String.Empty;
            lblValProductivite.Text = productivite.ToString() + "   /5";
        }
        public void setStress(int stress)
        {
            lblValStress.Text = String.Empty;
            lblValStress.Text = stress.ToString() + "   /100";
        }

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

            if (cboFonctionnalite1.SelectedIndex == -1 && reunion == false && cboFonctionnalite1.Visible!=false)
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



        public void recherche(Personnage perso)
        {
            perso.setConnaissances(perso.getConnaissances() + 10);
        }

        public void crunchActive()
        {
            this.lblAction3.Visible = true;
            this.cboFonctionnalite3.Visible = true;
            this.btnSupprimerTache3.Visible = true;
        }

        public void crunchDesactive()
        {
            this.lblAction3.Visible = false;
            this.cboFonctionnalite3.Visible = false;
            this.btnSupprimerTache3.Visible = false;
        }

        public void rendreAffinitesVisible()
        {
            affinite.Visible = true;
            pbCoeur.Visible = true;
            lblDeteste.Visible = true;
            pbCoeurNoir.Visible = true;
        }

        public void rendrePrenomsVisible()
        {
            lblPrenom.Visible = true;
        }

        public void rendreAttributsVisible()
        {
            pbCacheur.Visible = false;
        }

        public void rendreCBO1Visible()
        {
            cboFonctionnalite1.Visible = false;
            lblAction1.Visible = false;
            btnSupprimerTache1.Visible = false;
        }



        public void donnerTachePerso()
        {
            List<Fonctionnalites> listeTache = new List<Fonctionnalites>();

            //arrayliste des taches que le personnage va effectuer

            foreach (Fonctionnalites f in listfonctionnalite)
            {
                //MessageBox.Show(cboFonctionnalite1.Text);

                if (f.getNom() + " (" + f.getNvConnaissNecces() + ")" == cboFonctionnalite1.Text )  // dans une cboFonctionnale on a "nom (NvConnaissNecces)"
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

        private void btnSupprimerTache1_Click(object sender, EventArgs e)
        {
            cboFonctionnalite1.Controls.Clear();
            cboFonctionnalite1.SelectedIndex = -1;
        }

        private void btnSupprimerTache2_Click(object sender, EventArgs e)
        {
            cboFonctionnalite2.Controls.Clear();
            cboFonctionnalite2.SelectedIndex = -1;
        }

        private void btnSupprimerTache3_Click(object sender, EventArgs e)
        {
            cboFonctionnalite3.Controls.Clear();
            cboFonctionnalite3.SelectedIndex = -1;
        }

        public void afficherQualiteDefaut()     //et point fort et point faible
        {
            lblQualite.Visible = true;
            lblDefaut.Visible = true;
            lblPointFaible.Visible = true;
            lblPointFort.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        public Image getImagePerso()
        {
            return pictureBox1.Image;
        }
    }
}

