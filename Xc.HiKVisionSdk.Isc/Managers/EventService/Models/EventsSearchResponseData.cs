namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    public class EventsSearchResponseData
    {
        /// <summary>
        /// 事件id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 事件规则id
        /// </summary>
        public string EventRuleId { get; set; }
        /// <summary>
        /// 事件规则名称
        /// </summary>
        public string RuleName { get; set; }
        /// <summary>
        /// 事件开始时间，ISO8601格式：yyyy-MM-ddTHH:mm:ss.zzz+当前时区，例如北京时间：2018-07-26T15:00:00.000+08:00
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 事件结束时间，ISO8601格式：yyyy-MM-ddTHH:mm:ss.zzz+当前时区，例如北京时间：2018-07-26T15:00:00.000+08:00
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 事件等级,1-低，2-中，3-高
        /// </summary>
        public EventLevel EventLevel { get; set; }
        /// <summary>
        /// 事件等级value，低、中、高
        /// </summary>
        public string EventLevelValue { get; set; }
        /// <summary>
        /// 事件等级颜色，RGB格式，例如#AE8D06
        /// </summary>
        public string EventLevelColor { get; set; }
        /// <summary>
        /// 事件类型名称
        /// </summary>
        public string EventTypeName { get; set; }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 事件处理状态，0-未处理，1-已处理
        /// </summary>
        public HandleStatus HandleStatus { get; set; }
        /// <summary>
        /// 事件记录列表
        /// </summary>
        public EventsSearchResponseDataEventLogSrc[] EventLogSrcList { get; set; }
    }

}
