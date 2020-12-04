using HSC_Entity;
using HSC_SYPrintSystem;
using HSC_Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HSC_BLL
{
    public class UserBLL
    {
        public static tbl_HSCUSER userInfo = null;
        public static ReturnValue Login(string userId, string passWord)
        {
            var userDao = SqlSugarDB.Instance<tbl_HSCUSER>();
            ReturnValue rv = new ReturnValue();
            MD5 d5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(passWord);
            byte[] md5buffer = d5.ComputeHash(buffer);
            string str = null;
            foreach (byte b in md5buffer)
            {
                //得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                //但是在和对方测试过程中，发现我这边的MD5加密编码，经常出现少一位或几位的问题；
                //后来分析发现是 字符串格式符的问题， X 表示大写， x 表示小写， 
                //X2和x2表示不省略首位为0的十六进制数字；
                str += b.ToString("x2");
            }
            try
            {
                tbl_HSCUSER user = userDao.Query().First(p => p.UserID == userId && p.UserPwd == str);
                if (user == null)
                    return rv.Fail("用户名或者密码错误！");
                userInfo = user;
                return rv.Success("登录成功！");
            }
            catch (Exception e)
            {
                return rv.Fail(e.Message);
            }
        }
    }
}
