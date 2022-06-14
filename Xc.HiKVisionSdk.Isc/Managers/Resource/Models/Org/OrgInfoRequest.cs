using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 根据组织编号获取组织详细信息
    /// </summary>
    public class OrgInfoRequest : BaseRequest
    {
        /// <summary>
        /// 组织编号数组,从获取组织列表接口获取返回参数orgIndexCode，最大1000个
        /// </summary>
        public string[] OrgIndexCodes { get; set; }


        /// <summary>
        /// 根据组织编号获取组织详细信息
        /// </summary>
        /// <param name="orgIndexCodes">组织编号数组</param>
        public OrgInfoRequest(params string[] orgIndexCodes)
        {

            OrgIndexCodes = orgIndexCodes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (OrgIndexCodes == null || OrgIndexCodes.Length == 0)
            {
                throw new ArgumentNullException("OrgIndexCodes");
            }
            if (OrgIndexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("OrgIndexCodes", OrgIndexCodes.Length, "最大1000个");

            }
        }
    }
}
