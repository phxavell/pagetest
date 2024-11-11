
namespace WEBCAM
{
    partial class VALIDARECFACIAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VALIDARECFACIAL));
            panelOK = new Panel();
            lblTime = new Label();
            pictureBoxOK = new PictureBox();
            lblConfirme = new Label();
            lblFirebase = new Label();
            panelOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOK).BeginInit();
            SuspendLayout();
            // 
            // panelOK
            // 
            panelOK.BackColor = Color.ForestGreen;
            panelOK.Controls.Add(lblTime);
            panelOK.Controls.Add(pictureBoxOK);
            panelOK.Controls.Add(lblConfirme);
            panelOK.Location = new Point(-1, 74);
            panelOK.Margin = new Padding(4, 3, 4, 3);
            panelOK.Name = "panelOK";
            panelOK.Size = new Size(534, 477);
            panelOK.TabIndex = 16;
            panelOK.Paint += panelOK_Paint;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkBlue;
            lblTime.Location = new Point(472, 329);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(21, 24);
            lblTime.TabIndex = 14;
            lblTime.Text = "3";
            // 
            // pictureBoxOK
            // 
            pictureBoxOK.Image = pagetest.Properties.Resources.confirmarOK;
            pictureBoxOK.Location = new Point(146, 52);
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
            lblConfirme.Location = new Point(29, 329);
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
            lblFirebase.TabIndex = 40;
            lblFirebase.Text = ".";
            // 
            // VALIDARECFACIAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 550);
            Controls.Add(lblFirebase);
            Controls.Add(panelOK);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "VALIDARECFACIAL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RECONHECIMENTO FACIAL WEB CAM OK!";
            panelOK.ResumeLayout(false);
            panelOK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Label lblFirebase;
    }
}