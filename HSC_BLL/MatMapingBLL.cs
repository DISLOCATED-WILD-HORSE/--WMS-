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
    public class MatMapingBLL
    {
        public ReturnValue<List<MatMaping>> GetMatMapingInfo(string customMat, string hscMat_ID, Page page)
        {
            ReturnValue<List<MatMaping>> rv = new ReturnValue<List<MatMaping>>();
            var matDao = SqlSugarDB.Instance<MatMaping>();
            List<MatMaping> matList = matDao.Query()
                .WhereIF(!string.IsNullOrEmpty(customMat), p => p.CustomMat.Equals(customMat))
                .WhereIF(!string.IsNullOrEmpty(hscMat_ID), p => p.Mat_ID.Equals(hscMat_ID))
                .OrderBy(p => p.modifyDate, OrderByType.Desc).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount)
                .ToList();
            return rv.Success(matList, "");
        }


        /// <summary>
        /// 新增物料对应关系
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue AddMatMapingInfo(MatMaping model)
        {
            ReturnValue rv = new ReturnValue();
            var matDao = SqlSugarDB.Instance<MatMaping>();
            try
            {
                int result = matDao.Insert(model).ExecuteCommand();
                if (result > 0) return rv.Success("添加成功！");
                else return rv.Fail("物料对应关系添加失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 批量删除物料关系
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue DelMatMapingInfo(string[] batArrays)
        {
            ReturnValue rv = new ReturnValue();
            var matMapingDao = SqlSugarDB.Instance<MatMaping>();
            try
            {
                int result = matMapingDao.Delete(batArrays).ExecuteCommand();
                if (result > 0) return rv.Success("删除成功！");
                else return rv.Fail("物料对应关系删除失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 编辑物料对应关系
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue UpdateMatMapingInfo(MatMaping model)
        {
            ReturnValue rv = new ReturnValue();
            var matDao = SqlSugarDB.Instance<MatMaping>();
            try
            {
                int result = matDao.Update(model).ExecuteCommand();
                if (result > 0) return rv.Success("更新成功！");
                else return rv.Fail("物料对应关系更新失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }
    }
}
