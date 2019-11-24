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

namespace Menu
{
    public partial class UC_Personnage : UserControl
    {

        ArrayList listfonctionnalite = ControleurJeu.getListeFonctionnalite();
        private Personnage perso { get; set; }


        public Personnage getPersonnage()
        {
            return this.perso;
        }

        public UC_Personnage()
        {
            InitializeComponent();
            

            /*cboAction1.Items.Clear();
            cboAction2.Items.Clear();
            cboAction3.Items.Clear();
            */
            cboFonctionnalite1.Items.Clear();
            cboFonctionnalite1.Items.Clear();
            cboFonctionnalite1.Items.Clear();

        }


        // Remise a zero des combobox
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
        public void initialisationUCPerso(Personnage p)
        {
            this.perso = p;
            this.setPrenom(perso.getPrenom());
            this.setProductivite(perso.getProductivite());
            this.setStress(perso.getStress());
            this.setFatigue(perso.getFatigue());
            this.setSociabilite(perso.getSociabilite());
            this.setConnaissances(perso.getConnaissances());

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
                    this.BackColor = Color.Coral;
                    perso.setMalade(false);
                    perso.setDisponible(true);
                }

                else if(perso.estDisponible() == false && perso.getMalade() == false)
                {
                    this.Enabled = false;
                    this.BackColor = Color.Blue;
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
        public void setConnaissances(int connaissance)
        {
            lblValConnaissance.Text = String.Empty;
            lblValConnaissance.Text = connaissance.ToString() + "   /100";
        }
        public void setSociabilite(int sociabilite)
        {
            lblValSociabilite.Text = String.Empty;
            lblValSociabilite.Text = sociabilite.ToString() + "   /100";
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

            if (cboFonctionnalite1.SelectedIndex == -1)
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
    }
    }

