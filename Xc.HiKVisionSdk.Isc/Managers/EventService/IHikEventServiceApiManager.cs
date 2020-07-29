using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.EventService.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService
{
    public interface IHikEventServiceApiManager
    {

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EventsSearchResponse EventsSearch(EventsSearchRequest model);

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<EventsSearchResponse> EventsSearchAsync(EventsSearchRequest model);

        /// <summary>
        /// 按事件类型订阅事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EventSubscriptionByEventTypesResponse EventSubscriptionByEventTypes(EventSubscriptionByEventTypesRequest model);

        /// <summary>
        /// 按事件类型订阅事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<EventSubscriptionByEventTypesResponse> EventSubscriptionByEventTypesAsync(EventSubscriptionByEventTypesRequest model);

        /// <summary>
        /// 查询事件订阅信息
        /// </summary>
        /// <returns></returns>
        EventSubscriptionViewResponse EventSubscriptionView();

        /// <summary>
        /// 查询事件订阅信息
        /// </summary>
        /// <returns></returns>
        Task<EventSubscriptionViewResponse> EventSubscriptionViewAsync();

        /// <summary>
        /// 按事件类型取消订阅
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EventUnSubscriptionByEventTypesResponse EventUnSubscriptionByEventTypes(EventUnSubscriptionByEventTypesRequest model);

        /// <summary>
        /// 按事件类型取消订阅
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<EventUnSubscriptionByEventTypesResponse> EventUnSubscriptionByEventTypesAsync(EventUnSubscriptionByEventTypesRequest model);









    }
}
