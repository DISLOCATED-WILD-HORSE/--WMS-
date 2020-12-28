using HSC_BLL;
using HSC_Entity;
using HSC_Util;
using Newtonsoft.Json.Serialization;
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
    public partial class AddBatchForm : Form
    {
        BatchInfoBLL batbll = new BatchInfoBLL();
        public AddBatchForm()
        {
            InitializeComponent();
        }

        private void AddBatchForm_Load(object sender, EventArgs e)
        {
            string cNo = this.GetCNO();
            if(!string.IsNullOrEmpty(cNo))
                txt_batchNo.Text = "J" + productTypeCB.Text + workLineCB.SelectedValue + DateTime.Now.ToString("yyMMdd") + cNo;
            workLineCB.DataSource = SelectListModel.WorkLineList().Keys.ToList();
            txt_siloNo.DataSource = SelectListModel.SiloNumList().Keys.ToList();
            nbtWeightCB.DataSource = SelectListModel.NbtWeightList();
            gradeCB.DataSource = SelectListModel.GradeList();
        }

        /// <summary>
        /// 获取批次流水号
        /// </summary>
        /// <returns></returns>
        private string GetCNO()
        {
            string cNo = string.Empty;
            var rv = batbll.GetBatInfoCNo(workLineCB.Text);
            if (!rv.IsSuccess)
            {
                MessageBox.Show(rv.Msg);
                return "";
            }
            cNo = (Convert.ToInt32(rv.Value) + 1).ToString();
            return cNo;
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
            if (string.IsNullOrEmpty(workLineCB.Text))
            {
                msg = "线别不能为空";
                return false;
            }
            if (string.IsNullOrEmpty(this.productTypeCB.Text))
            {
                msg = "产品类别不能为空";
                return false;
            }
            return true;
        }

        private void BatSaveBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string user = UserBLL.userInfo.UserName;
            #region 组装批次信息
            batchInfo bat = new batchInfo
            {
                batchNo = txt_batchNo.Text.Trim(),
                material = materialTB.Text.Trim(),
                workLine = workLineCB.Text.Trim(),
                characteristics = txt_characteristics.Text.Trim(),
                productDate = dtp_productDate.Value,
                siloNo = txt_siloNo.Text.Trim(),
                ntbWeight = nbtWeightCB.SelectedValue!=null ? Convert.ToDecimal(nbtWeightCB.SelectedValue) : 0,
                grade = gradeCB.Text.Trim(),
                createDate = now,
                createUser = user,
                modifyDate = now,
                modifyUser = user
            };
            #endregion
            string Msg = string.Empty;
            if(!SaveValidate(ref Msg))
            {
                MessageBox.Show(Msg);
                return;
            }
            var result = batbll.AddBatInfo(bat);
            MessageBox.Show(result.Msg);
            string cno = (Convert.ToInt32(txt_batchNo.Text.Substring(txt_batchNo.Text.Length - 1)) + 1).ToString();
            txt_batchNo.Text = txt_batchNo.Text.Substring(0, txt_batchNo.Text.Length - 1) + cno;
        }

        private void txt_batchNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_batchNo.Text))
            {
                batchValidateBox.Visible = true;
                batchValidateBox.Text = "批次号不能为空！";
                batchValidateBox.ForeColor = Color.Red;
                BatSaveBtn.Enabled = false;
            }
            else
            {
                batchValidateBox.Visible = false;
                batchValidateBox.Text = "";
                BatSaveBtn.Enabled = true;
            }
        }

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

        private void BatResetBtn_Click(object sender, EventArgs e)
        {
            txt_batchNo.Text = "";
            productTypeCB.Text = "";
            workLineCB.Text = "";
            txt_characteristics.Text = "";
            txt_siloNo.Text = "";
            nbtWeightCB.Text = "";
            gradeCB.Text = "";
            dtp_productDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void AddBatchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void workLineCB_SelectedValueChanged(object sender, EventArgs e)
        {
            string workline = string.Empty;
            string productType = string.Empty;
            if (workLineCB.SelectedValue != null)
            {
                workline = SelectListModel.WorkLineList()[workLineCB.SelectedValue.ToString()];
            }
            if (!string.IsNullOrEmpty(this.productTypeCB.Text))
            {
                productType = productTypeCB.Text.Substring(productTypeCB.Text.Length - 1);
            }
            string cNo = this.GetCNO();
            if (!string.IsNullOrEmpty(cNo))
                txt_batchNo.Text = "J" + productType + workline + DateTime.Now.ToString("yyMMdd") + cNo;
        }

        private void productTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            string workline = string.Empty;
            string productType = string.Empty;
            if (workLineCB.SelectedValue != null)
            {
                workline = SelectListModel.WorkLineList()[workLineCB.SelectedValue.ToString()];
            }
            if (!string.IsNullOrEmpty(this.productTypeCB.Text))
            {
                productType = productTypeCB.Text.Substring(productTypeCB.Text.Length - 1);
            }
            string cNo = this.GetCNO();
            if (!string.IsNullOrEmpty(cNo))
                txt_batchNo.Text = "J" + productType + workline + DateTime.Now.ToString("yyMMdd") + cNo;
        }

        
    }
}
