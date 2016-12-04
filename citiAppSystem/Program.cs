using citiAppSystem.Modules.Views.Cashiers;
using citiAppSystem.Modules.Views.DelAccView;
using citiAppSystem.Modules.Views.DR;
using citiAppSystem.Modules.Views.Management.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem
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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
