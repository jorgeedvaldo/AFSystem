using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Aplicação criada por Edivaldo dos Santos Jorge
        /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
        /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
