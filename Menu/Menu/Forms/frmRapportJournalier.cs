﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Menu
{
    public partial class frmRapportJournalier : Form
    {

        /**
         * Constructeur du frmRapportJournalier
         */
        public frmRapportJournalier(string s)
        {
            
            InitializeComponent();

            bunifuCustomLabel1.Text = s;
            
            
            
            
            /*journalier = s;
            MessageBox.Show(journalier);*/
        }
        
        /**
         * Dispose
         */
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
