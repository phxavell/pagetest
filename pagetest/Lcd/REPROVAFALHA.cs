﻿using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using MaterialSkin;
using System.Reflection.Emit;
////using FireSharp.Config;
////using FireSharp.Interfaces;
////using FireSharp.Response;
using System.Drawing;

namespace RGB
{
    public partial class REPROVAFALHA : MaterialSkin.Controls.MaterialForm
    {
        public string LCD1;

        public REPROVAFALHA()
        {
            InitializeComponent();
            //StartFireBaseServices();
            Verificador();
            CriarLog_MySQLFalha();
        }

        //Firebase
        //IFirebaseConfig ifc = new FirebaseConfig()
        //{
        //    //Base de Dados da Avell, onde ficam os resultados
        //    AuthSecret = "BVBQHkHsf2fV2lqrP2GhPLjxufBMdxPoxYYg9XKP",
        //    BasePath = "https://avellweb-default-rtdb.firebaseio.com/"
        //};
        //IFirebaseClient client;
        private object res;

        //public void StartFireBaseServices()
        //{
        //    try
        //    {
        //        client = new FireSharp.FirebaseClient(ifc);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Não foi possível inserir os dados");
        //    }
        //}
        //Firebase

        public void Verificador()
        {
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL\logs_lcd", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
            int valor = int.Parse(quantidadeLog);
            if (valor < 1)
            {
                Interacao();
                CriarLogFalha();
            }
            else if (valor == 1)
            {
                //Chamar form, método mais eficiente.
                using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                {
                    this.Hide();
                    formEnviarReparo.ShowDialog();
                }
            }
        }

        public void Interacao()
        {
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\RepetirTeste.mp3";
            wplayer.controls.play();
        }

        public void CriarLogFalha()
        {
            try
            {
                var dataHoraMinuto = DateTime.Now.ToString("dd-MM-yyyy-HH-mms-s");
                System.IO.StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL\logs_lcd\Falha" + dataHoraMinuto + ".log");
                sw2.WriteLine("Falha em Testes Dia:" + dataHoraMinuto);
                sw2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnReteste_Click(object sender, EventArgs e)
        {
            //CriarLog_MySQLFalha();
            //Não faz sentido ustilizar essa Flag, pois
            //só chama outro form depois de pressionar reteste
            LCD1 = "OK";

            LCD formLCD = new LCD();
            this.Hide();
            formLCD.ShowDialog();
        }

        public void CriarLog_MySQLFalha()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string Furmark = "C:\\TESTES_AVELL\\MySqlData\\" + NomeArquivo + "\\RGB-Tela_FALHA.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("RGB TELA E FULGA DE LUZ FALHA!: " + dataHoraMinutoOK);
                Arquivo.Close();
                break;
            }

            try
            {
                //Firebase - Atualizado
                var dataHoraMinuto = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
                ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS1.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String DadosFirebase1 = "Lcd FALHA!:" + dataHoraMinuto;
                    //var teste = new rgb
                    //{
                    //    Serial = SerialAvell,
                    //    TLcd = DadosFirebase1
                    //};
                    //FirebaseResponse response = client.Update("WEB_CONSULTA_TESTE/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    DadosFirebase1 = string.Empty;
                    break;
                }
                //Firebase - Atualizado

                //Firebase - Atualizado
                foreach (ManagementObject getserial in MOS1.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String DadosFirebase1 = "Lcd FALHA!:" + dataHoraMinuto;
                    //var teste = new rgb
                    //{
                    //    Serial = SerialAvell,
                    //    TLcd = DadosFirebase1
                    //};
                    //FirebaseResponse response = client.Update("WEB_CONSULTA_TESTEFALHA/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    DadosFirebase1 = string.Empty;
                    break;
                }
                //Firebase - Atualizado
            }
            catch
            {
                lblFirebase.Text = "Firebase Off-Line";
                lblFirebase.ForeColor = Color.Red;
            }
        }
    }
}