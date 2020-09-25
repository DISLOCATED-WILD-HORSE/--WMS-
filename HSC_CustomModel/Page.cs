using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_CustomModel
{
    public class Page
    {
        public Page() { }
        public Page(int pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        public int pageIndex = 1;
        public int pageSize = 200;
        public int totalCount = 0;

        private int totalPage;
        public int GetTotalPage()
        {
            SetTotalPage();
            return totalPage;
        }
        private void SetTotalPage()
        {
            if (totalCount <= pageSize)
                totalPage = 1;
            else
            {
                if (totalCount % pageSize == 0)
                    totalPage = totalCount / pageSize;
                else
                    totalPage = totalCount / pageSize + 1;
            }
        }
        //    get
        //    {
        //        return _totalPage;
        //    }
        //    set
        //    {
        //        if (_totalPage <= pageSize)
        //            _totalPage = 1;
        //        else
        //        {
        //            if (totalCount % pageSize == 0)
        //                _totalPage = totalCount / pageSize;
        //            else
        //                _totalPage = totalCount / pageSize + 1;
        //        }
        //    }
        //}
    }
}
