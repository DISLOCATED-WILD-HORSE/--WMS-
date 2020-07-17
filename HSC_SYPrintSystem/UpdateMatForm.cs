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
            //this.Load += UpdateMatForm_Load;
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
            //unitTB.Text = matModel.MAT_UNIT;
            //unitdescTB.Text = matModel.MAT_UNITDESC;
            //if ("X".Equals(matModel.MAT_SNCONTROL))
            //    sncontrolCB.Text = "启用";
            //else
            //    sncontrolCB.Text = "不启用";
            //if ("X".Equals(matModel.MAT_BATCHMODE))
            //    batchmodeCB.Text = "是";
            //else
            //    batchmodeCB.Text = "否";
            //mattypeTB.Text = matModel.MAT_TYPE;
            //matgroupTB.Text = matModel.MAT_GROUP;
            //if (matModel.MAT_STATUS == 1)
            //    matstatusCB.Text = "激活";
            //else
            //    matstatusCB.Text = "冻结";
            //commontsTB.Text = matModel.MAT_REMARK;
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
            //matModel.MAT_UNIT = unitTB.Text.Trim().ToUpper();
            //matModel.MAT_UNITDESC = unitdescTB.Text.Trim();
            //if ("启用".Equals(sncontrolCB.Text.Trim()))
            //    matModel.MAT_SNCONTROL = "X";
            //else
            //    matModel.MAT_SNCONTROL = "";
            //if ("是".Equals(batchmodeCB.Text.Trim()))
            //    matModel.MAT_BATCHMODE = "X";
            //else
            //    matModel.MAT_BATCHMODE = "";
            //matModel.MAT_TYPE = mattypeTB.Text.Trim().ToUpper();
            //matModel.MAT_GROUP = matgroupTB.Text.Trim();
            //if ("激活".Equals(matstatusCB.Text.Trim()))
            //    matModel.MAT_STATUS = 1;
            //else
            //    matModel.MAT_STATUS = 0;
            //matModel.MAT_REMARK = commontsTB.Text.Trim();
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
