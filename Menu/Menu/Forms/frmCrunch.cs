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
    public partial class frmCrunch : Form
    {
        /**
         * Initialise les composants
         */
        public frmCrunch()
        {
            InitializeComponent();
        }

        /**
         * Valider le crunch
         */

        private void btnValiderCrunch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /**
         * Annuler et revenir en arrière
         */
        private void btnAnnulerCrunch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
