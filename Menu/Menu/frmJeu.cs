using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmJeu : Form
    {
        public frmJeu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        public String recupTxtFichier(String nomFichier, String typeFichier)
        {
            String texte = System.IO.File.ReadAllText(@"C:\Users\tieut\myt3\Menu\Menu\"+nomFichier+"."+typeFichier);
            return texte;
        }

        public void afficherStatPerso()
        {
            panelStatPerso.Visible = true;
            btnFleche.Location = new System.Drawing.Point(1227, 452);
            btnFleche.Text = " > ";
        }
        public void cacherStatPerso()
        {
            panelStatPerso.Visible = false;
            btnFleche.Location = new System.Drawing.Point(1577, 455);
            btnFleche.Text = "<";
        }


        private void btnFleche_Click(object sender, EventArgs e)
        {
            if (btnFleche.Text.ToString() == ">")
            {
                cacherStatPerso();
            }
            else
            {
                afficherStatPerso();
            }
        }

        private void btnTourSuivant_Click(object sender, EventArgs e)
        {
            
        }
    }
}
