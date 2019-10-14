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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblFatigue = new System.Windows.Forms.Label();
            this.lblProductivite = new System.Windows.Forms.Label();
            this.lblStress = new System.Windows.Forms.Label();
            this.lblConnaissance = new System.Windows.Forms.Label();
            this.lblSociabilite = new System.Windows.Forms.Label();
            this.lblAction1 = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblAction3 = new System.Windows.Forms.Label();
            this.lblAction2 = new System.Windows.Forms.Label();
            this.lblValFatigue = new System.Windows.Forms.Label();
            this.lblValProductivite = new System.Windows.Forms.Label();
            this.lblValStress = new System.Windows.Forms.Label();
            this.lblValConnaissance = new System.Windows.Forms.Label();
            this.lblValSociabilite = new System.Windows.Forms.Label();
            this.cboFonctionnalite1 = new System.Windows.Forms.ComboBox();
            this.cboFonctionnalite2 = new System.Windows.Forms.ComboBox();
            this.cboFonctionnalite3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeure3 = new System.Windows.Forms.TextBox();
            this.txtHeure2 = new System.Windows.Forms.TextBox();
            this.txtHeure1 = new System.Windows.Forms.TextBox();
            this.cboAction1 = new System.Windows.Forms.ComboBox();
            this.cboAction3 = new System.Windows.Forms.ComboBox();
            this.cboAction2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(6, 134);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(176, 24);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom du Perso";
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
            // lblProductivite
            // 
            this.lblProductivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductivite.Location = new System.Drawing.Point(206, 36);
            this.lblProductivite.Name = "lblProductivite";
            this.lblProductivite.Size = new System.Drawing.Size(102, 26);
            this.lblProductivite.TabIndex = 3;
            this.lblProductivite.Text = "Productivité:";
            this.lblProductivite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblConnaissance
            // 
            this.lblConnaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnaissance.Location = new System.Drawing.Point(206, 88);
            this.lblConnaissance.Name = "lblConnaissance";
            this.lblConnaissance.Size = new System.Drawing.Size(127, 26);
            this.lblConnaissance.TabIndex = 5;
            this.lblConnaissance.Text = "Connaissance:";
            this.lblConnaissance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSociabilite
            // 
            this.lblSociabilite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSociabilite.Location = new System.Drawing.Point(206, 114);
            this.lblSociabilite.Name = "lblSociabilite";
            this.lblSociabilite.Size = new System.Drawing.Size(102, 26);
            this.lblSociabilite.TabIndex = 6;
            this.lblSociabilite.Text = "Sociabilité:";
            this.lblSociabilite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAction1
            // 
            this.lblAction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction1.Location = new System.Drawing.Point(12, 58);
            this.lblAction1.Name = "lblAction1";
            this.lblAction1.Size = new System.Drawing.Size(101, 38);
            this.lblAction1.TabIndex = 10;
            this.lblAction1.Text = "Action 1 :";
            this.lblAction1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.cboAction1);
            this.grpAction.Controls.Add(this.cboAction3);
            this.grpAction.Controls.Add(this.cboAction2);
            this.grpAction.Controls.Add(this.label3);
            this.grpAction.Controls.Add(this.label2);
            this.grpAction.Controls.Add(this.label1);
            this.grpAction.Controls.Add(this.txtHeure3);
            this.grpAction.Controls.Add(this.txtHeure2);
            this.grpAction.Controls.Add(this.txtHeure1);
            this.grpAction.Controls.Add(this.cboFonctionnalite3);
            this.grpAction.Controls.Add(this.cboFonctionnalite2);
            this.grpAction.Controls.Add(this.cboFonctionnalite1);
            this.grpAction.Controls.Add(this.lblAction3);
            this.grpAction.Controls.Add(this.lblAction2);
            this.grpAction.Controls.Add(this.lblAction1);
            this.grpAction.Location = new System.Drawing.Point(16, 170);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(480, 179);
            this.grpAction.TabIndex = 11;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Liste d\'actions que le personnage doit effectuer";
            // 
            // lblAction3
            // 
            this.lblAction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction3.Location = new System.Drawing.Point(12, 129);
            this.lblAction3.Name = "lblAction3";
            this.lblAction3.Size = new System.Drawing.Size(101, 38);
            this.lblAction3.TabIndex = 12;
            this.lblAction3.Text = "Action 3 :";
            this.lblAction3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAction2
            // 
            this.lblAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction2.Location = new System.Drawing.Point(11, 92);
            this.lblAction2.Name = "lblAction2";
            this.lblAction2.Size = new System.Drawing.Size(101, 38);
            this.lblAction2.TabIndex = 11;
            this.lblAction2.Text = "Action 2 :";
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
            // lblValProductivite
            // 
            this.lblValProductivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValProductivite.Location = new System.Drawing.Point(339, 36);
            this.lblValProductivite.Name = "lblValProductivite";
            this.lblValProductivite.Size = new System.Drawing.Size(73, 26);
            this.lblValProductivite.TabIndex = 13;
            this.lblValProductivite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblValSociabilite
            // 
            this.lblValSociabilite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValSociabilite.Location = new System.Drawing.Point(339, 112);
            this.lblValSociabilite.Name = "lblValSociabilite";
            this.lblValSociabilite.Size = new System.Drawing.Size(73, 26);
            this.lblValSociabilite.TabIndex = 16;
            this.lblValSociabilite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFonctionnalite1
            // 
            this.cboFonctionnalite1.FormattingEnabled = true;
            this.cboFonctionnalite1.Location = new System.Drawing.Point(220, 53);
            this.cboFonctionnalite1.Name = "cboFonctionnalite1";
            this.cboFonctionnalite1.Size = new System.Drawing.Size(138, 37);
            this.cboFonctionnalite1.TabIndex = 13;
            // 
            // cboFonctionnalite2
            // 
            this.cboFonctionnalite2.FormattingEnabled = true;
            this.cboFonctionnalite2.Location = new System.Drawing.Point(220, 96);
            this.cboFonctionnalite2.Name = "cboFonctionnalite2";
            this.cboFonctionnalite2.Size = new System.Drawing.Size(138, 37);
            this.cboFonctionnalite2.TabIndex = 14;
            // 
            // cboFonctionnalite3
            // 
            this.cboFonctionnalite3.FormattingEnabled = true;
            this.cboFonctionnalite3.Location = new System.Drawing.Point(220, 134);
            this.cboFonctionnalite3.Name = "cboFonctionnalite3";
            this.cboFonctionnalite3.Size = new System.Drawing.Size(138, 37);
            this.cboFonctionnalite3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "h";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "h";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "h";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHeure3
            // 
            this.txtHeure3.Location = new System.Drawing.Point(364, 136);
            this.txtHeure3.Name = "txtHeure3";
            this.txtHeure3.Size = new System.Drawing.Size(64, 34);
            this.txtHeure3.TabIndex = 27;
            // 
            // txtHeure2
            // 
            this.txtHeure2.Location = new System.Drawing.Point(364, 96);
            this.txtHeure2.Name = "txtHeure2";
            this.txtHeure2.Size = new System.Drawing.Size(64, 34);
            this.txtHeure2.TabIndex = 26;
            // 
            // txtHeure1
            // 
            this.txtHeure1.Location = new System.Drawing.Point(364, 56);
            this.txtHeure1.Name = "txtHeure1";
            this.txtHeure1.Size = new System.Drawing.Size(64, 34);
            this.txtHeure1.TabIndex = 25;
            this.txtHeure1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboAction1
            // 
            this.cboAction1.FormattingEnabled = true;
            this.cboAction1.Location = new System.Drawing.Point(114, 54);
            this.cboAction1.Name = "cboAction1";
            this.cboAction1.Size = new System.Drawing.Size(100, 37);
            this.cboAction1.TabIndex = 31;
            // 
            // cboAction3
            // 
            this.cboAction3.FormattingEnabled = true;
            this.cboAction3.Location = new System.Drawing.Point(115, 133);
            this.cboAction3.Name = "cboAction3";
            this.cboAction3.Size = new System.Drawing.Size(100, 37);
            this.cboAction3.TabIndex = 33;
            // 
            // cboAction2
            // 
            this.cboAction2.FormattingEnabled = true;
            this.cboAction2.Location = new System.Drawing.Point(115, 94);
            this.cboAction2.Name = "cboAction2";
            this.cboAction2.Size = new System.Drawing.Size(100, 37);
            this.cboAction2.TabIndex = 32;
            // 
            // UC_Personnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblValSociabilite);
            this.Controls.Add(this.lblValConnaissance);
            this.Controls.Add(this.lblValStress);
            this.Controls.Add(this.lblValProductivite);
            this.Controls.Add(this.lblValFatigue);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.lblSociabilite);
            this.Controls.Add(this.lblConnaissance);
            this.Controls.Add(this.lblStress);
            this.Controls.Add(this.lblProductivite);
            this.Controls.Add(this.lblFatigue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_Personnage";
            this.Size = new System.Drawing.Size(501, 441);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblFatigue;
        private System.Windows.Forms.Label lblProductivite;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.Label lblConnaissance;
        private System.Windows.Forms.Label lblSociabilite;
        private System.Windows.Forms.Label lblAction1;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblAction3;
        private System.Windows.Forms.Label lblAction2;
        private System.Windows.Forms.Label lblValFatigue;
        private System.Windows.Forms.Label lblValProductivite;
        private System.Windows.Forms.Label lblValStress;
        private System.Windows.Forms.Label lblValConnaissance;
        private System.Windows.Forms.Label lblValSociabilite;
        private System.Windows.Forms.ComboBox cboFonctionnalite3;
        private System.Windows.Forms.ComboBox cboFonctionnalite2;
        private System.Windows.Forms.ComboBox cboFonctionnalite1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeure3;
        private System.Windows.Forms.TextBox txtHeure2;
        private System.Windows.Forms.TextBox txtHeure1;
        private System.Windows.Forms.ComboBox cboAction1;
        private System.Windows.Forms.ComboBox cboAction3;
        private System.Windows.Forms.ComboBox cboAction2;
    }
}
