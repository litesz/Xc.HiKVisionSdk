using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    public partial class HikResourceApiManager : IHikResourceApiManager
    {
     
        #region acs
        public Task<AcsDoorAdvanceAcsDoorListResponse> AcsDoorAdvanceAcsDoorListAsync(AcsDoorAdvanceAcsDoorListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AcsDoorAdvanceAcsDoorListRequest, AcsDoorAdvanceAcsDoorListResponse>("/artemis/api/resource/v1/acsDoor/advance/acsDoorList", model, Const.V1_0);
        }

        #endregion
    }
}
