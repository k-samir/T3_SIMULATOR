﻿using Menu.Classes;
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
        public frmReunion()
        {
            InitializeComponent();
            foreach (Reunion r in ControleurJeu.getListeReunion())
            {
                if (r.getStatut() && r.getThemeReunion() == "Mettre en place un système d'organisation")
                {
                    button3.Visible = true;     //si un système d'organisation a été mis en place et qu'un chef de groupe a été désigné alors on peut désormais faire le point
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmButReunion fbr = new frmButReunion();
            //this.Hide();
            fbr.themeReunion(button1.Text);     //pour faire passer un theme au formulaire frmbutreunion
            DialogResult dr = new DialogResult();
            dr=fbr.ShowDialog();
            if(dr==DialogResult.Cancel || dr==DialogResult.OK)
            {
                this.Show();
            }
            
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            frmButReunion fbr = new frmButReunion();
           // this.Hide();
            fbr.themeReunion(button2.Text);     //pour faire passer un theme au formulaire frmbutreunion
            DialogResult dr = new DialogResult();
            dr = fbr.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }

        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            frmButReunion fbr = new frmButReunion();
          //  this.Hide();
            fbr.themeReunion(button3.Text);         //pour faire passer un theme au formulaire frmbutreunion
            DialogResult dr = new DialogResult();
            dr = fbr.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void frmReunion_Load(object sender, EventArgs e)
        {

        }
    }
}
