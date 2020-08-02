namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    /// <summary>
    /// 按事件类型取消订阅请求
    /// </summary>
    public class EventUnSubscriptionByEventTypesRequest
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public int[] EventTypes { get; set; }
    }

}
