﻿
namespace RGB
{
    partial class CONFIRMATELAPIX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONFIRMATELAPIX));
            this.lblConfirme = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirme.Location = new System.Drawing.Point(23, 307);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(392, 24);
            this.lblConfirme.TabIndex = 17;
            this.lblConfirme.Text = "LCD EM PERFEITO FUNCIONAMENTO?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pagetest.Properties.Resources.lcds;
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.Red;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.Location = new System.Drawing.Point(239, 374);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(156, 40);
            this.btnNao.TabIndex = 15;
            this.btnNao.Text = "NÃO";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.Location = new System.Drawing.Point(34, 374);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(156, 40);
            this.btnSim.TabIndex = 14;
            this.btnSim.Text = "SIM";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(383, 337);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 24);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "20";
            // 
            // CONFIRMATELAPIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 438);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CONFIRMATELAPIX";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRMA TESTE LCD";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label lblTime;
    }
}