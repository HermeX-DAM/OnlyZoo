using OnlyZoo_Project.Controladores;

namespace OnlyZoo_Project
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
            Vista_Mascotas vista_Mascotas = new Vista_Mascotas();
            Controlador controlador = new Controlador(vista_Mascotas);
            Application.Run(vista_Mascotas);
        }
    }
}