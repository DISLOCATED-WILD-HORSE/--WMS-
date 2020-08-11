using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_SYPrintSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LoginForm lf = new LoginForm();

            //if (lf.ShowDialog() == DialogResult.OK)
            //{

            //    Application.Run(new MainForm());

            //}
            Application.Run(new LoginForm());
        }
    }
}
