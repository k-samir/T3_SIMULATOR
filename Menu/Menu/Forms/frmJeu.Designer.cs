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
            this.btnTourSuivant = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Personnage3 = new Menu.UC_Personnage();
            this.uC_Personnage4 = new Menu.UC_Personnage();
            this.uC_Personnage2 = new Menu.UC_Personnage();
            this.uC_Personnage1 = new Menu.UC_Personnage();
            this.btnRepos = new System.Windows.Forms.Button();
            this.pbAvancement = new System.Windows.Forms.ProgressBar();
            this.rtbActu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeadLine = new System.Windows.Forms.Label();
            this.btnCrunch = new System.Windows.Forms.Button();
            this.btnReunion = new System.Windows.Forms.Button();
            this.rtbListeF = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTourSuivant
            // 
            this.btnTourSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTourSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourSuivant.Location = new System.Drawing.Point(1637, 674);
            this.btnTourSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.btnTourSuivant.Name = "btnTourSuivant";
            this.btnTourSuivant.Size = new System.Drawing.Size(191, 54);
            this.btnTourSuivant.TabIndex = 7;
            this.btnTourSuivant.Text = "Tour Suivant";
            this.btnTourSuivant.UseVisualStyleBackColor = true;
            this.btnTourSuivant.Click += new System.EventHandler(this.btnTourSuivant_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(1637, 921);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(191, 54);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.uC_Personnage3);
            this.panel1.Controls.Add(this.uC_Personnage4);
            this.panel1.Controls.Add(this.uC_Personnage2);
            this.panel1.Controls.Add(this.uC_Personnage1);
            this.panel1.Location = new System.Drawing.Point(3, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1551, 897);
            this.panel1.TabIndex = 14;
            // 
            // uC_Personnage3
            // 
            this.uC_Personnage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage3.Location = new System.Drawing.Point(-3, 18);
            this.uC_Personnage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage3.Name = "uC_Personnage3";
            this.uC_Personnage3.Size = new System.Drawing.Size(769, 418);
            this.uC_Personnage3.TabIndex = 11;
            // 
            // uC_Personnage4
            // 
            this.uC_Personnage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage4.Location = new System.Drawing.Point(755, 454);
            this.uC_Personnage4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage4.Name = "uC_Personnage4";
            this.uC_Personnage4.Size = new System.Drawing.Size(775, 506);
            this.uC_Personnage4.TabIndex = 12;
            // 
            // uC_Personnage2
            // 
            this.uC_Personnage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage2.Location = new System.Drawing.Point(755, 18);
            this.uC_Personnage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage2.Name = "uC_Personnage2";
            this.uC_Personnage2.Size = new System.Drawing.Size(775, 418);
            this.uC_Personnage2.TabIndex = 10;
            // 
            // uC_Personnage1
            // 
            this.uC_Personnage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage1.Location = new System.Drawing.Point(-6, 454);
            this.uC_Personnage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage1.Name = "uC_Personnage1";
            this.uC_Personnage1.Size = new System.Drawing.Size(769, 608);
            this.uC_Personnage1.TabIndex = 9;
            // 
            // btnRepos
            // 
            this.btnRepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepos.Location = new System.Drawing.Point(1637, 859);
            this.btnRepos.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepos.Name = "btnRepos";
            this.btnRepos.Size = new System.Drawing.Size(191, 54);
            this.btnRepos.TabIndex = 15;
            this.btnRepos.Text = "Repos";
            this.btnRepos.UseVisualStyleBackColor = true;
            this.btnRepos.Click += new System.EventHandler(this.btnRepos_Click);
            // 
            // pbAvancement
            // 
            this.pbAvancement.Location = new System.Drawing.Point(15, 15);
            this.pbAvancement.Margin = new System.Windows.Forms.Padding(4);
            this.pbAvancement.Name = "pbAvancement";
            this.pbAvancement.Size = new System.Drawing.Size(1301, 43);
            this.pbAvancement.TabIndex = 1;
            this.pbAvancement.Value = 1;
            // 
            // rtbActu
            // 
            this.rtbActu.BackColor = System.Drawing.Color.White;
            this.rtbActu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbActu.ForeColor = System.Drawing.Color.Black;
            this.rtbActu.Location = new System.Drawing.Point(1561, 117);
            this.rtbActu.Margin = new System.Windows.Forms.Padding(4);
            this.rtbActu.Name = "rtbActu";
            this.rtbActu.Size = new System.Drawing.Size(336, 240);
            this.rtbActu.TabIndex = 16;
            this.rtbActu.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1609, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 53);
            this.label1.TabIndex = 17;
            this.label1.Text = "Actu Projet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeadLine
            // 
            this.lblDeadLine.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadLine.Location = new System.Drawing.Point(1324, 15);
            this.lblDeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadLine.Name = "lblDeadLine";
            this.lblDeadLine.Size = new System.Drawing.Size(229, 43);
            this.lblDeadLine.TabIndex = 18;
            this.lblDeadLine.Text = "% Avancement";
            this.lblDeadLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrunch
            // 
            this.btnCrunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrunch.Location = new System.Drawing.Point(1637, 798);
            this.btnCrunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrunch.Name = "btnCrunch";
            this.btnCrunch.Size = new System.Drawing.Size(191, 54);
            this.btnCrunch.TabIndex = 19;
            this.btnCrunch.Text = "Crunch";
            this.btnCrunch.UseVisualStyleBackColor = true;
            this.btnCrunch.Click += new System.EventHandler(this.btnCrunch_Click_1);
            // 
            // btnReunion
            // 
            this.btnReunion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.Location = new System.Drawing.Point(1637, 736);
            this.btnReunion.Margin = new System.Windows.Forms.Padding(4);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Size = new System.Drawing.Size(191, 54);
            this.btnReunion.TabIndex = 20;
            this.btnReunion.Text = "Réunion";
            this.btnReunion.UseVisualStyleBackColor = true;
            // 
            // rtbListeF
            // 
            this.rtbListeF.BackColor = System.Drawing.Color.White;
            this.rtbListeF.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListeF.ForeColor = System.Drawing.Color.Black;
            this.rtbListeF.Location = new System.Drawing.Point(1561, 379);
            this.rtbListeF.Margin = new System.Windows.Forms.Padding(4);
            this.rtbListeF.Name = "rtbListeF";
            this.rtbListeF.Size = new System.Drawing.Size(436, 240);
            this.rtbListeF.TabIndex = 21;
            this.rtbListeF.Text = "";
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1901, 1033);
            this.Controls.Add(this.rtbListeF);
            this.Controls.Add(this.btnReunion);
            this.Controls.Add(this.btnCrunch);
            this.Controls.Add(this.lblDeadLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbActu);
            this.Controls.Add(this.btnRepos);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTourSuivant);
            this.Controls.Add(this.pbAvancement);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJeu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTourSuivant;
        private System.Windows.Forms.Button btnQuitter;
        private UC_Personnage uC_Personnage1;
        private UC_Personnage uC_Personnage2;
        private UC_Personnage uC_Personnage3;
        private UC_Personnage uC_Personnage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRepos;
        private System.Windows.Forms.ProgressBar pbAvancement;
        private System.Windows.Forms.RichTextBox rtbActu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeadLine;
        private System.Windows.Forms.Button btnCrunch;
        private System.Windows.Forms.Button btnReunion;
        private System.Windows.Forms.RichTextBox rtbListeF;
    }
}