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

namespace pagetest
{
    public partial class Form1 : Form
    {
        private PerformanceCounter _downloadCounter;
        private PerformanceCounter _uploadCounter;
        private System.Windows.Forms.Timer _timer;
        private Ping _ping;

        private PlotModel _plotModel;

        // Variáveis para armazenar dados válidos durante os testes
        private List<float> _validDownloadValues;
        private List<float> _validUploadValues;
        private bool _isTestingUpload;
        private bool _isTested;
        private bool _isTesting = false;
        private bool _isTestingU = false;

        // Variáveis para médias
        private float _averageDownload;
        private float _averageUpload;

        public Form1()
        {
            InitializeComponent();
            InitializeNetworkCounters();
            InitializePlot();

            // Inicialização das listas
            _validDownloadValues = new List<float>();
            _validUploadValues = new List<float>();
            _isTestingUpload = false; // Começa com download

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

        private void InitializeNetworkCounters()
        {
            _downloadCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", "Realtek PCIe GbE Family Controller");
            _uploadCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", "Realtek PCIe GbE Family Controller");

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // Atualiza a cada 1 segundo
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float downloadSpeed = _downloadCounter.NextValue() / 125000; // Converte para Mbps
            float uploadSpeed = _uploadCounter.NextValue() / 125000; // Converte para Mbps

            lblDownloadSpeed.Text = $"Download: {downloadSpeed:F2} Mbps";
            lblUploadSpeed.Text = $"Upload: {uploadSpeed:F2} Mbps";

            // Adiciona os pontos ao gráfico
            var downloadSeries = (LineSeries)_plotModel.Series[0];
            var uploadSeries = (LineSeries)_plotModel.Series[1];

            downloadSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), downloadSpeed));
            uploadSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), uploadSpeed));

            // Verifica se os testes estão em andamento e armazena os valores válidos
            if (_isTesting)
            {
                _validDownloadValues.Add(downloadSpeed);
            }

            if (_isTestingU)
            {
                _validUploadValues.Add(uploadSpeed);
            }

            // Lógica de teste de download
            if (downloadSpeed > 70 && !_isTesting)
            {
                _isTesting = true;
                downinit.Text = "DOWNLOAD INICIADO..";
                _validDownloadValues.Clear(); // Limpa os valores anteriores
            }

            if (downloadSpeed < 1 && _isTesting)
            {
                downinit.Text = "DOWNLOAD FINALIZADO";
                _isTesting = false;
                _averageDownload = CalculateAverage(_validDownloadValues);
                float filteredAverageDownload = CalculateFilteredAverage(_validDownloadValues);
                lblAverageDownload.Text = $"{_averageDownload:F2} Mbps\n{filteredAverageDownload:F2} Mbps(Filter)";
                _validDownloadValues.Clear(); // Limpa os valores após calcular a média
            }

            // Lógica de teste de upload
            if (uploadSpeed > 10 && !_isTestingU)
            {
                _isTestingU = true;
                downinit.Text = "UPLOAD INICIADO..";
                _validUploadValues.Clear(); // Limpa os valores anteriores
            }

            if (uploadSpeed < 2 && _isTestingU)
            {
                downinit.Text = "UPLOAD FINALIZADO";
                _isTestingU = false;
                _averageUpload = CalculateAverage(_validUploadValues);
                float filteredAverageUpload = CalculateFilteredAverage(_validUploadValues);
                lblAverageUpload.Text = $"{_averageUpload:F2} Mbps\n{filteredAverageUpload:F2} Mbps(Filter)";
                _validUploadValues.Clear(); // Limpa os valores após calcular a média
            }

            // Limite de pontos no gráfico
            if (downloadSeries.Points.Count > 60)
            {
                downloadSeries.Points.RemoveAt(0);
                uploadSeries.Points.RemoveAt(0);
            }

            _plotModel.InvalidatePlot(true); // Atualiza o gráfico

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

            // Calcula a média dos valores filtrados
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
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            // Lógica adicional ao clicar na WebView, se necessário
        }
    }
}
