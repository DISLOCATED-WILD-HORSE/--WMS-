using HSC_BLL;
using HSC_Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_SYPrintSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            //InitializeComponent();
            //是否允许启动多个主程序
            if (!CanCreate())
            {
                Process progress1 = GetExistProcess();
                ShowMainWindow(progress1);
                Environment.Exit(-1);
            }
            else
            {
                this.InitializeComponent();
            }
        }
        static Mutex mutex = null;
        private static bool CanCreate()
        {
            bool canCreate;
            mutex = new Mutex(true, "HSC_SYPrintSystem", out canCreate);
            return canCreate;
        }

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);


        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        private const int SW_SHOW = 1;

        /// <summary>
        /// 最前端显示主窗体
        /// </summary>
        /// <param name="process"></param>
        private void ShowMainWindow(System.Diagnostics.Process process)
        {
            if (process != null)
            {
                IntPtr mainWindowHandle1 = process.MainWindowHandle;
                if (mainWindowHandle1 != IntPtr.Zero)
                {
                    ShowWindowAsync(mainWindowHandle1, SW_SHOW);
                    SetForegroundWindow(mainWindowHandle1);
                }
            }
        }

        /// <summary>
        /// 查看程序是否已经运行
        /// </summary>
        /// <returns></returns>
        private static System.Diagnostics.Process GetExistProcess()
        {
            System.Diagnostics.Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            foreach (System.Diagnostics.Process process1 in System.Diagnostics.Process.GetProcessesByName(currentProcess.ProcessName))
            {
                if ((process1.Id != currentProcess.Id) &&
                     (System.Reflection.Assembly.GetExecutingAssembly().Location == currentProcess.MainModule.FileName))
                {
                    return process1;
                }
            }
            return null;
        }


        private void txt_userId_Validating(object sender, EventArgs e)
        {
            LogerHelper.WriteLog("账号验证开始");
            if (string.IsNullOrEmpty(txt_userId.Text.Trim()))
            {
                txt_userId_ValidateBox.Visible = true;
                txt_userId_ValidateBox.Text = "账号不能为空！";
                txt_userId_ValidateBox.ForeColor = Color.Red;
                txt_userId.Focus();
            }
            else
            {
                txt_userId_ValidateBox.Visible = false;
                txt_userId_ValidateBox.Text = "";
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string userId = txt_userId.Text.Trim().ToUpper();
            string passWord = txt_passWord.Text.Trim();
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("账号不能为空！");
                txt_userId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("密码不能为空！");
                txt_passWord.Focus();
                return;
            }
            var rv = UserBLL.Login(userId, passWord);
            if (rv.StatusCode != HSC_Util.Status.SUCCESS)
            {
                MessageBox.Show(rv.Msg);
                return;
            }
            MainForm mf = new MainForm();
            //this.Hide();
            mf.Show();
            this.Dispose(false);
        }
    }
}
