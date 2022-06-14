using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 获取组织列表请求
    /// </summary>
    public class OrgListRequest : PagedRequest
    {
        /// <summary>
        /// 获取组织列表请求
        /// </summary>
        public OrgListRequest() { }

        /// <summary>
        /// 获取组织列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public OrgListRequest(int pageNo, int pageSize) : base(pageNo, pageSize)
        {

        }
    }
}
