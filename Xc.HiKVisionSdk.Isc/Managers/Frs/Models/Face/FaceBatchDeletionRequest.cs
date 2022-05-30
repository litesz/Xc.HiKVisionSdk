using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 批量删除人脸请求
    /// </summary>
    public class FaceBatchDeletionRequest : BaseRequest
    {


        /// <summary>
        /// 人脸的唯一标识集合，可从按条件批量查询人脸获取
        /// </summary>
        public string[] IndexCodes { get; set; }

        /// <summary>
        /// 人脸分组的唯一标识，可从按条件查询人脸分组获取
        /// </summary>
        public string FaceGroupIndexCode { get; set; }

        /// <summary>
        /// 批量删除人脸请求
        /// </summary>
        public FaceBatchDeletionRequest() { }

        /// <summary>
        /// 批量删除人脸请求
        /// </summary>
        /// <param name="faceGroupIndexCode">人脸分组的唯一标识</param>
        /// <param name="indexCodes">人脸的唯一标识集合</param>
        public FaceBatchDeletionRequest(string faceGroupIndexCode, params string[] indexCodes)
        {
            IndexCodes = indexCodes;
            FaceGroupIndexCode = faceGroupIndexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(FaceGroupIndexCode))
            {
                throw new ArgumentNullException(nameof(FaceGroupIndexCode));
            }
            if (IndexCodes == null)
            {
                throw new ArgumentNullException(nameof(IndexCodes));

            }
            if (IndexCodes.Length == 0 || IndexCodes.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(IndexCodes), "一次性最多从一个分组内删除1000个人脸");
            }
        }
    }
}
