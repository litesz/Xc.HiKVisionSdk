using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 修改组织
    /// </summary>
    public class OrgSingleUpdateRequest : BaseRequest
    {


        /// <summary>
        /// 组织标识，必须保证已存在，        
        /// 从获取组织列表 接口获取返回参数orgIndexCode。
        /// </summary>
        public string OrgIndexCode { get; set; }

        /// <summary>
        /// 组织名称，1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string OrgName { get; set; }

      
        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="orgIndexCode">组织标识</param>
        /// <param name="orgName">组织名称，1~32个字符</param>
        public OrgSingleUpdateRequest(string orgIndexCode, string orgName)
        {

            OrgIndexCode = orgIndexCode;
            OrgName = orgName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {

            if (string.IsNullOrEmpty(OrgIndexCode))
            {
                throw new ArgumentNullException(nameof(OrgIndexCode));
            }
            if (string.IsNullOrEmpty(OrgName))
            {
                throw new ArgumentNullException(nameof(OrgName));
            }

            base.CheckParams();
        }
    }
}
