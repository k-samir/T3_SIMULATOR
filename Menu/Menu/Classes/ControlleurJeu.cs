﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class ControleurJeu
    {
        public Projet Projet
        {
            get => default;
            set
            {
            }
        }

        public void lancerJeu(frmMenu f)
        {
            frmJeu jeu = new frmJeu();
            f.Hide();
            jeu.Show();
            
            //throw new System.NotImplementedException();
        }


        public void arreterJeu()
        {
            throw new System.NotImplementedException();
        }

        public void nouveauTour()
        {

            throw new System.NotImplementedException();
        }
    }
}