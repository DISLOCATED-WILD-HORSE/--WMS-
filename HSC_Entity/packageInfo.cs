using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Entity
{
    public class packageInfo
    {
        /// <summary>
		/// 序号
        /// </summary>		
		private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 产品描述
        /// </summary>		
        private string _productdesc;
        public string productDesc
        {
            get { return _productdesc; }
            set { _productdesc = value; }
        }
        /// <summary>
        /// 物料描述
        /// </summary>		
        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        /// <summary>
        /// 旧物料号
        /// </summary>		
        private string _newno;
        public string newNo
        {
            get { return _newno; }
            set { _newno = value; }
        }
        /// <summary>
        /// 隐藏产品
        /// </summary>		
        private string _hiddenproduct;
        public string hiddenProduct
        {
            get { return _hiddenproduct; }
            set { _hiddenproduct = value; }
        }
        /// <summary>
        /// 新物料号
        /// </summary>		
        private string _mno;
        public string mNo
        {
            get { return _mno; }
            set { _mno = value; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>		
        private string _standard;
        public string standard
        {
            get { return _standard; }
            set { _standard = value; }
        }
        /// <summary>
        /// 规格
        /// </summary>		
        private string _spec;
        public string spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// 筒数
        /// </summary>		
        private int _unit;
        public int unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        /// <summary>
        /// 流水号
        /// </summary>		
        private string _cno;
        public string cNo
        {
            get { return _cno; }
            set { _cno = value; }
        }
        /// <summary>
        /// 检验号
        /// </summary>		
        private string _insp;
        public string insp
        {
            get { return _insp; }
            set { _insp = value; }
        }
        /// <summary>
        /// 批次号
        /// </summary>		
        private string _bno;
        public string bNo
        {
            get { return _bno; }
            set { _bno = value; }
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
        /// 毛重
        /// </summary>		
        private decimal _grossweight;
        public decimal grossWeight
        {
            get { return _grossweight; }
            set { _grossweight = value; }
        }
        /// <summary>
        /// 净重
        /// </summary>		
        private decimal _nbtweight;
        public decimal nbtWeight
        {
            get { return _nbtweight; }
            set { _nbtweight = value; }
        }
        /// <summary>
        /// 生产日期
        /// </summary>		
        private DateTime _productdate;
        public DateTime productDate
        {
            get { return _productdate; }
            set { _productdate = value; }
        }
        /// <summary>
        /// 包装日期
        /// </summary>		
        private DateTime _packagedate;
        public DateTime packageDate
        {
            get { return _packagedate; }
            set { _packagedate = value; }
        }
        /// <summary>
        /// 改特性日期
        /// </summary>		
        private DateTime _changedate;
        public DateTime changeDate
        {
            get { return _changedate; }
            set { _changedate = value; }
        }
        /// <summary>
        /// 生产车间
        /// </summary>		
        private string _workshop;
        public string workShop
        {
            get { return _workshop; }
            set { _workshop = value; }
        }
        /// <summary>
        /// 车间细分
        /// </summary>		
        private string _wksplit;
        public string wksplit
        {
            get { return _wksplit; }
            set { _wksplit = value; }
        }
        /// <summary>
        /// 染色等级
        /// </summary>		
        private string _dyegrade;
        public string dyeGrade
        {
            get { return _dyegrade; }
            set { _dyegrade = value; }
        }
        /// <summary>
        /// 包装类型
        /// </summary>		
        private string _packtype;
        public string packType
        {
            get { return _packtype; }
            set { _packtype = value; }
        }
        /// <summary>
        /// 打印类型(0-改包装，1-生产下线)
        /// </summary>		
        private int _packagetype;
        public int packageType
        {
            get { return _packagetype; }
            set { _packagetype = value; }
        }
        /// <summary>
        /// 生产特性
        /// </summary>		
        private string _characteristic;
        public string characteristic
        {
            get { return _characteristic; }
            set { _characteristic = value; }
        }
        /// <summary>
        /// 纺位
        /// </summary>		
        private string _seat;
        public string seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
        /// <summary>
        /// 生产线
        /// </summary>		
        private string _workline;
        public string workLine
        {
            get { return _workline; }
            set { _workline = value; }
        }
        /// <summary>
        /// 管色
        /// </summary>		
        private string _pipecolor;
        public string pipeColor
        {
            get { return _pipecolor; }
            set { _pipecolor = value; }
        }
        /// <summary>
        /// 丝别
        /// </summary>		
        private string _wiretype;
        public string wireType
        {
            get { return _wiretype; }
            set { _wiretype = value; }
        }
        /// <summary>
        /// checkerId
        /// </summary>		
        private string _checkerid;
        public string checkerId
        {
            get { return _checkerid; }
            set { _checkerid = value; }
        }
        /// <summary>
        /// 仓库
        /// </summary>		
        private string _warehouseno;
        public string warehouseNo
        {
            get { return _warehouseno; }
            set { _warehouseno = value; }
        }
        /// <summary>
        /// 箱号
        /// </summary>		
        private string _seriesno;
        public string seriesNo
        {
            get { return _seriesno; }
            set { _seriesno = value; }
        }
        /// <summary>
        /// technologyNo
        /// </summary>		
        private string _technologyno;
        public string technologyNo
        {
            get { return _technologyno; }
            set { _technologyno = value; }
        }
        /// <summary>
        /// reason
        /// </summary>		
        private string _reason;
        public string reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
        /// <summary>
        /// 粒重
        /// </summary>		
        private string _grainweight;
        public string grainWeight
        {
            get { return _grainweight; }
            set { _grainweight = value; }
        }
        /// <summary>
        /// 箱重
        /// </summary>		
        private decimal _caseweight;
        public decimal caseWeight
        {
            get { return _caseweight; }
            set { _caseweight = value; }
        }
        /// <summary>
        /// 纸管重
        /// </summary>		
        private decimal _canweight;
        public decimal canWeight
        {
            get { return _canweight; }
            set { _canweight = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _comments;
        public string comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _othercomments;
        public string OTHERCOMMENTS
        {
            get { return _othercomments; }
            set { _othercomments = value; }
        }
        /// <summary>
        /// timestamps
        /// </summary>		
        private DateTime _timestamps;
        public DateTime timestamps
        {
            get { return _timestamps; }
            set { _timestamps = value; }
        }
        /// <summary>
        /// 机台号
        /// </summary>		
        private string _machine_no;
        public string machine_no
        {
            get { return _machine_no; }
            set { _machine_no = value; }
        }
        /// <summary>
        /// 隔离原因
        /// </summary>		
        private string _iso_no;
        public string ISO_NO
        {
            get { return _iso_no; }
            set { _iso_no = value; }
        }
        /// <summary>
        /// Reprintkey
        /// </summary>		
        private bool _reprintkey;
        public bool Reprintkey
        {
            get { return _reprintkey; }
            set { _reprintkey = value; }
        }
        /// <summary>
        /// DyeInnerCode
        /// </summary>		
        private string _dyeinnercode;
        public string DyeInnerCode
        {
            get { return _dyeinnercode; }
            set { _dyeinnercode = value; }
        }
        /// <summary>
        /// inner_key
        /// </summary>		
        private bool _inner_key;
        public bool inner_key
        {
            get { return _inner_key; }
            set { _inner_key = value; }
        }
        /// <summary>
        /// 隐藏料号
        /// </summary>		
        private string _innermatno;
        public string innerMatNo
        {
            get { return _innermatno; }
            set { _innermatno = value; }
        }
        /// <summary>
        /// 生产订单
        /// </summary>		
        private string _ord_no;
        public string ORD_NO
        {
            get { return _ord_no; }
            set { _ord_no = value; }
        }
        /// <summary>
        /// 料仓号
        /// </summary>		
        private string _silonum;
        public string SILONUM
        {
            get { return _silonum; }
            set { _silonum = value; }
        }
        /// <summary>
        /// 工艺号
        /// </summary>		
        private string _processnum;
        public string PROCESSNUM
        {
            get { return _processnum; }
            set { _processnum = value; }
        }
        /// <summary>
        /// 组别
        /// </summary>		
        private string _grouptxt;
        public string GroupTxt
        {
            get { return _grouptxt; }
            set { _grouptxt = value; }
        }
        /// <summary>
        /// 栈板号
        /// </summary>		
        private string _su_id;
        public string SU_ID
        {
            get { return _su_id; }
            set { _su_id = value; }
        }
        /// <summary>
        /// 箱号类型(0: 大箱 1:小箱)
        /// </summary>		
        private int _box_type;
        public int BOX_TYPE
        {
            get { return _box_type; }
            set { _box_type = value; }
        }
        /// <summary>
        /// 是否副产品
        /// </summary>		
        private bool _isviceproduct;
        public bool ISViceProduct
        {
            get { return _isviceproduct; }
            set { _isviceproduct = value; }
        }
        /// <summary>
        /// 是否出口
        /// </summary>		
        private bool _isexport;
        public bool ISExport
        {
            get { return _isexport; }
            set { _isexport = value; }
        }
        /// <summary>
        /// 状态(0已创建;1已组托;2已入库;3已完成;9已删除)
        /// </summary>		
        private int _state;
        public int STATE
        {
            get { return _state; }
            set { _state = value; }
        }
        /// <summary>
        /// 扩展字段0
        /// </summary>		
        private string _pack_ex0;
        public string pack_Ex0
        {
            get { return _pack_ex0; }
            set { _pack_ex0 = value; }
        }
        /// <summary>
        /// 扩展字段1
        /// </summary>		
        private string _pack_ex1;
        public string pack_Ex1
        {
            get { return _pack_ex1; }
            set { _pack_ex1 = value; }
        }
        /// <summary>
        /// 扩展字段2
        /// </summary>		
        private string _pack_ex2;
        public string pack_Ex2
        {
            get { return _pack_ex2; }
            set { _pack_ex2 = value; }
        }
        /// <summary>
        /// 扩展字段3（废丝标签存工厂字段）
        /// </summary>		
        private string _pack_ex3;
        public string pack_Ex3
        {
            get { return _pack_ex3; }
            set { _pack_ex3 = value; }
        }
        /// <summary>
        /// 扩展字段4
        /// </summary>		
        private string _pack_ex4;
        public string pack_Ex4
        {
            get { return _pack_ex4; }
            set { _pack_ex4 = value; }
        }
        /// <summary>
        /// 扩展字段5
        /// </summary>		
        private int _pack_ex5;
        public int pack_Ex5
        {
            get { return _pack_ex5; }
            set { _pack_ex5 = value; }
        }
        /// <summary>
        /// 扩展字段6（存储客户抬头标题）
        /// </summary>		
        private string _pack_ex6;
        public string pack_Ex6
        {
            get { return _pack_ex6; }
            set { _pack_ex6 = value; }
        }
        /// <summary>
        /// 扩展字段7（存储是否隐藏标签日期标识）
        /// </summary>		
        private string _pack_ex7;
        public string pack_Ex7
        {
            get { return _pack_ex7; }
            set { _pack_ex7 = value; }
        }
        /// <summary>
        /// 扩展字段8
        /// </summary>		
        private int _pack_ex8;
        public int pack_Ex8
        {
            get { return _pack_ex8; }
            set { _pack_ex8 = value; }
        }
        /// <summary>
        /// 扩展字段9
        /// </summary>		
        private string _pack_ex9;
        public string pack_Ex9
        {
            get { return _pack_ex9; }
            set { _pack_ex9 = value; }
        }
        /// <summary>
        /// 扩展字段10（存储客户批号）
        /// </summary>		
        private string _pack_ex10;
        public string pack_Ex10
        {
            get { return _pack_ex10; }
            set { _pack_ex10 = value; }
        }
        /// <summary>
        /// 扩展字段11
        /// </summary>		
        private int _pack_ex11;
        public int pack_Ex11
        {
            get { return _pack_ex11; }
            set { _pack_ex11 = value; }
        }
        /// <summary>
        /// CREATEUSER
        /// </summary>		
        private string _createuser;
        public string CREATEUSER
        {
            get { return _createuser; }
            set { _createuser = value; }
        }
        /// <summary>
        /// CREATEDATE
        /// </summary>		
        private DateTime _createdate;
        public DateTime CREATEDATE
        {
            get { return _createdate; }
            set { _createdate = value; }
        }
        /// <summary>
        /// MODIFYUSER
        /// </summary>		
        private string _modifyuser;
        public string MODIFYUSER
        {
            get { return _modifyuser; }
            set { _modifyuser = value; }
        }
        /// <summary>
        /// MODIFYDATE
        /// </summary>		
        private DateTime _modifydate;
        public DateTime MODIFYDATE
        {
            get { return _modifydate; }
            set { _modifydate = value; }
        }
    }
}
