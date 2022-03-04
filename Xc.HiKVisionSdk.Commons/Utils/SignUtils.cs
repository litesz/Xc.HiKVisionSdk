using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Xc.HiKVisionSdk.Utils
{
    /// <summary>
    /// 工具
    /// </summary>
    internal static class SignUtils
    {
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="strToSign"></param>
        /// <param name="sk"></param>
        /// <returns></returns>
        public static string ComputeForHMACSHA256(string strToSign, string sk)
        {
            var encoder = new UTF8Encoding();
            byte[] secretBytes = encoder.GetBytes(sk);
            byte[] strBytes = encoder.GetBytes(strToSign);
            var opertor = new HMACSHA256(secretBytes);
            byte[] hashbytes = opertor.ComputeHash(strBytes);
            return Convert.ToBase64String(hashbytes);
        }

        /// <summary>
        /// 生成body的md5内容
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string ComputeBodyMd5(string body)
        {
            using (var x = MD5.Create())
            {
                var bytes = x.ComputeHash(Encoding.UTF8.GetBytes(body));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// 计算签名头
        /// </summary>
        /// <param name="header">请求头</param>
        /// <returns>签名头</returns>
        public static string BuildSignHeader(Dictionary<string, string> header)
        {
            Dictionary<string, string> sortedDicHeader = new Dictionary<string, string>();
            sortedDicHeader = header;
            //var dic = from objDic in sortedDicHeader orderby objDic.Key ascending select objDic;
            var dic = sortedDicHeader.OrderBy(u => u.Key);
            StringBuilder sbSignHeader = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                if (kvp.Key.Replace(" ", "").Contains(SignConsts.XCa))
                {
                    sb.Append(kvp.Key + ":");
                    if (!string.IsNullOrWhiteSpace(kvp.Value))
                    {
                        sb.Append(kvp.Value);
                    }
                    sb.Append("\n");
                    if (sbSignHeader.Length > 0)
                    {
                        sbSignHeader.Append(",");
                    }
                    sbSignHeader.Append(kvp.Key);
                }
            }

            header.Add(SignConsts.XCaSignatureHeaders, sbSignHeader.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// 生成SignString
        /// </summary>
        /// <param name="method">HTTP请求方法，如“POST”</param>
        /// <param name="url">接口Url，如/artemis/api/resource/v1/org/advance/orgList</param>
        /// <param name="header">请求头</param>
        /// <returns>签名字符串</returns>
        public static string BuildSignString(string method, string url, Dictionary<string, string> header)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(method.ToUpper()).Append("\n");
            if (null != header)
            {
                if (null != header[SignConsts.Accept])
                {
                    sb.Append(header[SignConsts.Accept]);
                    sb.Append("\n");
                }

                if (header.ContainsKey(SignConsts.ContentMd5) && null != header[SignConsts.ContentMd5])
                {
                    sb.Append(header[SignConsts.ContentMd5]);
                    sb.Append("\n");
                }

                if (null != header[SignConsts.ContentType])
                {
                    sb.Append(header[SignConsts.ContentType]);
                    sb.Append("\n");
                }

                if (header.ContainsKey(SignConsts.Date) && null != header[SignConsts.Date])
                {
                    sb.Append(header[SignConsts.Date]);
                    sb.Append("\n");
                }
            }

            // build and add header to sign
            string signHeader = BuildSignHeader(header);
            sb.Append(signHeader);
            sb.Append(url);
            return sb.ToString();
        }

    }
}
