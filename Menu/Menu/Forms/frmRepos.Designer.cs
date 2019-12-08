namespace Menu.Forms
{
    partial class frmRepos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.btnGD = new System.Windows.Forms.Button();
            this.btnTGD = new System.Windows.Forms.Button();
            this.btnTDG = new System.Windows.Forms.Button();
            this.btnDG = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repos";
            // 
            // lstGauche
            // 
            this.lstGauche.BackColor = System.Drawing.Color.Snow;
            this.lstGauche.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.ItemHeight = 19;
            this.lstGauche.Location = new System.Drawing.Point(22, 68);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(235, 80);
            this.lstGauche.TabIndex = 1;
            // 
            // lstDroite
            // 
            this.lstDroite.BackColor = System.Drawing.Color.SpringGreen;
            this.lstDroite.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.ItemHeight = 19;
            this.lstDroite.Location = new System.Drawing.Point(279, 68);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(235, 80);
            this.lstDroite.TabIndex = 2;
            // 
            // btnGD
            // 
            this.btnGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD.ForeColor = System.Drawing.Color.Orange;
            this.btnGD.Location = new System.Drawing.Point(130, 179);
            this.btnGD.Name = "btnGD";
            this.btnGD.Size = new System.Drawing.Size(53, 46);
            this.btnGD.TabIndex = 3;
            this.btnGD.Text = ">";
            this.btnGD.UseVisualStyleBackColor = true;
            this.btnGD.Click += new System.EventHandler(this.btnGD_Click);
            // 
            // btnTGD
            // 
            this.btnTGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTGD.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTGD.ForeColor = System.Drawing.Color.Orange;
            this.btnTGD.Location = new System.Drawing.Point(204, 179);
            this.btnTGD.Name = "btnTGD";
            this.btnTGD.Size = new System.Drawing.Size(53, 46);
            this.btnTGD.TabIndex = 4;
            this.btnTGD.Text = ">>";
            this.btnTGD.UseVisualStyleBackColor = true;
            this.btnTGD.Click += new System.EventHandler(this.btnTGD_Click);
            // 
            // btnTDG
            // 
            this.btnTDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTDG.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTDG.ForeColor = System.Drawing.Color.Orange;
            this.btnTDG.Location = new System.Drawing.Point(279, 179);
            this.btnTDG.Name = "btnTDG";
            this.btnTDG.Size = new System.Drawing.Size(53, 46);
            this.btnTDG.TabIndex = 5;
            this.btnTDG.Text = "<<";
            this.btnTDG.UseVisualStyleBackColor = true;
            this.btnTDG.Click += new System.EventHandler(this.btnTDG_Click);
            // 
            // btnDG
            // 
            this.btnDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDG.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDG.ForeColor = System.Drawing.Color.Orange;
            this.btnDG.Location = new System.Drawing.Point(354, 179);
            this.btnDG.Name = "btnDG";
            this.btnDG.Size = new System.Drawing.Size(53, 46);
            this.btnDG.TabIndex = 6;
            this.btnDG.Text = "<";
            this.btnDG.UseVisualStyleBackColor = true;
            this.btnDG.Click += new System.EventHandler(this.btnDG_Click);
            // 
            // btnValider
            // 
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnValider.Location = new System.Drawing.Point(459, 213);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(84, 46);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmRepos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(555, 271);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnDG);
            this.Controls.Add(this.btnTDG);
            this.Controls.Add(this.btnTGD);
            this.Controls.Add(this.btnGD);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sélectionnez les personnages qui se reposeront.";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Repos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstGauche;
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Button btnGD;
        private System.Windows.Forms.Button btnTGD;
        private System.Windows.Forms.Button btnTDG;
        private System.Windows.Forms.Button btnDG;
        private System.Windows.Forms.Button btnValider;
    }
}