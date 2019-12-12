using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    class Tools
    {
        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns>是返回true,不是返回false</returns>
        public bool IsNumeric(string str)//接收一个string类型的参数,保存到str里
        {
            if (str==null||str.Length==0)       //验证这个参数是否为空
                return false; //是，就返回False
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例
            byte[] bytestr = ascii.GetBytes(str);//把string类型的参数保存到数组里

            foreach (var item in bytestr)//遍历这个数组里的内容
            {
                if (item<48||item>57)//判断是否为数字
                {
                    return false; //不是，就返回False
                }
            }
            return true; //是，就返回True
            //备注 数字，字母的ASCII码对照表
            /*
            0~9数字对应十进制48－57 
            a~z字母对应的十进制97－122十六进制61－7A 
            A~Z字母对应的十进制65－90十六进制41－5A
            */

        }


    }
}
