using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.EventService.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService
{

    /// <summary>
    /// 事件服务api
    /// </summary>
    public class HikEventServiceApiManager : IHikEventServiceApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEventServiceApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public EventsSearchResponse EventsSearch(EventsSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGet<EventsSearchRequest, EventsSearchResponse>("/artemis/api/eventService/v1/events/search", model, Const.V1_3);
        }

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<EventsSearchResponse> EventsSearchAsync(EventsSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventsSearchRequest, EventsSearchResponse>("/artemis/api/eventService/v1/events/search", model, Const.V1_3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public EventSubscriptionByEventTypesResponse EventSubscriptionByEventTypes(EventSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGet<EventSubscriptionByEventTypesRequest, EventSubscriptionByEventTypesResponse>("/artemis/api/eventService/v1/eventSubscriptionByEventTypes", model, Const.V1_3);
        }

        public Task<EventSubscriptionByEventTypesResponse> EventSubscriptionByEventTypesAsync(EventSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventSubscriptionByEventTypesRequest, EventSubscriptionByEventTypesResponse>("/artemis/api/eventService/v1/eventSubscriptionByEventTypes", model, Const.V1_3);
        }

        public EventSubscriptionViewResponse EventSubscriptionView()
        {
            return _hikVisionApiManager.PostAndGet<EventSubscriptionViewRequest, EventSubscriptionViewResponse>("/artemis/api/eventService/v1/eventSubscriptionView", null, Const.V1_0);
        }

        public Task<EventSubscriptionViewResponse> EventSubscriptionViewAsync()
        {
            return _hikVisionApiManager.PostAndGetAsync<EventSubscriptionViewRequest, EventSubscriptionViewResponse>("/artemis/api/eventService/v1/eventSubscriptionView", null, Const.V1_0);
        }

        public EventUnSubscriptionByEventTypesResponse EventUnSubscriptionByEventTypes(EventUnSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGet<EventUnSubscriptionByEventTypesRequest, EventUnSubscriptionByEventTypesResponse>("/artemis/api/eventService/v1/eventUnSubscriptionByEventTypes", model, Const.V1_0);
        }

        public Task<EventUnSubscriptionByEventTypesResponse> EventUnSubscriptionByEventTypesAsync(EventUnSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventUnSubscriptionByEventTypesRequest, EventUnSubscriptionByEventTypesResponse>("/artemis/api/eventService/v1/eventUnSubscriptionByEventTypes", model, Const.V1_0);
        }
    }
}
