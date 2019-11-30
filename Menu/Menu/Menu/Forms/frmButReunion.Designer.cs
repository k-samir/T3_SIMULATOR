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
            this.btnRevenir = new System.Windows.Forms.Button();
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
            this.btnRevenir.Location = new System.Drawing.Point(489, 425);
            this.btnRevenir.Margin = new System.Windows.Forms.Padding(0);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(119, 47);
            this.btnRevenir.TabIndex = 4;
            this.btnRevenir.Text = "Revenir";
            this.btnRevenir.UseVisualStyleBackColor = false;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click_1);
            // 
            // frmButReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(617, 481);
            this.Controls.Add(this.btnRevenir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(633, 520);
            this.Name = "frmButReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmButReunion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRevenir;
    }
}