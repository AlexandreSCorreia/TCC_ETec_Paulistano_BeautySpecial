using Ferramentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            SplashScreen splashScreen = new SplashScreen();
            DialogResult dialogResult = splashScreen.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                splashScreen.Dispose();
                Application.Run(new FrmLogin());
            }
            else
            {
                Application.Exit();
                
            }

        }
    }
}
