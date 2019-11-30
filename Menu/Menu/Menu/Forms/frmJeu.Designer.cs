﻿namespace Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJeu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pgConception = new System.Windows.Forms.ProgressBar();
            this.pgDeveloppement = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pgRecherches = new System.Windows.Forms.ProgressBar();
            this.btnVider = new System.Windows.Forms.Button();
            this.lblLstTache = new System.Windows.Forms.Label();
            this.lstTache = new System.Windows.Forms.ListBox();
            this.rtbActu = new System.Windows.Forms.RichTextBox();
            this.lblActu = new System.Windows.Forms.Label();
            this.rtbListeF = new System.Windows.Forms.RichTextBox();
            this.lblTacheReal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRepos = new System.Windows.Forms.Button();
            this.btnCrunch = new System.Windows.Forms.Button();
            this.btnReunion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnTourSuivant = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.uC_Personnage3 = new Menu.UC_Personnage();
            this.uC_Personnage4 = new Menu.UC_Personnage();
            this.uC_Personnage2 = new Menu.UC_Personnage();
            this.uC_Personnage1 = new Menu.UC_Personnage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel1.Controls.Add(this.pgConception);
            this.panel1.Controls.Add(this.pgDeveloppement);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pgRecherches);
            this.panel1.Controls.Add(this.btnVider);
            this.panel1.Controls.Add(this.lblLstTache);
            this.panel1.Controls.Add(this.lstTache);
            this.panel1.Controls.Add(this.uC_Personnage3);
            this.panel1.Controls.Add(this.uC_Personnage4);
            this.panel1.Controls.Add(this.uC_Personnage2);
            this.panel1.Controls.Add(this.uC_Personnage1);
            this.panel1.Location = new System.Drawing.Point(2, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 815);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(536, 24);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(163, 163);
            this.bunifuCircleProgressbar1.TabIndex = 29;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // pgConception
            // 
            this.pgConception.Location = new System.Drawing.Point(455, 677);
            this.pgConception.Name = "pgConception";
            this.pgConception.Size = new System.Drawing.Size(132, 23);
            this.pgConception.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgConception.TabIndex = 28;
            this.pgConception.Value = 50;
            // 
            // pgDeveloppement
            // 
            this.pgDeveloppement.Location = new System.Drawing.Point(635, 677);
            this.pgDeveloppement.Name = "pgDeveloppement";
            this.pgDeveloppement.Size = new System.Drawing.Size(132, 23);
            this.pgDeveloppement.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgDeveloppement.TabIndex = 27;
            this.pgDeveloppement.Value = 50;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(631, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "Développement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(464, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Conception";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(536, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Recherches ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgRecherches
            // 
            this.pgRecherches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.pgRecherches.Location = new System.Drawing.Point(536, 618);
            this.pgRecherches.Name = "pgRecherches";
            this.pgRecherches.Size = new System.Drawing.Size(132, 23);
            this.pgRecherches.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgRecherches.TabIndex = 23;
            this.pgRecherches.Value = 50;
            // 
            // btnVider
            // 
            this.btnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVider.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnVider.Location = new System.Drawing.Point(512, 490);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(201, 44);
            this.btnVider.TabIndex = 22;
            this.btnVider.Text = "Tout annuler";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblLstTache
            // 
            this.lblLstTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLstTache.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLstTache.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLstTache.Location = new System.Drawing.Point(474, 216);
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
            this.lstTache.Location = new System.Drawing.Point(477, 249);
            this.lstTache.Name = "lstTache";
            this.lstTache.Size = new System.Drawing.Size(273, 214);
            this.lstTache.TabIndex = 13;
            this.lstTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstTache_MouseDown);
            // 
            // rtbActu
            // 
            this.rtbActu.BackColor = System.Drawing.Color.White;
            this.rtbActu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbActu.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbActu.ForeColor = System.Drawing.Color.Black;
            this.rtbActu.Location = new System.Drawing.Point(1228, 42);
            this.rtbActu.Name = "rtbActu";
            this.rtbActu.Size = new System.Drawing.Size(204, 157);
            this.rtbActu.TabIndex = 16;
            this.rtbActu.Text = "";
            // 
            // lblActu
            // 
            this.lblActu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblActu.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActu.Location = new System.Drawing.Point(1247, 9);
            this.lblActu.Name = "lblActu";
            this.lblActu.Size = new System.Drawing.Size(196, 30);
            this.lblActu.TabIndex = 17;
            this.lblActu.Text = "Actu Projet";
            this.lblActu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbListeF
            // 
            this.rtbListeF.BackColor = System.Drawing.Color.White;
            this.rtbListeF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbListeF.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListeF.ForeColor = System.Drawing.Color.Black;
            this.rtbListeF.Location = new System.Drawing.Point(1228, 242);
            this.rtbListeF.Name = "rtbListeF";
            this.rtbListeF.ReadOnly = true;
            this.rtbListeF.Size = new System.Drawing.Size(204, 500);
            this.rtbListeF.TabIndex = 21;
            this.rtbListeF.Text = "";
            // 
            // lblTacheReal
            // 
            this.lblTacheReal.AutoSize = true;
            this.lblTacheReal.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.lblTacheReal.Location = new System.Drawing.Point(1222, 208);
            this.lblTacheReal.Name = "lblTacheReal";
            this.lblTacheReal.Size = new System.Drawing.Size(231, 31);
            this.lblTacheReal.TabIndex = 22;
            this.lblTacheReal.Text = "Tâches réalisées";
            this.lblTacheReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnRepos);
            this.panel2.Controls.Add(this.btnCrunch);
            this.panel2.Controls.Add(this.btnReunion);
            this.panel2.Controls.Add(this.btnQuitter);
            this.panel2.Controls.Add(this.btnTourSuivant);
            this.panel2.Location = new System.Drawing.Point(2, 741);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1441, 141);
            this.panel2.TabIndex = 23;
            // 
            // btnRepos
            // 
            this.btnRepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepos.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepos.Image = global::Menu.Properties.Resources.img_481167;
            this.btnRepos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepos.Location = new System.Drawing.Point(383, 10);
            this.btnRepos.Name = "btnRepos";
            this.btnRepos.Size = new System.Drawing.Size(125, 44);
            this.btnRepos.TabIndex = 15;
            this.btnRepos.Text = "Repos";
            this.btnRepos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepos.UseVisualStyleBackColor = true;
            this.btnRepos.Click += new System.EventHandler(this.btnRepos_Click);
            // 
            // btnCrunch
            // 
            this.btnCrunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrunch.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrunch.Image = global::Menu.Properties.Resources.work_hard_png_2;
            this.btnCrunch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrunch.Location = new System.Drawing.Point(544, 10);
            this.btnCrunch.Name = "btnCrunch";
            this.btnCrunch.Size = new System.Drawing.Size(124, 44);
            this.btnCrunch.TabIndex = 19;
            this.btnCrunch.Text = "Crunch";
            this.btnCrunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrunch.UseVisualStyleBackColor = true;
            this.btnCrunch.Click += new System.EventHandler(this.btnCrunch_Click_1);
            // 
            // btnReunion
            // 
            this.btnReunion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReunion.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.Image = global::Menu.Properties.Resources.meeting_with_a_friend;
            this.btnReunion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReunion.Location = new System.Drawing.Point(713, 10);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Size = new System.Drawing.Size(138, 44);
            this.btnReunion.TabIndex = 20;
            this.btnReunion.Text = "Réunion";
            this.btnReunion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReunion.UseVisualStyleBackColor = true;
            this.btnReunion.Click += new System.EventHandler(this.btnReunion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Image = global::Menu.Properties.Resources._53494;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.Location = new System.Drawing.Point(1306, 7);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(124, 44);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnTourSuivant
            // 
            this.btnTourSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTourSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourSuivant.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourSuivant.Image = global::Menu.Properties.Resources._510461;
            this.btnTourSuivant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTourSuivant.Location = new System.Drawing.Point(1037, 10);
            this.btnTourSuivant.Name = "btnTourSuivant";
            this.btnTourSuivant.Size = new System.Drawing.Size(184, 44);
            this.btnTourSuivant.TabIndex = 7;
            this.btnTourSuivant.Text = "Tour suivant";
            this.btnTourSuivant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTourSuivant.UseVisualStyleBackColor = true;
            this.btnTourSuivant.Click += new System.EventHandler(this.btnTourSuivant_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // uC_Personnage3
            // 
            this.uC_Personnage3.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage3.Location = new System.Drawing.Point(13, 17);
            this.uC_Personnage3.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage3.Name = "uC_Personnage3";
            this.uC_Personnage3.Size = new System.Drawing.Size(433, 331);
            this.uC_Personnage3.TabIndex = 11;
            this.uC_Personnage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage3_DragDrop);
            this.uC_Personnage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage3_DragEnter);
            // 
            // uC_Personnage4
            // 
            this.uC_Personnage4.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage4.Location = new System.Drawing.Point(776, 371);
            this.uC_Personnage4.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage4.Name = "uC_Personnage4";
            this.uC_Personnage4.Size = new System.Drawing.Size(429, 329);
            this.uC_Personnage4.TabIndex = 12;
            this.uC_Personnage4.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage4_DragDrop);
            this.uC_Personnage4.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage4_DragEnter);
            // 
            // uC_Personnage2
            // 
            this.uC_Personnage2.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage2.Location = new System.Drawing.Point(776, 17);
            this.uC_Personnage2.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage2.Name = "uC_Personnage2";
            this.uC_Personnage2.Size = new System.Drawing.Size(429, 331);
            this.uC_Personnage2.TabIndex = 10;
            this.uC_Personnage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage2_DragDrop);
            this.uC_Personnage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage2_DragEnter);
            // 
            // uC_Personnage1
            // 
            this.uC_Personnage1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage1.Location = new System.Drawing.Point(13, 371);
            this.uC_Personnage1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage1.Name = "uC_Personnage1";
            this.uC_Personnage1.Size = new System.Drawing.Size(433, 329);
            this.uC_Personnage1.TabIndex = 9;
            this.uC_Personnage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage1_DragDrop);
            this.uC_Personnage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage1_DragEnter);
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1460, 916);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTacheReal);
            this.Controls.Add(this.rtbListeF);
            this.Controls.Add(this.lblActu);
            this.Controls.Add(this.rtbActu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T3 Simulator";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJeu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblTacheReal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pgRecherches;
        private System.Windows.Forms.ProgressBar pgConception;
        private System.Windows.Forms.ProgressBar pgDeveloppement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}