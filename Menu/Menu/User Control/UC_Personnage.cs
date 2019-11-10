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


        public UC_Personnage()
        {
            InitializeComponent();

            ArrayList tabAction = new ArrayList();
            tabAction.Add("Concevoir");
            tabAction.Add("Développer");
            tabAction.Add("Rechercher");


            for (int i = 0; i < tabAction.Count; i++)
            {
                cboAction1.Items.Add(tabAction[i]);
                cboAction2.Items.Add(tabAction[i]);
                cboAction3.Items.Add(tabAction[i]);
            }

        }


        // Remise a zero des combobox
        public void cleanCBO()
        {
            cboAction1.Text = "";
            cboAction2.Text = "";
            cboAction3.Text = "";

            cboFonctionnalite1.Text = "";
            cboFonctionnalite2.Text = "";
            cboFonctionnalite3.Text = "";


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
                this.Enabled = true;
            }
            if (this.perso.getStress() == 100)
            {
                //this.setProductivite();
                this.Enabled = false;
            }


        
            
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

        private void cboAction1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirComboBox(cboAction1.Text, cboFonctionnalite1);
        }


        public void remplirComboBox(String action, ComboBox b)
        {

            b.Items.Clear();
            foreach (Fonctionnalites f in listfonctionnalite)
            {
                if (f.getType() == action)
                {
                    if(f.getPaDepense() < f.getPaNecess() && f.getStatus() == false)
                    {
                        b.Items.Add(f.getNom());
                    }
                    
                }
            }
        }

        private void cboAction2_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirComboBox(cboAction2.Text, cboFonctionnalite2);
        }

        private void cboAction3_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirComboBox(cboAction3.Text, cboFonctionnalite3);
        }


        public void recherche(Personnage perso)
        {
            perso.setConnaissances(perso.getConnaissances() + 10);
        }

        public void crunchActive()
        {
            this.lblAction3.Visible = true;
            this.cboAction3.Visible = true;
            this.cboFonctionnalite3.Visible = true;

        }

        public void crunchDesactive()
        {
            this.lblAction3.Visible = false;
            this.cboAction3.Visible = false;
            this.cboFonctionnalite3.Visible = false;
        }

        
     
        public void donnerTachePerso()
        {
            List<Fonctionnalites> listeTache = new List<Fonctionnalites>();
            
               //arrayliste des taches que le personnage va effectuer
            
                foreach(Fonctionnalites f in listfonctionnalite)
                {
                    //MessageBox.Show(cboFonctionnalite1.Text);

                    if(f.getNom()==cboFonctionnalite1.Text)
                    {
                        listeTache.Add(f); 
                    }
                    if (f.getNom() == cboFonctionnalite2.Text)
                    {
                        listeTache.Add(f);
                    }
                    if (cboFonctionnalite3.Visible == false)  //si le crunch est activé alors ajouter une tache en plus
                    {
                        if (f.getNom() == cboFonctionnalite3.Text)
                        {
                            listeTache.Add(f);
                        }
                    }
                }
            
                ControleurJeu.tache(this.perso, listeTache);
            
            
        }

        

    }
}
