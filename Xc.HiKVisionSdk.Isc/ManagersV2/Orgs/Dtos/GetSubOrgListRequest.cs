using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 根据父组织编号获取下级组织列表请求
    /// </summary>
    public class GetSubOrgListRequest : PagedRequest
    {
        /// <summary>
        /// 父组织编号，        从获取组织列表 接口获取返回参数orgIndexCode
        /// </summary>
        public string ParentOrgIndexCode { get; }

        /// <summary>
        /// 根据父组织编号获取下级组织列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentOrgIndexCode"></param>
        public GetSubOrgListRequest(int pageNo, int pageSize, string parentOrgIndexCode) : base(pageNo, pageSize)
        {
            if (string.IsNullOrWhiteSpace(parentOrgIndexCode))
            {
                throw new ArgumentNullException(nameof(parentOrgIndexCode));
            }
            ParentOrgIndexCode = parentOrgIndexCode;
        }
    }
}
