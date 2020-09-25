using HSC_Util;
using SqlSugar;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace HSC_SYPrintSystem
{
    public class DBHelper<T> where T : class,new()
    {
        public static string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        
        public DBHelper()
        {
            Db = new SqlSugarClient(config);

            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                //if (Db.TempItems == null) Db.TempItems = new Dictionary<string, object>() { { StartTime, DateTime.Now } };
                //if (Db.TempItems.ContainsKey(StartTime)) Db.TempItems[StartTime] = DateTime.Now;
                //if (!Db.TempItems.ContainsKey(StartTime)) Db.TempItems.Add(StartTime, DateTime.Now);
                //System.Windows.Forms.MessageBox.Show(sql);
                //LogerHelper.WriteLog("SqlSugar语句:" + sql);
                //LogHelper.Debug("请求标识：" + PDASession.Current.Request_Id + "\r\n SqlSugar语句：" + sql + "\r\n" + Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            };
        }
        public SqlSugarClient Db;
        ConnectionConfig config = new ConnectionConfig()
        {
            ConnectionString = connectionString,
            DbType = DbType.SqlServer,
            InitKeyType = InitKeyType.SystemTable,//从数据库表读取主键和自增列信息
            IsAutoCloseConnection = true
        };

        public ISugarQueryable<T> Query()
        {
            return this.Db.Queryable<T>();
        }
        public ISugarQueryable<T> Query(string sql)
        {
            return this.Db.SqlQueryable<T>(sql);
        }
        public IUpdateable<T> Update()
        {
            return this.Db.Updateable<T>();
        }
        public IUpdateable<T> Update(T model)
        {
            return this.Db.Updateable(model);
        }
        public IUpdateable<T> Update(List<T> list)
        {
            return this.Db.Updateable(list);
        }
        public IInsertable<T> Insert(T model)
        {
            return this.Db.Insertable(model);
        }

        public IDeleteable<T> Delete(string[] pramaryStrs)
        {
            return this.Db.Deleteable<T>().In(pramaryStrs);
        }
        public IDeleteable<T> Delete(int[] pramaryStrs)
        {
            return this.Db.Deleteable<T>().In(pramaryStrs);
        }

        public void BeginTran(System.Data.IsolationLevel iso) {
            Db.Ado.BeginTran(iso);
        }
    }
    public class SqlSugarDB
    {
        public static DBHelper<T> Instance<T>() where T : class, new()
        {
            return new DBHelper<T>();
        }
    }
}
