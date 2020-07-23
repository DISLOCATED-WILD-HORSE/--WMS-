using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Update
{
    public class ConfigModel
    {
        #region 配置实体信息
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        private String[] files;

        public String[] Files
        {
            get { return files; }
            set { files = value; }
        }

        public string Msg
        {
            get;
            set;
        }

        public string Program
        {
            get;
            set;
        }

        public bool IsSilentUpgrade
        {
            get;
            set;
        }

        #endregion
    }
}
