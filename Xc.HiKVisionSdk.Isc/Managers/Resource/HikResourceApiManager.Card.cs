using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org;

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
            return _hikVisionApiManager.PostAndGetAsync<CardListRequest, CardListResponse>("/artemis/api/resource/v1/card/cardList", request, Const.V1_2);
        }

    }
}
