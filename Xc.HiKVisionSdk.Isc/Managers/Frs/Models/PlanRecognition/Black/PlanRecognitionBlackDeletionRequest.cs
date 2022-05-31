using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 删除重点人员识别计划请求
    /// </summary>
    public class PlanRecognitionBlackDeletionRequest : BaseRequest
    {
        /// <summary>
        /// 操作的计划的唯一标识集合，操作可能是删除等，可从查询重点人员识别计划获取
        /// </summary>
        public string[] IndexCodes { get; set; }

        /// <summary>
        /// 删除重点人员识别计划请求
        /// </summary>
        /// <param name="indexCodes">操作的计划的唯一标识集合</param>
        public PlanRecognitionBlackDeletionRequest(params string[] indexCodes)
        {
            IndexCodes = indexCodes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (IndexCodes == null)
            {
                throw new ArgumentNullException(nameof(IndexCodes));
            }
            if (IndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(IndexCodes), "最少一个计划");
            }
        }
    }

}
