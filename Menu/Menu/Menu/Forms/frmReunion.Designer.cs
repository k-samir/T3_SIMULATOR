namespace Menu.Forms
{
    partial class frmReunion
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFinReunion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(33, 272);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 98);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faire le point";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.btnInfo3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(33, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "Découvir l\'équipe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(33, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 98);
            this.button2.TabIndex = 1;
            this.button2.Text = "Examiner le projet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnInfo2_Click);
            // 
            // btnFinReunion
            // 
            this.btnFinReunion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinReunion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinReunion.FlatAppearance.BorderSize = 0;
            this.btnFinReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinReunion.ForeColor = System.Drawing.Color.White;
            this.btnFinReunion.Location = new System.Drawing.Point(35, 406);
            this.btnFinReunion.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinReunion.Name = "btnFinReunion";
            this.btnFinReunion.Size = new System.Drawing.Size(259, 47);
            this.btnFinReunion.TabIndex = 3;
            this.btnFinReunion.Text = "Mettre Fin à la réunion";
            this.btnFinReunion.UseVisualStyleBackColor = false;
            this.btnFinReunion.Click += new System.EventHandler(this.btnRevenir_Click);
            // 
            // frmReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(328, 476);
            this.Controls.Add(this.btnFinReunion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReunion";
            this.Load += new System.EventHandler(this.frmReunion_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFinReunion;
    }
}