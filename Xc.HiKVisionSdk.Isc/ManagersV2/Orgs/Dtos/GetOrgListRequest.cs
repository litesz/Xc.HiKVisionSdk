using System.Collections.Generic;
using System.Text;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 获取组织列表请求
    /// </summary>
    public class GetOrgListRequest : PagedRequest
    {


        /// <summary>
        /// 获取组织列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public GetOrgListRequest(int pageNo, int pageSize) : base(pageNo, pageSize)
        {

        }
    }
}
