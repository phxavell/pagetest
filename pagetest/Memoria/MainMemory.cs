using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pagetest.Memoria
{
    public partial class MainMemory : Form
    {
        public MainMemory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultados.Clear();
            txtResultados.AppendText("Iniciando teste de memória...\n");

            // Exibe informações da memória
            CheckMemory();

            // Testa a memória
            if (MemoryTest())
            {
                txtResultados.AppendText("A memória RAM está em funcionamento correto.\n");
            }
            else
            {
                txtResultados.AppendText("A memória RAM apresentou erros.\n");
            }
        }

        private void CheckMemory()
        {
            var totalMemory = GC.GetTotalMemory(false);
            txtResultados.AppendText($"Total de Memória: {totalMemory / (1024 * 1024)} MB\n");
        }

        private bool MemoryTest(int size = 100 * 1024 * 1024) // Testa 100 MB
        {
            try
            {
                txtResultados.AppendText("Iniciando teste de leitura e escrita na memória...\n");

                byte[] testData = new byte[size];
                for (int i = 0; i < size; i++)
                {
                    testData[i] = (byte)(i % 256); // Preenche com dados
                }
                txtResultados.AppendText("Teste de escrita concluído.\n");

                for (int i = 0; i < size; i++)
                {
                    if (testData[i] != (i % 256))
                    {
                        txtResultados.AppendText($"Erro encontrado na posição {i}\n");
                        return false;
                    }
                }

                txtResultados.AppendText("Teste de leitura concluído. Nenhum erro encontrado.\n");
                return true;
            }
            catch (Exception e)
            {
                txtResultados.AppendText($"Ocorreu um erro: {e.Message}\n");
                return false;
            }
        }


        private void MainMemory_Load(object sender, EventArgs e)
        {

        }
    }
}
