using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Irds.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Irds
{
    /// <summary>
    /// 
    /// </summary>
    public class HikIrdsApiManager : IHikIrdsApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="hikVisionApiManager"></param>
        public HikIrdsApiManager(IHikVisionApiManager hikVisionApiManager)
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
            return _hikVisionApiManager.PostAndGetAsync<CardInfoRequest, CardInfoResponse>("/api/irds/v1/card/cardInfo", request, Const.V1_2);
        }
   
    }
}
