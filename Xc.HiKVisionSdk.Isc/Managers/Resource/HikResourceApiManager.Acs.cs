using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    /// <summary>
    /// 资源API
    /// </summary>
    public partial class HikResourceApiManager : IHikResourceApiManager
    {
        /// <summary>
        /// 查询门禁点列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AcsDoorAdvanceAcsDoorListResponse> AcsDoorAdvanceAcsDoorListAsync(AcsDoorAdvanceAcsDoorListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AcsDoorAdvanceAcsDoorListRequest, AcsDoorAdvanceAcsDoorListResponse>("/api/resource/v1/acsDoor/advance/acsDoorList", model, Const.V1_0);
        }

    }
}
