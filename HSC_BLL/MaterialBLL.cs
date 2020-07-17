using HSC_CustomModel;
using HSC_Entity;
using HSC_SYPrintSystem;
using HSC_Util;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_BLL
{
    public class MaterialBLL
    {
        /// <summary>
        /// 物料主数据分页查询
        /// </summary>
        /// <param name="model"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ReturnValue<List<tblMaterial>> GetMatInfo(MatModel model, Page page)
        {
            ReturnValue<List<tblMaterial>> rv = new ReturnValue<List<tblMaterial>>();
            var matDao = SqlSugarDB.Instance<tblMaterial>();
            List<tblMaterial> matList = matDao.Query()
                .WhereIF(!string.IsNullOrEmpty(model.MAT_ID), p => p.MAT_ID.Equals(model.MAT_ID))
                .WhereIF(!string.IsNullOrEmpty(model.MAT_SPECI), p => p.MAT_SPECI.Equals(model.MAT_SPECI))
                .WhereIF(!string.IsNullOrEmpty(model.MAT_SNCONTROL), p => p.MAT_SNCONTROL.Equals(model.MAT_SNCONTROL))
                .WhereIF(!string.IsNullOrEmpty(model.MAT_OLD), p => p.MAT_OLD.Equals(model.MAT_OLD))
                .WhereIF(!string.IsNullOrEmpty(model.MAT_BATCHMODE), p => p.MAT_BATCHMODE.Equals(model.MAT_BATCHMODE))
                .WhereIF(!string.IsNullOrEmpty(model.MAT_STATUS), p => p.MAT_STATUS == Convert.ToInt32(model.MAT_STATUS))
                .OrderBy(p => p.MAT_ID, OrderByType.Asc).ToPageList(page.pageIndex, page.pageSize, ref page.totalCount)
                .ToList();
            return rv.Success(matList, "");
        }

        public ReturnValue<tblMaterial> GetMatInfo(string material)
        {
            ReturnValue<tblMaterial> rv = new ReturnValue<tblMaterial>();
            var matDao = SqlSugarDB.Instance<tblMaterial>();
            var matModel = matDao.Query().First(p => p.MAT_ID.Equals(material));
            return rv.Success(matModel, "");
        }

        /// <summary>
        /// 新增物料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue AddMatInfo(tblMaterial model)
        {
            ReturnValue rv = new ReturnValue();
            var matDao = SqlSugarDB.Instance<tblMaterial>();
            try
            {
                int result = matDao.Insert(model).ExecuteCommand();
                if (result > 0) return rv.Success("添加成功！");
                else return rv.Fail("物料添加失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 批量删除物料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue DelMatInfo(string[] matArrays)
        {
            ReturnValue rv = new ReturnValue();
            var matDao = SqlSugarDB.Instance<tblMaterial>();
            try
            {
                int result = matDao.Delete(matArrays).ExecuteCommand();
                if (result > 0) return rv.Success("删除成功！");
                else return rv.Fail("物料删除失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }

        /// <summary>
        /// 更新物料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnValue UpdateMatInfo(tblMaterial model)
        {
            ReturnValue rv = new ReturnValue();
            var matDao = SqlSugarDB.Instance<tblMaterial>();
            try
            {
                int result = matDao.Update(model).ExecuteCommand();
                if (result > 0) return rv.Success("更新成功！");
                else return rv.Fail("物料更新失败！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }
    }
}
