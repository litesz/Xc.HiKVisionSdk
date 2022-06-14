using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 获取人脸及分组关联关系
    /// </summary>
    public class GetFaceRelationRequest : BaseRequest
    {
        /// <summary>
        /// 人脸唯一编号数组，，可从按条件批量查询人脸获取
        /// </summary>
        public string[] IndexCodes { get; set; }

        /// <summary>
        /// 获取人脸及分组关联关系
        /// </summary>
        /// <param name="indexCodes">人脸唯一编号数组</param>
        public GetFaceRelationRequest(params string[] indexCodes)
        {
            IndexCodes = indexCodes;
        }

        /// <summary>
        /// 获取人脸及分组关联关系
        /// </summary>
        public GetFaceRelationRequest() { }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {

            if (IndexCodes == null || IndexCodes.Length == 0)
            {
                throw new ArgumentNullException(nameof(IndexCodes));
            }

           

        }
    }
}
