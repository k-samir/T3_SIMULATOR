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
    public partial class FrmEnd : Form
    {
        private string s = "";

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s);
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

        public FrmEnd(String si)
        {
            InitializeComponent();
            //bunifuCustomLabel1.Text = s;
            s = si;


        }

    
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmMenu fm = new frmMenu();
            this.Dispose();
            fm.Show();
        }
    }
}
