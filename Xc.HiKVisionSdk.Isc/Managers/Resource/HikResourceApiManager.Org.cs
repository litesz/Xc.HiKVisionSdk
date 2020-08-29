using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 资源api
    /// </summary>
    public partial class HikResourceApiManager : IHikResourceApiManager
    {

        /// <summary>
        /// 组织
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<OrgListResponse> OrgListAsync(OrgListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgListRequest, OrgListResponse>("/api/resource/v1/org/orgList", model, Const.V1_0);
        }


        /// <summary>
        /// 根组织
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<RootOrgResponse> RootOrgAsync(RootOrgRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<RootOrgRequest, RootOrgResponse>("/api/resource/v1/org/rootOrg", model, Const.V1_0);
        }

    }
}
