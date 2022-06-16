using System;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    /// <summary>
    /// 获取联动事件列表请求
    /// </summary>
    public class EventsSearchRequest : IOSTimeRangeWithPagedRequest
    {
        /// <summary>
        ///  事件规则id
        /// </summary>
        public string EventRuleId { get; set; }
        /// <summary>
        ///  事件分类，详见附录A.62
        /// </summary>
        public string Ability { get; set; }
        /// <summary>
        /// 区域编号
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 所属位置，详见附录A.81 安装位置
        /// </summary>
        public string[] LocationIndexCodes { get; set; }
        /// <summary>
        ///  事件源名称
        /// </summary>
        public string ResName { get; set; }
        /// <summary>
        /// 事件源编号
        /// </summary>
        public string[] ResIndexCodes { get; set; }
        /// <summary>
        ///  事件源类型，详见附录A.63
        /// </summary>
        public string[] ResTypes { get; set; }
        /// <summary>
        /// 事件类型，详见附录D
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// 事件等级，1-低，2-中，3-高
        /// </summary>
        public string[] EventLevels { get; set; }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        ///  处理状态，0-未处理，1-已处理
        /// </summary>
        public HandleStatus HandleStatus { get; set; }

        /// <summary>
        /// 获取联动事件列表请求
        /// </summary>
        public EventsSearchRequest() { }


        /// <summary>
        /// 获取联动事件列表请求
        /// </summary>
        /// <param name="startTime"> 开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        public EventsSearchRequest(DateTime startTime, DateTime endTime, int pageNo, int pageSize) : base(pageNo, pageSize, startTime, endTime)
        {

        }


    }

}
