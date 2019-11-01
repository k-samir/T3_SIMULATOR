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
            tabAction.Add("Conception");
            tabAction.Add("Développement");
            tabAction.Add("Recherche");


            for (int i = 0; i < tabAction.Count; i++)
            {
                cboAction1.Items.Add(tabAction[i]);
                cboAction2.Items.Add(tabAction[i]);
                cboAction3.Items.Add(tabAction[i]);
            }

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
            if (action == "Conception")
            {
                foreach (Fonctionnalites f in listfonctionnalite)
                {
                    if (f.getAction() == action)
                    {
                        b.Items.Add(f.getNom());
                    }
                }
            }
            if (action == "Développement")
            {
                foreach (Fonctionnalites f in listfonctionnalite)
                {
                    if (f.getAction() == action)
                    {
                        b.Items.Add(f.getNom());
                    }
                }
            }
            if (action == "Recherche")
            {
                foreach (Fonctionnalites f in listfonctionnalite)
                {
                    if (f.getAction() == action)
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
    }
}
