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

        public FrmEnd(String si, ArrayList li,float avancement)
        {
            InitializeComponent();
            //bunifuCustomLabel1.Text = s;
            s = si;
            //MessageBox.Show(li.Count.ToString());
            foreach (Fonctionnalites f in li)
            {
                listBox1.Items.Add(f.getNom());
                //MessageBox.Show(f.getNom());
            }
            if (avancement != 0) {
                bunifuGauge1.Value = (int)avancement + 1;
            }
            else
            {
                bunifuGauge1.Value = (int)avancement;
            }
            //listeFonctionNonCode = li;


        }

    
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
