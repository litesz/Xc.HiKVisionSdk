using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 批量删除组织请求
    /// </summary>
    public class BatchDeleteOrgsRequest : BaseRequest
    {
        /// <summary>
        /// 待删除的组织indexCode列表，单次提交上限为1000条        
        /// 从获取组织列表 接口获取返回参数orgIndexCode
        /// </summary>
        public string[] IndexCodes { get; }

        /// <summary>
        /// 批量删除组织
        /// </summary>
        /// <param name="indexCodes">待删除的组织indexCode列表</param>
        public BatchDeleteOrgsRequest(params string[] indexCodes)
        {
            if (indexCodes == null || indexCodes.Length == 0)
            {
                throw new ArgumentNullException(nameof(indexCodes));
            }
            if (indexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(indexCodes), "最大1000个");

            }
            IndexCodes = indexCodes;
        }



    }
}
