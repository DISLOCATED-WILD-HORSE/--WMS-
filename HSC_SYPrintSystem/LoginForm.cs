using HSC_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_SYPrintSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txt_userId_ValidateBox.LostFocus += new EventHandler(txt_userId_Validating);
        }

        private void txt_userId_Validating(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userId.Text.Trim()))
            {
                txt_userId_ValidateBox.Visible = true;
                txt_userId_ValidateBox.Text = "账号不能为空！";
                txt_userId_ValidateBox.ForeColor = Color.Red;
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
                return;
            }
            if (string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            var rv = UserBLL.Login(userId, passWord);
            if(rv.StatusCode != HSC_Util.Status.SUCCESS)
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
