using System;

namespace HSC_Entity
{
    public class tblMaterial
    {
        /// <summary>
		/// 物料编号
        /// </summary>		
		private string _mat_id;
        public string MAT_ID
        {
            get { return _mat_id; }
            set { _mat_id = value; }
        }
        /// <summary>
        /// 旧物料号
        /// </summary>		
        private string _mat_old;
        public string MAT_OLD
        {
            get { return _mat_old; }
            set { _mat_old = value; }
        }
        /// <summary>
        /// 无粒重旧物料号
        /// </summary>		
        private string _mat_gwold;
        public string MAT_GWOLD
        {
            get { return _mat_gwold; }
            set { _mat_gwold = value; }
        }
        /// <summary>
        /// 外部编号
        /// </summary>		
        private string _mat_interfaceid;
        public string MAT_INTERFACEID
        {
            get { return _mat_interfaceid; }
            set { _mat_interfaceid = value; }
        }
        /// <summary>
        /// 外部系统
        /// </summary>		
        private string _mat_system;
        public string MAT_SYSTEM
        {
            get { return _mat_system; }
            set { _mat_system = value; }
        }
        /// <summary>
        /// 物料描述
        /// </summary>		
        private string _mat_desc;
        public string MAT_DESC
        {
            get { return _mat_desc; }
            set { _mat_desc = value; }
        }
        /// <summary>
        /// 英文描述
        /// </summary>		
        private string _mat_endesc;
        public string MAT_ENDESC
        {
            get { return _mat_endesc; }
            set { _mat_endesc = value; }
        }
        /// <summary>
        /// 旧物料描述
        /// </summary>		
        private string _mat_olddesc;
        public string MAT_OLDDESC
        {
            get { return _mat_olddesc; }
            set { _mat_olddesc = value; }
        }
        /// <summary>
        /// 标签品种规格
        /// </summary>		
        private string _mat_speci;
        public string MAT_SPECI
        {
            get { return _mat_speci; }
            set { _mat_speci = value; }
        }
        /// <summary>
        /// 聚合产品规格
        /// </summary>		
        private string _mat_jhspeci;
        public string MAT_JHSPECI
        {
            get { return _mat_jhspeci; }
            set { _mat_jhspeci = value; }
        }
        /// <summary>
        /// 单位
        /// </summary>		
        private string _mat_unit;
        public string MAT_UNIT
        {
            get { return _mat_unit; }
            set { _mat_unit = value; }
        }
        /// <summary>
        /// 单位描述
        /// </summary>		
        private string _mat_unitdesc;
        public string MAT_UNITDESC
        {
            get { return _mat_unitdesc; }
            set { _mat_unitdesc = value; }
        }
        /// <summary>
        /// 检索值(拼音首字母)
        /// </summary>		
        private string _mat_searchid;
        public string MAT_SEARCHID
        {
            get { return _mat_searchid; }
            set { _mat_searchid = value; }
        }
        /// <summary>
        /// 批次管理模式
        /// </summary>		
        private string _mat_batchmode;
        public string MAT_BATCHMODE
        {
            get { return _mat_batchmode; }
            set { _mat_batchmode = value; }
        }
        /// <summary>
        /// 批次管理规则
        /// </summary>		
        private string _mat_batchrule;
        public string MAT_BATCHRULE
        {
            get { return _mat_batchrule; }
            set { _mat_batchrule = value; }
        }
        /// <summary>
        /// 有效期值
        /// </summary>		
        private int _mat_expirynum;
        public int MAT_EXPIRYNUM
        {
            get { return _mat_expirynum; }
            set { _mat_expirynum = value; }
        }
        /// <summary>
        /// 有效期时间单位(Y-年 M-月 D-天)
        /// </summary>		
        private string _mat_expiryunit;
        public string MAT_EXPIRYUNIT
        {
            get { return _mat_expiryunit; }
            set { _mat_expiryunit = value; }
        }
        /// <summary>
        /// 图片
        /// </summary>		
        private string _mat_imageid;
        public string MAT_IMAGEID
        {
            get { return _mat_imageid; }
            set { _mat_imageid = value; }
        }
        /// <summary>
        /// 净重
        /// </summary>		
        private decimal _mat_netweight;
        public decimal MAT_NETWEIGHT
        {
            get { return _mat_netweight; }
            set { _mat_netweight = value; }
        }
        /// <summary>
        /// 毛重
        /// </summary>		
        private decimal _mat_grossweight;
        public decimal MAT_GROSSWEIGHT
        {
            get { return _mat_grossweight; }
            set { _mat_grossweight = value; }
        }
        /// <summary>
        /// 重量单位
        /// </summary>		
        private string _mat_weightunit;
        public string MAT_WEIGHTUNIT
        {
            get { return _mat_weightunit; }
            set { _mat_weightunit = value; }
        }
        /// <summary>
        /// 体积
        /// </summary>		
        private decimal _mat_volume;
        public decimal MAT_VOLUME
        {
            get { return _mat_volume; }
            set { _mat_volume = value; }
        }
        /// <summary>
        /// 体积单位
        /// </summary>		
        private string _mat_vunit;
        public string MAT_VUNIT
        {
            get { return _mat_vunit; }
            set { _mat_vunit = value; }
        }
        /// <summary>
        /// 能力
        /// </summary>		
        private decimal _mat_capacity;
        public decimal MAT_CAPACITY
        {
            get { return _mat_capacity; }
            set { _mat_capacity = value; }
        }
        /// <summary>
        /// 规格型号
        /// </summary>		
        private string _mat_modelname;
        public string MAT_MODELNAME
        {
            get { return _mat_modelname; }
            set { _mat_modelname = value; }
        }
        /// <summary>
        /// 物料产品组
        /// </summary>		
        private string _mat_prdgroup;
        public string MAT_PRDGROUP
        {
            get { return _mat_prdgroup; }
            set { _mat_prdgroup = value; }
        }
        /// <summary>
        /// 物料组
        /// </summary>		
        private string _mat_group;
        public string MAT_GROUP
        {
            get { return _mat_group; }
            set { _mat_group = value; }
        }
        /// <summary>
        /// MRP控制
        /// </summary>		
        private string _mat_mrpcontrol;
        public string MAT_MRPCONTROL
        {
            get { return _mat_mrpcontrol; }
            set { _mat_mrpcontrol = value; }
        }
        /// <summary>
        /// 物料类型
        /// </summary>		
        private string _mat_type;
        public string MAT_TYPE
        {
            get { return _mat_type; }
            set { _mat_type = value; }
        }
        /// <summary>
        /// 粒重
        /// </summary>		
        private string _mat_grainweight;
        public string MAT_GRAINWEIGHT
        {
            get { return _mat_grainweight; }
            set { _mat_grainweight = value; }
        }
        /// <summary>
        /// 箱号管理
        /// </summary>		
        private string _mat_sncontrol;
        public string MAT_SNCONTROL
        {
            get { return _mat_sncontrol; }
            set { _mat_sncontrol = value; }
        }
        /// <summary>
        /// SN基础数量
        /// </summary>		
        private decimal _mat_snbaseqty;
        public decimal MAT_SNBASEQTY
        {
            get { return _mat_snbaseqty; }
            set { _mat_snbaseqty = value; }
        }
        /// <summary>
        /// 物料特征定义
        /// </summary>		
        private string _matchar_defid;
        public string MATCHAR_DEFID
        {
            get { return _matchar_defid; }
            set { _matchar_defid = value; }
        }
        /// <summary>
        /// 提前期
        /// </summary>		
        private int _mat_leadtime;
        public int MAT_LEADTIME
        {
            get { return _mat_leadtime; }
            set { _mat_leadtime = value; }
        }
        /// <summary>
        /// 标准包装数量
        /// </summary>		
        private decimal _mat_spq;
        public decimal MAT_SPQ
        {
            get { return _mat_spq; }
            set { _mat_spq = value; }
        }
        /// <summary>
        /// 物料状态 1-启用 0-冻结
        /// </summary>		
        private int _mat_status;
        public int MAT_STATUS
        {
            get { return _mat_status; }
            set { _mat_status = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _mat_remark;
        public string MAT_REMARK
        {
            get { return _mat_remark; }
            set { _mat_remark = value; }
        }
        /// <summary>
        /// 品牌
        /// </summary>		
        private string _mat_brand;
        public string MAT_BRAND
        {
            get { return _mat_brand; }
            set { _mat_brand = value; }
        }
        /// <summary>
        /// 系列
        /// </summary>		
        private string _mat_series;
        public string MAT_SERIES
        {
            get { return _mat_series; }
            set { _mat_series = value; }
        }
        /// <summary>
        /// 材质
        /// </summary>		
        private string _mat_nature;
        public string MAT_NATURE
        {
            get { return _mat_nature; }
            set { _mat_nature = value; }
        }
        /// <summary>
        /// 定制类型
        /// </summary>		
        private string _mat_ctm;
        public string MAT_CTM
        {
            get { return _mat_ctm; }
            set { _mat_ctm = value; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>		
        private string _mat_standard;
        public string MAT_STANDARD
        {
            get { return _mat_standard; }
            set { _mat_standard = value; }
        }
        /// <summary>
        /// 长
        /// </summary>		
        private decimal _mat_length;
        public decimal MAT_LENGTH
        {
            get { return _mat_length; }
            set { _mat_length = value; }
        }
        /// <summary>
        /// 宽
        /// </summary>		
        private decimal _mat_width;
        public decimal MAT_WIDTH
        {
            get { return _mat_width; }
            set { _mat_width = value; }
        }
        /// <summary>
        /// 高
        /// </summary>		
        private decimal _mat_height;
        public decimal MAT_HEIGHT
        {
            get { return _mat_height; }
            set { _mat_height = value; }
        }
        /// <summary>
        /// 包装长
        /// </summary>		
        private decimal _mat_packlength;
        public decimal MAT_PACKLENGTH
        {
            get { return _mat_packlength; }
            set { _mat_packlength = value; }
        }
        /// <summary>
        /// 包装宽
        /// </summary>		
        private decimal _mat_packwidth;
        public decimal MAT_PACKWIDTH
        {
            get { return _mat_packwidth; }
            set { _mat_packwidth = value; }
        }
        /// <summary>
        /// 包装高
        /// </summary>		
        private decimal _mat_packheight;
        public decimal MAT_PACKHEIGHT
        {
            get { return _mat_packheight; }
            set { _mat_packheight = value; }
        }
        /// <summary>
        /// 质检大类
        /// </summary>		
        private string _qc_bno;
        public string QC_BNO
        {
            get { return _qc_bno; }
            set { _qc_bno = value; }
        }
        /// <summary>
        /// 质检小类
        /// </summary>		
        private string _qc_sno;
        public string QC_SNO
        {
            get { return _qc_sno; }
            set { _qc_sno = value; }
        }
        /// <summary>
        /// 扩展属性1
        /// </summary>		
        private string _mat_attribute1;
        public string MAT_ATTRIBUTE1
        {
            get { return _mat_attribute1; }
            set { _mat_attribute1 = value; }
        }
        /// <summary>
        /// 扩展属性2
        /// </summary>		
        private string _mat_attribute2;
        public string MAT_ATTRIBUTE2
        {
            get { return _mat_attribute2; }
            set { _mat_attribute2 = value; }
        }
        /// <summary>
        /// 扩展属性3
        /// </summary>		
        private string _mat_attribute3;
        public string MAT_ATTRIBUTE3
        {
            get { return _mat_attribute3; }
            set { _mat_attribute3 = value; }
        }
        /// <summary>
        /// 扩展属性4
        /// </summary>		
        private string _mat_attribute4;
        public string MAT_ATTRIBUTE4
        {
            get { return _mat_attribute4; }
            set { _mat_attribute4 = value; }
        }
        /// <summary>
        /// 扩展属性5
        /// </summary>		
        private string _mat_attribute5;
        public string MAT_ATTRIBUTE5
        {
            get { return _mat_attribute5; }
            set { _mat_attribute5 = value; }
        }
        /// <summary>
        /// 物料条码
        /// </summary>		
        private string _mat_barcode;
        public string MAT_BARCODE
        {
            get { return _mat_barcode; }
            set { _mat_barcode = value; }
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
        /// CREATEUSER
        /// </summary>		
        private string _createuser;
        public string CREATEUSER
        {
            get { return _createuser; }
            set { _createuser = value; }
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
        /// <summary>
        /// MODIFYUSER
        /// </summary>		
        private string _modifyuser;
        public string MODIFYUSER
        {
            get { return _modifyuser; }
            set { _modifyuser = value; }
        }
    }
}
