using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 组织请求
    /// </summary>
    public class OrgListRequest : PagedQuery
    {
        /// <summary>
        /// 组织请求
        /// </summary>
        public OrgListRequest() { }

        /// <summary>
        /// 组织请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public OrgListRequest(int pageNo, int pageSize) : base(pageNo, pageSize)
        {

        }
    }
}
