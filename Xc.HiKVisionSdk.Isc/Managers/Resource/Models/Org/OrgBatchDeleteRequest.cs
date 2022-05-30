using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 批量删除组织
    /// </summary>
    public class OrgBatchDeleteRequest : BaseRequest
    {
        /// <summary>
        /// 待删除的组织indexCode列表，单次提交上限为1000条        
        /// 从获取组织列表 接口获取返回参数orgIndexCode
        /// </summary>
        public string[] IndexCodes { get; set; }

        /// <summary>
        /// 批量删除组织
        /// </summary>
        /// <param name="indexCodes">待删除的组织indexCode列表</param>
        public OrgBatchDeleteRequest(params string[] indexCodes)
        {

            IndexCodes = indexCodes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected override void CheckParams()
        {
            if (IndexCodes == null || IndexCodes.Length == 0)
            {
                throw new ArgumentNullException("IndexCodes");
            }
            if (IndexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("IndexCodes", "最大1000个");

            }
        }

    }
}
