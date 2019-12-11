namespace Menu.Forms
{
    partial class frmStatPerso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatPerso));
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.lblLstTache = new System.Windows.Forms.Label();
            this.btnRevenir = new System.Windows.Forms.Button();
            this.lblPrenomPerso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpQualiteDefaut = new System.Windows.Forms.GroupBox();
            this.lblDéfaut = new System.Windows.Forms.Label();
            this.lblQualite = new System.Windows.Forms.Label();
            this.pbStress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pbProductivite = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pbFatigue = new Bunifu.Framework.UI.BunifuProgressBar();
            this.grpPointFortFaible = new System.Windows.Forms.GroupBox();
            this.lblPointFaible = new System.Windows.Forms.Label();
            this.lblPointFort = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDeteste = new System.Windows.Forms.Label();
            this.lblAffinite = new System.Windows.Forms.Label();
            this.lblStress = new System.Windows.Forms.Label();
            this.lblProductivite = new System.Windows.Forms.Label();
            this.lblFatigue = new System.Windows.Forms.Label();
            this.pbPerso = new System.Windows.Forms.PictureBox();
            this.pnlHaut.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpQualiteDefaut.SuspendLayout();
            this.grpPointFortFaible.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHaut
            // 
            this.pnlHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.pnlHaut.Controls.Add(this.lblLstTache);
            this.pnlHaut.Controls.Add(this.btnRevenir);
            this.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(951, 62);
            this.pnlHaut.TabIndex = 1;
            // 
            // lblLstTache
            // 
            this.lblLstTache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLstTache.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLstTache.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLstTache.Location = new System.Drawing.Point(151, 9);
            this.lblLstTache.Name = "lblLstTache";
            this.lblLstTache.Size = new System.Drawing.Size(734, 39);
            this.lblLstTache.TabIndex = 23;
            this.lblLstTache.Text = "Description détaillée du personnage";
            this.lblLstTache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRevenir
            // 
            this.btnRevenir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenir.FlatAppearance.BorderSize = 0;
            this.btnRevenir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRevenir.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenir.Image")));
            this.btnRevenir.Location = new System.Drawing.Point(3, 3);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(60, 56);
            this.btnRevenir.TabIndex = 0;
            this.btnRevenir.UseVisualStyleBackColor = true;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click);
            // 
            // lblPrenomPerso
            // 
            this.lblPrenomPerso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrenomPerso.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomPerso.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPrenomPerso.Location = new System.Drawing.Point(-7, 74);
            this.lblPrenomPerso.Name = "lblPrenomPerso";
            this.lblPrenomPerso.Size = new System.Drawing.Size(268, 58);
            this.lblPrenomPerso.TabIndex = 23;
            this.lblPrenomPerso.Text = "Prenom Perso";
            this.lblPrenomPerso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpQualiteDefaut);
            this.panel1.Controls.Add(this.pbStress);
            this.panel1.Controls.Add(this.pbProductivite);
            this.panel1.Controls.Add(this.pbFatigue);
            this.panel1.Controls.Add(this.grpPointFortFaible);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblStress);
            this.panel1.Controls.Add(this.lblProductivite);
            this.panel1.Controls.Add(this.lblFatigue);
            this.panel1.Location = new System.Drawing.Point(255, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 311);
            this.panel1.TabIndex = 24;
            // 
            // grpQualiteDefaut
            // 
            this.grpQualiteDefaut.Controls.Add(this.lblDéfaut);
            this.grpQualiteDefaut.Controls.Add(this.lblQualite);
            this.grpQualiteDefaut.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpQualiteDefaut.Location = new System.Drawing.Point(459, 140);
            this.grpQualiteDefaut.Name = "grpQualiteDefaut";
            this.grpQualiteDefaut.Size = new System.Drawing.Size(225, 165);
            this.grpQualiteDefaut.TabIndex = 34;
            this.grpQualiteDefaut.TabStop = false;
            this.grpQualiteDefaut.Text = "Qualité / Défaut";
            // 
            // lblDéfaut
            // 
            this.lblDéfaut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDéfaut.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDéfaut.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDéfaut.Location = new System.Drawing.Point(9, 96);
            this.lblDéfaut.Name = "lblDéfaut";
            this.lblDéfaut.Size = new System.Drawing.Size(214, 30);
            this.lblDéfaut.TabIndex = 33;
            this.lblDéfaut.Text = "Défaut :";
            this.lblDéfaut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQualite
            // 
            this.lblQualite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblQualite.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualite.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblQualite.Location = new System.Drawing.Point(9, 54);
            this.lblQualite.Name = "lblQualite";
            this.lblQualite.Size = new System.Drawing.Size(214, 30);
            this.lblQualite.TabIndex = 32;
            this.lblQualite.Text = "Qualité :";
            this.lblQualite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbStress
            // 
            this.pbStress.BackColor = System.Drawing.Color.Silver;
            this.pbStress.BorderRadius = 5;
            this.pbStress.Location = new System.Drawing.Point(115, 99);
            this.pbStress.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
            this.pbStress.MaximumValue = 100;
            this.pbStress.Name = "pbStress";
            this.pbStress.ProgressColor = System.Drawing.Color.Teal;
            this.pbStress.Size = new System.Drawing.Size(536, 18);
            this.pbStress.TabIndex = 33;
            this.pbStress.Value = 0;
            // 
            // pbProductivite
            // 
            this.pbProductivite.BackColor = System.Drawing.Color.Silver;
            this.pbProductivite.BorderRadius = 5;
            this.pbProductivite.Location = new System.Drawing.Point(115, 67);
            this.pbProductivite.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.pbProductivite.MaximumValue = 100;
            this.pbProductivite.Name = "pbProductivite";
            this.pbProductivite.ProgressColor = System.Drawing.Color.Teal;
            this.pbProductivite.Size = new System.Drawing.Size(540, 18);
            this.pbProductivite.TabIndex = 32;
            this.pbProductivite.Value = 0;
            // 
            // pbFatigue
            // 
            this.pbFatigue.BackColor = System.Drawing.Color.Silver;
            this.pbFatigue.BorderRadius = 5;
            this.pbFatigue.Location = new System.Drawing.Point(115, 36);
            this.pbFatigue.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pbFatigue.MaximumValue = 100;
            this.pbFatigue.Name = "pbFatigue";
            this.pbFatigue.ProgressColor = System.Drawing.Color.Silver;
            this.pbFatigue.Size = new System.Drawing.Size(540, 18);
            this.pbFatigue.TabIndex = 25;
            this.pbFatigue.Value = 20;
            // 
            // grpPointFortFaible
            // 
            this.grpPointFortFaible.Controls.Add(this.lblPointFaible);
            this.grpPointFortFaible.Controls.Add(this.lblPointFort);
            this.grpPointFortFaible.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpPointFortFaible.Location = new System.Drawing.Point(222, 140);
            this.grpPointFortFaible.Name = "grpPointFortFaible";
            this.grpPointFortFaible.Size = new System.Drawing.Size(225, 165);
            this.grpPointFortFaible.TabIndex = 31;
            this.grpPointFortFaible.TabStop = false;
            this.grpPointFortFaible.Text = "Point fort / faible";
            // 
            // lblPointFaible
            // 
            this.lblPointFaible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPointFaible.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointFaible.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPointFaible.Location = new System.Drawing.Point(9, 96);
            this.lblPointFaible.Name = "lblPointFaible";
            this.lblPointFaible.Size = new System.Drawing.Size(214, 30);
            this.lblPointFaible.TabIndex = 33;
            this.lblPointFaible.Text = "Point faible :";
            this.lblPointFaible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointFort
            // 
            this.lblPointFort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPointFort.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointFort.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPointFort.Location = new System.Drawing.Point(9, 54);
            this.lblPointFort.Name = "lblPointFort";
            this.lblPointFort.Size = new System.Drawing.Size(214, 30);
            this.lblPointFort.TabIndex = 32;
            this.lblPointFort.Text = "Point fort :";
            this.lblPointFort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDeteste);
            this.groupBox1.Controls.Add(this.lblAffinite);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(6, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 165);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affinité";
            // 
            // lblDeteste
            // 
            this.lblDeteste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDeteste.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeteste.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDeteste.Location = new System.Drawing.Point(6, 96);
            this.lblDeteste.Name = "lblDeteste";
            this.lblDeteste.Size = new System.Drawing.Size(198, 30);
            this.lblDeteste.TabIndex = 34;
            this.lblDeteste.Text = "Déteste :";
            this.lblDeteste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAffinite
            // 
            this.lblAffinite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAffinite.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffinite.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAffinite.Location = new System.Drawing.Point(6, 54);
            this.lblAffinite.Name = "lblAffinite";
            this.lblAffinite.Size = new System.Drawing.Size(198, 30);
            this.lblAffinite.TabIndex = 33;
            this.lblAffinite.Text = "Affinité avec :";
            this.lblAffinite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStress
            // 
            this.lblStress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStress.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStress.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStress.Location = new System.Drawing.Point(3, 99);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(105, 18);
            this.lblStress.TabIndex = 26;
            this.lblStress.Text = "Stress";
            this.lblStress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductivite
            // 
            this.lblProductivite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProductivite.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductivite.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblProductivite.Location = new System.Drawing.Point(3, 67);
            this.lblProductivite.Name = "lblProductivite";
            this.lblProductivite.Size = new System.Drawing.Size(105, 20);
            this.lblProductivite.TabIndex = 25;
            this.lblProductivite.Text = "Productivité";
            this.lblProductivite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFatigue
            // 
            this.lblFatigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFatigue.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatigue.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFatigue.Location = new System.Drawing.Point(3, 36);
            this.lblFatigue.Name = "lblFatigue";
            this.lblFatigue.Size = new System.Drawing.Size(105, 21);
            this.lblFatigue.TabIndex = 24;
            this.lblFatigue.Text = "Fatigue";
            this.lblFatigue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPerso
            // 
            this.pbPerso.Location = new System.Drawing.Point(24, 132);
            this.pbPerso.Name = "pbPerso";
            this.pbPerso.Size = new System.Drawing.Size(198, 275);
            this.pbPerso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPerso.TabIndex = 2;
            this.pbPerso.TabStop = false;
            // 
            // frmStatPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(951, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPerso);
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.lblPrenomPerso);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatPerso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStatPerso";
            this.pnlHaut.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpQualiteDefaut.ResumeLayout(false);
            this.grpPointFortFaible.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRevenir;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Label lblLstTache;
        private System.Windows.Forms.PictureBox pbPerso;
        private System.Windows.Forms.Label lblPrenomPerso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.Label lblProductivite;
        private System.Windows.Forms.Label lblFatigue;
        private System.Windows.Forms.Label lblPointFaible;
        private System.Windows.Forms.Label lblPointFort;
        private System.Windows.Forms.GroupBox grpPointFortFaible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAffinite;
        private System.Windows.Forms.Label lblDeteste;
        private Bunifu.Framework.UI.BunifuProgressBar pbStress;
        private Bunifu.Framework.UI.BunifuProgressBar pbProductivite;
        private Bunifu.Framework.UI.BunifuProgressBar pbFatigue;
        private System.Windows.Forms.GroupBox grpQualiteDefaut;
        private System.Windows.Forms.Label lblDéfaut;
        private System.Windows.Forms.Label lblQualite;
    }
}