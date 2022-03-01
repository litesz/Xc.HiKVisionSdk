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
    }
}
