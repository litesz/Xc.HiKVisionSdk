using Xc.HiKVisionSdk.Models.Request;
using System;
using System.Linq;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 删除人脸分组请求
    /// </summary>
    public class FaceGroupBatchDeletionRequest : BaseRequest
    {
        /// <summary>
        /// 通过indexCode集合查询指定的识别资源集合
        /// </summary>
        public string[] IndexCodes { get; set; }

        /// <summary>
        /// 删除人脸分组请求
        /// </summary>
        public FaceGroupBatchDeletionRequest() { }

        /// <summary>
        /// 删除人脸分组请求
        /// </summary>
        /// <param name="indexCodes">分组的唯一标识</param>
        public FaceGroupBatchDeletionRequest(params string[] indexCodes)
        {
            IndexCodes = indexCodes;
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void CheckParams()
        {
            if (IndexCodes == null)
            {
                throw new ArgumentNullException(nameof(IndexCodes));
            }
            if (IndexCodes.Length == 0)
            {
                throw new IndexOutOfRangeException(nameof(IndexCodes));
            }
            if (IndexCodes.Any(u => string.IsNullOrWhiteSpace(u)))
            {
                throw new ArgumentNullException(nameof(IndexCodes), "分组的唯一标识中有空字符串");
            }
        }


    }
}
