namespace Menu.Forms
{
    partial class frmReunionPopUp
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotification.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Black;
            this.lblNotification.Location = new System.Drawing.Point(136, -53);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(517, 50);
            this.lblNotification.TabIndex = 1;
            this.lblNotification.Text = "Bienvenue sur le projet T3";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotification.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(39, -9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(714, 101);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Votre projet vient de démarrer, mais par où commencer ? Une petite réunion ne ser" +
    "ait pas du luxe..";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(668, 68);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(61, 40);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 150;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 150;
            this.bunifuElipse2.TargetControl = this;
            // 
            // frmReunionPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 117);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReunionPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReunionDecouverteEquipe";
            this.Leave += new System.EventHandler(this.frmReunionPopUp_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOk;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}