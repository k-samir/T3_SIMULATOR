namespace Menu
{
    partial class frmJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAvancement = new System.Windows.Forms.ProgressBar();
            this.panelStatPerso = new System.Windows.Forms.Panel();
            this.lblStatPerso = new System.Windows.Forms.Label();
            this.btnTourSuivant = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnFleche = new System.Windows.Forms.Button();
            this.uC_Personnage4 = new Menu.UC_Personnage();
            this.uC_Personnage3 = new Menu.UC_Personnage();
            this.uC_Personnage2 = new Menu.UC_Personnage();
            this.uC_Personnage1 = new Menu.UC_Personnage();
            this.panelStatPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAvancement
            // 
            this.pbAvancement.Location = new System.Drawing.Point(33, 12);
            this.pbAvancement.Name = "pbAvancement";
            this.pbAvancement.Size = new System.Drawing.Size(1049, 35);
            this.pbAvancement.TabIndex = 1;
            this.pbAvancement.Value = 1;
            // 
            // panelStatPerso
            // 
            this.panelStatPerso.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelStatPerso.Controls.Add(this.lblStatPerso);
            this.panelStatPerso.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStatPerso.Location = new System.Drawing.Point(1261, 0);
            this.panelStatPerso.Name = "panelStatPerso";
            this.panelStatPerso.Size = new System.Drawing.Size(343, 881);
            this.panelStatPerso.TabIndex = 6;
            // 
            // lblStatPerso
            // 
            this.lblStatPerso.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatPerso.Location = new System.Drawing.Point(73, 12);
            this.lblStatPerso.Name = "lblStatPerso";
            this.lblStatPerso.Size = new System.Drawing.Size(217, 76);
            this.lblStatPerso.TabIndex = 0;
            this.lblStatPerso.Text = "Stat Perso";
            this.lblStatPerso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTourSuivant
            // 
            this.btnTourSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTourSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourSuivant.Location = new System.Drawing.Point(1095, 724);
            this.btnTourSuivant.Name = "btnTourSuivant";
            this.btnTourSuivant.Size = new System.Drawing.Size(143, 44);
            this.btnTourSuivant.TabIndex = 7;
            this.btnTourSuivant.Text = "Tour Suivant";
            this.btnTourSuivant.UseVisualStyleBackColor = true;
            this.btnTourSuivant.Click += new System.EventHandler(this.btnTourSuivant_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(1095, 784);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 44);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnFleche
            // 
            this.btnFleche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFleche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFleche.Location = new System.Drawing.Point(1223, 450);
            this.btnFleche.Name = "btnFleche";
            this.btnFleche.Size = new System.Drawing.Size(35, 32);
            this.btnFleche.TabIndex = 13;
            this.btnFleche.Text = ">";
            this.btnFleche.UseVisualStyleBackColor = true;
            this.btnFleche.Click += new System.EventHandler(this.btnFleche_Click);
            // 
            // uC_Personnage4
            // 
            this.uC_Personnage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage4.Location = new System.Drawing.Point(607, 473);
            this.uC_Personnage4.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage4.Name = "uC_Personnage4";
            this.uC_Personnage4.Size = new System.Drawing.Size(442, 355);
            this.uC_Personnage4.TabIndex = 12;
            // 
            // uC_Personnage3
            // 
            this.uC_Personnage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage3.Location = new System.Drawing.Point(58, 473);
            this.uC_Personnage3.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage3.Name = "uC_Personnage3";
            this.uC_Personnage3.Size = new System.Drawing.Size(442, 355);
            this.uC_Personnage3.TabIndex = 11;
            // 
            // uC_Personnage2
            // 
            this.uC_Personnage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage2.Location = new System.Drawing.Point(607, 86);
            this.uC_Personnage2.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage2.Name = "uC_Personnage2";
            this.uC_Personnage2.Size = new System.Drawing.Size(442, 355);
            this.uC_Personnage2.TabIndex = 10;
            // 
            // uC_Personnage1
            // 
            this.uC_Personnage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage1.Location = new System.Drawing.Point(58, 86);
            this.uC_Personnage1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage1.Name = "uC_Personnage1";
            this.uC_Personnage1.Size = new System.Drawing.Size(442, 355);
            this.uC_Personnage1.TabIndex = 9;
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.btnFleche);
            this.Controls.Add(this.uC_Personnage4);
            this.Controls.Add(this.uC_Personnage3);
            this.Controls.Add(this.uC_Personnage2);
            this.Controls.Add(this.uC_Personnage1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTourSuivant);
            this.Controls.Add(this.panelStatPerso);
            this.Controls.Add(this.pbAvancement);
            this.Name = "frmJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJeu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelStatPerso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbAvancement;
        private System.Windows.Forms.Panel panelStatPerso;
        private System.Windows.Forms.Label lblStatPerso;
        private System.Windows.Forms.Button btnTourSuivant;
        private System.Windows.Forms.Button btnQuitter;
        private UC_Personnage uC_Personnage1;
        private UC_Personnage uC_Personnage2;
        private UC_Personnage uC_Personnage3;
        private UC_Personnage uC_Personnage4;
        private System.Windows.Forms.Button btnFleche;
    }
}