using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc
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
            return $"{dt:yyyy-MM-DDTHH:mm:ss}+08:00:00";
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

    }
}
