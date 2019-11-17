using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class frmButReunion : Form
    {
        public frmButReunion()
        {
            InitializeComponent();
        }

        public void themeReunion(String theme)
        {
            int posGauche = 66;

            if (theme == "Découvir l'équipe")
            {
                Button button1 = new Button();
                button1.Size = new System.Drawing.Size(494, 78);
                button1.Location = new System.Drawing.Point(posGauche, 38);
                button1.Text = "Faire connaissance";
                button1.Cursor = System.Windows.Forms.Cursors.Hand;
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.ForeColor = System.Drawing.Color.Orange;
                button1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button1.Click += new System.EventHandler(this.lancerNotification);

                Button button2 = new Button();
                button2.Size = new System.Drawing.Size(494, 78);
                button2.Location = new System.Drawing.Point(posGauche, 138);
                button2.Text = "Évaluer le potentiel du groupe";
                button2.Cursor = System.Windows.Forms.Cursors.Hand;
                button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.ForeColor = System.Drawing.Color.Orange;
                button2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button2.Click += new System.EventHandler(this.lancerNotification);
                
                Button button3 = new Button();
                button3.Size = new System.Drawing.Size(494, 78);
                button3.Location = new System.Drawing.Point(posGauche, 238);
                button3.Text = "Révèle les qualités et les défauts";
                button3.Cursor = System.Windows.Forms.Cursors.Hand;
                button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.ForeColor = System.Drawing.Color.Orange;
                button3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button3.Click += new System.EventHandler(this.lancerNotification);

                Button button4 = new Button();
                button4.Size = new System.Drawing.Size(494, 78);
                button4.Location = new System.Drawing.Point(posGauche, 338);
                button4.Text = "Analyse des affinités de chacun";
                button4.Cursor = System.Windows.Forms.Cursors.Hand;
                button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button4.ForeColor = System.Drawing.Color.Orange;
                button4.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button4.Click += new System.EventHandler(this.lancerNotification);

                this.Controls.Add(button1);
                this.Controls.Add(button2);
                this.Controls.Add(button3);
                this.Controls.Add(button4);
            }

            if(theme == "Examiner le projet") {
                Button button1 = new Button();
                button1.Size = new System.Drawing.Size(494, 78);
                button1.Location = new System.Drawing.Point(posGauche, 38);
                button1.Text = "Découvrir le projet";
                button1.Cursor = System.Windows.Forms.Cursors.Hand;
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.ForeColor = System.Drawing.Color.Orange;
                button1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button1.Click += new System.EventHandler(this.lancerNotification);

                Button button2 = new Button();
                button2.Size = new System.Drawing.Size(494, 78);
                button2.Location = new System.Drawing.Point(posGauche, 138);
                button2.Text = "Analyse de la demande du client et de ses besoins";
                button2.Cursor = System.Windows.Forms.Cursors.Hand;
                button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.ForeColor = System.Drawing.Color.Orange;
                button2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button2.Click += new System.EventHandler(this.lancerNotification);

                Button button3 = new Button();
                button3.Size = new System.Drawing.Size(494, 78);
                button3.Location = new System.Drawing.Point(posGauche, 238);
                button3.Text = "Définir un cahier des charges";
                button3.Cursor = System.Windows.Forms.Cursors.Hand;
                button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.ForeColor = System.Drawing.Color.Orange;
                button3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button3.Click += new System.EventHandler(this.lancerNotification);

                Button button4 = new Button();
                button4.Size = new System.Drawing.Size(494, 78);
                button4.Location = new System.Drawing.Point(posGauche, 338);
                button4.Text = "Mettre en place un système d'organisation";
                button4.Cursor = System.Windows.Forms.Cursors.Hand;
                button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button4.ForeColor = System.Drawing.Color.Orange;
                button4.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button4.Click += new System.EventHandler(this.lancerNotification);

                Button button5 = new Button();
                button5.Size = new System.Drawing.Size(494, 78);
                button5.Location = new System.Drawing.Point(posGauche, 338);
                button5.Text = "Mettre en place un calendrier";
                button5.Cursor = System.Windows.Forms.Cursors.Hand;
                button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button5.ForeColor = System.Drawing.Color.Orange;
                button5.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button5.Click += new System.EventHandler(this.lancerNotification);

                this.Controls.Add(button1);
                this.Controls.Add(button2);
                this.Controls.Add(button3);
                this.Controls.Add(button4);
                this.Controls.Add(button5);
            }

            if(theme == "Faire le point")
            {
                Button button1 = new Button();
                button1.Size = new System.Drawing.Size(494, 78);
                button1.Location = new System.Drawing.Point(posGauche, 38);
                button1.Text = "Mettre en commun le travail et l'avancement de chacun";
                button1.Cursor = System.Windows.Forms.Cursors.Hand;
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.ForeColor = System.Drawing.Color.Orange;
                button1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button1.Click += new System.EventHandler(this.lancerNotification);

                this.Controls.Add(button1);
            }

        }


        public void lancerNotification(object sender, EventArgs e)
        {
            this.Opacity = 0.3;     //effet flouté pour le popup
            frmReunionPopUp popup = new frmReunionPopUp();
            DialogResult dr = new DialogResult();
            dr=popup.ShowDialog();
            if(popup.DialogResult == DialogResult.Cancel)
            {
                //enlever l'effet flouté
                this.Opacity = 1;
            }

            //une fois l'achievement activé on bloque le boutton avec un enable pour dire à l'utilisateur 
            //qu'il n'a plus besoin de s'occuper de cet achievement et que cette derniere a été validé
            Button b = (Button)sender;
            b.Enabled = false;  
        }

        private void btnRevenir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
