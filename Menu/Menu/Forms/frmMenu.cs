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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            //lancer formulaire pour lancer le jeu
            frmJeu jeu = new frmJeu();
            this.Hide();
            jeu.Show();
        }

        private void btnCommencer_MouseEnter(object sender, EventArgs e)
        {
            btnCommencer.BackColor = Color.DarkGray;
            btnCommencer.Size = new System.Drawing.Size(240, 78);
            btnCommencer.Margin = new System.Windows.Forms.Padding(0);
        }

        private void btnCommencer_MouseLeave(object sender, EventArgs e)
        {
            btnCommencer.BackColor = System.Drawing.Color.Transparent;
            btnCommencer.Size = new System.Drawing.Size(200, 68);
            btnCommencer.Margin = new System.Windows.Forms.Padding(6);
        }

        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.DarkGray;
            btnQuitter.Size = new System.Drawing.Size(240, 78);
            btnQuitter.Margin = new System.Windows.Forms.Padding(0);
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.BackColor = System.Drawing.Color.Transparent;
            btnQuitter.Size = new System.Drawing.Size(200, 70);
            btnQuitter.Margin = new System.Windows.Forms.Padding(6);
        }
    }
}
