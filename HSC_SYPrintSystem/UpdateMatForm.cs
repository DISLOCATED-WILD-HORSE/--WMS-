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
    public partial class UpdateMatForm : Form
    {
        tblMaterial matModel = null;
        public UpdateMatForm()
        {
            InitializeComponent();
        }

        public UpdateMatForm(tblMaterial model)
        {
            InitializeComponent();
            this.matModel = model;
        }

        private void UpdateMatForm_Load(object sender, EventArgs e)
        {
            matdescTB.Text = matModel.MAT_DESC;
            matoldTB.Text = matModel.MAT_OLD;
            matolddescTB.Text = matModel.MAT_OLDDESC;
            specTB.Text = matModel.MAT_SPECI;
            txt_JHSPEC.Text = matModel.MAT_JHSPECI;
        }

        private void matSaveBTN_Click(object sender, EventArgs e)
        {
            if (matModel == null)
            {
                MessageBox.Show("界面数据获取异常，请重新打开编辑");
                this.Close();
                return;
            }
            #region 更新对象组装
            matModel.MAT_DESC = matdescTB.Text.Trim();
            matModel.MAT_OLD = matoldTB.Text.Trim().ToUpper();
            matModel.MAT_OLDDESC = matolddescTB.Text.Trim();
            matModel.MAT_SPECI = specTB.Text.Trim();
            matModel.MAT_JHSPECI = txt_JHSPEC.Text.Trim();
            matModel.MODIFYDATE = DateTime.Now;
            matModel.MODIFYUSER = UserBLL.userInfo.UserID;
            #endregion
            MaterialBLL matbll = new MaterialBLL();
            var rv = matbll.UpdateMatInfo(matModel);
            MessageBox.Show(rv.Msg);
            this.DialogResult = DialogResult.OK;
            this.matModel = null;
            this.Close();
        }
    }
}
