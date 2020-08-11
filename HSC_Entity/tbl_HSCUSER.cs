using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Entity
{
    public class tbl_HSCUSER
    {
        /// <summary>
		/// 用户自增ID
        /// </summary>		
		private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 账号
        /// </summary>		
        private string _userid;
        public string UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>		
        private string _userpwd;
        public string UserPwd
        {
            get { return _userpwd; }
            set { _userpwd = value; }
        }
        /// <summary>
        /// 车间代号
        /// </summary>		
        private string _workshopcode;
        public string WorkShopCode
        {
            get { return _workshopcode; }
            set { _workshopcode = value; }
        }
        /// <summary>
        /// 车间描述
        /// </summary>		
        private string _workshopname;
        public string WorkShopName
        {
            get { return _workshopname; }
            set { _workshopname = value; }
        }
        /// <summary>
        /// 中心仓
        /// </summary>		
        private string _centerwarehouse;
        public string CenterWareHouse
        {
            get { return _centerwarehouse; }
            set { _centerwarehouse = value; }
        }
        /// <summary>
        /// 标识
        /// </summary>		
        private int _flag;
        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        /// <summary>
        /// 打印类型
        /// </summary>		
        private string _printtype;
        public string PrintType
        {
            get { return _printtype; }
            set { _printtype = value; }
        }
        /// <summary>
        /// 线别
        /// </summary>		
        private string _workline;
        public string WorkLine
        {
            get { return _workline; }
            set { _workline = value; }
        }
        /// <summary>
        /// 交文部门
        /// </summary>		
        private string _departmentcode;
        public string DepartmentCode
        {
            get { return _departmentcode; }
            set { _departmentcode = value; }
        }
        /// <summary>
        /// 箱号头
        /// </summary>		
        private string _serieshead;
        public string SeriesHead
        {
            get { return _serieshead; }
            set { _serieshead = value; }
        }
        /// <summary>
        /// 公司
        /// </summary>		
        private string _company;
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        /// <summary>
        /// UserName
        /// </summary>		
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// Phone
        /// </summary>		
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        /// <summary>
        /// Remark
        /// </summary>		
        private string _remark;
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }
}
