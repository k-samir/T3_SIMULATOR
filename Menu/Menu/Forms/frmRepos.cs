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

namespace Menu.Forms
{
    public partial class frmRepos : Form
    {
        List<Personnage> list_perso = new List<Personnage>();
        private static List<Personnage> list_repos = new List<Personnage>();
        private frmJeu frmJ;
        public frmRepos(List<Personnage> listePersonnage, frmJeu frmParent)
        {
            
            InitializeComponent();
            list_perso = listePersonnage;
            this.frmJ = frmParent;
            
        }

        private void Repos_Load(object sender, EventArgs e)
        {
            foreach (Personnage p in list_perso)
            {
                lstGauche.Items.Add(p.getPrenom());
            }
        }

        private void btnGD_Click(object sender, EventArgs e)
        {
            if (lstGauche.Items.Count > 0 && lstGauche.SelectedItems.Count > 0)
            {
                lstDroite.Items.Add(lstGauche.SelectedItem);
                lstGauche.Items.Remove(lstGauche.SelectedItem);
            }
            else
            {
                
            }

        }

        private void btnDG_Click(object sender, EventArgs e)
        {
            if (lstDroite.Items.Count > 0 && lstDroite.SelectedItems.Count > 0)
            {
                lstGauche.Items.Add(lstDroite.SelectedItem);
                lstDroite.Items.Remove(lstDroite.SelectedItem);
            }
            else
            {
                
            }
        }

        private void btnTGD_Click(object sender, EventArgs e)
        {
            lstDroite.Items.AddRange(lstGauche.Items);
            lstGauche.Items.Clear();
        }

        private void btnTDG_Click(object sender, EventArgs e)
        {
            lstGauche.Items.AddRange(lstDroite.Items);
            lstDroite.Items.Clear();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            for(int i=0; i<lstDroite.Items.Count; i++)
            {
                //list_repos.Add(lstDroite.Items[i].ToString());

                foreach (Personnage p in list_perso)
                {
                    if (p.getPrenom() == (string)lstDroite.Items[i])
                    {
                        frmJ.setRepos(p);
                    }
                }


               
            }
            list_repos.Clear();


            this.Close();
        }

    }
}
