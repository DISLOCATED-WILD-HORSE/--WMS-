using HSC_CustomModel;
using HSC_Entity;
using HSC_SYPrintSystem;
using HSC_Util;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_BLL
{
    public class PackageInfoBLL
    {
        /// <summary>
        /// 根据物料获取打印记录
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public ReturnValue<packageInfo> GetPackageInfo(string material)
        {
            ReturnValue<packageInfo> rv = new ReturnValue<packageInfo>();
            var packageDao = SqlSugarDB.Instance<packageInfo>();
            var packageModel = packageDao.Query().Where(p => p.mNo.Equals(material) && p.STATE != 9).OrderBy(p => p.id, SqlSugar.OrderByType.Desc).First();
            return rv.Success(packageModel, "");
        }

        /// <summary>
        /// 获取当天最大箱号
        /// </summary>
        /// <param name="wksplit"></param>
        /// <param name="siloNum">料仓号编号</param>
        /// <param name="PorcessNum">工艺号</param>
        /// <returns></returns>
        public ReturnValue<string> GetSNInfo(string wksplit, string siloNum = "", string PorcessNum = "")
        {
            ReturnValue<string> rv = new ReturnValue<string>();
            var packageDao = SqlSugarDB.Instance<packageInfo>();
            var packageModel = packageDao.Query().Where(p => p.wksplit.Equals(wksplit) && SqlFunc.DateIsSame(p.timestamps, DateTime.Now)).OrderBy(p => p.id, OrderByType.Desc).First();
            string date = DateTime.Now.ToString("yyMMdd");
            if (packageModel != null)
            {
                string snCode = rv.Success(packageModel.seriesNo.Substring(packageModel.seriesNo.Length - 3)).Value;
                return rv.Success(UserBLL.userInfo.SeriesHead + siloNum + (!string.IsNullOrEmpty(PorcessNum) ? PorcessNum : "00") + date + (Convert.ToInt32(snCode) + 1).ToString().PadLeft(3, '0'));
            }
            else
            {
                return rv.Success(UserBLL.userInfo.SeriesHead + siloNum + (!string.IsNullOrEmpty(PorcessNum) ? PorcessNum : "00") + date + "001");
            }
        }

        public ReturnValue AddPackageInfo(packageInfo packageModel)
        {
            ReturnValue rv = new ReturnValue();
            var packageDao = SqlSugarDB.Instance<packageInfo>();
            //var packageDao = new DBHelper<packageInfo>();
            try
            {
                var package = packageDao.Query().First(p => p.seriesNo.Equals(packageModel.seriesNo));
                if (package != null)
                    throw new Exception(string.Format("箱号：{0}已经存在，可能已经打印过了，请检查！", packageModel.seriesNo));
                var result = packageDao.Insert(packageModel).ExecuteCommand();
                if (result > 0) return rv.Success("");
                else return rv.Fail("打印记录添加失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 打印记录查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ReturnValue<List<packageInfo>> GetPrintInfo(PintInfoModel model, Page page)
        {
            var packageDao = SqlSugarDB.Instance<packageInfo>();
            List<packageInfo> packageList = packageDao.Query()
                .WhereIF(!string.IsNullOrEmpty(model.material), p => p.mNo.Equals(model.material))
                .WhereIF(!string.IsNullOrEmpty(model.status), p => p.STATE == model.status.ObjToInt())
                .WhereIF(!string.IsNullOrEmpty(model.seriesNo), p => p.seriesNo.Equals(model.seriesNo))
                .WhereIF(!string.IsNullOrEmpty(model.oldMatNo), p => p.newNo.Equals(model.oldMatNo))
                .WhereIF(!string.IsNullOrEmpty(model.isPackage), p => p.packageType == model.isPackage.ObjToInt())
                .WhereIF(!string.IsNullOrEmpty(model.spackageDate), p => p.packageDate >= Convert.ToDateTime(model.spackageDate))
                .WhereIF(!string.IsNullOrEmpty(model.epackageDate), p => p.packageDate <= Convert.ToDateTime(model.epackageDate))
                .WhereIF(!string.IsNullOrEmpty(model.printDate), p => p.timestamps == Convert.ToDateTime(model.printDate))
                .WhereIF(!string.IsNullOrEmpty(UserBLL.userInfo.WorkLine), p => p.workShop == UserBLL.userInfo.WorkLine)
                .OrderBy(p => p.id, OrderByType.Desc).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount)
                .ToList();
            return new ReturnValue<List<packageInfo>>().Success(packageList);
        }

        /// <summary>
        /// 打印汇总查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ReturnValue<List<PackageInfoSum>> GetPrintInfoSum(PintInfoModel model, Page page)
        {
            #region 弃用
            //var packageDao = SqlSugarDB.Instance<PackageInfoSum>();
            //StringBuilder sql = new StringBuilder();
            //sql.Append("select top 1000 productDesc as 规格,(case when inner_key=1 or inner_key=0 and (innerMatNo='' or innerMatNo is null)  then  newNo else    innerMatNo end )as 旧物料号,mNo as 物料号,bNo as 批次,grade as 等级,workLine as 线别,convert(char(10),packageDate,120) as 包装日期,count(*) as 袋数,CONVERT(decimal(18, 2), sum(nbtWeight)) as 净重小计 from packageInfo");
            //sql.Append(" where  state<>9 and workShop = '申远聚合'");
            //if (!string.IsNullOrEmpty(model.spackageDate))
            //{
            //    sql.Append(" and packageDate >= '" + model.spackageDate + "'");
            //}
            //if (!string.IsNullOrEmpty(model.epackageDate))
            //{
            //    sql.Append(" and packageDate <= '" + model.epackageDate + "'");
            //}
            //if (!string.IsNullOrEmpty(model.isPackage))
            //{
            //    sql.Append(" and packagetype = " + Convert.ToInt32(model.isPackage));
            //}
            //if (!string.IsNullOrEmpty(model.grade))
            //{
            //    sql.Append(" and grade = '" + model.grade + "'");
            //}
            //sql.Append(" group by productDesc, newNo ,grade,workline,packageDate,mNo,bNo,case when inner_key=1 or inner_key=0 and (innerMatNo='' or innerMatNo is null)  then newNo else innerMatNo end");
            //sql.Append(" order by packageDate desc");
            //var sumPackageInfo = packageDao.Query(sql.ToString()).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount).ToList();
            #endregion
            DBHelper<packageInfo> pdao = SqlSugarDB.Instance<packageInfo>();
            List<PackageInfoSum> sum = pdao.Query().WhereIF(!string.IsNullOrEmpty(model.spackageDate), p => p.packageDate >= Convert.ToDateTime(model.spackageDate))
                .WhereIF(!string.IsNullOrEmpty(model.epackageDate), p => p.packageDate <= Convert.ToDateTime(model.epackageDate))
                .WhereIF(!string.IsNullOrEmpty(model.isPackage), p => p.packageType == Convert.ToInt32(model.isPackage))
                .WhereIF(!string.IsNullOrEmpty(model.grade), p => p.grade == model.grade)
                .Where(p => p.STATE != 9 && p.workShop == UserBLL.userInfo.WorkLine)
                .Select<PackageInfoSum>(@"productDesc as 规格,(case when inner_key=1 or inner_key=0 and (innerMatNo='' or innerMatNo is null)  then  newNo else    innerMatNo end )as 旧物料号,mNo as 物料号,bNo as 批次,grade as 等级,workLine as 线别,convert(char(10),packageDate,120) as 包装日期,count(*) as 袋数,CONVERT(decimal(18, 2), sum(nbtWeight)) as 净重小计")
                .GroupBy(@"productDesc, newNo ,grade,workline,packageDate,mNo,bNo,case when inner_key=1 or inner_key=0 and (innerMatNo='' or innerMatNo is null)  then newNo else innerMatNo end")
                .OrderBy(@"packageDate desc")
                .ToPageList(page.pageIndex, page.pageSize, ref page.totalCount).ToList();
            return new ReturnValue<List<PackageInfoSum>>().Success(sum);
        }

        /// <summary>
        /// 打印记录批量删除
        /// </summary>
        /// <param name="idArrays"></param>
        /// <returns></returns>
        public ReturnValue DeletePrintInfo(List<packageInfo> list)
        {
            ReturnValue rv = new ReturnValue();
            var packageDao = SqlSugarDB.Instance<packageInfo>();
            try
            {
                int result = packageDao.Update(list).ExecuteCommand();
                if (result > 0) return rv.Success("删除成功！");
                else return rv.Fail("标签记录删除失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }
    }
}
