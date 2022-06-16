using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos
{
    /// <summary>
    /// 按事件类型取消订阅请求
    /// </summary>
    public class UnSubscriptionByEventTypesRequest : BaseRequest
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public int[] EventTypes { get;  }

       
        /// <summary>
        /// 按事件类型取消订阅请求
        /// </summary>
        /// <param name="eventTypes">事件类型</param>
        public UnSubscriptionByEventTypesRequest(params int[] eventTypes)
        {
            if (eventTypes == null || eventTypes.Length == 0)
            {
                throw new ArgumentNullException(nameof(eventTypes));
            }
            EventTypes = eventTypes;
        }

        

    }
}
