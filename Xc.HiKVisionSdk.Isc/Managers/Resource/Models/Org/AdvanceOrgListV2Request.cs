using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 高级查询请求
    /// </summary>
    public class AdvanceOrgListV2Request : PagedRequest
    {
        /// <summary>
        /// 组织名称，支持模糊查询
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 组织唯一标识码集合        多个值使用英文逗号分隔，不超过1000个，从获取组织列表接口获取返回参数orgIndexCode
        /// </summary>
        public string OrgIndexCodes { get; set; }
        /// <summary>
        /// 父组织唯一标识集合，多个时使用英文逗号分隔，总数不超过1000个。指定parentOrgIndexCodes时会返回available值为false的父组织信息
        /// </summary>
        public string ParentOrgIndexCodes { get; set; }
        /// <summary>
        ///  	true时，搜索parentOrgIndexCodes的所有子孙组织；        false时，只搜索直接子组织
        /// </summary>
        public bool IsSubOrg { get; set; }
        /// <summary>
        /// 查询表达式
        /// </summary>
        public RequestExpression[] Expressions { get; set; }

        /// <summary>
        /// 排序字段，注意：排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// 降序：desc
        /// 升序：asc
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public AdvanceOrgListV2Request(int pageNo, int pageSize) : base(pageNo, pageSize)
        {
        }

    }
}
