using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸批量拷贝
    /// </summary>
    public class FaceBatchCopyRequest : BaseRequest
    {
        /// <summary>
        /// 待拷贝的若干人脸唯一标识集合，，可从按条件批量查询人脸获取
        /// </summary>
        public string[] IndexCodes { get; set; }
        /// <summary>
        /// 目标人脸分组的唯一标识集合，，可从按条件查询人脸分组获取
        /// </summary>
        public string[] FaceGroupIndexCodes { get; set; }

        /// <summary>
        /// 人脸批量拷贝
        /// </summary>
        public FaceBatchCopyRequest() { }

        /// <summary>
        /// 人脸批量拷贝
        /// </summary>
        /// <param name="indexCodes">待拷贝的若干人脸唯一标识集合</param>
        /// <param name="faceGroupIndexCodes">目标人脸分组的唯一标识集合</param>
        public FaceBatchCopyRequest(string[] indexCodes, string[] faceGroupIndexCodes)
        {
            IndexCodes = indexCodes;
            FaceGroupIndexCodes = faceGroupIndexCodes;
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
            if (FaceGroupIndexCodes == null)
            {
                throw new ArgumentNullException(nameof(FaceGroupIndexCodes));
            }

            if (IndexCodes.Length > 1000 || IndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(IndexCodes), "1 到 1000张图片");
            }

            if (FaceGroupIndexCodes.Length > 16 || FaceGroupIndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(IndexCodes), "1 到 16 个分组");
            }
        }
    }




}
