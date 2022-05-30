using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    /// <summary>
    /// 按事件类型取消订阅请求
    /// </summary>
    public class EventUnSubscriptionByEventTypesRequest : BaseRequest
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public int[] EventTypes { get; set; }

        /// <summary>
        /// 按事件类型取消订阅请求
        /// </summary>
        public EventUnSubscriptionByEventTypesRequest() { }

        /// <summary>
        /// 按事件类型取消订阅请求
        /// </summary>
        /// <param name="eventTypes">事件类型</param>
        public EventUnSubscriptionByEventTypesRequest(params int[] eventTypes)
        {
            EventTypes = eventTypes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        protected override void CheckParams()
        {
            if (EventTypes == null)
            {
                throw new ArgumentNullException(nameof(EventTypes));
            }
            if (EventTypes.Length == 0)
            {
                throw new IndexOutOfRangeException(nameof(EventTypes));
            }
        }

    }

}
