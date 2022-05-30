using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 高级查询请求
    /// </summary>
    public class AdvanceOrgListRequest : PagedRequest
    {

        /// <summary>
        /// 组织名称，支持模糊查询
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 组织唯一标识码集合        
        /// 多个值使用英文逗号分隔，不超过1000个，从获取组织列表接口获取返回参数orgIndexCode
        /// </summary>
        public string OrgIndexCodes { get; set; }

        /// <summary>
        /// 高级查询请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public AdvanceOrgListRequest(int pageNo, int pageSize) : base(pageNo, pageSize)
        {
        }
    }
}
