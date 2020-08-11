using HSC_BLL;
using HSC_CustomModel;
using HSC_Entity;
using HSC_Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HSC_SYPrintSystem
{
    public partial class MainForm : NForm
    {
        PackageInfoBLL packagebll = new PackageInfoBLL();
        MaterialBLL materialbll = new MaterialBLL();
        BatchInfoBLL batInfobll = new BatchInfoBLL();
        MatMapingBLL matMapingbll = new MatMapingBLL();
        packageInfo packageData = null;
        Dictionary<string, string> dic = null;
        public MainForm()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
            sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine).Value;
            dic = SelectListModel.SiloNumList();
            //siloNum.DataSource = dic.Keys.ToList();
            //txt_grade.DataSource = SelectListModel.GradeList();
            //txt_workLine.DataSource = SelectListModel.WorkLineList().Keys.ToList();
            packType.DataSource = SelectListModel.PackTypeList();
            if (this.TabControl.SelectedTab.Text.Equals("标签打印"))
                footPanl.Visible = false;

            #region 打印记录初始化
            txt_sPackageDate.Text = "";
            txt_ePackageDate.Text = "";
            txt_printDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            #endregion

            #region 打印汇总
            txt_startPackageDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_endPackageDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            #endregion
            this.version.Text = "V" + Assembly.GetExecutingAssembly().GetName().Version;
        }

        /// <summary>
        /// TABControl切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!this.TabControl.SelectedTab.Text.Equals("标签打印"))
            {
                footPanl.Visible = true;
                switch (this.TabControl.SelectedTab.Text)
                {
                    case "物料主数据":
                        mat_search_Click_1(sender, e);
                        break;
                    case "打印记录":
                        searchBTN_Click(sender, e);
                        break;
                    case "打印汇总":
                        sumSearchBTN_Click(sender, e);
                        break;
                    case "批次信息":
                        batch_search_Click(sender, e);
                        break;
                    case "物料关系":
                        matRelationSearchBtn_Click(sender, e);
                        break;
                    default:

                        break;
                }
            }
            else
            {
                footPanl.Visible = false;
            }
        }

        #region 物料主数据
        /// <summary>
        /// 物料主数据搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mat_search_Click_1(object sender, System.EventArgs e)
        {
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            MaterialBLL matbll = new MaterialBLL();
            var model = MatQueryData();
            Page page = new Page();
            var rv = matbll.GetMatInfo(model, page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                //去掉datagrideview自动加载多余的列
                this.Mat_DataGridView.AutoGenerateColumns = false;
                Mat_DataGridView.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(Mat_DataGridView);
                return;
            }
            this.Mat_DataGridView.DataSource = null;
        }

        private MatModel MatQueryData()
        {
            var model = new MatModel()
            {
                MAT_ID = mat.Text.Trim(),
                MAT_SPECI = spec.Text.Trim(),
                //MAT_SNCONTROL = snControler.Text,
                //MAT_OLD = oldMatNo.Text.Trim(),
                //MAT_BATCHMODE = batMode.Text,
                //MAT_STATUS = matNoType.Text
            };
            //if ("启用".Equals(snControler.Text.Trim()))
            //    model.MAT_SNCONTROL = "X";
            //else
            //    model.MAT_SNCONTROL = "";
            //if ("是".Equals(batMode.Text.Trim()))
            //    model.MAT_BATCHMODE = "X";
            //else
            //    model.MAT_BATCHMODE = "";
            //if ("激活".Equals(matNoType.Text.Trim()))
            //    model.MAT_STATUS = "1";
            //else if ("冻结".Equals(matNoType.Text.Trim()))
            //    model.MAT_STATUS = "0";
            //else
            //    model.MAT_STATUS = "";
            return model;
        }

        /// <summary>
        /// 新增物料主数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMatBtn_Click(object sender, System.EventArgs e)
        {
            AddMatForm addMatFrm = new AddMatForm();
            addMatFrm.ShowDialog();
            if (addMatFrm.DialogResult == DialogResult.OK)
            {
                mat_search_Click_1(sender, e);
            }
        }

        /// <summary>
        /// 物料删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void matDelBTN_Click(object sender, EventArgs e)
        {
            if (Mat_DataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("至少选中一行数据");
                return;
            }
            if (MessageBox.Show("确认删除" + Mat_DataGridView.SelectedRows.Count + "条物料记录？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow item in Mat_DataGridView.SelectedRows)
                {
                    tblMaterial matModel = (tblMaterial)item.DataBoundItem;
                    list.Add(matModel.MAT_ID);
                }
                var rv = materialbll.DelMatInfo(list.ToArray());
                MessageBox.Show(rv.Msg);
            }
            mat_search_Click_1(sender, e);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBTN_Click(object sender, EventArgs e)
        {
            if (Mat_DataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            UpdateMatForm updateForm = new UpdateMatForm((tblMaterial)Mat_DataGridView.CurrentRow.DataBoundItem);
            updateForm.ShowDialog();
            if (updateForm.DialogResult == DialogResult.OK)
            {
                mat_search_Click_1(sender, e);
            }
        }
        #endregion

        #region 标签打印
        /// <summary>
        /// 新物料号回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaterialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string material = MaterialNo.Text.Trim();
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(material))
                    MessageBox.Show("物料号为空，请检查！");
                var packageInfo = packagebll.GetPackageInfo(material);
                if (packageInfo.Value != null && packageInfo.IsSuccess)
                {
                    if (string.IsNullOrEmpty(packageInfo.Value.spec) || string.IsNullOrEmpty(packageInfo.Value.description)
                        || string.IsNullOrEmpty(packageInfo.Value.hiddenProduct))
                    {
                        QueryMat(material);
                    }
                    else
                    {
                        //商品名
                        jhspeci.Text = packageInfo.Value.spec;
                        //物料描述
                        mat_desc.Text = packageInfo.Value.description;
                        //英文描述
                        if (string.IsNullOrEmpty(packageInfo.Value.productDesc))
                            englishDesc.Text = packageInfo.Value.newNo;
                        else
                            englishDesc.Text = packageInfo.Value.productDesc;
                        //批号
                        oldMat.Text = packageInfo.Value.hiddenProduct;
                        //执行标准
                        //standard.Text = standard.Items[0].ToString();
                    }
                    batch_no.Text = packageInfo.Value.bNo;
                    siloNum.Text = dic.FirstOrDefault(o => o.Value == packageInfo.Value.SILONUM).Key;
                    txt_grade.Text = packageInfo.Value.grade;
                    PROCESSNUM.Text = packageInfo.Value.PROCESSNUM;
                    chracteristicsTB.Text = packageInfo.Value.characteristic;
                    txt_workLine.Text = packageInfo.Value.workLine;
                    txt_nbtWeight.Text = packageInfo.Value.nbtWeight.ToString("0.00");
                    txt_productDate.Text = packageInfo.Value.productDate.ToString("yyyy-MM-dd");
                    remark.Text = packageInfo.Value.comments;
                    packType.Text = packageInfo.Value.packType;
                }
                else
                {
                    QueryMat(material);
                }
            }
        }

        /// <summary>
        /// 批次号回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batch_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(batch_no.Text))
                {
                    MessageBox.Show("批次号为空，请检查！");
                    ClearChracteries();
                    return;
                }
                if (string.IsNullOrEmpty(MaterialNo.Text))
                {
                    MessageBox.Show("物料号未空，请检查！");
                    ClearChracteries();
                    return;
                }
                var rv = batInfobll.GetBatInfo(MaterialNo.Text.Trim(), batch_no.Text.Trim());
                if (rv.IsSuccess && rv.Value == null)
                {
                    MessageBox.Show(string.Format("批次号：{0}与物料号{1}未绑定，请先在批次信息页面维护！", batch_no.Text.Trim(), MaterialNo.Text.Trim()));
                    ClearChracteries();
                    return;
                }
                if (!rv.IsSuccess)
                {
                    MessageBox.Show(rv.Msg);
                    ClearChracteries();
                    return;
                }
                siloNum.Text = rv.Value.siloNo;
                txt_grade.Text = rv.Value.grade;
                txt_nbtWeight.Text = rv.Value.ntbWeight.ToString("0.00");
                chracteristicsTB.Text = rv.Value.characteristics;
                txt_workLine.Text = rv.Value.workLine;
                txt_productDate.Value = (DateTime)rv.Value.productDate;

            }
        }

        /// <summary>
        /// 批次号回车报错清空已有的特性值
        /// </summary>
        private void ClearChracteries()
        {
            siloNum.Text = "";
            txt_grade.Text = "";
            txt_nbtWeight.Text = "";
            txt_chracteristics.Text = "";
        }

        public void QueryMat(string material)
        {
            //去查询物料主数据
            var result = materialbll.GetMatInfo(material);
            if (result.Value != null && result.IsSuccess)
            {
                //商品名
                jhspeci.Text = result.Value.MAT_JHSPECI;
                //物料描述
                mat_desc.Text = result.Value.MAT_DESC;
                //英文描述
                englishDesc.Text = result.Value.MAT_SPECI;
                //批号
                oldMat.Text = result.Value.MAT_OLD;
                //执行标准
                //standard.Text = standard.Items[0].ToString();
                resetPartPrintInfo();
            }
            else
            {
                resetAllPrintInfo();
                MessageBox.Show(string.Format("物料号:{0} 不存在，请先在物料主数据界面维护！", material));
            }
        }

        private void resetPartPrintInfo()
        {
            batch_no.Text = "";
            siloNum.Text = "";
            txt_grade.Text = "";
            chracteristicsTB.Text = "";
            PROCESSNUM.Text = "";
            txt_workLine.Text = "";
            txt_nbtWeight.Text = "";
            txt_productDate.Value = DateTime.Now;
            remark.Text = "";
        }

        private void resetAllPrintInfo()
        {
            jhspeci.Text = "";
            mat_desc.Text = "";
            englishDesc.Text = "";
            oldMat.Text = "";
            resetPartPrintInfo();
        }

        private packageInfo GetPrintPackageInfo()
        {
            var printModel = new packageInfo();

            #region 标签打印数据组装
            //printModel.ORD_NO = txt_ORD_NO.Text;
            printModel.spec = jhspeci.Text.Trim();
            printModel.description = mat_desc.Text.Trim();
            printModel.hiddenProduct = oldMat.Text.Trim();
            printModel.newNo = oldMat.Text.Trim();
            printModel.productDesc = englishDesc.Text.Trim();
            var matDao = SqlSugarDB.Instance<MatMaping>();
            var matMapingModel = matDao.Query().First(p => p.CustomMat == MaterialNo.Text.Trim());
            printModel.mNo = matMapingModel.Mat_ID;
            printModel.standard = "FZ/T 51004-2011";
            printModel.bNo = batch_no.Text.Trim();
            printModel.workLine = txt_workLine.Text.Trim();
            printModel.SILONUM = dic[siloNum.Text.Trim()];
            printModel.grade = txt_grade.Text.Trim();
            printModel.characteristic = chracteristicsTB.Text.Trim();
            printModel.PROCESSNUM = PROCESSNUM.Text.Trim();
            //printModel.grainWeight = txt_grainWeight.Text;
            //printModel.unit = txt_unit.Text.ToInt();
            printModel.nbtWeight = Convert.ToDecimal(txt_nbtWeight.Text.Trim());
            //printModel.productDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            printModel.packageDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            printModel.timestamps = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            printModel.packType = packType.Text.Trim();
            if (com_packageType.Text.Trim().Equals("生产下线"))
            {
                printModel.packageType = 1;
            }
            else
            {
                printModel.packageType = 0;
            }
            printModel.productDate = Convert.ToDateTime(txt_productDate.Text.Trim());
            //printModel.pipeColor = txt_pipeColor.Text;
            //printModel.wireType = txt_WireType.Text;
            //printModel.insp = txt_insp.Text;//班次
            //printModel.caseWeight = txt_caseWeight.Text.ToDecimal();
            //printModel.canWeight = txt_canWeight.Text.ToDecimal();
            //printModel.grossWeight = txt_grossWeight.Text.ToDecimal();
            printModel.comments = remark.Text.Trim();
            printModel.ISExport = false;//是否出口
            printModel.ISViceProduct = false;//是否副产品
            printModel.BOX_TYPE = 0;//纸箱类型
            //if (radioButton3.IsChecked == true)
            //{
            //    printModel.packageType = 1;
            //}
            //else
            //{
            //    printModel.packageType = 0;
            //}
            printModel.workShop = UserBLL.userInfo.WorkLine;
            printModel.wksplit = UserBLL.userInfo.WorkLine;
            printModel.warehouseNo = "SJC";
            printModel.CREATEUSER = printModel.MODIFYUSER = UserBLL.userInfo.UserName;
            printModel.CREATEDATE = printModel.MODIFYDATE = DateTime.Now;
            //string fg = siloNum.Text.Split('-')[0].Substring(1, siloNum.Text.Split('-')[0].Length - 1) + (!string.IsNullOrEmpty(printModel.PROCESSNUM.Trim()) ? printModel.PROCESSNUM : "00");
            printModel.seriesNo = sn.Text;
            #endregion

            return printModel;
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            #region 组装验证数据
            packageData = new packageInfo();
            packageData.spec = jhspeci.Text.Trim();//商品名
            packageData.description = mat_desc.Text.Trim();
            packageData.mNo = MaterialNo.Text.Trim();
            packageData.standard = "FZ/T 51004-2011";
            packageData.bNo = batch_no.Text.Trim();
            packageData.workLine = txt_workLine.Text.Trim();
            packageData.grade = txt_grade.Text.Trim();
            packageData.hiddenProduct = oldMat.Text.Trim();
            packageData.packType = packType.Text.Trim();
            if (string.IsNullOrEmpty(txt_nbtWeight.Text.Trim()))
                packageData.nbtWeight = 0;
            else
                packageData.nbtWeight = Convert.ToDecimal(txt_nbtWeight.Text.Trim());
            packageData.SILONUM = siloNum.Text.Trim();//料仓号
            #endregion
            if (!PrintValidating.Verification(packageData, ref msg, txt_page.Text))
            {
                MessageBox.Show(msg);
                return;
            }
            int page = Convert.ToInt32(txt_page.Text);
            for (int i = 0; i < page; i++)
            {
                var packageDao = SqlSugarDB.Instance<packageInfo>();
                var packageInfo = packageDao.Query().First(p => p.seriesNo.Equals(sn.Text.Trim()));
                if (packageInfo != null)
                {
                    sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine, dic[siloNum.Text], PROCESSNUM.Text.Trim()).Value;
                    MessageBox.Show("已经自动重置最大箱号!请继续点击打印!");
                    return;
                }
                else
                {
                    PrintDocument pdt = new PrintDocument();
                    pdt.PrinterSettings = new PrinterSettings();
                    pdt.DefaultPageSettings = new PageSettings();
                    pdt.PrintController = new StandardPrintController();
                    PageSettings ps = pdt.DefaultPageSettings;
                    pdt.PrintPage += GetPrintPageEventHandler();
                    pdt.Print();
                }
            }
        }

        public PrintPageEventHandler GetPrintPageEventHandler(packageInfo printModel = null, string type = null)
        {
            packageData = printModel;
            if (packageData == null && GetPrintPackageInfo() != null)
            {
                packageData = GetPrintPackageInfo();
            }
            if (string.IsNullOrEmpty(type))
                return new PrintPageEventHandler(PrintExecute);
            else
                return new PrintPageEventHandler(revPrintExecute);
        }

        private void PrintExecute(object sender, PrintPageEventArgs e)
        {
            PrintHelper.PrintImplementation(packageData, MaterialNo.Text.Trim(), e);
            var result = packagebll.AddPackageInfo(packageData);
            if (!result.IsSuccess)
                MessageBox.Show(result.Msg);
            sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine, dic[siloNum.Text], PROCESSNUM.Text.Trim()).Value;
            packageDate = null;
        }
        private void revPrintExecute(object sender, PrintPageEventArgs e)
        {
            PrintHelper.PrintImplementation(packageData, MaterialNo.Text.Trim(), e);
            packageDate = null;
        }


        /// <summary>
        /// 料仓号改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void siloNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(siloNum.Text))
                sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine, dic[siloNum.Text], PROCESSNUM.Text).Value;
        }

        private void siloNum_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(siloNum.Text))
                sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine, dic[siloNum.Text], PROCESSNUM.Text).Value;
        }
        private void siloNum_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(siloNum.Text))
                sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine, dic[siloNum.Text], PROCESSNUM.Text).Value;
        }

        /// <summary>
        /// 工艺号改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PROCESSNUM_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(siloNum.Text))
                sn.Text = packagebll.GetSNInfo(UserBLL.userInfo.WorkLine, dic[siloNum.Text], PROCESSNUM.Text).Value;
        }
        #endregion

        #region 打印记录

        public PintInfoModel QueryData()
        {
            PintInfoModel model = new PintInfoModel
            {
                material = matNum.Text.Trim(),
                //status = status.Text.Trim(),
                seriesNo = serialno.Text.Trim(),
                //oldMatNo = oldMatNum.Text.Trim(),
                //isPackage = isChangePack.Text.Trim(),
                spackageDate = txt_sPackageDate.Text ?? null,
                epackageDate = txt_ePackageDate.Text ?? null,
                printDate = txt_printDate.Text ?? null
            };
            if ("已创建".Equals(status.Text.Trim()))
            {
                model.status = "0";
            }
            else if("已删除".Equals(status.Text.Trim()))
            {
                model.status = "9";
            }
            else
            {
                model.status = status.Text.Trim();
            }
            if ("是".Equals(isChangePack.Text.Trim()))
            {
                model.isPackage = "0";
            }
            else if("否".Equals(isChangePack.Text.Trim()))
            {
                model.isPackage = "1";
            }
            else
            {
                model.isPackage = isChangePack.Text.Trim();
            }
            return model;
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBTN_Click(object sender, EventArgs e)
        {
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            var model = QueryData();
            Page page = new Page();
            var rv = packagebll.GetPrintInfo(model, page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                this.printInfoDG.AutoGenerateColumns = false;
                printInfoDG.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(printInfoDG);
                return;
            }
            this.printInfoDG.DataSource = null;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refrshBTN_Click(object sender, EventArgs e)
        {
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            var model = QueryData();
            Page page = new Page();
            var rv = packagebll.GetPrintInfo(model, page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                this.printInfoDG.AutoGenerateColumns = false;
                printInfoDG.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(printInfoDG);
                return;
            }
        }

        /// <summary>
        /// 补打
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revPrintBTN_Click(object sender, EventArgs e)
        {
            var rows = this.printInfoDG.SelectedRows;
            if (rows.Count > 1)
            {
                MessageBox.Show("请选择一行打印");
                return;
            }
            if (rows.Count == 1 && rows[0].DataBoundItem == null)
            {
                MessageBox.Show("选中的一行没有数据，请检查！");
                return;
            }
            if (rows.Count < 1)
            {
                MessageBox.Show("你还未选中，请选择一行打印");
                return;
            }
            packageInfo selectModel = (packageInfo)rows[0].DataBoundItem;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrinterSettings = new PrinterSettings();
            printDocument.DefaultPageSettings = new PageSettings();
            printDocument.PrintController = new StandardPrintController();
            printDocument.PrintPage += this.GetPrintPageEventHandler(selectModel, "补打");
            printDocument.Print();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printInfoDelBTN_Click(object sender, EventArgs e)
        {
            if (printInfoDG.SelectedRows.Count <= 0)
            {
                MessageBox.Show("至少选中一行数据");
                return;
            }
            int index = printInfoDG.CurrentRow.Index;
            List<packageInfo> list = new List<packageInfo>();
            foreach (DataGridViewRow item in printInfoDG.SelectedRows)
            {
                packageInfo packageModel = (packageInfo)item.DataBoundItem;
                if (packageModel.STATE == 9)
                {
                    MessageBox.Show("选中数据已经被删除，不能重复删除！");
                    return;
                }
                packageModel.STATE = 9;
                list.Add(packageModel);
            }
            if (MessageBox.Show("确认删除" + printInfoDG.SelectedRows.Count + "条物料记录？", "此删除可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var rv = packagebll.DeletePrintInfo(list);
                if (rv.IsSuccess)
                {
                    foreach (DataGridViewRow item in printInfoDG.SelectedRows)
                    {
                        item.DefaultCellStyle.BackColor = Color.Red;
                        this.NoChecked(printInfoDG);
                    }
                }
                MessageBox.Show(rv.Msg);
            }
            else
            {
                list.ForEach(o =>
                {
                    if (o.STATE == 9)
                        o.STATE = 0;
                });
            }
            //refrshBTN_Click(sender, e);
        }

        private void sPackDate_ValueChanged(object sender, EventArgs e)
        {
            txt_sPackageDate.Text = sPackDate.Value.ToString("yyyy-MM-dd");
        }

        private void ePackDate_ValueChanged(object sender, EventArgs e)
        {
            txt_ePackageDate.Text = ePackDate.Value.ToString("yyyy-MM-dd");
        }

        private void printDate_ValueChanged(object sender, EventArgs e)
        {
            txt_printDate.Text = printDate.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstPage_Click(object sender, EventArgs e)
        {
            if (lastPage.Enabled == false)
                lastPage.Enabled = true;
            if (nextPage.Enabled == false)
                nextPage.Enabled = true;
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            commont(1, sender);
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousPage_Click(object sender, EventArgs e)
        {
            if (nextPage.Enabled == false)
                nextPage.Enabled = true;
            if (lastPage.Enabled == false)
                lastPage.Enabled = true;
            commont(Convert.ToInt32(currentPage.Text), sender);
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPage_Click(object sender, EventArgs e)
        {
            if (previousPage.Enabled == false)
                previousPage.Enabled = true;
            if (firstPage.Enabled == false)
                firstPage.Enabled = true;
            commont(Convert.ToInt32(currentPage.Text), sender);
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastPage_Click(object sender, EventArgs e)
        {
            if (firstPage.Enabled == false)
                firstPage.Enabled = true;
            if (previousPage.Enabled == false)
                previousPage.Enabled = true;
            if (nextPage.Enabled == true)
                nextPage.Enabled = false;
            if (lastPage.Enabled == true)
                lastPage.Enabled = false;
            commont(Convert.ToInt32(totalCount.Text), sender);
        }

        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jump_Click(object sender, EventArgs e)
        {

            bool flag = PrintValidating.IsUnsign(JumpPage.Text.Trim());
            if (!flag)
            {
                MessageBox.Show("输入的页码格式有误，不是一个正整数，请检查！");
                return;
            }
            //要跳转的页码
            int jumpPage = Convert.ToInt32(JumpPage.Text.Trim());
            int totalCount = Convert.ToInt32(this.totalCount.Text);
            if (jumpPage > totalCount)
            {
                MessageBox.Show("输入的页码已经大于总页数，请检查！");
                return;
            }
            else if (jumpPage == totalCount)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
                if (jumpPage == 1)
                {
                    previousPage.Enabled = false;
                    firstPage.Enabled = false;
                    return;
                }
                previousPage.Enabled = true;
                firstPage.Enabled = true;

            }
            else if (jumpPage > 1 && jumpPage < totalCount)
            {
                previousPage.Enabled = true;
                firstPage.Enabled = true;
                nextPage.Enabled = true;
                lastPage.Enabled = true;
            }
            else if (jumpPage == 1)
            {
                previousPage.Enabled = false;
                firstPage.Enabled = false;
                nextPage.Enabled = true;
                lastPage.Enabled = true;
            }
            commont(jumpPage, sender);
            //var model = QueryData();
            //Page page = new Page(jumpPage);
            //var rv = packagebll.GetPrintInfo(model, page);
            //if (rv.IsSuccess && rv.Value.Count > 0)
            //{
            //    this.printInfoDG.AutoGenerateColumns = false;
            //    printInfoDG.DataSource = rv.Value;
            //    this.totalCount.Text = page.GetTotalPage().ToString();
            //    currentPage.Text = page.pageIndex.ToString();
            //}
        }
        #endregion

        private void commont(int pageNo, object sender)
        {
            switch (this.TabControl.SelectedTab.Text)
            {
                case "物料主数据":
                    #region 物料数据
                    var model = MatQueryData();
                    Page page = new Page(pageNo);
                    #region 上一页和下一页的额外逻辑
                    if (sender.ToString().Contains("上一页"))
                    {
                        page.pageIndex -= 1;
                        if (page.pageIndex == 1)
                        {
                            previousPage.Enabled = false;
                            firstPage.Enabled = false;
                        }
                    }
                    if (sender.ToString().Contains("下一页"))
                    {
                        page.pageIndex += 1;
                    }
                    #endregion
                    var rv = materialbll.GetMatInfo(model, page);
                    int totalPage = page.GetTotalPage();
                    if (page.pageIndex >= totalPage)
                    {
                        nextPage.Enabled = false;
                        lastPage.Enabled = false;
                    }
                    if (rv.IsSuccess && rv.Value.Count > 0)
                    {
                        this.Mat_DataGridView.AutoGenerateColumns = false;
                        Mat_DataGridView.DataSource = rv.Value;
                        this.totalCount.Text = page.GetTotalPage().ToString();
                        currentPage.Text = page.pageIndex.ToString();
                        this.NoChecked(Mat_DataGridView);
                    }
                    #endregion
                    break;
                case "打印记录":
                    #region 打印记录
                    var model2 = QueryData();
                    Page page2 = new Page(pageNo);
                    #region 上一页和下一页的额外逻辑
                    if (sender.ToString().Contains("上一页"))
                    {
                        page2.pageIndex -= 1;
                        if (page2.pageIndex == 1)
                        {
                            previousPage.Enabled = false;
                            firstPage.Enabled = false;
                        }
                    }
                    if (sender.ToString().Contains("下一页"))
                    {
                        page2.pageIndex += 1;
                    }
                    #endregion
                    var rv2 = packagebll.GetPrintInfo(model2, page2);
                    int totalPage2 = page2.GetTotalPage();
                    if (page2.pageIndex >= totalPage2)
                    {
                        nextPage.Enabled = false;
                        lastPage.Enabled = false;
                    }
                    if (rv2.IsSuccess && rv2.Value.Count > 0)
                    {
                        this.printInfoDG.AutoGenerateColumns = false;
                        printInfoDG.DataSource = rv2.Value;
                        this.totalCount.Text = page2.GetTotalPage().ToString();
                        currentPage.Text = page2.pageIndex.ToString();
                        this.NoChecked(printInfoDG);
                    }
                    #endregion
                    break;
                case "打印汇总":
                    #region 打印汇总
                    var model3 = SumQueryData();
                    Page page3 = new Page(pageNo);
                    #region 上一页和下一页的额外逻辑
                    if (sender.ToString().Contains("上一页"))
                    {
                        page3.pageIndex -= 1;
                        if (page3.pageIndex == 1)
                        {
                            previousPage.Enabled = false;
                            firstPage.Enabled = false;
                        }
                    }
                    if (sender.ToString().Contains("下一页"))
                    {
                        page3.pageIndex += 1;
                    }
                    #endregion
                    var rv3 = packagebll.GetPrintInfoSum(model3, page3);
                    int totalPage3 = page3.GetTotalPage();
                    if (page3.pageIndex >= totalPage3)
                    {
                        nextPage.Enabled = false;
                        lastPage.Enabled = false;
                    }
                    if (rv3.IsSuccess && rv3.Value.Count > 0)
                    {
                        this.printSumDG.AutoGenerateColumns = false;
                        printSumDG.DataSource = rv3.Value;
                        totalCount.Text = page3.GetTotalPage().ToString();
                        currentPage.Text = page3.pageIndex.ToString();
                        this.NoChecked(printSumDG);
                    }
                    #endregion
                    break;
                case "批次信息":
                    #region 批次信息
                    var model4 = BatQueryData();
                    Page page4 = new Page(pageNo);
                    #region 上一页和下一页的额外逻辑
                    if (sender.ToString().Contains("上一页"))
                    {
                        page4.pageIndex -= 1;
                        if (page4.pageIndex == 1)
                        {
                            previousPage.Enabled = false;
                            firstPage.Enabled = false;
                        }
                    }
                    if (sender.ToString().Contains("下一页"))
                    {
                        page4.pageIndex += 1;
                    }
                    #endregion
                    var rv4 = batInfobll.GetBacthInfo(model4, page4);
                    int totalPage4 = page4.GetTotalPage();
                    if (page4.pageIndex >= totalPage4)
                    {
                        nextPage.Enabled = false;
                        lastPage.Enabled = false;
                    }
                    if (rv4.IsSuccess && rv4.Value.Count > 0)
                    {
                        this.batchInfoDG.AutoGenerateColumns = false;
                        batchInfoDG.DataSource = rv4.Value;
                        this.totalCount.Text = page4.GetTotalPage().ToString();
                        currentPage.Text = page4.pageIndex.ToString();
                        this.NoChecked(batchInfoDG);
                    }
                    #endregion
                    break;
            }
        }

        #region 打印汇总

        private PintInfoModel SumQueryData()
        {
            var model = new PintInfoModel()
            {
                spackageDate = txt_startPackageDate.Text ?? "",
                epackageDate = txt_endPackageDate.Text ?? "",
                //isPackage = isChangePackageCB.Text.Trim(),
                grade = gradeCB.Text.Trim()
            };
            if ("是".Equals(isChangePackageCB.Text.Trim()))
            {
                model.isPackage = "0";
            }
            else if ("否".Equals(isChangePackageCB.Text.Trim()))
            {
                model.isPackage = "1";
            }
            else
            {
                model.isPackage = isChangePackageCB.Text.Trim();
            }
            return model ;
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sumSearchBTN_Click(object sender, EventArgs e)
        {
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            var model = SumQueryData();
            Page page = new Page();
            var rv = packagebll.GetPrintInfoSum(model, page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                this.printInfoDG.AutoGenerateColumns = false;
                printSumDG.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(printSumDG);
                return;
            }
            this.printSumDG.DataSource = null;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SumRefreshBTN_Click(object sender, EventArgs e)
        {
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            var model = SumQueryData();
            Page page = new Page();
            var rv = packagebll.GetPrintInfoSum(model, page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                this.printInfoDG.AutoGenerateColumns = false;
                printSumDG.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(printSumDG);
                return;
            }
            this.printSumDG.DataSource = null;
        }

        private void sPackageDateDT_ValueChanged(object sender, EventArgs e)
        {
            txt_startPackageDate.Text = sPackageDateDT.Value.ToString("yyyy-MM-dd");
        }

        private void ePackageDateDT_ValueChanged(object sender, EventArgs e)
        {
            txt_endPackageDate.Text = ePackageDateDT.Value.ToString("yyyy-MM-dd");
        }

        #endregion


        /// <summary>
        /// 各种刷新表格时保持删除的数据为红色背景
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printInfoDG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int status = Convert.ToInt32(printInfoDG.Rows[e.RowIndex].Cells["state"].Value);
            switch (status)
            {
                case 0:
                    printInfoDG.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    break;
                case 9:
                    printInfoDG.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    break;
            }
        }

        /// <summary>
        /// 默认不选中
        /// </summary>
        /// <param name="dgView"></param>
        private void NoChecked(DataGridView dgView)
        {
            dgView.ClearSelection();
        }

        #region 批次信息

        private BatchInfoModel BatQueryData()
        {
            var model = new BatchInfoModel()
            {
                batchNo = txt_batchNo.Text.Trim(),
                charactersistics = txt_chracteristics.Text.Trim(),
                grade = cb_grade.Text.Trim(),
                productDate = txt_changesDate.Text.Trim(),
                siloNo = txt_siloNo.Text.Trim()
            };
            return model;
        }
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batch_search_Click(object sender, EventArgs e)
        {
            //string sql = string.Empty;
            //sql += "select * from batchInfo where 1=1";
            //if (!string.IsNullOrEmpty(txt_batchNo.Text.Trim()))
            //    sql += " and batchNo = '" + txt_batchNo.Text.Trim() + "'";
            //sql += " order by createDate desc";
            //Page page = new Page();
            //var rv = BatchInfoBLL.GetAll<BatchInfoModel>(sql, page);
            //this.batchInfoDG.AutoGenerateColumns = false;
            //batchInfoDG.DataSource = rv.Value;
            //totalCount.Text = page.GetTotalPage().ToString();
            //currentPage.Text = page.pageIndex.ToString();
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            BatchInfoBLL batbll = new BatchInfoBLL();
            var model = BatQueryData();
            Page page = new Page();
            var rv = batbll.GetBacthInfo(model, page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                //去掉datagrideview自动加载多余的列
                this.batchInfoDG.AutoGenerateColumns = false;
                batchInfoDG.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(batchInfoDG);
                return;
            }
            this.batchInfoDG.DataSource = null;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batch_add_Click(object sender, EventArgs e)
        {
            AddBatchForm addBatFrm = new AddBatchForm();
            addBatFrm.ShowDialog();
            if (addBatFrm.DialogResult == DialogResult.OK)
            {
                batch_search_Click(sender, e);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batch_del_Click(object sender, EventArgs e)
        {
            if (batchInfoDG.SelectedRows.Count <= 0)
            {
                MessageBox.Show("至少选中一行数据");
                return;
            }
            if (MessageBox.Show("确认删除" + batchInfoDG.SelectedRows.Count + "条物料记录？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow item in batchInfoDG.SelectedRows)
                {
                    batchInfo batModel = (batchInfo)item.DataBoundItem;
                    list.Add(batModel.batchNo);
                }
                var rv = batInfobll.DelBatInfo(list.ToArray());
                MessageBox.Show(rv.Msg);
            }
            batch_search_Click(sender, e);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batch_edit_Click(object sender, EventArgs e)
        {
            if (batchInfoDG.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            UpdateBatForm updateForm = new UpdateBatForm((batchInfo)batchInfoDG.CurrentRow.DataBoundItem);
            updateForm.ShowDialog();
            if (updateForm.DialogResult == DialogResult.OK)
            {
                batch_search_Click(sender, e);
            }
        }
        #endregion

        
        /// <summary>
        /// 物料对应关系新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void matRelationAddBtn_Click(object sender, EventArgs e)
        {
            AddMatRelationForm addMatRelationFrm = new AddMatRelationForm();
            addMatRelationFrm.ShowDialog();
            if (addMatRelationFrm.DialogResult == DialogResult.OK)
            {
                matRelationSearchBtn_Click(sender, e);
            }
        }
        /// <summary>
        /// 物料对应关系的搜索功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void matRelationSearchBtn_Click(object sender, EventArgs e)
        {
            firstPage.Enabled = false;
            previousPage.Enabled = false;
            nextPage.Enabled = true;
            lastPage.Enabled = true;
            Page page = new Page();
            var rv = matMapingbll.GetMatMapingInfo(txt_customMat.Text.Trim(), txt_hscMat_ID.Text.Trim(), page);
            if (page.GetTotalPage() == 1)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            if (rv.IsSuccess && rv.Value.Count > 0)
            {
                //去掉datagrideview自动加载多余的列
                this.matRelationDGV.AutoGenerateColumns = false;
                matRelationDGV.DataSource = rv.Value;
                totalCount.Text = page.GetTotalPage().ToString();
                currentPage.Text = page.pageIndex.ToString();
                this.NoChecked(matRelationDGV);
                return;
            }
            this.matRelationDGV.DataSource = null;
        }

        /// <summary>
        /// 物料对应关系编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void matRelationEditBtn_Click(object sender, EventArgs e)
        {
            if (matRelationDGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            UpdateMatRelationForm updateForm = new UpdateMatRelationForm((MatMaping)matRelationDGV.CurrentRow.DataBoundItem);
            updateForm.ShowDialog();
            if (updateForm.DialogResult == DialogResult.OK)
            {
                batch_search_Click(sender, e);
            }
        }

        private void matRelationDelBtn_Click(object sender, EventArgs e)
        {
            if (matRelationDGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("至少选中一行数据");
                return;
            }
            if (MessageBox.Show("确认删除" + matRelationDGV.SelectedRows.Count + "条记录？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow item in matRelationDGV.SelectedRows)
                {
                    MatMaping matMapingModel = (MatMaping)item.DataBoundItem;
                    list.Add(matMapingModel.CustomMat);
                }
                var rv = matMapingbll.DelMatMapingInfo(list.ToArray());
                MessageBox.Show(rv.Msg);
            }
            //matRelationSearchBtn_Click(sender, e);
            matRelationDelBtn.Click += new EventHandler(matRelationSearchBtn_Click);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
