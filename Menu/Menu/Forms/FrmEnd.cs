using System;
using System.Collections;
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
    public partial class FrmEnd : Form
    {
        private string s = "";

        
        /**
         * Affiche le rapport journalier
         */
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmRapportJournalier rapport = new frmRapportJournalier(s);
           
            rapport.Show();
            //this.Hide();

        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        public FrmEnd()
        {

        }
        /**
         * Constructeur du formulaire de fin
         */
        public FrmEnd(String si, ArrayList li,float avancement,int score)
        {
            int avanc = (int)avancement;
            InitializeComponent();
            //bunifuCustomLabel1.Text = s;
            s = si;
            //MessageBox.Show(li.Count.ToString());
            foreach (Fonctionnalites f in li)
            {
                listBox1.Items.Add(f.getNom());
                //MessageBox.Show(f.getNom());
            }
            if (avanc != 0) {
                bunifuGauge1.Value = avanc;
            }
            else
            {
                bunifuGauge1.Value = avanc;
            }
            //listeFonctionNonCode = li;
            
            if(avanc >= 99)
            {
                bunifuGauge1.Value = 100;
                label3.Text = "Vous avez Gagné ! Score :" + score;
            }
            else
            {
                label3.Text += score;
            }

        }

        /**
         * Créé un nouveau frmMenu
         */
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmMenu fm = new frmMenu();
            this.Dispose();
            fm.Show();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
