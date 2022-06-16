namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos
{
    /// <summary>
    /// 查询事件订阅信息详细
    /// </summary>
    public class EventSubscriptionViewDetail
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public int[] EventTypes { get; set; }
        /// <summary>
        /// 事件接收地址
        /// </summary>
        public string EventDest { get; set; }
    }
}
