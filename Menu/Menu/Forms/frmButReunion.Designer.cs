namespace Menu.Forms
{
    partial class frmButReunion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmButReunion));
            this.btnRevenir = new System.Windows.Forms.Button();
            this.timerPopUp = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRevenir
            // 
            this.btnRevenir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRevenir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenir.FlatAppearance.BorderSize = 0;
            this.btnRevenir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenir.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenir.ForeColor = System.Drawing.Color.White;
            this.btnRevenir.Location = new System.Drawing.Point(652, 556);
            this.btnRevenir.Margin = new System.Windows.Forms.Padding(0);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(159, 58);
            this.btnRevenir.TabIndex = 4;
            this.btnRevenir.Text = "Revenir";
            this.btnRevenir.UseVisualStyleBackColor = false;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click_1);
            // 
            // timerPopUp
            // 
            this.timerPopUp.Enabled = true;
            this.timerPopUp.Interval = 1600;
            this.timerPopUp.Tick += new System.EventHandler(this.timerPopUp_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Enabled = true;
            this.timerClose.Interval = 3000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // frmButReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(844, 640);
            this.Controls.Add(this.btnRevenir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(844, 640);
            this.Name = "frmButReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "But de la réunion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRevenir;
        private System.Windows.Forms.Timer timerPopUp;
        private System.Windows.Forms.Timer timerClose;
    }
}