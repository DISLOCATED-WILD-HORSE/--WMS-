using HSC_BLL;
using HSC_Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public static Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
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

        public LoginForm(bool autoLogin)
        {
            InitializeComponent();
            this.autoLogin.Checked = autoLogin;
            cfa.AppSettings.Settings["autoLogin"].Value = autoLogin.ToString();
            cfa.Save();
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
            Login();
        }

        private void Login()
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
            #region 配置登录设置参数

            cfa.AppSettings.Settings["autoLogin"].Value = "false";
            cfa.AppSettings.Settings["isRemember"].Value = "false";
            cfa.AppSettings.Settings["userId"].Value = "";
            cfa.AppSettings.Settings["passWord"].Value = "";
            if (isRemember.Checked && autoLogin.Checked)
            {
                cfa.AppSettings.Settings["autoLogin"].Value = "true";
                cfa.AppSettings.Settings["isRemember"].Value = "true";
                cfa.AppSettings.Settings["userId"].Value = userId;
                cfa.AppSettings.Settings["passWord"].Value = passWord;
            }
            else
            {
                if (isRemember.Checked)
                {
                    cfa.AppSettings.Settings["autoLogin"].Value = "false";
                    cfa.AppSettings.Settings["isRemember"].Value = "true";
                    cfa.AppSettings.Settings["userId"].Value = userId;
                    cfa.AppSettings.Settings["passWord"].Value = passWord;
                }
                //else
                //{
                //    cfa.AppSettings.Settings["autoLogin"].Value = "false";
                //    cfa.AppSettings.Settings["isRemember"].Value = "false";
                //    cfa.AppSettings.Settings["userId"].Value = "";
                //    cfa.AppSettings.Settings["passWord"].Value = "";
                //}
                if (autoLogin.Checked)
                {
                    cfa.AppSettings.Settings["autoLogin"].Value = "true";
                    cfa.AppSettings.Settings["isRemember"].Value = "false";
                    cfa.AppSettings.Settings["userId"].Value = userId;
                    cfa.AppSettings.Settings["passWord"].Value = passWord;
                }
                //else
                //{
                //    cfa.AppSettings.Settings["autoLogin"].Value = "false";
                //    cfa.AppSettings.Settings["isRemember"].Value = "false";
                //    cfa.AppSettings.Settings["userId"].Value = "";
                //    cfa.AppSettings.Settings["passWord"].Value = "";
                //}
            }
            cfa.Save(); 
            #endregion
            try
            {
                Common.ShowProcessing("正在登录中，请稍候...", this, (obj) =>
                {
                    //这里写处理耗时的代码，代码处理完成则自动关闭该窗口
                    var rv = UserBLL.Login(userId, passWord);
                    if (rv.StatusCode != Status.SUCCESS)
                    {
                        MessageBox.Show(rv.Msg);
                        return;
                    }
                }, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MainForm mf = new MainForm(cfa);
            //this.Hide();
            mf.Show();
            this.Dispose(false);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // 获取输入账号焦点
            txt_userId.Focus(); 
            // 账号默认记住
            this.txt_userId.Text = ConfigurationManager.AppSettings["userId"];
            //如果记住密码为true 那么把值赋给文本框
            if (ConfigurationManager.AppSettings["isRemember"].ToLower().Equals("true"))
            {
                this.txt_passWord.Text = ConfigurationManager.AppSettings["passWord"];
                isRemember.Checked = true;
            }
            //如果是自动登录  那么拿获取 配置文件中的账号密码  然后到数据库里边查询 登录
            if (ConfigurationManager.AppSettings["autoLogin"].ToLower().Equals("true"))
            {
                autoLogin.Checked = true;
                Login();
                this.Close();
            }
        }

        /// <summary>
        /// 自动登录打勾时默认勾选记住账号密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (autoLogin.Checked)
                isRemember.Checked = true;
        }

        /// <summary>
        /// 取消记住账号密码，必须同时取消自动登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void isRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRemember.Checked)
                autoLogin.Checked = false;
        }
    }
}
