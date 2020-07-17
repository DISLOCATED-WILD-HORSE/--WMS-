using HSC_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HSC_Util
{
    public static class PrintValidating
    {
        /// <summary>
        /// 打印验证
        /// </summary>
        /// <returns>返回是否通过 ref Msg</returns>
        public static bool Verification(packageInfo model, ref string Msg,string page)
        {
            bool isPass = true;
            if (string.IsNullOrEmpty(model.spec))
            {
                Msg = "商品名不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.description))
            {
                Msg = "物料描述不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.mNo))
            {
                Msg = "新物料号不能为空！";
                return false;
            }
            if (string.IsNullOrEmpty(model.standard))
            {
                Msg = "执行标准不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.bNo))
            {
                Msg = "批次号不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.workLine))
            {
                Msg = "生产线不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.grade))
            {
                Msg = "等级不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.hiddenProduct))
            {
                Msg = "批号不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(model.nbtWeight.ToString()) || !IsNumeric(model.nbtWeight.ToString()))
            {
                Msg = "净重不能为空,或者不是数字!";
                return false;
            }
            if (string.IsNullOrEmpty(model.SILONUM))
            {
                Msg = "料仓号不能为空!";
                return false;
            }
            if (string.IsNullOrEmpty(page) || !IsUnsign(page))
            {
                Msg = "张数不能为空!";
                return false;
            }
            return isPass;
        }

        /// <summary>
        /// 验证是否是正整数
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsUnsign(string value)
        {
            return Regex.IsMatch(value, @"^[1-9]\d*$");
        }

        /// <summary>
        /// 验证数字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
    }
}
