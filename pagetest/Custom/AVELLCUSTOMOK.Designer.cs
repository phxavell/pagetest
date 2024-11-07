
namespace AVELLCUSTOM1
{
    partial class AVELLCUSTOMOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVELLCUSTOMOK));
            panel1 = new Panel();
            lblTime = new Label();
            pictureBoxOK = new PictureBox();
            lblConfirme = new Label();
            lblFirebase = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOK).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(pictureBoxOK);
            panel1.Controls.Add(lblConfirme);
            panel1.Location = new Point(-1, 74);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 477);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkBlue;
            lblTime.Location = new Point(476, 329);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(21, 24);
            lblTime.TabIndex = 15;
            lblTime.Text = "3";
            // 
            // pictureBoxOK
            // 
            pictureBoxOK.Image = pagetest.Properties.Resources.confirmarOK;
            pictureBoxOK.Location = new Point(142, 52);
            pictureBoxOK.Margin = new Padding(4, 3, 4, 3);
            pictureBoxOK.Name = "pictureBoxOK";
            pictureBoxOK.Size = new Size(254, 224);
            pictureBoxOK.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOK.TabIndex = 13;
            pictureBoxOK.TabStop = false;
            // 
            // lblConfirme
            // 
            lblConfirme.AutoSize = true;
            lblConfirme.BackColor = Color.Transparent;
            lblConfirme.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirme.ForeColor = Color.DarkBlue;
            lblConfirme.Location = new Point(33, 329);
            lblConfirme.Margin = new Padding(4, 0, 4, 0);
            lblConfirme.Name = "lblConfirme";
            lblConfirme.Size = new Size(374, 24);
            lblConfirme.TabIndex = 12;
            lblConfirme.Text = "SEGUINDO PARA O PRÓXIMO TESTE";
            // 
            // lblFirebase
            // 
            lblFirebase.AutoSize = true;
            lblFirebase.BackColor = Color.Transparent;
            lblFirebase.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFirebase.ForeColor = Color.Gainsboro;
            lblFirebase.Location = new Point(14, 10);
            lblFirebase.Margin = new Padding(4, 0, 4, 0);
            lblFirebase.Name = "lblFirebase";
            lblFirebase.Size = new Size(14, 20);
            lblFirebase.TabIndex = 37;
            lblFirebase.Text = ".";
            // 
            // AVELLCUSTOMOK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 550);
            Controls.Add(lblFirebase);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AVELLCUSTOMOK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TESTE AVELL CUSTOM OK!";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFirebase;
    }
}