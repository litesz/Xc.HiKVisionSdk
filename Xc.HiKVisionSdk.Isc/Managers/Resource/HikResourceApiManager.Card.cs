using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 资源api
    /// </summary>
    public partial class HikResourceApiManager : IHikResourceApiManager
    {

        /// <summary>
        /// 卡列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CardListResponse> CardListAsync(CardListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CardListRequest, CardListResponse>("/api/resource/v1/card/cardList", request, VersionConsts.V1_2);
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
