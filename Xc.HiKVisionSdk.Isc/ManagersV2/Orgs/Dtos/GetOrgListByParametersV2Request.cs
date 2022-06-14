using System;
using Xc.HiKVisionSdk.Consts;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 获取组织列表V2请求
    /// </summary>
    public class GetOrgListByParametersV2Request : PagedRequest
    {

        /// <summary>
        /// 组织名称，支持模糊查询
        /// </summary>
        public string OrgName { get; }

        /// <summary>
        /// 组织唯一标识码集合        多个值使用英文逗号分隔，不超过1000个，从获取组织列表接口获取返回参数orgIndexCode
        /// </summary>
        public string OrgIndexCodes { get; private set; }
        /// <summary>
        /// 父组织唯一标识集合，多个时使用英文逗号分隔，总数不超过1000个。指定parentOrgIndexCodes时会返回available值为false的父组织信息
        /// </summary>
        public string ParentOrgIndexCodes { get; private set; }
        /// <summary>
        /// true时，搜索parentOrgIndexCodes的所有子孙组织；        false时，只搜索直接子组织
        /// </summary>
        public bool IsSubOrg { get; }
        /// <summary>
        /// 查询表达式
        /// </summary>
        public RequestExpression[] Expressions { get; private set; }

        /// <summary>
        /// 排序字段，注意：排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; }
        /// <summary>
        /// 降序：desc
        /// 升序：asc
        /// </summary>
        public string OrderType { get; }


        /// <summary>
        /// 获取组织列表V2请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="orgName">组织名称，支持模糊查询</param>
        /// <param name="isSubOrg">true时，搜索parentOrgIndexCodes的所有子孙组织；        false时，只搜索直接子组织</param>
        /// <param name="orderBy">排序字段，注意：排序字段必须是查询条件，否则返回参数错误</param>
        /// <param name="isAsc">升序</param>
        public GetOrgListByParametersV2Request(int pageNo, int pageSize, string orgName, bool isSubOrg = false, string orderBy = "", bool? isAsc = null) : base(pageNo, pageSize)
        {
            OrgName = orgName;
            IsSubOrg = isSubOrg;
            OrderBy = orderBy;

            if (isAsc.HasValue)
            {
                if (string.IsNullOrWhiteSpace(orderBy))
                {
                    throw new ArgumentNullException(nameof(orderBy), "指定排序方式时，排序字段不可为空");
                }
                OrderType = OrderTypeConsts.GetOrderType(isAsc.Value);
            }
        }

        /// <summary>
        /// 使用组织唯一标识码集合
        /// </summary>
        /// <param name="orgIndexCodes">组织唯一标识码集合，多个值使用英文逗号分隔，不超过1000个，从获取组织列表接口获取返回参数orgIndexCode</param>
        /// <returns></returns>
        public GetOrgListByParametersV2Request UseOrgIndexCodes(params string[] orgIndexCodes)
        {
            if (orgIndexCodes == null || orgIndexCodes.Length == 0)
            {
                throw new ArgumentNullException(nameof(orgIndexCodes));
            }
            if (orgIndexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(orgIndexCodes), "最大1000个");
            }
            OrgIndexCodes = String.Join(",", orgIndexCodes);
            return this;
        }

        /// <summary>
        /// 使用父组织唯一标识集合
        /// </summary>
        /// <param name="parentOrgIndexCodes">父组织唯一标识集合，多个时使用英文逗号分隔，总数不超过1000个。指定parentOrgIndexCodes时会返回available值为false的父组织信息</param>
        /// <returns></returns>
        public GetOrgListByParametersV2Request UseParentOrgIndexCodes(params string[] parentOrgIndexCodes)
        {
            if (parentOrgIndexCodes == null || parentOrgIndexCodes.Length == 0)
            {
                throw new ArgumentNullException(nameof(parentOrgIndexCodes));
            }
            if (parentOrgIndexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(parentOrgIndexCodes), "最大1000个");
            }
            ParentOrgIndexCodes = String.Join(",", parentOrgIndexCodes);
            return this;
        }

        /// <summary>
        /// 使用查询表达式
        /// </summary>
        /// <param name="expressions">查询表达式</param>
        /// <returns></returns>
        public GetOrgListByParametersV2Request UseRequestExpression(params RequestExpression[] expressions)
        {
            if (expressions == null || expressions.Length == 0)
            {
                throw new ArgumentNullException(nameof(expressions));
            }
            //if (expressions.Length > 1000)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(expressions), "最大1000个");
            //}
            Expressions = expressions;
            return this;
        }
    }
}
