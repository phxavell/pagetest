using pagetest;
using pagetest.Memoria;
using TESTE_MAQUINAS;


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
            Application.Run(new Sistema_Teste());
        }
    }
}