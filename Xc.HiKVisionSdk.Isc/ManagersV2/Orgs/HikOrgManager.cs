using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs
{
    /// <summary>
    /// 组织管理
    /// </summary>
    public class HikOrgManager : IHikOrgManager
    {
        static GetRootOrgRequest getRootOrgRequest = new GetRootOrgRequest();

        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 组织管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikOrgManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<UpdateOrgResponse> UpdateAsync(UpdateOrgRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<UpdateOrgRequest, UpdateOrgResponse>("/api/resource/v1/org/single/update", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 批量删除组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BatchDeleteOrgsResponse> BatchDeleteAsync(BatchDeleteOrgsRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<BatchDeleteOrgsRequest, BatchDeleteOrgsResponse>("/api/resource/v1/org/batch/delete", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 批量添加组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BatchAddOrgsResponse> BatchAddAsync(BatchAddOrgsRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<BatchAddOrgsRequest, BatchAddOrgsResponse>("/api/resource/v1/org/batch/add", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 获取根组织
        /// </summary>
        /// <returns></returns>
        public Task<GetRootOrgResponse> GetRootAsync()
        {
            return _hikVisionApiManager.PostAndGetAsync<GetRootOrgRequest, GetRootOrgResponse>("/api/resource/v1/org/rootOrg", getRootOrgRequest, VersionConsts.V1);
        }

        /// <summary>
        /// 获取组织列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetOrgListResponse> GetListAsync(GetOrgListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetOrgListRequest, GetOrgListResponse>("/api/resource/v1/org/orgList", request, VersionConsts.V1);
        }

        /// <summary>
        /// 查询组织列表v2
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetOrgListByParametersV2Response> GetListByParametersV2Async(GetOrgListByParametersV2Request request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetOrgListByParametersV2Request, GetOrgListByParametersV2Response>("/api/resource/v2/org/advance/orgList", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 根据父组织编号获取下级组织列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetSubOrgListResponse> GetSubListAsync(GetSubOrgListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetSubOrgListRequest, GetSubOrgListResponse>("/api/resource/v1/org/parentOrgIndexCode/subOrgList", request, VersionConsts.V1);
        }

        /// <summary>
        /// 增量获取组织数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetOrgListByTimeRangeResponse> GetListByTimeRangeAsync(GetOrgListByTimeRangeRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetOrgListByTimeRangeRequest, GetOrgListByTimeRangeResponse>("/api/resource/v1/org/timeRange", request, VersionConsts.V1_4);
        }


        /// <summary>
        /// 根据组织编号获取组织详细信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetOrgListByIndexCodesResponse> GetListByIndexCodesAsync(GetOrgListByIndexCodesRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetOrgListByIndexCodesRequest, GetOrgListByIndexCodesResponse>("/api/resource/v1/org/orgIndexCodes/orgInfo", request, VersionConsts.V1_4);
        }
    }
}
