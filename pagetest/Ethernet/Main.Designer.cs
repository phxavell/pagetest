namespace pagetest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label1 = new Label();
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.Black;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(35, 141);
            webView21.Name = "webView21";
            webView21.Size = new Size(630, 401);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Location = new Point(595, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "XXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(809, 26);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "DOWNLOAD";
            // 
            // lblDownloadSpeed
            // 
            lblDownloadSpeed.AutoSize = true;
            lblDownloadSpeed.BackColor = Color.DimGray;
            lblDownloadSpeed.Location = new Point(809, 82);
            lblDownloadSpeed.Name = "lblDownloadSpeed";
            lblDownloadSpeed.Size = new Size(37, 20);
            lblDownloadSpeed.TabIndex = 3;
            lblDownloadSpeed.Text = "unit.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(1120, 31);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "UPLOAD";
            // 
            // lblUploadSpeed
            // 
            lblUploadSpeed.AutoSize = true;
            lblUploadSpeed.BackColor = Color.DimGray;
            lblUploadSpeed.Location = new Point(1120, 82);
            lblUploadSpeed.Name = "lblUploadSpeed";
            lblUploadSpeed.Size = new Size(37, 20);
            lblUploadSpeed.TabIndex = 5;
            lblUploadSpeed.Text = "unit.";
            // 
            // plotView
            // 
            plotView.BackColor = Color.FromArgb(24, 24, 24);
            plotView.Location = new Point(809, 208);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(376, 244);
            plotView.TabIndex = 6;
            plotView.Text = "plotView";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lblPing
            // 
            lblPing.AutoSize = true;
            lblPing.Location = new Point(1243, 522);
            lblPing.Name = "lblPing";
            lblPing.Size = new Size(37, 20);
            lblPing.TabIndex = 8;
            lblPing.Text = "xxxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1159, 522);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 7;
            label5.Text = "LATENCIA:";
            // 
            // lblAverageDownload
            // 
            lblAverageDownload.AutoSize = true;
            lblAverageDownload.Location = new Point(848, 119);
            lblAverageDownload.Name = "lblAverageDownload";
            lblAverageDownload.Size = new Size(0, 20);
            lblAverageDownload.TabIndex = 9;
            // 
            // lblAverageUpload
            // 
            lblAverageUpload.AutoSize = true;
            lblAverageUpload.Location = new Point(1159, 124);
            lblAverageUpload.Name = "lblAverageUpload";
            lblAverageUpload.Size = new Size(0, 20);
            lblAverageUpload.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DimGray;
            label7.Location = new Point(809, 124);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 11;
            label7.Text = "AVR:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DimGray;
            label8.Location = new Point(1120, 124);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 12;
            label8.Text = "AVR:";
            // 
            // downinit
            // 
            downinit.AutoSize = true;
            downinit.BackColor = Color.DimGray;
            downinit.Font = new Font("Cascadia Mono SemiBold", 20F);
            downinit.Location = new Point(534, 57);
            downinit.Name = "downinit";
            downinit.Size = new Size(180, 45);
            downinit.TabIndex = 13;
            downinit.Text = "downinit";
            // 
            // button1
            // 
            button1.Location = new Point(182, 17);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(182, 73);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.led_apagado;
            pictureBox1.Location = new Point(740, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1051, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(366, 32);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1300, 564);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(label1);
            Controls.Add(webView21);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "TESTE DE CONEXAO ETHERNET";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label1;
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
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}
