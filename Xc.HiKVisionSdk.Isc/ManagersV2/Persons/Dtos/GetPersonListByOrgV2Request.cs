using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 获取组织下人员列表v2请求
    /// </summary>
    public class GetPersonListByOrgV2Request : PagedRequest
    {
        /// <summary>
        /// 组织唯一标识码， 获取组织列表 接口获取
        /// </summary>
        public string OrgIndexCode { get; }

        /// <summary>
        /// 获取组织下人员列表v2请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="orgIndexCode">组织唯一标识码， 获取组织列表 接口获取</param>
        /// <exception cref="ArgumentNullException"></exception>
        public GetPersonListByOrgV2Request(int pageNo, int pageSize, string orgIndexCode) : base(pageNo, pageSize)
        {
            if (string.IsNullOrWhiteSpace(orgIndexCode))
            {
                throw new ArgumentNullException(nameof(orgIndexCode));
            }

            OrgIndexCode = orgIndexCode;
        }
    }

}
