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
    public partial class UpdateBatForm : Form
    {
        batchInfo batModel = null;
        public UpdateBatForm()
        {
            InitializeComponent();
        }

        public UpdateBatForm(batchInfo model)
        {
            InitializeComponent();
            this.batModel = model;
            siloNoCB.DataSource = SelectListModel.SiloNumList().Keys.ToList();
            gradeCB.DataSource = SelectListModel.GradeList();
        }

        private void UpdateBatForm_Load(object sender, EventArgs e)
        {
            workLineCB.Text = batModel.workLine;
            txt_characteristics.Text = batModel.characteristics;
            siloNoCB.Text = batModel.siloNo;
            //txt_processNumber.Text = batModel.processNumber;
            gradeCB.Text = batModel.grade;
            dtp_productDate.Value = (DateTime)batModel.productDate;

        }

        private void matSaveBTN_Click(object sender, EventArgs e)
        {
            if (batModel == null)
            {
                MessageBox.Show("界面数据获取异常，请重新打开编辑");
                this.Close();
                return;
            }
            #region 更新对象组装
            batModel.workLine = workLineCB.Text.Trim();
            batModel.characteristics = txt_characteristics.Text.Trim();
            batModel.siloNo = siloNoCB.Text.Trim();
            //batModel.processNumber = txt_processNumber.Text.Trim();
            batModel.grade = gradeCB.Text.Trim().ToUpper();
            batModel.productDate = dtp_productDate.Value;
            #endregion
            BatchInfoBLL batbll = new BatchInfoBLL();
            var rv = batbll.UpdateBatInfo(batModel);
            MessageBox.Show(rv.Msg);
            this.DialogResult = DialogResult.OK;
            this.batModel = null;
            this.Close();
        }
    }
}
