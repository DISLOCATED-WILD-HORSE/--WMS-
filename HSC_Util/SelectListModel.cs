using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_Util
{
    public static class SelectListModel
    {
        /// <summary>
        /// 本地存储的料仓号
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string,string> SiloNumList()
        {
            Dictionary<string,string> siloNumsList = new Dictionary<string,string>();
            siloNumsList.Add("","");
            siloNumsList.Add("140T010A","01");
            siloNumsList.Add("140T010B","02");
            siloNumsList.Add("140T020","03");
            siloNumsList.Add("240T010A","04");
            siloNumsList.Add("240T010B","05");
            siloNumsList.Add("240T020A","06");
            siloNumsList.Add("240T010C","07");
            siloNumsList.Add("240T010D","08");
            siloNumsList.Add("240T020B","09"); 
            siloNumsList.Add("340T010A","10");
            siloNumsList.Add("340T010B","11");
            siloNumsList.Add("340T020A","12");
            siloNumsList.Add("340T010C","13");
            siloNumsList.Add("340T010D","14");
            siloNumsList.Add("340T020B","15");
            return siloNumsList;
        }

        /// <summary>
        /// 本地等级存储
        /// </summary>
        /// <returns></returns>
        public static List<string> GradeList()
        {
            List<string> gradeList = new List<string>();
            gradeList.Add("");
            gradeList.Add("AA");
            //gradeList.Add("AA+");
            gradeList.Add("A");
            //gradeList.Add("A1");
            //gradeList.Add("A2");
            //gradeList.Add("ST");
            gradeList.Add("B");
            //gradeList.Add("A+");
            return gradeList;
        }

        /// <summary>
        /// 本地生产线存储
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string,string> WorkLineList()
        {
            Dictionary<string,string> workLienList = new Dictionary<string, string>();
            workLienList.Add("","");
            workLienList.Add("140-U010A", "1");
            workLienList.Add("140-U010B", "2");
            workLienList.Add("240-U010A", "3");
            workLienList.Add("240-U010B", "4");
            workLienList.Add("340-U010A", "5");
            workLienList.Add("340-U010B", "6");
            return workLienList;
        }

        /// <summary>
        /// 本地包装类型
        /// </summary>
        /// <returns></returns>
        public static List<string> PackTypeList()
        {
            List<string> packTypeList = new List<string>();
            packTypeList.Add("");
            packTypeList.Add("袋装");
            packTypeList.Add("桶装");
            return packTypeList;
        }

        /// <summary>
        /// 净重
        /// </summary>
        /// <returns></returns>
        public static List<decimal> NbtWeightList()
        {
            List<decimal> list = new List<decimal>();
            list.Add(25);
            list.Add(750);
            list.Add(820);
            list.Add(850);
            return list;
        }
    }
}
