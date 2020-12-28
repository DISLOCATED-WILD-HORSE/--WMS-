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
    public class BatchInfoBLL
    {
        /// <summary>
        /// 批次信息分页查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ReturnValue<List<batchInfo>> GetBacthInfo(BatchInfoModel model, Page page)
        {
            ReturnValue<List<batchInfo>> rv = new ReturnValue<List<batchInfo>>();
            var matDao = SqlSugarDB.Instance<batchInfo>();
            List<batchInfo> batchList = matDao.Query()
                .WhereIF(!string.IsNullOrEmpty(model.batchNo), p => p.batchNo.Equals(model.batchNo))
                .WhereIF(!string.IsNullOrEmpty(model.charactersistics), p => p.characteristics.Equals(model.charactersistics))
                .WhereIF(!string.IsNullOrEmpty(model.grade), p => p.grade.Equals(model.grade))
                .WhereIF(!string.IsNullOrEmpty(model.productDate), p => p.productDate == Convert.ToDateTime(model.productDate))
                .WhereIF(!string.IsNullOrEmpty(model.siloNo), p => p.siloNo.Equals(model.siloNo))
                .WhereIF(!string.IsNullOrEmpty(model.processNo), p => p.processNumber.Equals(model.processNo))
                .OrderBy(p => p.createDate, OrderByType.Desc).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount)
                .ToList();
            return rv.Success(batchList, "");
        }

        public static ReturnValue<List<T>> GetAll<T>(string sql,Page page) where T : class, new()
        {
            ReturnValue<List<T>> rv = new ReturnValue<List<T>>();
            var matDao = SqlSugarDB.Instance<T>();
            //List<T> batchList = matDao.Query()
            //    .WhereIF(!string.IsNullOrEmpty(model.batchNo), p => p.batchNo.Equals(model.batchNo))
            //    .WhereIF(!string.IsNullOrEmpty(model.charactersistics), p => p.characteristics.Equals(model.charactersistics))
            //    .WhereIF(!string.IsNullOrEmpty(model.grade), p => p.grade.Equals(model.grade))
            //    .WhereIF(!string.IsNullOrEmpty(model.changeDate), p => p.changeDate == Convert.ToDateTime(model.changeDate))
            //    .WhereIF(!string.IsNullOrEmpty(model.siloNo), p => p.siloNo.Equals(model.siloNo))
            //    .WhereIF(!string.IsNullOrEmpty(model.processNo), p => p.processNumber.Equals(model.processNo))
            //    .OrderBy(p => p.createDate, OrderByType.Desc).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount)
            //    .ToList();
            var batchList = matDao.Query(sql).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount).ToList();
            return rv.Success(batchList, "");
        }

        /// <summary>
        /// 新增批次
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue AddBatInfo(batchInfo model)
        {
            ReturnValue rv = new ReturnValue();
            var matDao = SqlSugarDB.Instance<batchInfo>();
            try
            {
                int result = matDao.Insert(model).ExecuteCommand();
                if (result > 0) return rv.Success("添加成功！");
                else return rv.Fail("批次信息添加失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 批量删除批次
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue DelBatInfo(string[] batArrays)
        {
            ReturnValue rv = new ReturnValue();
            var batDao = SqlSugarDB.Instance<batchInfo>();
            try
            {
                int result = batDao.Delete(batArrays).ExecuteCommand();
                if (result > 0) return rv.Success("删除成功！");
                else return rv.Fail("批次信息删除失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 更新批次
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue UpdateBatInfo(batchInfo model)
        {
            ReturnValue rv = new ReturnValue();
            var batDao = SqlSugarDB.Instance<batchInfo>();
            try
            {
                int result = batDao.Update(model).ExecuteCommand();
                if (result > 0) return rv.Success("更新成功！");
                else return rv.Fail("批次更新失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 添加批次信息获取批次规则流水号
        /// </summary>
        /// <returns></returns>
        public ReturnValue<string> GetBatInfoCNo(string workLine)
        {
            ReturnValue<string> rv = new ReturnValue<string>();
            var batDao = SqlSugarDB.Instance<batchInfo>();
            try
            {
                List<batchInfo> list = batDao.Query().Where(p => SqlFunc.DateIsSame(p.createDate, DateTime.Now) && SqlFunc.StartsWith(p.workLine, workLine.Substring(0,1))).OrderBy(p => p.createDate, OrderByType.Desc).ToList();
                if (list != null && list.Count > 0)
                {
                    return rv.Success(list[0].batchNo.Substring(list[0].batchNo.Length - 1));
                }
                return rv.Success("0");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 根据物料批次获取特性值
        /// </summary>
        /// <param name="material"></param>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public ReturnValue<batchInfo> GetBatInfo(string material, string batchNo)
        {
            ReturnValue<batchInfo> rv = new ReturnValue<batchInfo>();
            var batDao = SqlSugarDB.Instance<batchInfo>();
            try
            {
                batchInfo model = batDao.Query().First(p => p.material == material && p.batchNo == batchNo);
                return rv.Success(model);
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }
    }
}
