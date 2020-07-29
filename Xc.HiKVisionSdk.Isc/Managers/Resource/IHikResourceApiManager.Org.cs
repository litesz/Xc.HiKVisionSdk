using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 组织api
    /// </summary>
    public partial interface IHikResourceApiManager
    {
        /// <summary>
        /// 获取组织列表
        /// </summary>
        /// <remarks>
        /// 根据该接口全量同步组织信息,不作权限过滤，返回结果分页展示。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OrgListResponse> OrgListAsync(OrgListRequest model);
    }
}
