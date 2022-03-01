using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 根据父组织编号获取下级组织列表请求
    /// </summary>
    public class SubOrgListRequest : PagedQuery
    {
        /// <summary>
        /// 父组织编号，        从获取组织列表 接口获取返回参数orgIndexCode
        /// </summary>
        public string ParentOrgIndexCode { get; set; }

        /// <summary>
        /// 根据父组织编号获取下级组织列表请求
        /// </summary>
        /// <param name="parentOrgIndexCode">父组织编号</param>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        public SubOrgListRequest(string parentOrgIndexCode, int pageNo, int pageSize) : base(pageNo, pageSize)
        {
            ParentOrgIndexCode = parentOrgIndexCode;
        }


    }
}
