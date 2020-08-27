using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸识别api
    /// </summary>
    public partial class HikFrsApiManager
    {
        /// <summary>
        /// 按条件查询重点人员事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<EventBlackSearchResponse> EventBlackSearch(EventBlackSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventBlackSearchRequest, EventBlackSearchResponse>("/artemis/api/frs/v1/event/black/search", model, Const.V1_3);
        }

       
    }
}
