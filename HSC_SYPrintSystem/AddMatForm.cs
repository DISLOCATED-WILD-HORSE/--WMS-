using HSC_BLL;
using HSC_Entity;
using HSC_Util;
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
    public partial class AddMatForm : Form
    {
        public AddMatForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatSaveBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string user = UserBLL.userInfo.UserName;
            if (string.IsNullOrEmpty(materialTB.Text.Trim()))
            {
                MessageBox.Show("物料号不能为空！","警告");
                materialTB.Focus();
                return;
            }
            #region 组装物料
            tblMaterial mat = new tblMaterial
            {
                MAT_ID = materialTB.Text.Trim(),
                MAT_OLD = oldMaterialTB.Text.Trim().ToUpper(),
                MAT_DESC = matDesc.Text.Trim(),
                MAT_OLDDESC = oldMatDesc.Text.Trim(),
                MAT_SPECI = matSpeci.Text.Trim(),
                MAT_JHSPECI = matJHSpeci.Text.Trim(),
                MAT_STATUS = Mat_Status.启用.GetHashCode(),
                CREATEDATE = now,
                CREATEUSER = user,
                MODIFYDATE = now,
                MODIFYUSER = user
            }; 
            #endregion
            MaterialBLL matbll = new MaterialBLL();
            var result = matbll.AddMatInfo(mat);
            MessageBox.Show(result.Msg);
            materialTB.Text = "";
        }

        private void materialTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(materialTB.Text))
            {
                materialValidateBox.Visible = true;
                materialValidateBox.Text = "物料号不能为空！";
                materialValidateBox.ForeColor = Color.Red;
                materialTB.Focus();
                MatSaveBtn.Enabled = false;
            }else
            {
                materialValidateBox.Visible = false;
                materialValidateBox.Text = "";
                MatSaveBtn.Enabled = true;
            }
                
        }

        private void MatResetBtn_Click(object sender, EventArgs e)
        {
            materialTB.Text = "";
            oldMaterialTB.Text = "";
            matDesc.Text = "";
            oldMatDesc.Text = "";
            matSpeci.Text = "";
            matJHSpeci.Text = "";
        }

        private void AddMatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
