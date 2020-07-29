using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    public partial class HikResourceApiManager : IHikResourceApiManager
    {

        public Task<OrgListResponse> OrgListAsync(OrgListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgListRequest, OrgListResponse>("/artemis/api/resource/v1/org/orgList", model, Const.V1_0);
        }

    }
}
