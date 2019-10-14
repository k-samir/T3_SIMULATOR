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
        public UC_Personnage()
        {
            InitializeComponent();

               ArrayList tabAction = new ArrayList();
               tabAction.Add("Réalisation");
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
            //this.setFatigue(0);
            this.setSociabilite(sociabilite);

            this.setConnaissance(connaissance);
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
    }
}
