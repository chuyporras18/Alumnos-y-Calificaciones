using Alumnos_y_Calificaciones.home.view;
using System;
using System.Windows.Forms;

namespace Alumnos_y_Calificaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ActivityHome());
        }
    }
}
