using System;
using Xc.HiKVisionSdk.Consts;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Isc.Enums.Resource;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPersonListByParametersV2Request : PagedRequest
    {
        /// <summary>
        /// 人员ID集合        多个值使用英文逗号分隔，不超过1000个        获取人员列表v2 接口获取
        /// </summary>
        public string PersonIds { get; private set; }
        /// <summary>
        /// <![CDATA[人员姓名 支持中英文字符，不能包含 ’ / \ : * ? " < >]]>
        /// </summary>
        public string PersonName { get; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender? Gender { get; }
        /// <summary>
        /// 所属组织唯一标识码集合        多个值使用英文逗号分隔，不超过1000个
        /// </summary>
        public string OrgIndexCodes { get; private set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public CertificateType? CertificateType { get; private set; }
        /// <summary>
        /// 证件号码(最大长度64)
        /// </summary>
        public string CertificateNo { get; private set; }
        /// <summary>
        /// 是否包含下级组织，true时，搜索orgIndexCodes及其所有子孙组织的人员；        false时，只搜索orgIndexCodes的人员
        /// </summary>
        public bool IsSubOrg { get; private set; }
        /// <summary>
        /// 卡号, 获取卡片列表接口可以获取
        /// </summary>
        public string CardNo { get; private set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNo { get; private set; }
        /// <summary>
        /// 排序字段，注意：排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; private set; }
        /// <summary>
        /// 降序：desc        升序：asc
        /// </summary>
        public string OrderType { get; private set; }
        /// <summary>
        /// 查询表达式
        /// </summary>
        public RequestExpression[] Expressions { get; private set; }

        ///
        public GetPersonListByParametersV2Request(int pageNo, int pageSize, string personName, Gender? gender = null, CertificateType? certificateType = null, string certificateNo = "", string cardNo = "", string plateNo = "", bool isSubOrg = false, string orderBy = "", bool? isAsc = null) : base(pageNo, pageSize)
        {
            PersonName = personName;
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
            Gender = gender;
            CertificateType = certificateType;
            CertificateNo = certificateNo;
            CardNo = cardNo;
            PlateNo = plateNo;
        }

        /// <summary>
        /// 使用组织唯一标识码集合
        /// </summary>
        /// <param name="orgIndexCodes">组织唯一标识码集合，多个值使用英文逗号分隔，不超过1000个，从获取组织列表接口获取返回参数orgIndexCode</param>
        /// <returns></returns>
        public GetPersonListByParametersV2Request UseOrgIndexCodes(params string[] orgIndexCodes)
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
        /// 使用人员ID集合
        /// </summary>
        /// <param name="personIds">人员ID集合        多个值使用英文逗号分隔，不超过1000个        获取人员列表v2 接口获取</param>
        /// <returns></returns>
        public GetPersonListByParametersV2Request UseParentOrgIndexCodes(params string[] personIds)
        {
            if (personIds == null || personIds.Length == 0)
            {
                throw new ArgumentNullException(nameof(personIds));
            }
            if (personIds.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(personIds), "最大1000个");
            }
            PersonIds = String.Join(",", personIds);
            return this;
        }

        /// <summary>
        /// 使用查询表达式
        /// </summary>
        /// <param name="expressions">查询表达式</param>
        /// <returns></returns>
        public GetPersonListByParametersV2Request UseRequestExpression(params RequestExpression[] expressions)
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
