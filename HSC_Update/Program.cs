using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace HSC_Update
{
    static class Program
    {
        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (!UpdateHelper.CheckServerEdition())
                {
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
