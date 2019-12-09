using Menu.classePersonnage;
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
    public partial class frmStatPerso : Form
    {
        public frmStatPerso(UC_Personnage up)
        {
            InitializeComponent();

            pbPerso.Image = up.getImagePerso();

            Personnage p = up.getPersonnage();

            lblPrenomPerso.Text = p.getPrenom();

            pbFatigue.Value = p.getFatigue();
            if (pbFatigue.Value <= 45)
            {
                pbFatigue.ProgressColor = Color.Green;
            }
            if (pbFatigue.Value > 45 && pbFatigue.Value <= 75)
            {
                pbFatigue.ProgressColor = Color.Orange;
            }
            if(pbFatigue.Value > 75)
            {
                pbFatigue.ProgressColor = Color.Red;
            }

            pbProductivite.Value = (int)p.getProductivite() * 5;
            if (pbProductivite.Value <= 45)
            {
                pbProductivite.ProgressColor = Color.Green;
            }
            if (pbProductivite.Value > 45 && pbProductivite.Value <= 75)
            {
                pbProductivite.ProgressColor = Color.Orange;
            }
            if (pbProductivite.Value > 75)
            {
                pbProductivite.ProgressColor = Color.Red;
            }

            pbStress.Value = p.getStress();
            if (pbStress.Value <= 45)
            {
                pbStress.ProgressColor = Color.Green;
            }
            if (pbStress.Value > 45 && pbStress.Value <= 75)
            {
                pbStress.ProgressColor = Color.Orange;
            }
            if (pbStress.Value > 75)
            {
                pbStress.ProgressColor = Color.Red;
            }

            if(p.getAffinite() == null)
            {
                lblAffinite.Text = "Affinité avec personne";
            }
            else
            {
                lblAffinite.Text = "Affinité avec " + p.getAffinite().getPrenom();
            }


            if (p.getDeteste() == null)
            {
                lblDeteste.Text = "Ne déteste personne";
            }
            else
            {
                lblDeteste.Text = "Déteste "+p.getDeteste().getPrenom();
            }


           
            
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
