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
        public FrmEnd()
        {

        }

        public FrmEnd(String s)
        {
            InitializeComponent();
            //bunifuCustomLabel1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu fm = new frmMenu();
            this.Dispose();
            fm.Show();
        }
    }
}
