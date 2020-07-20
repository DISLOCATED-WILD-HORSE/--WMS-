using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Entity
{
    public class batchInfo
    {
        /// <summary>
		/// 批次号
        /// </summary>		
		private string _batchno;
        public string batchNo
        {
            get { return _batchno; }
            set { _batchno = value; }
        }
        /// <summary>
        /// 物料号
        /// </summary>
        private string _material;
        public string material
        {
            get { return _material; }
            set { _material = value; }
        }
        /// <summary>
        /// 生产日期
        /// </summary>		
        private DateTime? _productDate;
        public DateTime? productDate
        {
            get { return _productDate; }
            set { _productDate = value; }
        }
        /// <summary>
        /// 生产特性
        /// </summary>		
        private string _characteristics;
        public string characteristics
        {
            get { return _characteristics; }
            set { _characteristics = value; }
        }
        /// <summary>
        /// 料仓号
        /// </summary>		
        private string _silono;
        public string siloNo
        {
            get { return _silono; }
            set { _silono = value; }
        }
        /// <summary>
        /// 工艺号
        /// </summary>		
        private string _processnumber;
        public string processNumber
        {
            get { return _processnumber; }
            set { _processnumber = value; }
        }
        /// <summary>
        /// 等级
        /// </summary>		
        private string _grade;
        public string grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        /// <summary>
        /// createDate
        /// </summary>		
        private DateTime _createdate;
        public DateTime createDate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }
        /// <summary>
        /// createUser
        /// </summary>		
        private string _createuser;
        public string createUser
        {
            get { return _createuser; }
            set { _createuser = value; }
        }
        /// <summary>
        /// modifyDate
        /// </summary>		
        private DateTime _modifydate;
        public DateTime modifyDate
        {
            get { return _modifydate; }
            set { _modifydate = value; }
        }
        /// <summary>
        /// modifyUser
        /// </summary>		
        private string _modifyuser;
        public string modifyUser
        {
            get { return _modifyuser; }
            set { _modifyuser = value; }
        }
        /// <summary>
        /// ntbWeight
        /// </summary>
        private decimal _ntbWeight;
        public decimal ntbWeight
        {
            get { return _ntbWeight; }
            set { _ntbWeight = value; }
        }
        /// <summary>
        /// workLine
        /// </summary>
        private string _workLine;
        public string workLine
        {
            get { return _workLine; }
            set { _workLine = value; }
        }
    }
}
