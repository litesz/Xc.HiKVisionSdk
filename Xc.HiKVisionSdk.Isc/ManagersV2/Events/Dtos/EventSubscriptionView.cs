namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos
{
    /// <summary>
    /// 查询事件订阅信息结果数据
    /// </summary>
    public class EventSubscriptionView
    {
        /// <summary>
        /// 详细数据
        /// </summary>
        public EventSubscriptionViewDetail[] Detail { get; set; }
    }
}
