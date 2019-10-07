using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.classePersonnage;

namespace Menu
{
    public partial class frmJeu : Form
    {
        public frmJeu(Personnage p1, Personnage p2, Personnage p3, Personnage p4)
        {
            InitializeComponent();

            modifierUC(uC_Personnage1, p1.getPrenom(), p1.getProductivite(), p1.getStress(), p1.getSociabilite(),p1.getFatigue(),p1.getConnaissances());
            modifierUC(uC_Personnage2,p2.getPrenom(), p2.getProductivite(), p2.getStress(), p2.getSociabilite(), p2.getFatigue(), p2.getConnaissances());
            modifierUC(uC_Personnage3, p3.getPrenom(), p3.getProductivite(), p3.getStress(), p3.getSociabilite(), p3.getFatigue(), p3.getConnaissances());
            modifierUC(uC_Personnage4,p4.getPrenom(), p4.getProductivite(), p4.getStress(), p4.getSociabilite(), p4.getFatigue(), p4.getConnaissances());

        }
        
        public void modifierUC(UC_Personnage uC, string prenom, double productivite, int stress, int sociabilite,int fatigue, int connaissance)
        {
            uC.setPrenom(prenom);
            uC.setProductivite(productivite);
            uC.setStress(stress);
            uC.setSociabilite(sociabilite);
            uC.setFatigue(fatigue);
            uC.setConnaissance(connaissance);
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
            btnFleche.Location = new System.Drawing.Point(1223, 450);
            btnFleche.Text = ">";
        }
        public void cacherStatPerso()
        {
            panelStatPerso.Visible = false;
            btnFleche.Location = new System.Drawing.Point(1565, 455);
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
