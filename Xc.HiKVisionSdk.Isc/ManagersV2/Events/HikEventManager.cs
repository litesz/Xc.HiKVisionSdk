using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events
{
    /// <summary>
    /// 事件
    /// </summary>
    public class HikEventManager : IHikEventManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;
        private static readonly GetSubscriptionViewRequest _getSubscriptionViewRequest = new GetSubscriptionViewRequest();
        /// <summary>
        /// 人员及照片管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEventManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetEventsListResponse> GetEventsListAsync(GetEventsListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetEventsListRequest, GetEventsListResponse>("/api/els/v1/events/search", request, VersionConsts.V1_3);
        }


        /// <summary>
        /// 按事件类型订阅事件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<SubscriptionByEventTypesResponse> SubscriptionByEventTypesAsync(SubscriptionByEventTypesRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<SubscriptionByEventTypesRequest, SubscriptionByEventTypesResponse>("/api/eventService/v1/eventSubscriptionByEventTypes", request, VersionConsts.V1_3);
        }


        /// <summary>
        /// 查询事件订阅信息
        /// </summary>
        /// <returns></returns>
        public Task<GetSubscriptionViewResponse> GetEventSubscriptionViewAsync()
        {
            return _hikVisionApiManager.PostAndGetAsync<GetSubscriptionViewRequest, GetSubscriptionViewResponse>("/api/eventService/v1/eventSubscriptionView", _getSubscriptionViewRequest, VersionConsts.V1);
        }

        /// <summary>
        /// 按事件类型取消订阅
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<UnSubscriptionByEventTypesResponse> UnSubscriptionByEventTypesAsync(UnSubscriptionByEventTypesRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<UnSubscriptionByEventTypesRequest, UnSubscriptionByEventTypesResponse>("/api/eventService/v1/eventUnSubscriptionByEventTypes", request, VersionConsts.V1);
        }
    }
}
