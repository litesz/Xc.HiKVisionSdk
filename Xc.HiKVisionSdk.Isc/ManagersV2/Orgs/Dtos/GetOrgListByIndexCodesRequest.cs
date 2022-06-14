using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 根据组织编号获取组织详细信息
    /// </summary>
    public class GetOrgListByIndexCodesRequest : BaseRequest
    {
        /// <summary>
        /// 组织编号数组,从获取组织列表接口获取返回参数orgIndexCode，最大1000个
        /// </summary>
        public string[] OrgIndexCodes { get; }


        /// <summary>
        /// 根据组织编号获取组织详细信息
        /// </summary>
        /// <param name="orgIndexCodes">组织编号数组</param>
        public GetOrgListByIndexCodesRequest(params string[] orgIndexCodes)
        {
            if (orgIndexCodes == null || orgIndexCodes.Length == 0)
            {
                throw new ArgumentNullException("orgIndexCodes");
            }
            if (orgIndexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("orgIndexCodes", "最大1000个");

            }
            OrgIndexCodes = orgIndexCodes;
        }

       
    }
}
