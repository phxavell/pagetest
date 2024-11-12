using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Management; // Adicione esta refer�ncia
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using TECLADO;

namespace pagetest
{
    public partial class MainEthernet : Form
    {
        private PerformanceCounter _downloadCounter;
        private PerformanceCounter _uploadCounter;
        private System.Windows.Forms.Timer _timer;
        private Ping _ping;

        private PlotModel _plotModel;

        // Vari�veis para armazenar dados v�lidos durante os testes
        private List<float> _validDownloadValues;
        private List<float> _validUploadValues;
        private bool _isTestingUpload;
        private bool _isTested;
        private bool _isTesting = false;
        private bool _isTestingU = false;

        // Vari�veis para m�dias
        private float _averageDownload;
        private float _averageUpload;

        public MainEthernet()
        {
            InitializeComponent();
            GetAllNetworkInterfaces();
            InitializeNetworkCounters();
            InitializePlot();

            // Inicializa��o das listas
            _validDownloadValues = new List<float>();
            _validUploadValues = new List<float>();
            _isTestingUpload = false; // Come�a com download

            // Inicializa o Ping
            _ping = new Ping();
        }

        private void InitializePlot()
        {
            _plotModel = new PlotModel { Title = "Network Speed" };

            var downloadSeries = new LineSeries
            {
                Title = "Download",
                Color = OxyColors.Blue
            };

            var uploadSeries = new LineSeries
            {
                Title = "Upload",
                Color = OxyColor.FromRgb(255, 165, 0) // Laranja
            };

            _plotModel.Series.Add(downloadSeries);
            _plotModel.Series.Add(uploadSeries);
            plotView.Model = _plotModel;
        }

        private List<string> GetAllNetworkInterfaces()
        {
            {
                var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                var interfaceInfos = new List<string>();

                foreach (var ni in networkInterfaces)
                {
                    // Formata a informa��o para incluir o nome e a descri��o
                    var info = $"{ni.Description}";
                    interfaceInfos.Add(info); // Adiciona o nome e descri��o � lista
                }

                return interfaceInfos; // Retorna a lista de interfaces com nome e descri��o

                //PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
                //String[] instancename = category.GetInstanceNames();

                //foreach (string name in instancename)
                //{
                //    Console.WriteLine(name);
                //}
                //return interfaceInfos;
            }
        }

