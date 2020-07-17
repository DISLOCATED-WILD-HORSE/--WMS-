using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_CustomModel
{
    /// <summary>
    /// 物料查询需要的条件对象
    /// </summary>
    public class MatModel
    {
        public string MAT_ID { get; set; }
        public string MAT_SPECI { get; set; }
        public string MAT_SNCONTROL { get; set; }
        public string MAT_OLD { get; set; }
        public string MAT_BATCHMODE { get; set; }
        public string MAT_STATUS { get; set; }
    }
}
