using System;
using System.Collections.Generic;
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
        }

        public void setFatigue(int fatigue)
        {
            lblValFatigue.Text = String.Empty;
            lblValFatigue.Text = fatigue.ToString();
        }
        public void setProductivite(int productivite)
        {
            lblValProductivite.Text = String.Empty;
            lblValProductivite.Text = productivite.ToString();
        }
        public void setStress(int stress)
        {
            lblValStress.Text = String.Empty;
            lblValStress.Text = stress.ToString();
        }
        public void setConnaissance(int connaissance)
        {
            lblValConnaissance.Text = String.Empty;
            lblValConnaissance.Text = connaissance.ToString();
        }
        public void setSociabilite(int sociabilite)
        {
            lblValSociabilite.Text = String.Empty;
            lblValSociabilite.Text = sociabilite.ToString();
        }
    }
}
