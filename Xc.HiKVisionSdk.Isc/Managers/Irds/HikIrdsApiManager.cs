using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Irds.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Irds
{
    /// <summary>
    /// 
    /// </summary>
    public class HikIrdsApiManager : IHikIrdsApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikIrdsApiManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardInfoResponse> CardInfoAsync(CardInfoRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CardInfoRequest, CardInfoResponse>("/api/irds/v1/card/cardInfo", request, VersionConsts.V1_2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardListResponse> CardListAsync(CardListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CardListRequest, CardListResponse>("/api/resource/v1/card/cardList", request, VersionConsts.V1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<AdvanceCardListResponse> AdvanceCardListAsync(AdvanceCardListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvanceCardListRequest, AdvanceCardListResponse>("/api/irds/v1/card/advance/cardList", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardTimeRangeResponse> CardTimeRangeAsync(CardTimeRangeRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CardTimeRangeRequest, CardTimeRangeResponse>("/api/resource/v1/card/timeRange", request, VersionConsts.V1_4);
        }

    }
}
