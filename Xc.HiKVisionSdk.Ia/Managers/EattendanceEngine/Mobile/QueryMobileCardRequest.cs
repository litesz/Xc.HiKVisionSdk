using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile
{
    /// <summary>
    /// 获取移动考勤有效打卡地点请求
    /// </summary>
    public class QueryMobileCardRequest : BaseRequest
    {
        /// <summary>
        /// 获取移动考勤有效打卡地点请求
        /// </summary>
        public QueryMobileCardRequest() { }


        /// <summary>
        /// 获取移动考勤有效打卡地点请求
        /// </summary>
        /// <param name="id">人员标识</param>
        /// <param name="date">日期</param>
        public QueryMobileCardRequest(string id, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            Date = date.ToString("yyyy-MM-dd HH:mm:ss");
        }


        /// <summary>
        /// 人员标识
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; }

        /// <summary>
        /// 
        /// </summary>
        public override void CheckParams()
        {
        }
    }
}
