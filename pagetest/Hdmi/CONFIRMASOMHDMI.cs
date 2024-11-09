﻿using System;
using System.Windows.Forms;
using MaterialSkin;
//using FireSharp.Config;
//using FireSharp.Interfaces;

namespace HDMI
{
    public partial class CONFIRMASOMHDMI : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMASOMHDMI()
        {
            InitializeComponent();
            Interacao();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMIAudio.mp3";
            wplayer.controls.play();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            VALIDAOK formValidaOk = new VALIDAOK();
            this.Hide();
            formValidaOk.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            //Ajustar segunda dia 06/05/2023 - para verificar quantos logs de erro já tem
            //REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
            //this.Hide();
            //formReprovaFalha.ShowDialog();
        }
    }
}