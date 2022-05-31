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
            return _hikVisionApiManager.PostAndGetAsync<OrgListRequest, OrgListResponse>("/api/resource/v1/org/orgList", model, VersionConsts.V1);
        }


        /// <summary>
        /// 根组织
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<RootOrgResponse> RootOrgAsync(RootOrgRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<RootOrgRequest, RootOrgResponse>("/api/resource/v1/org/rootOrg", model, VersionConsts.V1);
        }

        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<OrgSingleUpdateResponse> OrgSingleUpdateAsync(OrgSingleUpdateRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgSingleUpdateRequest, OrgSingleUpdateResponse>("/api/resource/v1/org/single/update", request, VersionConsts.V1_3);
        }


        /// <summary>
        /// 批量删除组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<OrgBatchDeleteResponse> OrgBatchDeleteAsync(OrgBatchDeleteRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgBatchDeleteRequest, OrgBatchDeleteResponse>("/api/resource/v1/org/batch/delete", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 批量添加组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<OrgBatchAddResponse> OrgBatchAddAsync(OrgBatchAddRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgBatchAddRequest, OrgBatchAddResponse>("/api/resource/v1/org/batch/add", request, VersionConsts.V1_3);
        }


        /// <summary>
        /// 查询组织列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AdvanceOrgListV2Response> AdvanceOrgListV2Async(AdvanceOrgListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvanceOrgListV2Request, AdvanceOrgListV2Response>("/api/resource/v2/org/advance/orgList", model, VersionConsts.V1_4);
        }

        /// <summary>
        /// 查询组织列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AdvanceOrgListResponse> AdvanceOrgListAsync(AdvanceOrgListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvanceOrgListRequest, AdvanceOrgListResponse>("/api/resource/v1/org/advance/orgList", model, VersionConsts.V1);
        }

        /// <summary>
        /// 根据父组织编号获取下级组织列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<SubOrgListResponse> SubOrgListAsync(SubOrgListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<SubOrgListRequest, SubOrgListResponse>("/api/resource/v1/org/parentOrgIndexCode/subOrgList", model, VersionConsts.V1);
        }

        /// <summary>
        /// 增量获取组织数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<OrgTimeRangeResponse> OrgTimeRangeAsync(OrgTimeRangeRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgTimeRangeRequest, OrgTimeRangeResponse>("/api/resource/v1/org/timeRange", model, VersionConsts.V1_4);
        }

        /// <summary>
        /// 根据组织编号获取组织详细信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<OrgInfoResponse> OrgInfoAsync(OrgInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgInfoRequest, OrgInfoResponse>("/api/resource/v1/org/orgIndexCodes/orgInfo", model, VersionConsts.V1_4);
        }
    }
}
