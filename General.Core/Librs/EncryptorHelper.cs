using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace General.Core.Librs
{
    public static class EncryptorHelper
    {

        /// <summary>
        /// Md5加密（32位大写）
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string GetMd532(string inputValue)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(inputValue));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "");
            }
        }

        /// <summary>
        /// Md5加密（16位大写）
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string GetMd516(string inputValue)
        {
            //16位大写
            using (var md5 = MD5.Create())
            {
                var data = md5.ComputeHash(Encoding.UTF8.GetBytes(inputValue));
                StringBuilder builder = new StringBuilder();
                // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串 
                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("X2"));
                }
                return builder.ToString().Substring(8, 16);
            }
        }
    }
}
