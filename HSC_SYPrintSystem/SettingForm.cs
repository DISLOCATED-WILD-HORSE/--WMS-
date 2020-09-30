using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_SYPrintSystem
{
    public partial class SettingForm : Form
    {
        Configuration cfa = LoginForm.cfa;
        public SettingForm(Configuration cfa)
        {
            InitializeComponent();
            autoLogin.Checked = Convert.ToBoolean(cfa.AppSettings.Settings["autoLogin"].Value);
        }

        private void autoLogin_CheckedChanged(object sender, EventArgs e)
        {
            cfa.AppSettings.Settings["autoLogin"].Value = autoLogin.Checked.ToString();
            LoginForm lf = new LoginForm(autoLogin.Checked);
        }
    }
}
