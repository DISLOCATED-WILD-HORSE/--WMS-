using HSC_BLL;
using HSC_Entity;
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
    public partial class AddMatRelationForm : Form
    {
        MatMapingBLL matMapingbll = new MatMapingBLL();
        public AddMatRelationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 物料号验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(materialTB.Text))
            {
                materialValidateBox.Visible = true;
                materialValidateBox.Text = "物料号不能为空！";
                materialValidateBox.ForeColor = Color.Red;
                materialTB.Focus();
                BatSaveBtn.Enabled = false;
            }
            else
            {
                var matDao = SqlSugarDB.Instance<tblMaterial>();
                var matModel = matDao.Query().First(p => p.MAT_ID == materialTB.Text.Trim());
                if (matModel == null)
                {
                    string msg = string.Format("物料号：{0} 未维护，请先在物料主数据维护该物料后再操作！", materialTB.Text.Trim());
                    materialTB.Focus();
                    BatSaveBtn.Enabled = false;
                    MessageBox.Show(msg, "错误");
                    return;
                }
                materialValidateBox.Visible = false;
                materialValidateBox.Text = "";
                BatSaveBtn.Enabled = true;
            }
        }

        /// <summary>
        /// 新物料号验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hscMat_ID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(hscMat_ID.Text))
            {
                hscMatValidateBox.Visible = true;
                hscMatValidateBox.Text = "新物料号不能为空！";
                hscMatValidateBox.ForeColor = Color.Red;
                hscMat_ID.Focus();
            }
            else
            {
                var matDao = SqlSugarDB.Instance<MatMaping>();
                var matModel = matDao.Query().First(p => p.Mat_ID == hscMat_ID.Text.Trim());
                if (matModel != null)
                {
                    string msg = string.Format("新物料号：{0} 已经和物料号：{1}建立对应关系，请检查！", hscMat_ID.Text.Trim(), materialTB.Text.Trim());
                    hscMat_ID.Focus();
                    //BatSaveBtn.Enabled = false;
                    MessageBox.Show(msg, "错误");
                    return;
                }
            }
        }

        private void BatSaveBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string user = UserBLL.userInfo.UserName;
            #region 组装物料对应关系信息
            MatMaping matMaping = new MatMaping
            {
                CustomMat = materialTB.Text.Trim(),
                Mat_ID = hscMat_ID.Text.Trim(),
                createDate = now,
                createUser = user,
                modifyDate = now,
                modifyUser = user
            };
            #endregion
            string Msg = string.Empty;
            if (!SaveValidate(ref Msg))
            {
                MessageBox.Show(Msg);
                return;
            }
            var result = matMapingbll.AddMatMapingInfo(matMaping);
            MessageBox.Show(result.Msg);
        }

        /// <summary>
        /// 保存时验证
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool SaveValidate(ref string msg)
        {
            if (string.IsNullOrEmpty(materialTB.Text.Trim()))
            {
                msg = "物料号不能为空";
                return false;
            }
            if (string.IsNullOrEmpty(hscMat_ID.Text.Trim()))
            {
                msg = "新物料号不能为空";
                return false; 
            }
            var matDao = SqlSugarDB.Instance<MatMaping>();
            var matMapModel = matDao.Query().First(p => p.CustomMat == materialTB.Text.Trim());
            if (matMapModel != null)
            {
                msg = "物料号" + materialTB.Text.Trim() + "已经被维护了对应关系，请检查！";
                return false;
            }
            return true;
        }

        private void AddMatRelationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BatResetBtn_Click(object sender, EventArgs e)
        {
            this.materialTB.Text = "";
            this.hscMat_ID.Text = "";
        }
    }
}
