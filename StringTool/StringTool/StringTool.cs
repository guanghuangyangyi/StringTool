//文件名称（File Name）                 StringTool.cs
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringTool
{
    /// <summary>
    /// 字符串工具类
    /// </summary>
    public class StringTool
    {
        public static string[] SplitString(string strContent, string strSplit)
        {
            string[] result = new string[] { };
            try
            {
                if (!string.IsNullOrWhiteSpace(strContent))
                {
                    if (!string.IsNullOrWhiteSpace(strSplit))
                    {
                        int i = strContent.IndexOf(strSplit);
                        if (strContent.IndexOf(strSplit) > 0)
                        {
                            result = Regex.Split(strContent, @strSplit.Replace(".", @"\."));
                        }
                        else
                        {
                            //result = { strContent };
                        }
                    }
                    else {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }
}
