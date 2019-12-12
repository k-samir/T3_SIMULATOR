namespace Menu
{
    partial class UC_Personnage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Personnage));
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblFatigue = new System.Windows.Forms.Label();
            this.lblCompetence = new System.Windows.Forms.Label();
            this.lblStress = new System.Windows.Forms.Label();
            this.lblAction1 = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnSupprimerTache3 = new System.Windows.Forms.Button();
            this.btnSupprimerTache2 = new System.Windows.Forms.Button();
            this.btnSupprimerTache1 = new System.Windows.Forms.Button();
            this.cboFonctionnalite3 = new System.Windows.Forms.ComboBox();
            this.cboFonctionnalite2 = new System.Windows.Forms.ComboBox();
            this.cboFonctionnalite1 = new System.Windows.Forms.ComboBox();
            this.lblAction3 = new System.Windows.Forms.Label();
            this.lblAction2 = new System.Windows.Forms.Label();
            this.lblValFatigue = new System.Windows.Forms.Label();
            this.lblValCompetence = new System.Windows.Forms.Label();
            this.lblValStress = new System.Windows.Forms.Label();
            this.lblValConnaissance = new System.Windows.Forms.Label();
            this.lblDeteste = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbCoeurNoir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCacheur = new System.Windows.Forms.PictureBox();
            this.pbCoeur = new System.Windows.Forms.PictureBox();
            this.affinite = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPointFort = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPointFaible = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQualite = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDefaut = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbClic = new System.Windows.Forms.PictureBox();
            this.grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoeurNoir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCacheur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(-1, 135);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(150, 24);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom du Perso";
            this.lblPrenom.Visible = false;
            // 
            // lblFatigue
            // 
            this.lblFatigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatigue.Location = new System.Drawing.Point(206, 10);
            this.lblFatigue.Name = "lblFatigue";
            this.lblFatigue.Size = new System.Drawing.Size(73, 26);
            this.lblFatigue.TabIndex = 2;
            this.lblFatigue.Text = "Fatigue:";
            this.lblFatigue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompetence
            // 
            this.lblCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetence.Location = new System.Drawing.Point(206, 36);
            this.lblCompetence.Name = "lblCompetence";
            this.lblCompetence.Size = new System.Drawing.Size(102, 26);
            this.lblCompetence.TabIndex = 3;
            this.lblCompetence.Text = "Compétence : ";
            this.lblCompetence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStress
            // 
            this.lblStress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStress.Location = new System.Drawing.Point(206, 62);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(89, 26);
            this.lblStress.TabIndex = 4;
            this.lblStress.Text = "Stress:";
            this.lblStress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAction1
            // 
            this.lblAction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction1.Location = new System.Drawing.Point(6, 25);
            this.lblAction1.Name = "lblAction1";
            this.lblAction1.Size = new System.Drawing.Size(101, 38);
            this.lblAction1.TabIndex = 10;
            this.lblAction1.Text = "Matin :";
            this.lblAction1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnSupprimerTache3);
            this.grpAction.Controls.Add(this.btnSupprimerTache2);
            this.grpAction.Controls.Add(this.btnSupprimerTache1);
            this.grpAction.Controls.Add(this.cboFonctionnalite3);
            this.grpAction.Controls.Add(this.cboFonctionnalite2);
            this.grpAction.Controls.Add(this.cboFonctionnalite1);
            this.grpAction.Controls.Add(this.lblAction3);
            this.grpAction.Controls.Add(this.lblAction2);
            this.grpAction.Controls.Add(this.lblAction1);
            this.grpAction.Location = new System.Drawing.Point(3, 186);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(424, 144);
            this.grpAction.TabIndex = 11;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Tâches à effectuer";
            // 
            // btnSupprimerTache3
            // 
            this.btnSupprimerTache3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimerTache3.BackgroundImage")));
            this.btnSupprimerTache3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupprimerTache3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerTache3.Location = new System.Drawing.Point(381, 107);
            this.btnSupprimerTache3.Name = "btnSupprimerTache3";
            this.btnSupprimerTache3.Size = new System.Drawing.Size(28, 32);
            this.btnSupprimerTache3.TabIndex = 18;
            this.btnSupprimerTache3.UseVisualStyleBackColor = true;
            this.btnSupprimerTache3.Visible = false;
            this.btnSupprimerTache3.Click += new System.EventHandler(this.btnSupprimerTache3_Click);
            // 
            // btnSupprimerTache2
            // 
            this.btnSupprimerTache2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimerTache2.BackgroundImage")));
            this.btnSupprimerTache2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupprimerTache2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerTache2.Location = new System.Drawing.Point(381, 64);
            this.btnSupprimerTache2.Name = "btnSupprimerTache2";
            this.btnSupprimerTache2.Size = new System.Drawing.Size(28, 32);
            this.btnSupprimerTache2.TabIndex = 17;
            this.btnSupprimerTache2.UseVisualStyleBackColor = true;
            this.btnSupprimerTache2.Click += new System.EventHandler(this.btnSupprimerTache2_Click);
            // 
            // btnSupprimerTache1
            // 
            this.btnSupprimerTache1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSupprimerTache1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimerTache1.BackgroundImage")));
            this.btnSupprimerTache1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupprimerTache1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerTache1.Location = new System.Drawing.Point(381, 27);
            this.btnSupprimerTache1.Name = "btnSupprimerTache1";
            this.btnSupprimerTache1.Size = new System.Drawing.Size(28, 32);
            this.btnSupprimerTache1.TabIndex = 16;
            this.btnSupprimerTache1.UseVisualStyleBackColor = false;
            this.btnSupprimerTache1.Click += new System.EventHandler(this.btnSupprimerTache1_Click);
            // 
            // cboFonctionnalite3
            // 
            this.cboFonctionnalite3.Enabled = false;
            this.cboFonctionnalite3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFonctionnalite3.FormattingEnabled = true;
            this.cboFonctionnalite3.Location = new System.Drawing.Point(99, 107);
            this.cboFonctionnalite3.Name = "cboFonctionnalite3";
            this.cboFonctionnalite3.Size = new System.Drawing.Size(310, 30);
            this.cboFonctionnalite3.TabIndex = 15;
            this.cboFonctionnalite3.Visible = false;
            // 
            // cboFonctionnalite2
            // 
            this.cboFonctionnalite2.Enabled = false;
            this.cboFonctionnalite2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFonctionnalite2.FormattingEnabled = true;
            this.cboFonctionnalite2.Location = new System.Drawing.Point(99, 66);
            this.cboFonctionnalite2.Name = "cboFonctionnalite2";
            this.cboFonctionnalite2.Size = new System.Drawing.Size(310, 30);
            this.cboFonctionnalite2.TabIndex = 14;
            // 
            // cboFonctionnalite1
            // 
            this.cboFonctionnalite1.Enabled = false;
            this.cboFonctionnalite1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFonctionnalite1.FormattingEnabled = true;
            this.cboFonctionnalite1.Location = new System.Drawing.Point(99, 28);
            this.cboFonctionnalite1.Name = "cboFonctionnalite1";
            this.cboFonctionnalite1.Size = new System.Drawing.Size(310, 30);
            this.cboFonctionnalite1.TabIndex = 13;
            // 
            // lblAction3
            // 
            this.lblAction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction3.Location = new System.Drawing.Point(6, 105);
            this.lblAction3.Name = "lblAction3";
            this.lblAction3.Size = new System.Drawing.Size(101, 38);
            this.lblAction3.TabIndex = 12;
            this.lblAction3.Text = "Nuit :";
            this.lblAction3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAction3.Visible = false;
            // 
            // lblAction2
            // 
            this.lblAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction2.Location = new System.Drawing.Point(6, 64);
            this.lblAction2.Name = "lblAction2";
            this.lblAction2.Size = new System.Drawing.Size(101, 38);
            this.lblAction2.TabIndex = 11;
            this.lblAction2.Text = "Après-Midi :";
            this.lblAction2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValFatigue
            // 
            this.lblValFatigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValFatigue.Location = new System.Drawing.Point(339, 10);
            this.lblValFatigue.Name = "lblValFatigue";
            this.lblValFatigue.Size = new System.Drawing.Size(73, 26);
            this.lblValFatigue.TabIndex = 12;
            this.lblValFatigue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValCompetence
            // 
            this.lblValCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCompetence.Location = new System.Drawing.Point(339, 36);
            this.lblValCompetence.Name = "lblValCompetence";
            this.lblValCompetence.Size = new System.Drawing.Size(73, 26);
            this.lblValCompetence.TabIndex = 13;
            this.lblValCompetence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValStress
            // 
            this.lblValStress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValStress.Location = new System.Drawing.Point(339, 62);
            this.lblValStress.Name = "lblValStress";
            this.lblValStress.Size = new System.Drawing.Size(73, 26);
            this.lblValStress.TabIndex = 14;
            this.lblValStress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValConnaissance
            // 
            this.lblValConnaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValConnaissance.Location = new System.Drawing.Point(339, 88);
            this.lblValConnaissance.Name = "lblValConnaissance";
            this.lblValConnaissance.Size = new System.Drawing.Size(73, 26);
            this.lblValConnaissance.TabIndex = 15;
            this.lblValConnaissance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeteste
            // 
            this.lblDeteste.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeteste.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDeteste.Location = new System.Drawing.Point(295, 103);
            this.lblDeteste.Name = "lblDeteste";
            this.lblDeteste.Size = new System.Drawing.Size(74, 17);
            this.lblDeteste.TabIndex = 17;
            this.lblDeteste.Text = "Deteste :";
            this.lblDeteste.Visible = false;
            // 
            // pbCoeurNoir
            // 
            this.pbCoeurNoir.BackgroundImage = global::Menu.Properties.Resources._30571;
            this.pbCoeurNoir.Location = new System.Drawing.Point(375, 97);
            this.pbCoeurNoir.Name = "pbCoeurNoir";
            this.pbCoeurNoir.Size = new System.Drawing.Size(25, 23);
            this.pbCoeurNoir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoeurNoir.TabIndex = 19;
            this.pbCoeurNoir.TabStop = false;
            this.pbCoeurNoir.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbCacheur
            // 
            this.pbCacheur.Location = new System.Drawing.Point(178, 12);
            this.pbCacheur.Name = "pbCacheur";
            this.pbCacheur.Size = new System.Drawing.Size(249, 79);
            this.pbCacheur.TabIndex = 20;
            this.pbCacheur.TabStop = false;
            // 
            // pbCoeur
            // 
            this.pbCoeur.BackgroundImage = global::Menu.Properties.Resources._30571;
            this.pbCoeur.Image = ((System.Drawing.Image)(resources.GetObject("pbCoeur.Image")));
            this.pbCoeur.Location = new System.Drawing.Point(247, 97);
            this.pbCoeur.Name = "pbCoeur";
            this.pbCoeur.Size = new System.Drawing.Size(25, 23);
            this.pbCoeur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoeur.TabIndex = 22;
            this.pbCoeur.TabStop = false;
            this.pbCoeur.Visible = false;
            // 
            // affinite
            // 
            this.affinite.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affinite.ForeColor = System.Drawing.Color.Green;
            this.affinite.Location = new System.Drawing.Point(170, 103);
            this.affinite.Name = "affinite";
            this.affinite.Size = new System.Drawing.Size(73, 17);
            this.affinite.TabIndex = 21;
            this.affinite.Text = "Affinité avec :";
            this.affinite.Visible = false;
            // 
            // lblPointFort
            // 
            this.lblPointFort.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.lblPointFort.ForeColor = System.Drawing.Color.Green;
            this.lblPointFort.Location = new System.Drawing.Point(169, 126);
            this.lblPointFort.Name = "lblPointFort";
            this.lblPointFort.Size = new System.Drawing.Size(110, 17);
            this.lblPointFort.TabIndex = 23;
            this.lblPointFort.Text = "Point fort";
            this.lblPointFort.Visible = false;
            // 
            // lblPointFaible
            // 
            this.lblPointFaible.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.lblPointFaible.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPointFaible.Location = new System.Drawing.Point(294, 126);
            this.lblPointFaible.Name = "lblPointFaible";
            this.lblPointFaible.Size = new System.Drawing.Size(145, 17);
            this.lblPointFaible.TabIndex = 24;
            this.lblPointFaible.Text = "Point faible";
            this.lblPointFaible.Visible = false;
            // 
            // lblQualite
            // 
            this.lblQualite.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.lblQualite.ForeColor = System.Drawing.Color.Green;
            this.lblQualite.Location = new System.Drawing.Point(169, 152);
            this.lblQualite.Name = "lblQualite";
            this.lblQualite.Size = new System.Drawing.Size(110, 17);
            this.lblQualite.TabIndex = 25;
            this.lblQualite.Text = "Qualité";
            this.lblQualite.Visible = false;
            // 
            // lblDefaut
            // 
            this.lblDefaut.Font = new System.Drawing.Font("Cooper Black", 11F);
            this.lblDefaut.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDefaut.Location = new System.Drawing.Point(295, 152);
            this.lblDefaut.Name = "lblDefaut";
            this.lblDefaut.Size = new System.Drawing.Size(145, 17);
            this.lblDefaut.TabIndex = 26;
            this.lblDefaut.Text = "Défaut";
            this.lblDefaut.Visible = false;
            // 
            // pbClic
            // 
            this.pbClic.Image = ((System.Drawing.Image)(resources.GetObject("pbClic.Image")));
            this.pbClic.Location = new System.Drawing.Point(120, 94);
            this.pbClic.Name = "pbClic";
            this.pbClic.Size = new System.Drawing.Size(37, 40);
            this.pbClic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClic.TabIndex = 27;
            this.pbClic.TabStop = false;
            this.pbClic.Visible = false;
            // 
            // UC_Personnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.pbClic);
            this.Controls.Add(this.lblDefaut);
            this.Controls.Add(this.lblQualite);
            this.Controls.Add(this.lblPointFaible);
            this.Controls.Add(this.lblPointFort);
            this.Controls.Add(this.pbCoeur);
            this.Controls.Add(this.affinite);
            this.Controls.Add(this.pbCacheur);
            this.Controls.Add(this.pbCoeurNoir);
            this.Controls.Add(this.lblDeteste);
            this.Controls.Add(this.lblValConnaissance);
            this.Controls.Add(this.lblValStress);
            this.Controls.Add(this.lblValCompetence);
            this.Controls.Add(this.lblValFatigue);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.lblStress);
            this.Controls.Add(this.lblCompetence);
            this.Controls.Add(this.lblFatigue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_Personnage";
            this.Size = new System.Drawing.Size(439, 343);
            this.grpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoeurNoir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCacheur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblFatigue;
        private System.Windows.Forms.Label lblCompetence;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.Label lblAction1;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblAction3;
        private System.Windows.Forms.Label lblAction2;
        private System.Windows.Forms.Label lblValFatigue;
        private System.Windows.Forms.Label lblValCompetence;
        private System.Windows.Forms.Label lblValStress;
        private System.Windows.Forms.Label lblValConnaissance;
        private System.Windows.Forms.ComboBox cboFonctionnalite3;
        private System.Windows.Forms.ComboBox cboFonctionnalite2;
        private System.Windows.Forms.ComboBox cboFonctionnalite1;
        private System.Windows.Forms.Button btnSupprimerTache3;
        private System.Windows.Forms.Button btnSupprimerTache2;
        private System.Windows.Forms.Button btnSupprimerTache1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeteste;
        private System.Windows.Forms.PictureBox pbCoeurNoir;
        private System.Windows.Forms.PictureBox pbCacheur;
        private System.Windows.Forms.PictureBox pbCoeur;
        private Bunifu.Framework.UI.BunifuCustomLabel affinite;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPointFort;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPointFaible;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQualite;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDefaut;
        private System.Windows.Forms.PictureBox pbClic;
    }
}
