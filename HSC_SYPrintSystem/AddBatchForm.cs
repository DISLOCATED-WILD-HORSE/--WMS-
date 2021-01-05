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
            string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
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
        private string GetCNO(string tabStr)
        {
            string cNo = string.Empty;
            string workline = "";
            if ("新建批次".Equals(tabStr)) workline = workLineCB.Text;
            else workline = wkLineCB.Text;
            var rv = batbll.GetBatInfoCNo(workline);
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
        private bool SaveValidate(string tabStr, ref string msg)
        {
            if ("新建批次".Equals(tabStr))
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
            else
            {
                if (string.IsNullOrEmpty(matTb.Text.Trim()))
                {
                    msg = "物料号不能为空";
                    return false;
                }
                if (string.IsNullOrEmpty(wkLineCB.Text))
                {
                    msg = "线别不能为空";
                    return false;
                }
                if (string.IsNullOrEmpty(this.pdTypeCB.Text))
                {
                    msg = "产品类别不能为空";
                    return false;
                }
                return true;
            }
        }

        private void BatSaveBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string user = UserBLL.userInfo.UserName;
            #region 组装批次信息
            batchInfo bat = new batchInfo();
            if(this.AddBatNoTabControl.SelectedTab.Text.Equals("新建批次"))
            {
                bat.batchNo = txt_batchNo.Text.Trim();
                bat.material = materialTB.Text.Trim();
                bat.workLine = workLineCB.Text.Trim();
                bat.characteristics = txt_characteristics.Text.Trim();
                bat.productDate = dtp_productDate.Value;
                bat.siloNo = txt_siloNo.Text.Trim();
                bat.ntbWeight = nbtWeightCB.SelectedValue != null ? Convert.ToDecimal(nbtWeightCB.SelectedValue) : 0;
                bat.grade = gradeCB.Text.Trim();
            }
            else
            {
                bat.batchNo = txt_bNo.Text.Trim();
                bat.material = matTb.Text.Trim();
                bat.workLine = wkLineCB.Text.Trim();
                bat.characteristics = txt_characteristicsByChange.Text.Trim();
                bat.productDate = dtp_pdDate.Value;
                bat.siloNo = txt_siloNum.Text.Trim();
                bat.ntbWeight = txt_nbt.SelectedValue != null ? Convert.ToDecimal(txt_nbt.SelectedValue) : 0;
                bat.grade = txt_grade.Text.Trim();
                
            }
            bat.createDate = now;
            bat.createUser = user;
            bat.modifyDate = now;
            bat.modifyUser = user;
            #endregion
            string Msg = string.Empty;
            if(!SaveValidate(this.AddBatNoTabControl.SelectedTab.Text, ref Msg))
            {
                MessageBox.Show(Msg);
                return;
            }
            var result = batbll.AddBatInfo(bat);
            MessageBox.Show(result.Msg);
            if (this.AddBatNoTabControl.SelectedTab.Text.Equals("新建批次"))
            {
                string cno = (Convert.ToInt32(txt_batchNo.Text.Substring(txt_batchNo.Text.Length - 1)) + 1).ToString();
                txt_batchNo.Text = txt_batchNo.Text.Substring(0, txt_batchNo.Text.Length - 1) + cno;
            }
            else
            {
                string cno = (Convert.ToInt32(txt_bNo.Text.Substring(txt_bNo.Text.Length - 1)) + 1).ToString();
                txt_bNo.Text = txt_bNo.Text.Substring(0, txt_bNo.Text.Length - 1) + cno;
            }
            
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
            if ("新建批次".Equals(this.AddBatNoTabControl.SelectedTab.Text))
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
            else
            {
                txt_bNo.Text = "";
                pdTypeCB.Text = "";
                wkLineCB.Text = "";
                txt_characteristicsByChange.Text = "";
                txt_siloNum.Text = "";
                txt_nbt.Text = "";
                txt_grade.Text = "";
                dtp_pdDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
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
            string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
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
            string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
            if (!string.IsNullOrEmpty(cNo))
                txt_batchNo.Text = "J" + productType + workline + DateTime.Now.ToString("yyMMdd") + cNo;
        }

        /// <summary>
        /// 批次Tab切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBatNoTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.AddBatNoTabControl.SelectedTab.Text.Equals("新建批次"))
            {
                string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
                if (!string.IsNullOrEmpty(cNo))
                    txt_batchNo.Text = "J" + productTypeCB.Text + workLineCB.SelectedValue + DateTime.Now.ToString("yyMMdd") + cNo;
                workLineCB.DataSource = SelectListModel.WorkLineList().Keys.ToList();
                txt_siloNo.DataSource = SelectListModel.SiloNumList().Keys.ToList();
                nbtWeightCB.DataSource = SelectListModel.NbtWeightList();
                gradeCB.DataSource = SelectListModel.GradeList();
            }
            else
            {
                string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
                if (!string.IsNullOrEmpty(cNo))
                    txt_bNo.Text = "J" + pdTypeCB.Text + wkLineCB.SelectedValue + DateTime.Now.ToString("yyMMdd") + cNo;
                wkLineCB.DataSource = SelectListModel.WorkLineList().Keys.ToList();
                txt_siloNum.DataSource = SelectListModel.SiloNumList().Keys.ToList();
                txt_nbt.DataSource = SelectListModel.NbtWeightList();
                txt_grade.DataSource = SelectListModel.GradeList();
            }
        }

        private void txt_bNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bNo.Text))
            {
                txt_bNoValidate.Visible = true;
                txt_bNoValidate.Text = "批次号不能为空！";
                txt_bNoValidate.ForeColor = Color.Red;
                BatSaveBtn.Enabled = false;
            }
            else
            {
                txt_bNoValidate.Visible = false;
                txt_bNoValidate.Text = "";
                BatSaveBtn.Enabled = true;
            }
        }

        private void matTb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(matTb.Text))
            {
                matTbValidate.Visible = true;
                matTbValidate.Text = "物料号不能为空！";
                matTbValidate.ForeColor = Color.Red;
                matTb.Focus();
                BatSaveBtn.Enabled = false;
            }
            else
            {
                var matDao = SqlSugarDB.Instance<tblMaterial>();
                var matModel = matDao.Query().First(p => p.MAT_ID == matTb.Text.Trim());
                if (matModel == null)
                {
                    string msg = string.Format("物料号：{0} 未维护，请先在物料主数据维护该物料后再操作！", matTb.Text.Trim());
                    matTb.Focus();
                    BatSaveBtn.Enabled = false;
                    MessageBox.Show(msg, "错误");
                    return;
                }
                matTbValidate.Visible = false;
                matTbValidate.Text = "";
                BatSaveBtn.Enabled = true;
            }
        }

        private void pdTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            string workline = string.Empty;
            string productType = string.Empty;
            if (wkLineCB.SelectedValue != null)
            {
                workline = SelectListModel.WorkLineList()[wkLineCB.SelectedValue.ToString()];
            }
            if (!string.IsNullOrEmpty(this.pdTypeCB.Text))
            {
                productType = pdTypeCB.Text.Substring(pdTypeCB.Text.Length - 1);
            }
            string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
            if (!string.IsNullOrEmpty(cNo))
                txt_bNo.Text = "J" + productType + workline + DateTime.Now.ToString("yyMMdd") + cNo;
        }

        private void wkLineCB_SelectedValueChanged(object sender, EventArgs e)
        {
            string workline = string.Empty;
            string productType = string.Empty;
            if (wkLineCB.SelectedValue != null)
            {
                workline = SelectListModel.WorkLineList()[wkLineCB.SelectedValue.ToString()];
            }
            if (!string.IsNullOrEmpty(this.pdTypeCB.Text))
            {
                productType = pdTypeCB.Text.Substring(pdTypeCB.Text.Length - 1);
            }
            string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
            if (!string.IsNullOrEmpty(cNo))
                txt_bNo.Text = "J" + productType + workline + DateTime.Now.ToString("yyMMdd") + cNo;
        }

        private void dtp_bNoCrDate_ValueChanged(object sender, EventArgs e)
        {
            string workline = string.Empty;
            string productType = string.Empty;
            if (wkLineCB.SelectedValue != null)
            {
                workline = SelectListModel.WorkLineList()[wkLineCB.SelectedValue.ToString()];
            }
            if (!string.IsNullOrEmpty(this.pdTypeCB.Text))
            {
                productType = pdTypeCB.Text.Substring(pdTypeCB.Text.Length - 1);
            }
            string cNo = this.GetCNO(this.AddBatNoTabControl.SelectedTab.Text);
            DateTime selectTime = dtp_bNoCrDate.Value;
            txt_bNo.Text = "J" + productType + workline + selectTime.ToString("yyMMdd") + cNo;
        }
    }
}
