using System;
using Xc.HiKVisionSdk.Models.Request;
using Xc.HiKVisionSdk.Utils;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 增量获取人员数据请求
    /// </summary>
    public class GetPersonListByTimeRangeRequest : PagedRequest
    {

        /// <summary>
        /// 针对更新时间的查询开始日期，IOS8601格式
        /// </summary>
        public string StartTime { get; }
        /// <summary>
        /// 针对更新时间的查询截止日期，IOS8601格式
        /// </summary>
        public string EndTime { get; }


        /// <summary>
        /// 增量获取组织数据
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        /// <param name="start">针对更新时间的查询开始日期</param>
        /// <param name="end">针对更新时间的查询截止日期</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public GetPersonListByTimeRangeRequest(int pageNo, int pageSize, DateTime start, DateTime? end = null) : base(pageNo, pageSize)
        {
            StartTime = DateTimeFormat.ToIOS8601(start);
            if (end == null)
            {
                EndTime = DateTimeFormat.ToIOS8601(start.AddHours(48));
            }
            else
            {
                if (end.Value < start)
                {
                    throw new ArgumentOutOfRangeException(nameof(end), "查询截止时间必须大于开始时间");
                }
                if ((end.Value - start).TotalSeconds > 60 * 60 * 48)
                {
                    throw new ArgumentOutOfRangeException(nameof(end), "开始日期与结束日期的时间差必须在1-48小时内");

                }
                EndTime = DateTimeFormat.ToIOS8601(end.Value);
            }
        }

    }


}
