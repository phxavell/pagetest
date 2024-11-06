namespace pagetest
{
    partial class MainEthernet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEthernet));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label2 = new Label();
            lblDownloadSpeed = new Label();
            label4 = new Label();
            lblUploadSpeed = new Label();
            plotView = new OxyPlot.WindowsForms.PlotView();
            lblPing = new Label();
            label5 = new Label();
            lblAverageDownload = new Label();
            lblAverageUpload = new Label();
            label7 = new Label();
            label8 = new Label();
            downinit = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.Black;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(31, 106);
            webView21.Margin = new Padding(3, 2, 3, 2);
            webView21.Name = "webView21";
            webView21.Size = new Size(551, 301);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(708, 23);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "DOWNLOAD";
            // 
            // lblDownloadSpeed
            // 
            lblDownloadSpeed.AutoSize = true;
            lblDownloadSpeed.BackColor = Color.DimGray;
            lblDownloadSpeed.Location = new Point(708, 62);
            lblDownloadSpeed.Name = "lblDownloadSpeed";
            lblDownloadSpeed.Size = new Size(31, 15);
            lblDownloadSpeed.TabIndex = 3;
            lblDownloadSpeed.Text = "unit.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(980, 23);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "UPLOAD";
            // 
            // lblUploadSpeed
            // 
            lblUploadSpeed.AutoSize = true;
            lblUploadSpeed.BackColor = Color.DimGray;
            lblUploadSpeed.Location = new Point(980, 62);
            lblUploadSpeed.Name = "lblUploadSpeed";
            lblUploadSpeed.Size = new Size(31, 15);
            lblUploadSpeed.TabIndex = 5;
            lblUploadSpeed.Text = "unit.";
            // 
            // plotView
            // 
            plotView.BackColor = Color.White;
            plotView.Location = new Point(708, 156);
            plotView.Margin = new Padding(3, 2, 3, 2);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(329, 183);
            plotView.TabIndex = 6;
            plotView.Text = "plotView";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            plotView.Click += plotView_Click;
            // 
            // lblPing
            // 
            lblPing.AutoSize = true;
            lblPing.Location = new Point(904, 392);
            lblPing.Name = "lblPing";
            lblPing.Size = new Size(31, 15);
            lblPing.TabIndex = 8;
            lblPing.Text = "xxxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(830, 392);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "LATENCIA:";
            // 
            // lblAverageDownload
            // 
            lblAverageDownload.AutoSize = true;
            lblAverageDownload.Location = new Point(742, 89);
            lblAverageDownload.Name = "lblAverageDownload";
            lblAverageDownload.Size = new Size(0, 15);
            lblAverageDownload.TabIndex = 9;
            // 
            // lblAverageUpload
            // 
            lblAverageUpload.AutoSize = true;
            lblAverageUpload.Location = new Point(1014, 93);
            lblAverageUpload.Name = "lblAverageUpload";
            lblAverageUpload.Size = new Size(0, 15);
            lblAverageUpload.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DimGray;
            label7.Location = new Point(708, 93);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 11;
            label7.Text = "AVR:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DimGray;
            label8.Location = new Point(980, 93);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 12;
            label8.Text = "AVR:";
            // 
            // downinit
            // 
            downinit.AutoSize = true;
            downinit.BackColor = Color.DimGray;
            downinit.Font = new Font("Cascadia Mono SemiBold", 20F);
            downinit.Location = new Point(253, 46);
            downinit.Name = "downinit";
            downinit.Size = new Size(0, 35);
            downinit.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.led_apagado;
            pictureBox1.Location = new Point(648, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(920, 14);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(85, 196, 252);
            pictureBox3.Image = Properties.Resources.xxx_Photoroom;
            pictureBox3.Location = new Point(31, 14);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(217, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // MainEthernet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1138, 423);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(downinit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblAverageUpload);
            Controls.Add(lblAverageDownload);
            Controls.Add(lblPing);
            Controls.Add(label5);
            Controls.Add(plotView);
            Controls.Add(lblUploadSpeed);
            Controls.Add(label4);
            Controls.Add(lblDownloadSpeed);
            Controls.Add(label2);
            Controls.Add(webView21);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainEthernet";
            Text = "TESTE DE CONEXAO ETHERNET";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label2;
        private Label lblDownloadSpeed;
        private Label label4;
        private Label lblUploadSpeed;
        private OxyPlot.WindowsForms.PlotView plotView;
        private Label lblPing;
        private Label label5;
        private Label lblAverageDownload;
        private Label lblAverageUpload;
        private Label label7;
        private Label label8;
        private Label downinit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
