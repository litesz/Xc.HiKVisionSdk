using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Utils
{
    /// <summary>
    /// 时间格式转换
    /// </summary>
    public static class DateTimeFormat
    {
        /// <summary>
        /// datetime转ios8601
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToIOS8601(DateTime dt)
        {
            return $"{dt:yyyy-MM-ddTHH:mm:ss}.000+08:00:00";
        }

        /// <summary>
        /// datetime转yyyy-MM-dd
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToDate(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// ios8601转datetime
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(string date)
        {
            return DateTime.Parse(date.Split('+')[0]);
        }

        //public static DateTime TryToDateTime(string date, out DateTime dt)
        //{

        //}
    }
}
