using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_CustomModel
{
    /// <summary>
    /// 物料编辑修改的对象
    /// </summary>
    public class UpdateMatModel
    {
        public string MAT_ID { get; set; }//主键
        public string MAT_DESC { get; set; }
        public string MAT_OLD { get; set; }
        public string MAT_OLDDESC { get; set; }
        public string MAT_SPECI { get; set; }
        public string MAT_UNIT { get; set; }
        public string MAT_UNITDESC { get; set; }
        public string MAT_SNCONTROL { get; set; }
        public string MAT_BATCHMODE { get; set; }
        public string MAT_TYPE { get; set; }
        public string MAT_GROUP { get; set; }
        public int MAT_STATUS { get; set; }
        public string MAT_REMARK { get; set; }
    }
}
