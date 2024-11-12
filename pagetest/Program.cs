using AVELLCUSTOM1;
using pagetest;
using pagetest.Memoria;
using TECLADO;
using TESTE_MAQUINAS;
using USB;
using WEBCAM;


namespace pagetest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //       Application.Run(new MainEthernet());
            Application.Run(new MainEthernet());
        }
    }
}