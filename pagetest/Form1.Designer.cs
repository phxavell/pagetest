namespace pagetest
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(162, 79);
            webView21.Name = "webView21";
            webView21.Size = new Size(630, 401);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "XXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Location = new Point(844, 65);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "DOWNLOAD";
            // 
            // lblDownloadSpeed
            // 
            lblDownloadSpeed.AutoSize = true;
            lblDownloadSpeed.Location = new Point(855, 121);
            lblDownloadSpeed.Name = "lblDownloadSpeed";
            lblDownloadSpeed.Size = new Size(50, 20);
            lblDownloadSpeed.TabIndex = 3;
            lblDownloadSpeed.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(1036, 65);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "UPLOAD";
            // 
            // lblUploadSpeed
            // 
            lblUploadSpeed.AutoSize = true;
            lblUploadSpeed.Location = new Point(1051, 121);
            lblUploadSpeed.Name = "lblUploadSpeed";
            lblUploadSpeed.Size = new Size(50, 20);
            lblUploadSpeed.TabIndex = 5;
            lblUploadSpeed.Text = "label5";
            // 
            // plotView
            // 
            plotView.Location = new Point(822, 224);
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
            lblPing.Location = new Point(1052, 471);
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
            label5.Location = new Point(968, 471);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 7;
            label5.Text = "LATENCIA:";
            // 
            // lblAverageDownload
            // 
            lblAverageDownload.AutoSize = true;
            lblAverageDownload.Location = new Point(883, 158);
            lblAverageDownload.Name = "lblAverageDownload";
            lblAverageDownload.Size = new Size(0, 20);
            lblAverageDownload.TabIndex = 9;
            // 
            // lblAverageUpload
            // 
            lblAverageUpload.AutoSize = true;
            lblAverageUpload.Location = new Point(1075, 158);
            lblAverageUpload.Name = "lblAverageUpload";
            lblAverageUpload.Size = new Size(0, 20);
            lblAverageUpload.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(844, 158);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 11;
            label7.Text = "AVR:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1036, 158);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 12;
            label8.Text = "AVR:";
            // 
            // downinit
            // 
            downinit.AutoSize = true;
            downinit.Location = new Point(570, 31);
            downinit.Name = "downinit";
            downinit.Size = new Size(67, 20);
            downinit.TabIndex = 13;
            downinit.Text = "downinit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 511);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
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
    }
}
