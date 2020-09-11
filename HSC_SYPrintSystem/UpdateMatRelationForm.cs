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
    public partial class UpdateMatRelationForm : Form
    {
        MatMaping matMapingModel = null;
        public UpdateMatRelationForm()
        {
            InitializeComponent();
        }

        public UpdateMatRelationForm(MatMaping model)
        {
            InitializeComponent();
            this.matMapingModel = model;
        }

        private void UpdateMatRelationForm_Load(object sender, EventArgs e)
        {
            materialTB.Text = matMapingModel.CustomMat;
            hscMat_ID.Text = matMapingModel.Mat_ID;
        }

        private void matMapingSaveBTN_Click(object sender, EventArgs e)
        {
            if (matMapingModel == null)
            {
                MessageBox.Show("界面数据获取异常，请重新打开编辑界面！");
                this.Close();
                return;
            }
            if (string.IsNullOrEmpty(hscMat_ID.Text.Trim()))
            {
                MessageBox.Show("新物料号不能为空，请检查！");
                return;
            }
            #region 更新对象组装
            matMapingModel.Mat_ID = hscMat_ID.Text.Trim();
            matMapingModel.modifyDate = DateTime.Now;
            matMapingModel.modifyUser = UserBLL.userInfo.UserName;
            #endregion
            MatMapingBLL matMapingbll = new MatMapingBLL();
            var rv = matMapingbll.UpdateMatMapingInfo(matMapingModel);
            MessageBox.Show(rv.Msg);
            this.DialogResult = DialogResult.OK;
            this.matMapingModel = null;
            this.Close();
        }
    }
}
