//文件名称（File Name）                 StringConverTool.cs
//作者(Author)                          yjq
//日期（Create Date）                   2017.5.5
//修改记录(Revision History)
//    R1:
//        修改作者:
//        修改日期:
//        修改原因:
//    R2:
//        修改作者:
//        修改日期:
//        修改原因:
//**************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTool
{
    /// <summary>
    /// 字符串转换工具类
    /// </summary>
    public class StringConverTool
    {
        public static int StringToInt(object strValue)
        {
            int defValue = -1;
            try
            {
                if (strValue!=null&& string.IsNullOrWhiteSpace(strValue))
                {

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return defValue;
        }
    }
}
