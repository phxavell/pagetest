
namespace AVELLCUSTOM1
{
    partial class CUSTOM1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUSTOM1));
            pictureBox1 = new PictureBox();
            lblTempo = new Label();
            lblTime = new Label();
            lblFirebase = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = pagetest.Properties.Resources.custom;
            pictureBox1.Location = new Point(14, 84);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.Transparent;
            lblTempo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempo.ForeColor = Color.DarkBlue;
            lblTempo.Location = new Point(14, 316);
            lblTempo.Margin = new Padding(4, 0, 4, 0);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(83, 24);
            lblTempo.TabIndex = 14;
            lblTempo.Text = "TESTE:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkBlue;
            lblTime.Location = new Point(400, 316);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(16, 24);
            lblTime.TabIndex = 16;
            lblTime.Text = ".";
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
            lblFirebase.TabIndex = 39;
            lblFirebase.Text = ".";
            // 
            // CUSTOM1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 376);
            Controls.Add(lblFirebase);
            Controls.Add(lblTime);
            Controls.Add(lblTempo);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CUSTOM1";
            Opacity = 0.9D;
            Text = "AVELL CUSTOM ";
            TopMost = true;
            Load += CUSTOM1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFirebase;
    }
}

