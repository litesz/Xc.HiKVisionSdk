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
    }
}
