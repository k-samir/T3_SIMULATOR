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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnReunion = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.lblLstTache = new System.Windows.Forms.Label();
            this.lstTache = new System.Windows.Forms.ListBox();
            this.uC_Personnage3 = new Menu.UC_Personnage();
            this.uC_Personnage4 = new Menu.UC_Personnage();
            this.uC_Personnage2 = new Menu.UC_Personnage();
            this.uC_Personnage1 = new Menu.UC_Personnage();
            this.rtbListeF = new System.Windows.Forms.RichTextBox();
            this.lblTacheReal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.switchColor = new Bunifu.Framework.UI.BunifuSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepos = new System.Windows.Forms.Button();
            this.btnCrunch = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnTourSuivant = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerRepos = new System.Windows.Forms.Timer(this.components);
            this.pnlProgressBarTache = new System.Windows.Forms.Panel();
            this.fonctionnalitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlProgressBarTache.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fonctionnalitesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lblTour);
            this.panel1.Controls.Add(this.lblIntro);
            this.panel1.Controls.Add(this.btnReunion);
            this.panel1.Controls.Add(this.btnVider);
            this.panel1.Controls.Add(this.lblLstTache);
            this.panel1.Controls.Add(this.lstTache);
            this.panel1.Controls.Add(this.uC_Personnage3);
            this.panel1.Controls.Add(this.uC_Personnage4);
            this.panel1.Controls.Add(this.uC_Personnage2);
            this.panel1.Controls.Add(this.uC_Personnage1);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1628, 1003);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.lblTour.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.lblTour.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTour.Location = new System.Drawing.Point(652, 123);
            this.lblTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(306, 57);
            this.lblTour.TabIndex = 31;
            this.lblTour.Text = "Tour : 0/10";
            this.lblTour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTour.Visible = false;
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIntro.Location = new System.Drawing.Point(683, 377);
            this.lblIntro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(267, 123);
            this.lblIntro.TabIndex = 30;
            this.lblIntro.Text = "Il faudrait faire une réunion pour déterminer les tâches à effectuer..";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReunion
            // 
            this.btnReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.btnReunion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReunion.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnReunion.Image = global::Menu.Properties.Resources.meeting_with_a_friend;
            this.btnReunion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReunion.Location = new System.Drawing.Point(728, 791);
            this.btnReunion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Size = new System.Drawing.Size(181, 71);
            this.btnReunion.TabIndex = 20;
            this.btnReunion.Text = "Réunion";
            this.btnReunion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReunion.UseVisualStyleBackColor = false;
            this.btnReunion.Click += new System.EventHandler(this.btnReunion_Click);
            // 
            // btnVider
            // 
            this.btnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVider.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnVider.Location = new System.Drawing.Point(731, 727);
            this.btnVider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(173, 33);
            this.btnVider.TabIndex = 22;
            this.btnVider.Text = "Tout annuler";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Visible = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblLstTache
            // 
            this.lblLstTache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.lblLstTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLstTache.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLstTache.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLstTache.Location = new System.Drawing.Point(628, 266);
            this.lblLstTache.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLstTache.Name = "lblLstTache";
            this.lblLstTache.Size = new System.Drawing.Size(368, 37);
            this.lblLstTache.TabIndex = 22;
            this.lblLstTache.Text = "Tâches à glisser/déposer";
            this.lblLstTache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLstTache.Visible = false;
            // 
            // lstTache
            // 
            this.lstTache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.lstTache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstTache.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.lstTache.ForeColor = System.Drawing.Color.OrangeRed;
            this.lstTache.FormattingEnabled = true;
            this.lstTache.ItemHeight = 27;
            this.lstTache.Location = new System.Drawing.Point(607, 306);
            this.lstTache.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTache.Name = "lstTache";
            this.lstTache.Size = new System.Drawing.Size(415, 380);
            this.lstTache.Sorted = true;
            this.lstTache.TabIndex = 13;
            this.lstTache.Visible = false;
            this.lstTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstTache_MouseDown);
            // 
            // uC_Personnage3
            // 
            this.uC_Personnage3.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage3.Location = new System.Drawing.Point(17, 21);
            this.uC_Personnage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage3.Name = "uC_Personnage3";
            this.uC_Personnage3.Size = new System.Drawing.Size(572, 405);
            this.uC_Personnage3.TabIndex = 11;
            this.uC_Personnage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage3_DragDrop);
            this.uC_Personnage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage3_DragEnter);
            // 
            // uC_Personnage4
            // 
            this.uC_Personnage4.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage4.Location = new System.Drawing.Point(1035, 457);
            this.uC_Personnage4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage4.Name = "uC_Personnage4";
            this.uC_Personnage4.Size = new System.Drawing.Size(572, 405);
            this.uC_Personnage4.TabIndex = 12;
            this.uC_Personnage4.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage4_DragDrop);
            this.uC_Personnage4.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage4_DragEnter);
            // 
            // uC_Personnage2
            // 
            this.uC_Personnage2.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage2.Location = new System.Drawing.Point(1035, 21);
            this.uC_Personnage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage2.Name = "uC_Personnage2";
            this.uC_Personnage2.Size = new System.Drawing.Size(572, 405);
            this.uC_Personnage2.TabIndex = 10;
            this.uC_Personnage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage2_DragDrop);
            this.uC_Personnage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage2_DragEnter);
            // 
            // uC_Personnage1
            // 
            this.uC_Personnage1.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_Personnage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage1.Location = new System.Drawing.Point(17, 457);
            this.uC_Personnage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.uC_Personnage1.Name = "uC_Personnage1";
            this.uC_Personnage1.Size = new System.Drawing.Size(572, 405);
            this.uC_Personnage1.TabIndex = 9;
            this.uC_Personnage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.uC_Personnage1_DragDrop);
            this.uC_Personnage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.uC_Personnage1_DragEnter);
            // 
            // rtbListeF
            // 
            this.rtbListeF.BackColor = System.Drawing.Color.White;
            this.rtbListeF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbListeF.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListeF.ForeColor = System.Drawing.Color.Black;
            this.rtbListeF.Location = new System.Drawing.Point(261, 22);
            this.rtbListeF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbListeF.Name = "rtbListeF";
            this.rtbListeF.ReadOnly = true;
            this.rtbListeF.Size = new System.Drawing.Size(152, 42);
            this.rtbListeF.TabIndex = 21;
            this.rtbListeF.Text = "";
            this.rtbListeF.Visible = false;
            // 
            // lblTacheReal
            // 
            this.lblTacheReal.AutoSize = true;
            this.lblTacheReal.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacheReal.Location = new System.Drawing.Point(39, -7);
            this.lblTacheReal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacheReal.Name = "lblTacheReal";
            this.lblTacheReal.Size = new System.Drawing.Size(329, 44);
            this.lblTacheReal.TabIndex = 22;
            this.lblTacheReal.Text = "Tâches réalisées";
            this.lblTacheReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTacheReal.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.switchColor);
            this.panel2.Controls.Add(this.rtbListeF);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRepos);
            this.panel2.Controls.Add(this.btnCrunch);
            this.panel2.Controls.Add(this.btnQuitter);
            this.panel2.Controls.Add(this.btnTourSuivant);
            this.panel2.Location = new System.Drawing.Point(3, 912);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1921, 174);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mode sombre";
            // 
            // switchColor
            // 
            this.switchColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchColor.BorderRadius = 0;
            this.switchColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchColor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchColor.Location = new System.Drawing.Point(167, 41);
            this.switchColor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.switchColor.Name = "switchColor";
            this.switchColor.Oncolor = System.Drawing.Color.SeaGreen;
            this.switchColor.Onoffcolor = System.Drawing.Color.DarkGray;
            this.switchColor.Size = new System.Drawing.Size(0, 0);
            this.switchColor.TabIndex = 30;
            this.switchColor.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchColor.Value = false;
            this.switchColor.Click += new System.EventHandler(this.switchColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Version 0.9";
            // 
            // btnRepos
            // 
            this.btnRepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepos.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepos.Image = global::Menu.Properties.Resources.img_481167;
            this.btnRepos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepos.Location = new System.Drawing.Point(564, 10);
            this.btnRepos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRepos.Name = "btnRepos";
            this.btnRepos.Size = new System.Drawing.Size(167, 54);
            this.btnRepos.TabIndex = 15;
            this.btnRepos.Text = "Repos";
            this.btnRepos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepos.UseVisualStyleBackColor = true;
            this.btnRepos.Visible = false;
            this.btnRepos.Click += new System.EventHandler(this.btnRepos_Click);
            // 
            // btnCrunch
            // 
            this.btnCrunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrunch.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrunch.Image = global::Menu.Properties.Resources.work_hard_png_2;
            this.btnCrunch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrunch.Location = new System.Drawing.Point(739, 10);
            this.btnCrunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrunch.Name = "btnCrunch";
            this.btnCrunch.Size = new System.Drawing.Size(165, 54);
            this.btnCrunch.TabIndex = 19;
            this.btnCrunch.Text = "Crunch";
            this.btnCrunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrunch.UseVisualStyleBackColor = true;
            this.btnCrunch.Visible = false;
            this.btnCrunch.Click += new System.EventHandler(this.btnCrunch_Click_1);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Image = global::Menu.Properties.Resources._53494;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.Location = new System.Drawing.Point(739, 71);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(172, 54);
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
            this.btnTourSuivant.Location = new System.Drawing.Point(912, 10);
            this.btnTourSuivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTourSuivant.Name = "btnTourSuivant";
            this.btnTourSuivant.Size = new System.Drawing.Size(245, 54);
            this.btnTourSuivant.TabIndex = 7;
            this.btnTourSuivant.Text = "Tour suivant";
            this.btnTourSuivant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTourSuivant.UseVisualStyleBackColor = true;
            this.btnTourSuivant.Visible = false;
            this.btnTourSuivant.Click += new System.EventHandler(this.btnTourSuivant_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timerRepos
            // 
            this.timerRepos.Enabled = true;
            this.timerRepos.Interval = 450;
            this.timerRepos.Tick += new System.EventHandler(this.timerRepos_Tick);
            // 
            // pnlProgressBarTache
            // 
            this.pnlProgressBarTache.Controls.Add(this.lblTacheReal);
            this.pnlProgressBarTache.Location = new System.Drawing.Point(1632, 34);
            this.pnlProgressBarTache.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProgressBarTache.Name = "pnlProgressBarTache";
            this.pnlProgressBarTache.Size = new System.Drawing.Size(311, 869);
            this.pnlProgressBarTache.TabIndex = 24;
            this.pnlProgressBarTache.Visible = false;
            // 
            // fonctionnalitesBindingSource
            // 
            this.fonctionnalitesBindingSource.DataSource = typeof(Menu.Fonctionnalites);
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pnlProgressBarTache);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T3 Simulator";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlProgressBarTache.ResumeLayout(false);
            this.pnlProgressBarTache.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fonctionnalitesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnCrunch;
        private System.Windows.Forms.Button btnReunion;
        private System.Windows.Forms.RichTextBox rtbListeF;
        private System.Windows.Forms.ListBox lstTache;
        private System.Windows.Forms.Label lblLstTache;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblTacheReal;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSwitch switchColor;
        private System.Windows.Forms.Timer timerRepos;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Panel pnlProgressBarTache;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.BindingSource fonctionnalitesBindingSource;
    }
}