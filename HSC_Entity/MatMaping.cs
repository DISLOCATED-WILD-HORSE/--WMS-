using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Entity
{
    public class MatMaping
    {
        /// <summary>
		/// 申远物料，用于展示在标签上
        /// </summary>		
		private string _custommat;
        public string CustomMat
        {
            get { return _custommat; }
            set { _custommat = value; }
        }
        /// <summary>
        /// 映射的恒申管理系统上的物料，用于各种业务操作
        /// </summary>		
        private string _mat_id;
        public string Mat_ID
        {
            get { return _mat_id; }
            set { _mat_id = value; }
        }
        /// <summary>
        /// 修改日期
        /// </summary>		
        private DateTime _modifydate;
        public DateTime modifyDate
        {
            get { return _modifydate; }
            set { _modifydate = value; }
        }
        /// <summary>
        /// 修改人
        /// </summary>		
        private string _modifyuser;
        public string modifyUser
        {
            get { return _modifyuser; }
            set { _modifyuser = value; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>		
        private DateTime _createdate;
        public DateTime createDate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }
        /// <summary>
        /// 创建人
        /// </summary>		
        private string _createuser;
        public string createUser
        {
            get { return _createuser; }
            set { _createuser = value; }
        }
    }
}
