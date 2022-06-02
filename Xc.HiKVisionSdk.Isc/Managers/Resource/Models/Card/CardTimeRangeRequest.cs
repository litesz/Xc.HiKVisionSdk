using System;
using Xc.HiKVisionSdk.Models.Request;
using Xc.HiKVisionSdk.Utils;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card
{
    /// <summary>
    /// 增量获取卡片数据请求
    /// </summary>
    public class CardTimeRangeRequest : PagedRequest
    {

        /// <summary>
        /// 针对更新时间的查询开始日期，IOS8601格式，参考附录B ISO8601时间格式说明
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 针对更新时间的查询截止日期，IOS8601格式，参考附录B ISO8601时间格式说明
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 增量获取卡片数据请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public CardTimeRangeRequest(int pageNo, int pageSize, DateTime startTime, DateTime? endTime = null) : base(pageNo, pageSize)
        {
            StartTime = DateTimeFormat.ToIOS8601(startTime);
            if (endTime.HasValue)
            {
                if (endTime.Value < startTime)
                {
                    throw new ArgumentOutOfRangeException(nameof(endTime), "查询截止日期必须大于查询开始日期");
                }
                if ((endTime.Value - startTime).TotalSeconds > 60 * 60 * 48)
                {
                    throw new ArgumentOutOfRangeException(nameof(endTime), "查询截止日期与查询开始日期的时间差必须在48小时内");
                }

                EndTime = DateTimeFormat.ToIOS8601(endTime.Value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(StartTime))
            {
                throw new ArgumentNullException(nameof(StartTime));
            }
            base.CheckParams();
        }


    }
}
