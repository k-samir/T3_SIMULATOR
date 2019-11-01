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
            this.btnCrunch = new System.Windows.Forms.Button();
            this.pbAvancement = new System.Windows.Forms.ProgressBar();
            this.rtbActu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnTourSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourSuivant.Location = new System.Drawing.Point(1237, 648);
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
            this.btnQuitter.Location = new System.Drawing.Point(1237, 748);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 44);
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
            this.panel1.Location = new System.Drawing.Point(11, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 729);
            this.panel1.TabIndex = 14;
            // 
            // btnCrunch
            // 
            this.btnCrunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrunch.Location = new System.Drawing.Point(1237, 698);
            this.btnCrunch.Name = "btnCrunch";
            this.btnCrunch.Size = new System.Drawing.Size(143, 44);
            this.btnCrunch.TabIndex = 15;
            this.btnCrunch.Text = "Crunch";
            this.btnCrunch.UseVisualStyleBackColor = true;
            this.btnCrunch.Click += new System.EventHandler(this.btnCrunch_Click);
            // 
            // pbAvancement
            // 
            this.pbAvancement.Location = new System.Drawing.Point(17, 12);
            this.pbAvancement.Name = "pbAvancement";
            this.pbAvancement.Size = new System.Drawing.Size(1049, 35);
            this.pbAvancement.TabIndex = 1;
            this.pbAvancement.Value = 1;
            // 
            // rtbActu
            // 
            this.rtbActu.BackColor = System.Drawing.Color.White;
            this.rtbActu.Enabled = false;
            this.rtbActu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbActu.ForeColor = System.Drawing.Color.Black;
            this.rtbActu.Location = new System.Drawing.Point(1190, 89);
            this.rtbActu.Name = "rtbActu";
            this.rtbActu.Size = new System.Drawing.Size(233, 532);
            this.rtbActu.TabIndex = 16;
            this.rtbActu.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1220, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "Actu Projet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uC_Personnage3
            // 
            this.uC_Personnage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage3.Location = new System.Drawing.Point(6, 15);
            this.uC_Personnage3.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage3.Name = "uC_Personnage3";
            this.uC_Personnage3.Size = new System.Drawing.Size(556, 340);
            this.uC_Personnage3.TabIndex = 11;
            // 
            // uC_Personnage4
            // 
            this.uC_Personnage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage4.Location = new System.Drawing.Point(566, 402);
            this.uC_Personnage4.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage4.Name = "uC_Personnage4";
            this.uC_Personnage4.Size = new System.Drawing.Size(562, 411);
            this.uC_Personnage4.TabIndex = 12;
            // 
            // uC_Personnage2
            // 
            this.uC_Personnage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage2.Location = new System.Drawing.Point(566, 15);
            this.uC_Personnage2.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage2.Name = "uC_Personnage2";
            this.uC_Personnage2.Size = new System.Drawing.Size(558, 340);
            this.uC_Personnage2.TabIndex = 10;
            // 
            // uC_Personnage1
            // 
            this.uC_Personnage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uC_Personnage1.Location = new System.Drawing.Point(7, 402);
            this.uC_Personnage1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Personnage1.Name = "uC_Personnage1";
            this.uC_Personnage1.Size = new System.Drawing.Size(556, 494);
            this.uC_Personnage1.TabIndex = 9;
            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbActu);
            this.Controls.Add(this.btnCrunch);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTourSuivant);
            this.Controls.Add(this.pbAvancement);
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
        private System.Windows.Forms.Button btnCrunch;
        private System.Windows.Forms.ProgressBar pbAvancement;
        private System.Windows.Forms.RichTextBox rtbActu;
        private System.Windows.Forms.Label label1;
    }
}