    using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class UC_Personnage : UserControl
    {

        /*variable global
        public ArrayList liste_fonctionnalites_Recherche = new ArrayList();
        public void remplirRecherche() {
            liste_fonctionnalites_Recherche.Add("Recherche dans Cahier des Charges");
            liste_fonctionnalites_Recherche.Add("Recherche Objectifs Pédagogiques");
            liste_fonctionnalites_Recherche.Add("Recherche code");
        }

        public ArrayList liste_fonctionnalites_Developpement = new ArrayList();
        public void remplirDeveloppement() {
            liste_fonctionnalites_Developpement.Add("1");
            liste_fonctionnalites_Developpement.Add("2");
            liste_fonctionnalites_Developpement.Add("3");

        }
        public ArrayList liste_fonctionnalites_Conception = new ArrayList();
        public void remplirConception() {
            liste_fonctionnalites_Conception.Add("4");
            liste_fonctionnalites_Conception.Add("5");
            liste_fonctionnalites_Conception.Add("6");
        }
        */
        public UC_Personnage()
        {
            InitializeComponent();

               ArrayList tabAction = new ArrayList();
               tabAction.Add("Conception");
               tabAction.Add("Développement");
               tabAction.Add("Recherche");

               

               for(int i=0; i<tabAction.Count; i++)
               {
                   cboAction1.Items.Add(tabAction[i]);
                   cboAction2.Items.Add(tabAction[i]);
                   cboAction3.Items.Add(tabAction[i]);
               }
               

        }

        public UC_Personnage(string prenom, double productivite, int stress, int sociabilite,int connaissance)
        {
            this.setPrenom(prenom);
            this.setProductivite(productivite);
            this.setStress(stress);
            this.setFatigue(0);
            this.setSociabilite(sociabilite);

            this.setConnaissance(connaissance);

            //remplirConception();
            //remplirDeveloppement();
            //remplirRecherche();
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
        public void setConnaissance(int connaissance)
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
            //cboFonctionnalite1.Items.Clear();

            String action = cboAction1.Text;
            MessageBox.Show(action);
            if (action == "Conception")
            {
                cboFonctionnalite1.Items.Clear();
                cboFonctionnalite1.Items.Add("CC1");
                cboFonctionnalite1.Items.Add("CC2");
                cboFonctionnalite1.Items.Add("CC3");

                /*for (int i = 0; i < liste_fonctionnalites_Conception.Count; i++)
                {
                    MessageBox.Show(liste_fonctionnalites_Conception[i].ToString());
                    cboFonctionnalite1.Items.Add(liste_fonctionnalites_Conception[i]);
                }*/
            }
            if (action == "Développement")
            {
                cboFonctionnalite1.Items.Clear();
                cboFonctionnalite1.Items.Add("DD1");
                cboFonctionnalite1.Items.Add("DD2");
                cboFonctionnalite1.Items.Add("DD3");
                /*for (int i = 0; i < liste_fonctionnalites_Developpement.Count; i++)
                {
                    cboFonctionnalite1.Items.Add(liste_fonctionnalites_Developpement[i]);
                }*/
            }
            if (action == "Recherche")
            {
                cboFonctionnalite1.Items.Clear();
                cboFonctionnalite1.Items.Add("Recherche dans Cahier des Charges");
                cboFonctionnalite1.Items.Add("Recherche Objectifs Pédagogiques");
                cboFonctionnalite1.Items.Add("Recherche code");
                /*for (int i = 0; i < liste_fonctionnalites_Recherche.Count; i++)
                {
                    cboFonctionnalite1.Items.Add(liste_fonctionnalites_Recherche[i]);
                }*/
            }
        }
    }
}
