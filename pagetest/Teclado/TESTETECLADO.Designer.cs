
namespace TECLADO
{
    partial class TESTETECLADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TESTETECLADO));
            lblConfirme = new Label();
            pictureBoxTeclado = new PictureBox();
            lblTime = new Label();
            lblFirebase = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeclado).BeginInit();
            SuspendLayout();
            // 
            // lblConfirme
            // 
            lblConfirme.AutoSize = true;
            lblConfirme.BackColor = Color.Transparent;
            lblConfirme.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirme.ForeColor = Color.DarkBlue;
            lblConfirme.Location = new Point(26, 365);
            lblConfirme.Margin = new Padding(4, 0, 4, 0);
            lblConfirme.Name = "lblConfirme";
            lblConfirme.Size = new Size(257, 24);
            lblConfirme.TabIndex = 11;
            lblConfirme.Text = "INICIAR TESTE TECLADO";
            lblConfirme.Click += lblConfirme_Click;
            // 
            // pictureBoxTeclado
            // 
            pictureBoxTeclado.Image = pagetest.Properties.Resources.TecladoLight;
            pictureBoxTeclado.Location = new Point(14, 90);
            pictureBoxTeclado.Margin = new Padding(4, 3, 4, 3);
            pictureBoxTeclado.Name = "pictureBoxTeclado";
            pictureBoxTeclado.Size = new Size(509, 255);
            pictureBoxTeclado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeclado.TabIndex = 7;
            pictureBoxTeclado.TabStop = false;
            pictureBoxTeclado.Click += pictureBoxTeclado_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkBlue;
            lblTime.Location = new Point(484, 365);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(21, 24);
            lblTime.TabIndex = 13;
            lblTime.Text = "3";
            // 
            // lblFirebase
            // 
            lblFirebase.AutoSize = true;
            lblFirebase.BackColor = Color.Transparent;
            lblFirebase.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirebase.ForeColor = Color.LimeGreen;
            lblFirebase.Location = new Point(240, 38);
            lblFirebase.Margin = new Padding(4, 0, 4, 0);
            lblFirebase.Name = "lblFirebase";
            lblFirebase.Size = new Size(13, 20);
            lblFirebase.TabIndex = 14;
            lblFirebase.Text = ".";
            // 
            // TESTETECLADO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 415);
            Controls.Add(lblFirebase);
            Controls.Add(lblTime);
            Controls.Add(lblConfirme);
            Controls.Add(pictureBoxTeclado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TESTETECLADO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TESTE DE TECLADOS";
            TopMost = true;
            Load += TESTETECLADO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeclado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.PictureBox pictureBoxTeclado;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFirebase;
    }
}