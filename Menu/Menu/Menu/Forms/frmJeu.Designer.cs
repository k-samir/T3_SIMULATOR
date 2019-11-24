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
            this.btnVider = new System.Windows.Forms.Button();
            this.lblLstTache = new System.Windows.Forms.Label();
            this.lstTache = new System.Windows.Forms.ListBox();
            this.btnRepos = new System.Windows.Forms.Button();
            this.rtbActu = new System.Windows.Forms.RichTextBox();
            this.lblActu = new System.Windows.Forms.Label();
            this.btnCrunch = new System.Windows.Forms.Button();
            this.btnReunion = new System.Windows.Forms.Button();
            this.rtbListeF = new System.Windows.Forms.RichTextBox();
            this.uC_Personnage3 = new Menu.UC_Personnage();
            this.uC_Personnage4 = new Menu.UC_Personnage();
            this.uC_Personnage2 = new Menu.UC_Personnage();
            this.uC_Personnage1 = new Menu.UC_Personnage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTourSuivant
            // 
            this.btnTourSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTourSuivant.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourSuivant.Location = new System.Drawing.Point(1240, 548);
            this.btnTourSuivant.Name = "btnTourSuivant";
            this.btnTourSuivant.Size = new System.Drawing.Size(168, 44);
            this.btnTourSuivant.TabIndex = 7;
            this.btnTourSuivant.Text = "Tour Suivant";
            this.btnTourSuivant.UseVisualStyleBackColor = true;
            this.btnTourSuivant.Click += new System.EventHandler(this.btnTourSuivant_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(1240, 748);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(168, 44);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnVider);
            this.panel1.Controls.Add(this.lblLstTache);
            this.panel1.Controls.Add(this.lstTache);
            this.panel1.Controls.Add(this.uC_Personnage3);
            this.panel1.Controls.Add(this.uC_Personnage4);
            this.panel1.Controls.Add(this.uC_Personnage2);
            this.panel1.Controls.Add(this.uC_Personnage1);
            this.panel1.Location = new System.Drawing.Point(2, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 731);
            this.panel1.TabIndex = 14;
            // 
            // btnVider
            // 
            this.btnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVider.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.Location = new System.Drawing.Point(981, 524);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(201, 44);
            this.btnVider.TabIndex = 22;
            this.btnVider.Text = "Annuler tout";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblLstTache
            // 
            this.lblLstTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLstTache.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLstTache.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLstTache.Location = new System.Drawing.Point(945, 143);
            this.lblLstTache.Name = "lblLstTache";
            this.lblLstTache.Size = new System.Drawing.Size(276, 30);
            this.lblLstTache.TabIndex = 22;
            this.lblLstTache.Text = "Tâches à glisser/déposer";
            this.lblLstTache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTache
            // 
            this.lstTache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstTache.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTache.FormattingEnabled = true;
            this.lstTache.ItemHeight = 21;
            this.lstTache.Location = new System.Drawing.Point(945, 176);
            this.lstTache.Name = "lstTache";
            this.lstTache.Size = new System.Drawing.Size(273, 319);
            this.lstTache.TabIndex = 13;
            this.lstTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstTache_MouseDown);
            // 
            // btnRepos
            // 
            this.btnRepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepos.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepos.Location = new System.Drawing.Point(1240, 698);
            this.btnRepos.Name = "btnRepos";
            this.btnRepos.Size = new System.Drawing.Size(168, 44);
            this.btnRepos.TabIndex = 15;
            this.btnRepos.Text = "Repos";
            this.btnRepos.UseVisualStyleBackColor = true;
            this.btnRepos.Click += new System.EventHandler(this.btnRepos_Click);
            // 
            // rtbActu
            // 
            this.rtbActu.BackColor = System.Drawing.Color.White;
            this.rtbActu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbActu.ForeColor = System.Drawing.Color.Black;
            this.rtbActu.Location = new System.Drawing.Point(1228, 63);
            this.rtbActu.Name = "rtbActu";
            this.rtbActu.Size = new System.Drawing.Size(215, 196);
            this.rtbActu.TabIndex = 16;
            this.rtbActu.Text = "";
            // 
            // lblActu
            // 
            this.lblActu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblActu.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActu.Location = new System.Drawing.Point(1247, 30);
            this.lblActu.Name = "lblActu";
            this.lblActu.Size = new System.Drawing.Size(196, 30);
            this.lblActu.TabIndex = 17;
            this.lblActu.Text = "Actu Projet";
            this.lblActu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrunch
            // 
            this.btnCrunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrunch.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrunch.Location = new System.Drawing.Point(1240, 648);
            this.btnCrunch.Name = "btnCrunch";
            this.btnCrunch.Size = new System.Drawing.Size(168, 44);
            this.btnCrunch.TabIndex = 19;
            this.btnCrunch.Text = "Crunch";
            this.btnCrunch.UseVisualStyleBackColor = true;
            this.btnCrunch.Click += new System.EventHandler(this.btnCrunch_Click_1);
            // 
            // btnReunion
            // 
            this.btnReunion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReunion.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.Location = new System.Drawing.Point(1240, 598);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Size = new System.Drawing.Size(168, 44);
            this.btnReunion.TabIndex = 20;
            this.btnReunion.Text = "Réunion";
            this.btnReunion.UseVisualStyleBackColor = true;
            this.btnReunion.Click += new System.EventHandler(this.btnReunion_Click);
            // 
            // rtbListeF
            // 
            this.rtbListeF.BackColor = System.Drawing.Color.White;
            this.rtbListeF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListeF.ForeColor = System.Drawing.Color.Black;
            this.rtbListeF.Location = new System.Drawing.Point(1228, 276);
            this.rtbListeF.Name = "rtbListeF";
            this.rtbListeF.ReadOnly = true;
            this.rtbListeF.Size = new System.Drawing.Size(213, 245);
            this.rtbListeF.TabIndex = 21;
            this.rtbListeF.Text = "";
            // 
            // uC_Personnage3
            // 
            this.uC_Personnage3.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage3.Location = new System.Drawing.Point(6, 15);
            this.uC_Personnage3.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage3.Name = "uC_Personnage3";
            this.uC_Personnage3.Size = new System.Drawing.Size(466, 342);
            this.uC_Personnage3.TabIndex = 11;
            this.uC_Personnage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage3_DragDrop);
            this.uC_Personnage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage3_DragEnter);
            // 
            // uC_Personnage4
            // 
            this.uC_Personnage4.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage4.Location = new System.Drawing.Point(476, 363);
            this.uC_Personnage4.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage4.Name = "uC_Personnage4";
            this.uC_Personnage4.Size = new System.Drawing.Size(466, 342);
            this.uC_Personnage4.TabIndex = 12;
            this.uC_Personnage4.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage4_DragDrop);
            this.uC_Personnage4.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage4_DragEnter);
            // 
            // uC_Personnage2
            // 
            this.uC_Personnage2.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage2.Location = new System.Drawing.Point(476, 15);
            this.uC_Personnage2.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage2.Name = "uC_Personnage2";
            this.uC_Personnage2.Size = new System.Drawing.Size(466, 342);
            this.uC_Personnage2.TabIndex = 10;
            this.uC_Personnage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage2_DragDrop);
            this.uC_Personnage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage2_DragEnter);
            // 
            // uC_Personnage1
            // 
            this.uC_Personnage1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage1.Location = new System.Drawing.Point(6, 363);
            this.uC_Personnage1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage1.Name = "uC_Personnage1";
            this.uC_Personnage1.Size = new System.Drawing.Size(466, 342);
            this.uC_Personnage1.TabIndex = 9;
            this.uC_Personnage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage1_DragDrop);
            this.uC_Personnage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage1_DragEnter);
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.rtbListeF);
            this.Controls.Add(this.btnReunion);
            this.Controls.Add(this.btnCrunch);
            this.Controls.Add(this.lblActu);
            this.Controls.Add(this.rtbActu);
            this.Controls.Add(this.btnRepos);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTourSuivant);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.RichTextBox rtbActu;
        private System.Windows.Forms.Label lblActu;
        private System.Windows.Forms.Button btnCrunch;
        private System.Windows.Forms.Button btnReunion;
        private System.Windows.Forms.RichTextBox rtbListeF;
        private System.Windows.Forms.ListBox lstTache;
        private System.Windows.Forms.Label lblLstTache;
        private System.Windows.Forms.Button btnVider;
    }
}