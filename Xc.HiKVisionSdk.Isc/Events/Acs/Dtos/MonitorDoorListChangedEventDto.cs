using Xc.HiKVisionSdk.Isc.Enums.Events;

namespace Xc.HiKVisionSdk.Isc.Events.Acs.Dtos
{
    /// <summary>
    /// 监听门改变事件传输模型
    /// </summary>
    public class MonitorDoorListChangedEventDto
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public EventType Type { get; set; }
        /// <summary>
        /// 具体值
        /// </summary>
        public MonitorDoorListItemDto[] Items { get; set; }
    }
}
