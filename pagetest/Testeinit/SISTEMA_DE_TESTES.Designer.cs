
namespace TESTE_MAQUINAS
{
    partial class Sistema_Teste
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Teste));
            lblFurMark = new Label();
            lblTeclado = new Label();
            lblModelo = new Label();
            groupBoxIndividual = new GroupBox();
            lblAtualizacao = new Label();
            lblSair = new Label();
            lblBluetooth = new Label();
            lblAtivacao = new Label();
            lblFinaliza = new Label();
            lblAuditor = new Label();
            lblHDMI = new Label();
            lblAvellCustom = new Label();
            lblWifi = new Label();
            lblAudio = new Label();
            lblLCD = new Label();
            lblWebCamRec = new Label();
            lblUSB = new Label();
            lblTouchPad = new Label();
            lblDisplay = new Label();
            groupBoxFrequenciaTela = new GroupBox();
            lblHZ = new Label();
            lblInfoSistema = new Label();
            lblTime = new Label();
            lblConfirme = new Label();
            lblSerial = new Label();
            timerBateria = new System.Windows.Forms.Timer(components);
            lblDotNet = new Label();
            picBateria = new PictureBox();
            pbBateria = new ProgressBar();
            lblTempoDescarga = new Label();
            lblPercentual = new Label();
            splOpcoes = new Splitter();
            label1 = new Label();
            lblAvellWeb = new Label();
            button1 = new Button();
            groupBoxIndividual.SuspendLayout();
            groupBoxFrequenciaTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBateria).BeginInit();
            SuspendLayout();
            // 
            // lblFurMark
            // 
            lblFurMark.AutoSize = true;
            lblFurMark.BackColor = Color.Transparent;
            lblFurMark.Cursor = Cursors.Hand;
            lblFurMark.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFurMark.ForeColor = Color.Gold;
            lblFurMark.Location = new Point(48, 51);
            lblFurMark.Margin = new Padding(4, 0, 4, 0);
            lblFurMark.Name = "lblFurMark";
            lblFurMark.Size = new Size(82, 16);
            lblFurMark.TabIndex = 4;
            lblFurMark.Text = "1- BURNIN";
            // 
            // lblTeclado
            // 
            lblTeclado.AutoSize = true;
            lblTeclado.BackColor = Color.Transparent;
            lblTeclado.Cursor = Cursors.Hand;
            lblTeclado.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTeclado.ForeColor = Color.Gold;
            lblTeclado.Location = new Point(46, 75);
            lblTeclado.Margin = new Padding(4, 0, 4, 0);
            lblTeclado.Name = "lblTeclado";
            lblTeclado.Size = new Size(94, 16);
            lblTeclado.TabIndex = 5;
            lblTeclado.Text = "2- TECLADO";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.Cursor = Cursors.Hand;
            lblModelo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblModelo.ForeColor = Color.Lime;
            lblModelo.Location = new Point(82, 97);
            lblModelo.Margin = new Padding(4, 0, 4, 0);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(85, 24);
            lblModelo.TabIndex = 6;
            lblModelo.Text = "#Model:";
            // 
            // groupBoxIndividual
            // 
            groupBoxIndividual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxIndividual.BackColor = Color.Transparent;
            groupBoxIndividual.Controls.Add(lblAtualizacao);
            groupBoxIndividual.Controls.Add(lblSair);
            groupBoxIndividual.Controls.Add(lblBluetooth);
            groupBoxIndividual.Controls.Add(lblAtivacao);
            groupBoxIndividual.Controls.Add(lblFinaliza);
            groupBoxIndividual.Controls.Add(lblAuditor);
            groupBoxIndividual.Controls.Add(lblHDMI);
            groupBoxIndividual.Controls.Add(lblAvellCustom);
            groupBoxIndividual.Controls.Add(lblWifi);
            groupBoxIndividual.Controls.Add(lblAudio);
            groupBoxIndividual.Controls.Add(lblLCD);
            groupBoxIndividual.Controls.Add(lblWebCamRec);
            groupBoxIndividual.Controls.Add(lblUSB);
            groupBoxIndividual.Controls.Add(lblTouchPad);
            groupBoxIndividual.Controls.Add(lblFurMark);
            groupBoxIndividual.Controls.Add(lblTeclado);
            groupBoxIndividual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxIndividual.ForeColor = Color.White;
            groupBoxIndividual.Location = new Point(859, 47);
            groupBoxIndividual.Margin = new Padding(4, 3, 4, 3);
            groupBoxIndividual.Name = "groupBoxIndividual";
            groupBoxIndividual.Padding = new Padding(4, 3, 4, 3);
            groupBoxIndividual.Size = new Size(246, 443);
            groupBoxIndividual.TabIndex = 9;
            groupBoxIndividual.TabStop = false;
            groupBoxIndividual.Text = "Sequência de Testes";
            groupBoxIndividual.Enter += groupBoxIndividual_Enter;
            // 
            // lblAtualizacao
            // 
            lblAtualizacao.AutoSize = true;
            lblAtualizacao.BackColor = Color.Transparent;
            lblAtualizacao.Cursor = Cursors.Hand;
            lblAtualizacao.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAtualizacao.ForeColor = Color.DarkGreen;
            lblAtualizacao.Location = new Point(33, 416);
            lblAtualizacao.Margin = new Padding(4, 0, 4, 0);
            lblAtualizacao.Name = "lblAtualizacao";
            lblAtualizacao.Size = new Size(170, 16);
            lblAtualizacao.TabIndex = 25;
            lblAtualizacao.Text = "Atualização: 09/11/2024";
            lblAtualizacao.Click += lblAtualizacao_Click;
            // 
            // lblSair
            // 
            lblSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Cursor = Cursors.Hand;
            lblSair.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.Maroon;
            lblSair.Location = new Point(16, 391);
            lblSair.Margin = new Padding(4, 0, 4, 0);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(207, 18);
            lblSair.TabIndex = 24;
            lblSair.Text = "&Sair do Sistema de Testes";
            lblSair.Click += lblSair_Click;
            // 
            // lblBluetooth
            // 
            lblBluetooth.AutoSize = true;
            lblBluetooth.BackColor = Color.Transparent;
            lblBluetooth.Cursor = Cursors.Hand;
            lblBluetooth.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBluetooth.ForeColor = Color.Gold;
            lblBluetooth.Location = new Point(42, 267);
            lblBluetooth.Margin = new Padding(4, 0, 4, 0);
            lblBluetooth.Name = "lblBluetooth";
            lblBluetooth.Size = new Size(124, 16);
            lblBluetooth.TabIndex = 23;
            lblBluetooth.Text = "10- BLUETOOTH";
            // 
            // lblAtivacao
            // 
            lblAtivacao.AutoSize = true;
            lblAtivacao.BackColor = Color.Transparent;
            lblAtivacao.Cursor = Cursors.Hand;
            lblAtivacao.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAtivacao.ForeColor = Color.RoyalBlue;
            lblAtivacao.Location = new Point(37, 363);
            lblAtivacao.Margin = new Padding(4, 0, 4, 0);
            lblAtivacao.Name = "lblAtivacao";
            lblAtivacao.Size = new Size(160, 16);
            lblAtivacao.TabIndex = 21;
            lblAtivacao.Text = "14- LACRAR / LIMPAR";
            // 
            // lblFinaliza
            // 
            lblFinaliza.AutoSize = true;
            lblFinaliza.BackColor = Color.Transparent;
            lblFinaliza.Cursor = Cursors.Hand;
            lblFinaliza.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFinaliza.ForeColor = Color.Gold;
            lblFinaliza.Location = new Point(37, 339);
            lblFinaliza.Margin = new Padding(4, 0, 4, 0);
            lblFinaliza.Name = "lblFinaliza";
            lblFinaliza.Size = new Size(97, 16);
            lblFinaliza.TabIndex = 16;
            lblFinaliza.Text = "13- FINALIZA";
            // 
            // lblAuditor
            // 
            lblAuditor.AutoSize = true;
            lblAuditor.BackColor = Color.Transparent;
            lblAuditor.Cursor = Cursors.Hand;
            lblAuditor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAuditor.ForeColor = Color.Gold;
            lblAuditor.Location = new Point(38, 315);
            lblAuditor.Margin = new Padding(4, 0, 4, 0);
            lblAuditor.Name = "lblAuditor";
            lblAuditor.Size = new Size(100, 16);
            lblAuditor.TabIndex = 15;
            lblAuditor.Text = "12- AUDITOR";
            // 
            // lblHDMI
            // 
            lblHDMI.AutoSize = true;
            lblHDMI.BackColor = Color.Transparent;
            lblHDMI.Cursor = Cursors.Hand;
            lblHDMI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHDMI.ForeColor = Color.Gold;
            lblHDMI.Location = new Point(41, 291);
            lblHDMI.Margin = new Padding(4, 0, 4, 0);
            lblHDMI.Name = "lblHDMI";
            lblHDMI.Size = new Size(70, 16);
            lblHDMI.TabIndex = 14;
            lblHDMI.Text = "11- HDMI";
            // 
            // lblAvellCustom
            // 
            lblAvellCustom.AutoSize = true;
            lblAvellCustom.BackColor = Color.Transparent;
            lblAvellCustom.Cursor = Cursors.Hand;
            lblAvellCustom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvellCustom.ForeColor = Color.Gold;
            lblAvellCustom.Location = new Point(46, 99);
            lblAvellCustom.Margin = new Padding(4, 0, 4, 0);
            lblAvellCustom.Name = "lblAvellCustom";
            lblAvellCustom.Size = new Size(142, 16);
            lblAvellCustom.TabIndex = 13;
            lblAvellCustom.Text = "3- AVELL_CUSTOM";
            // 
            // lblWifi
            // 
            lblWifi.AutoSize = true;
            lblWifi.BackColor = Color.Transparent;
            lblWifi.Cursor = Cursors.Hand;
            lblWifi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWifi.ForeColor = Color.Gold;
            lblWifi.Location = new Point(46, 242);
            lblWifi.Margin = new Padding(4, 0, 4, 0);
            lblWifi.Name = "lblWifi";
            lblWifi.Size = new Size(60, 16);
            lblWifi.TabIndex = 11;
            lblWifi.Text = "9- WI-FI";
            // 
            // lblAudio
            // 
            lblAudio.AutoSize = true;
            lblAudio.BackColor = Color.Transparent;
            lblAudio.Cursor = Cursors.Hand;
            lblAudio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAudio.ForeColor = Color.Gold;
            lblAudio.Location = new Point(46, 218);
            lblAudio.Margin = new Padding(4, 0, 4, 0);
            lblAudio.Name = "lblAudio";
            lblAudio.Size = new Size(71, 16);
            lblAudio.TabIndex = 10;
            lblAudio.Text = "8- AUDIO";
            // 
            // lblLCD
            // 
            lblLCD.AutoSize = true;
            lblLCD.BackColor = Color.Transparent;
            lblLCD.Cursor = Cursors.Hand;
            lblLCD.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLCD.ForeColor = Color.Gold;
            lblLCD.Location = new Point(46, 194);
            lblLCD.Margin = new Padding(4, 0, 4, 0);
            lblLCD.Name = "lblLCD";
            lblLCD.Size = new Size(53, 16);
            lblLCD.TabIndex = 9;
            lblLCD.Text = "7- LCD";
            // 
            // lblWebCamRec
            // 
            lblWebCamRec.AutoSize = true;
            lblWebCamRec.BackColor = Color.Transparent;
            lblWebCamRec.Cursor = Cursors.Hand;
            lblWebCamRec.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWebCamRec.ForeColor = Color.Gold;
            lblWebCamRec.Location = new Point(46, 170);
            lblWebCamRec.Margin = new Padding(4, 0, 4, 0);
            lblWebCamRec.Name = "lblWebCamRec";
            lblWebCamRec.Size = new Size(90, 16);
            lblWebCamRec.TabIndex = 8;
            lblWebCamRec.Text = "6- WEBCAM";
            // 
            // lblUSB
            // 
            lblUSB.AutoSize = true;
            lblUSB.BackColor = Color.Transparent;
            lblUSB.Cursor = Cursors.Hand;
            lblUSB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUSB.ForeColor = Color.Gold;
            lblUSB.Location = new Point(46, 145);
            lblUSB.Margin = new Padding(4, 0, 4, 0);
            lblUSB.Name = "lblUSB";
            lblUSB.Size = new Size(55, 16);
            lblUSB.TabIndex = 7;
            lblUSB.Text = "5- USB";
            // 
            // lblTouchPad
            // 
            lblTouchPad.AutoSize = true;
            lblTouchPad.BackColor = Color.Transparent;
            lblTouchPad.Cursor = Cursors.Hand;
            lblTouchPad.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTouchPad.ForeColor = Color.Gold;
            lblTouchPad.Location = new Point(46, 122);
            lblTouchPad.Margin = new Padding(4, 0, 4, 0);
            lblTouchPad.Name = "lblTouchPad";
            lblTouchPad.Size = new Size(112, 16);
            lblTouchPad.TabIndex = 6;
            lblTouchPad.Text = "4- TOUCH PAD";
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.BackColor = Color.Transparent;
            lblDisplay.Cursor = Cursors.Hand;
            lblDisplay.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplay.ForeColor = Color.Gold;
            lblDisplay.Location = new Point(7, 38);
            lblDisplay.Margin = new Padding(4, 0, 4, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(28, 24);
            lblDisplay.TabIndex = 10;
            lblDisplay.Text = "...";
            // 
            // groupBoxFrequenciaTela
            // 
            groupBoxFrequenciaTela.BackColor = Color.Transparent;
            groupBoxFrequenciaTela.Controls.Add(lblHZ);
            groupBoxFrequenciaTela.Controls.Add(lblDisplay);
            groupBoxFrequenciaTela.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFrequenciaTela.ForeColor = SystemColors.ButtonHighlight;
            groupBoxFrequenciaTela.Location = new Point(14, 243);
            groupBoxFrequenciaTela.Margin = new Padding(4, 3, 4, 3);
            groupBoxFrequenciaTela.Name = "groupBoxFrequenciaTela";
            groupBoxFrequenciaTela.Padding = new Padding(4, 3, 4, 3);
            groupBoxFrequenciaTela.Size = new Size(260, 142);
            groupBoxFrequenciaTela.TabIndex = 10;
            groupBoxFrequenciaTela.TabStop = false;
            groupBoxFrequenciaTela.Text = "Frequência de Tela";
            // 
            // lblHZ
            // 
            lblHZ.AutoSize = true;
            lblHZ.BackColor = Color.Transparent;
            lblHZ.Cursor = Cursors.Hand;
            lblHZ.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHZ.ForeColor = Color.Gold;
            lblHZ.Location = new Point(209, 96);
            lblHZ.Margin = new Padding(4, 0, 4, 0);
            lblHZ.Name = "lblHZ";
            lblHZ.Size = new Size(38, 24);
            lblHZ.TabIndex = 11;
            lblHZ.Text = "HZ";
            // 
            // lblInfoSistema
            // 
            lblInfoSistema.AutoSize = true;
            lblInfoSistema.BackColor = Color.Transparent;
            lblInfoSistema.Cursor = Cursors.Hand;
            lblInfoSistema.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInfoSistema.ForeColor = Color.White;
            lblInfoSistema.Location = new Point(21, 10);
            lblInfoSistema.Margin = new Padding(4, 0, 4, 0);
            lblInfoSistema.Name = "lblInfoSistema";
            lblInfoSistema.Size = new Size(221, 24);
            lblInfoSistema.TabIndex = 12;
            lblInfoSistema.Text = "AVELL - TESTES V6.0";
            lblInfoSistema.Click += lblInfoSistema_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkGray;
            lblTime.Location = new Point(1095, 10);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(21, 24);
            lblTime.TabIndex = 16;
            lblTime.Text = "5";
            // 
            // lblConfirme
            // 
            lblConfirme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblConfirme.AutoSize = true;
            lblConfirme.BackColor = Color.Transparent;
            lblConfirme.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirme.ForeColor = Color.DarkGray;
            lblConfirme.Location = new Point(842, 10);
            lblConfirme.Margin = new Padding(4, 0, 4, 0);
            lblConfirme.Name = "lblConfirme";
            lblConfirme.Size = new Size(211, 24);
            lblConfirme.TabIndex = 15;
            lblConfirme.Text = "INICIO DOS TESTES:";
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.BackColor = Color.Transparent;
            lblSerial.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSerial.ForeColor = Color.Lime;
            lblSerial.Location = new Point(38, 182);
            lblSerial.Margin = new Padding(4, 0, 4, 0);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(190, 25);
            lblSerial.TabIndex = 18;
            lblSerial.Text = "#NumeroDeSerie";
            // 
            // timerBateria
            // 
            timerBateria.Interval = 500;
            timerBateria.Tick += timerBateria_Tick;
            // 
            // lblDotNet
            // 
            lblDotNet.AutoSize = true;
            lblDotNet.BackColor = Color.Transparent;
            lblDotNet.Cursor = Cursors.Hand;
            lblDotNet.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDotNet.ForeColor = Color.Silver;
            lblDotNet.Location = new Point(97, 47);
            lblDotNet.Margin = new Padding(4, 0, 4, 0);
            lblDotNet.Name = "lblDotNet";
            lblDotNet.Size = new Size(59, 16);
            lblDotNet.TabIndex = 23;
            lblDotNet.Text = ".Net 8.0";
            // 
            // picBateria
            // 
            picBateria.Image = pagetest.Properties.Resources.bateria;
            picBateria.Location = new Point(1505, 795);
            picBateria.Margin = new Padding(4, 3, 4, 3);
            picBateria.Name = "picBateria";
            picBateria.Size = new Size(56, 83);
            picBateria.SizeMode = PictureBoxSizeMode.StretchImage;
            picBateria.TabIndex = 24;
            picBateria.TabStop = false;
            // 
            // pbBateria
            // 
            pbBateria.Location = new Point(307, 885);
            pbBateria.Margin = new Padding(4, 3, 4, 3);
            pbBateria.Name = "pbBateria";
            pbBateria.Size = new Size(1254, 12);
            pbBateria.TabIndex = 25;
            // 
            // lblTempoDescarga
            // 
            lblTempoDescarga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTempoDescarga.AutoSize = true;
            lblTempoDescarga.BackColor = Color.Transparent;
            lblTempoDescarga.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempoDescarga.ForeColor = Color.DarkGray;
            lblTempoDescarga.Location = new Point(282, 850);
            lblTempoDescarga.Margin = new Padding(4, 0, 4, 0);
            lblTempoDescarga.Name = "lblTempoDescarga";
            lblTempoDescarga.Size = new Size(16, 24);
            lblTempoDescarga.TabIndex = 26;
            lblTempoDescarga.Text = ".";
            // 
            // lblPercentual
            // 
            lblPercentual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPercentual.AutoSize = true;
            lblPercentual.BackColor = Color.Transparent;
            lblPercentual.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentual.ForeColor = Color.DarkGray;
            lblPercentual.Location = new Point(945, 850);
            lblPercentual.Margin = new Padding(4, 0, 4, 0);
            lblPercentual.Name = "lblPercentual";
            lblPercentual.Size = new Size(16, 24);
            lblPercentual.TabIndex = 27;
            lblPercentual.Text = ".";
            // 
            // splOpcoes
            // 
            splOpcoes.BackColor = Color.Black;
            splOpcoes.Location = new Point(0, 0);
            splOpcoes.Margin = new Padding(4, 3, 4, 3);
            splOpcoes.Name = "splOpcoes";
            splOpcoes.Size = new Size(286, 521);
            splOpcoes.TabIndex = 0;
            splOpcoes.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(-123, 850);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 28;
            label1.Text = "Status Bateria:";
            // 
            // lblAvellWeb
            // 
            lblAvellWeb.AutoSize = true;
            lblAvellWeb.BackColor = Color.Transparent;
            lblAvellWeb.Cursor = Cursors.Hand;
            lblAvellWeb.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvellWeb.ForeColor = Color.Gold;
            lblAvellWeb.Location = new Point(302, 10);
            lblAvellWeb.Margin = new Padding(4, 0, 4, 0);
            lblAvellWeb.Name = "lblAvellWeb";
            lblAvellWeb.Size = new Size(443, 24);
            lblAvellWeb.TabIndex = 12;
            lblAvellWeb.Text = "INSERINDO NA BASE DE DADOS AVELLWEB";
            // 
            // button1
            // 
            button1.Location = new Point(511, 112);
            button1.Name = "button1";
            button1.Size = new Size(103, 73);
            button1.TabIndex = 29;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sistema_Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = pagetest.Properties.Resources.bakground_sistema2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1150, 521);
            Controls.Add(button1);
            Controls.Add(lblAvellWeb);
            Controls.Add(label1);
            Controls.Add(lblPercentual);
            Controls.Add(lblTempoDescarga);
            Controls.Add(pbBateria);
            Controls.Add(picBateria);
            Controls.Add(lblDotNet);
            Controls.Add(lblSerial);
            Controls.Add(lblTime);
            Controls.Add(lblConfirme);
            Controls.Add(lblInfoSistema);
            Controls.Add(groupBoxFrequenciaTela);
            Controls.Add(groupBoxIndividual);
            Controls.Add(lblModelo);
            Controls.Add(splOpcoes);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sistema_Teste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMAS DE TESTES DE MÁQUINAS AVELL - AM";
            Load += Sistema_Teste_Load;
            groupBoxIndividual.ResumeLayout(false);
            groupBoxIndividual.PerformLayout();
            groupBoxFrequenciaTela.ResumeLayout(false);
            groupBoxFrequenciaTela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBateria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblFurMark;
        private System.Windows.Forms.Label lblTeclado;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox groupBoxIndividual;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox groupBoxFrequenciaTela;
        private System.Windows.Forms.Label lblInfoSistema;
        private System.Windows.Forms.Label lblHZ;
        private System.Windows.Forms.Label lblTouchPad;
        private System.Windows.Forms.Label lblUSB;
        private System.Windows.Forms.Label lblWebCamRec;
        private System.Windows.Forms.Label lblLCD;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.Label lblWifi;
        private System.Windows.Forms.Label lblAvellCustom;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Label lblHDMI;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Timer timerBateria;
        private System.Windows.Forms.Label lblFinaliza;
        private System.Windows.Forms.Label lblAuditor;
        private System.Windows.Forms.Label lblDotNet;
        private System.Windows.Forms.Label lblBluetooth;
        private System.Windows.Forms.Label lblAtivacao;
        private System.Windows.Forms.Label lblAtualizacao;
        private System.Windows.Forms.PictureBox picBateria;
        private System.Windows.Forms.ProgressBar pbBateria;
        private System.Windows.Forms.Label lblTempoDescarga;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Splitter splOpcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvellWeb;
        private Label lblSair;
        private Button button1;
    }
}