        private void InitializeNetworkCounters()
        {
            // Obtenha todas as interfaces de rede
            var allInterfaces = GetAllNetworkInterfaces();

            // Busque a interface de rede que come�a com "Realtek Gaming 2.5GbE"
            string interfaceName = allInterfaces
                .FirstOrDefault(ni => ni.StartsWith("Realtek Gaming 2.5GbE"));

            if (interfaceName != null)
            {
                // Crie os contadores de desempenho com base na interface encontrada [0] = "Realtek Gaming 2.5GbE Family Controller" [1] = "Realtek Gaming 2.5GbE Family Controller _2"
                _downloadCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", "Intel[R] Wi-Fi 6 AX201 160MHz");
                _uploadCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", "Intel[R] Wi-Fi 6 AX201 160MHz");

                // Inicie o temporizador para atualiza��o peri�dica
                _timer = new System.Windows.Forms.Timer();
                _timer.Interval = 1000; // Atualiza a cada 1 segundo
                _timer.Tick += Timer_Tick;
                _timer.Start();
            }
            else
            {
                // Lidar com a situa��o em que nenhuma interface correspondente foi encontrada
                MessageBox.Show("Interface de rede 'Realtek Gaming 2.5GbE' n�o encontrada.");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float downloadSpeed = _downloadCounter.NextValue() / 125000; // Converte para Mbps
            float uploadSpeed = _uploadCounter.NextValue() / 125000; // Converte para Mbps

            lblDownloadSpeed.Text = $"Download: {downloadSpeed:F2} Mbps";
            lblUploadSpeed.Text = $"Upload: {uploadSpeed:F2} Mbps";

            // Adiciona os pontos ao gr�fico
            var downloadSeries = (LineSeries)_plotModel.Series[0];
            var uploadSeries = (LineSeries)_plotModel.Series[1];

            downloadSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), downloadSpeed));
            uploadSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), uploadSpeed));

            // Verifica se os testes est�o em andamento e armazena os valores v�lidos
            if (_isTesting)
            {
                _validDownloadValues.Add(downloadSpeed);
            }

            if (_isTestingU)
            {
                _validUploadValues.Add(uploadSpeed);
            }

            // L�gica de teste de download
            if (downloadSpeed > 40 && !_isTesting)
            {
                _isTesting = true;
                downinit.Text = "DOWNLOAD INICIADO..";
                pictureBox1.Image = Properties.Resources.led_vermelho;
                _validDownloadValues.Clear(); // Limpa os valores anteriores
            }

            if (downloadSpeed < 1 && _isTesting)
            {
                downinit.Text = "DOWNLOAD FINALIZADO";
                pictureBox1.Image = Properties.Resources.led_acesso_verde;
                _isTesting = false;
                _averageDownload = CalculateAverage(_validDownloadValues);
                float filteredAverageDownload = CalculateFilteredAverage(_validDownloadValues);
                lblAverageDownload.Text = $"{_averageDownload:F2} Mbps\n{filteredAverageDownload:F2} Mbps(Filter)";
                _validDownloadValues.Clear(); // Limpa os valores ap�s calcular a m�dia

               
            }

            // L�gica de teste de upload
            if (uploadSpeed > 10 && !_isTestingU)
            {
                _isTestingU = true;
                downinit.Text = "UPLOAD INICIADO..";
                pictureBox2.Image = Properties.Resources.led_vermelho;
                _validUploadValues.Clear(); // Limpa os valores anteriores
            }

            if (uploadSpeed < 2 && _isTestingU)
            {
                downinit.Text = "UPLOAD FINALIZADO";
                pictureBox2.Image = Properties.Resources.led_acesso_verde;
                _isTestingU = false;
                _averageUpload = CalculateAverage(_validUploadValues);
                float filteredAverageUpload = CalculateFilteredAverage(_validUploadValues);
                lblAverageUpload.Text = $"{_averageUpload:F2} Mbps\n{filteredAverageUpload:F2} Mbps(Filter)";
                _validUploadValues.Clear(); // Limpa os valores ap�s calcular a m�dia

                // Verifica��o do resultado do teste de upload

                // Verifica��o do resultado do teste de download
                if (_averageDownload < 40)
                {
                    MessageBox.Show("Teste Ethernet Reprovado Downstream", "Resultado do Teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (_averageUpload < 4)
                {
                    MessageBox.Show("Teste Ethernet Reprovado Upstream", "Resultado do Teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Teste Ethernet Aprovado", "Resultado do Teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Salva a imagem do gr�fico
                    SavePlotImage(Application.StartupPath);

                    TECLADO.TESTETECLADO TESTE = new TECLADO.TESTETECLADO();
                    this.Hide();
                    TESTE.ShowDialog();

                }
            }

            // Limite de pontos no gr�fico
            if (downloadSeries.Points.Count > 60)
            {
                downloadSeries.Points.RemoveAt(0);
                uploadSeries.Points.RemoveAt(0);
            }

            _plotModel.InvalidatePlot(true); // Atualiza o gr�fico

            // Medir o ping
            MeasurePing("8.8.8.8");
        }

        private float CalculateAverage(List<float> values)
        {
            if (values.Count == 0) return 0;
            float sum = values.Sum();
            return sum / values.Count;
        }

        private float CalculateFilteredAverage(List<float> values)
        {
            if (values.Count == 0) return 0;

            // Ordena a lista de valores
            var sortedValues = new List<float>(values);
            sortedValues.Sort();

            // Define limites para descartar os outliers
            int discardCount = (int)(sortedValues.Count * 0.1); // 10% dos valores

            // Cria uma nova lista sem os outliers
            var filteredValues = sortedValues.Skip(discardCount).Take(sortedValues.Count - 2 * discardCount).ToList();

            // Calcula a m�dia dos valores filtrados
            if (filteredValues.Count == 0) return 0;
            float sum = filteredValues.Sum();
            return sum / filteredValues.Count;
        }

        private async void MeasurePing(string address)
        {
            try
            {
                var reply = await _ping.SendPingAsync(address);
                if (reply.Status == IPStatus.Success)
                {
                    lblPing.Text = $"Ping: {reply.RoundtripTime} ms";
                }
                else
                {
                    lblPing.Text = "Ping: Falhou";
                }
            }
            catch
            {
                lblPing.Text = "Ping: Erro";
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            string filePath = Path.Combine(Application.StartupPath, "speedtest.html");
            webView21.Source = new Uri(filePath);
            //           webView21.CoreWebView2.WebMessageReceived += WebView2_WebMessageReceived;
            webView21.NavigationCompleted += WebView_NavigationCompleted;
        }

        private void WebView2_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            var message = e.TryGetWebMessageAsString();

            if (message == "start-speed-test")
            {
                webView21.Visible = true; // Oculta a WebView
            }
        }

        private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // Injeta JavaScript para fazer um leve scroll
                string script = "window.scrollBy(0,270);"; // Scrolla 200 pixels para baixo
                await webView21.CoreWebView2.ExecuteScriptAsync(script);
            }
            else
            {
                MessageBox.Show("Erro ao carregar a p�gina.");
            }
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            // L�gica adicional ao clicar na WebView, se necess�rio
        }

        private void SavePlotImage(string directoryPath)
        {
            string serialNumber = GetSerialNumber();
            string fileName = $"Network_test_serial_{serialNumber}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                var pngExporter = new PngExporter { Width = 800, Height = 400 };
                pngExporter.Export(_plotModel, stream);
            }
        }

        private string GetSerialNumber()
        {
            string serialNumber = string.Empty;

            using (var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS"))
            {
                foreach (var obj in searcher.Get())
                {
                    serialNumber = obj["SerialNumber"]?.ToString();
                    break; // Pega o primeiro resultado
                }
            }

            return serialNumber ?? "Unknown"; // Retorna "Unknown" se n�o conseguir encontrar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.Visible = true; // Oculta a WebView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView21.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //    webView21.Visible = true; // Oculta a WebView
            pictureBox1.Image = Properties.Resources.led_acesso_verde;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //webView21.Visible = false;
            pictureBox1.Image = Properties.Resources.led_apagado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.led_vermelho;
        }

        private void plotView_Click(object sender, EventArgs e)
        {

        }
    }
}
