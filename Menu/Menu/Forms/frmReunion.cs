using Menu.Classes;
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
    public partial class frmReunion : Form
    {
        private int nbReunion = 0;       //compteur de thématiques abordés durant la réunion, et si le nb égale à 3 alors on ne peut plus aborder de réunion
        public frmReunion()

        {
            InitializeComponent();
            update();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmButReunion fbr = new frmButReunion(this);
            fbr.themeReunion(button1.Text);     //pour faire passer un theme au formulaire frmbutreunion
            DialogResult dr = new DialogResult();
            dr = fbr.ShowDialog();
            if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            {
                this.Show();
                update();
            }

        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            frmButReunion fbr = new frmButReunion(this);
            fbr.themeReunion(button2.Text);     //pour faire passer un theme au formulaire frmbutreunion
            DialogResult dr = new DialogResult();
            dr = fbr.ShowDialog();
            if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            {
                this.Show();
                update();
            }

        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {

            frmButReunion fbr = new frmButReunion(this);
            fbr.themeReunion(button3.Text);     //pour faire passer un theme au formulaire frmbutreunion
            DialogResult dr = new DialogResult();
            dr = fbr.ShowDialog();
            if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            {
                this.Show();
                update();
            }
        }

        public void remettreCompteurAZero()
        {
            nbReunion = 0;
        }

        public void incrementerNbReunion()
        {
            nbReunion++;
        }

        public int getNbReunion()
        {
            return nbReunion;
        }

        public void update()
        {
            Boolean test1 = true;       //verifie que tous les thématiques des réunions de la catégorie "Découvir l'équipe" ont été faites
            Boolean test2 = true;       //verifie que tous les thématiques des réunions de la catégorie "Examiner le projet" ont été faites
            Boolean test3 = true;       //verifie que tous les thématiques des réunions de la catégorie "Faire le point" ont été faites


            foreach (Reunion r in ControleurJeu.getListeReunion())
            {
                if (r.getCategorie() == "Découvir l'équipe" && !(r.getStatut()))
                {
                    test1 = false;
                }
                if (r.getCategorie() == "Examiner le projet" && !(r.getStatut()))
                {
                    test2 = false;
                }
                if (r.getCategorie() == "Faire le point" && !(r.getStatut()))
                {
                    test3 = false;
                }
            }

            if (test1 || getNbReunion() >= 3)
            {
                button1.Enabled = false;
            }
            if (test2 || getNbReunion() >= 3)
            {
                button2.Enabled = false;
            }
            if (test3 || getNbReunion() >= 3)
            {
                button3.Enabled = false;
            }


            //verifie si un chef de projet a été designé pour pouvoir faire le point sur l'avancement du projet
            foreach (Reunion r in ControleurJeu.getListeReunion())
            {
                if (r.getStatut() == true && r.getThemeReunion() == "Mettre en place un système d'organisation")
                {
                    button3.Visible = true;     //si un système d'organisation a été mis en place et qu'un chef de groupe a été désigné alors on peut désormais faire le point;
                }
            }
        }
    }
}
