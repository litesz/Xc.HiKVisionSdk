namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    /// <summary>
    /// 事件记录
    /// </summary>
    public class EventsSearchResponseDataEventLogSrc
    {
        /// <summary>
        /// 事件源id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 事件id
        /// </summary>
        public string EventLogId { get; set; }
        /// <summary>
        ///  事件分类，详见附录A.62
        /// </summary>
        public string Ability;
        /// <summary>
        /// 事件类型，详见附录D.1
        /// </summary>
        public string EventType;
        /// <summary>
        /// 事件类型名称
        /// </summary>
        public string EventTypeName;
        /// <summary>
        /// 事件源编号
        /// </summary>
        public string ResIndexCode;
        /// <summary>
        /// 事件源类型，详见附录A.63
        /// </summary>
        public string ResType;
        /// <summary>
        /// 事件源名称
        /// </summary>
        public string ResName;
        /// <summary>
        /// 所属区域编号
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 所属区域名称
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// 所属位置，详见附录A.81 安装位置
        /// </summary>
        public string LocationIndexCode { get; set; }
        /// <summary>
        /// 所属位置名称
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 扩展字段1，暂不使用
        /// </summary>
        public string Extend1 { get; set; }
        /// <summary>
        /// 扩展字段2，暂不使用
        /// </summary>
        public string Extend2 { get; set; }
        /// <summary>
        ///  开始时间,ISO8601时间
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 事件扩展信息
        /// </summary>
        public string Data { get; set; }
    }

}
