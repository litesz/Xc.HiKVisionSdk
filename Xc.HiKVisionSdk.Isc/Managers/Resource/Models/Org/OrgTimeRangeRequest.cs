﻿using System;
using Xc.HiKVisionSdk.Isc.Models;


namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 增量获取组织数据
    /// </summary>
    public class OrgTimeRangeRequest : PagedQuery
    {
        /// <summary>
        /// 针对更新时间的查询开始日期，IOS8601格式
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 针对更新时间的查询截止日期，IOS8601格式
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 增量获取组织数据
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        /// <param name="start">针对更新时间的查询开始日期</param>
        /// <param name="end">针对更新时间的查询截止日期</param>

        public OrgTimeRangeRequest(int pageNo, int pageSize, DateTime start, DateTime? end = null) : base(pageNo, pageSize)
        {
            StartTime = DateTimeFormat.ToIOS8601(start);
            if (end == null)
            {
                EndTime = DateTimeFormat.ToIOS8601(start.AddHours(48));
            }
            else
            {
                EndTime = DateTimeFormat.ToIOS8601(end.Value);
            }
        }

    }
}