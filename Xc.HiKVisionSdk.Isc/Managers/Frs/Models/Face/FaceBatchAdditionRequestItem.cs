using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸批量添加请求项
    /// </summary>
    public class FaceBatchAdditionRequestItem : ICheckRequestItem
    {
        /// <summary>
        /// 人脸唯一标识，单次批量添加操作，不允许重复。
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 指定人脸添加到的人脸分组的唯一标识,人脸监控应用服务会校验该值的有效性，可从按条件查询人脸分组获取
        /// </summary>
        public string FaceGroupIndexCode { get; set; }

        /// <summary>
        /// 人脸批量添加请求项
        /// </summary>
        public FaceBatchAdditionRequestItem() { }

        /// <summary>
        /// 人脸批量添加请求项
        /// </summary>
        /// <param name="indexCode">人脸唯一标识</param>
        /// <param name="faceGroupIndexCode">指定人脸添加到的人脸分组的唯一标识</param>
        public FaceBatchAdditionRequestItem(string indexCode, string faceGroupIndexCode)
        {
            IndexCode = indexCode;
            FaceGroupIndexCode = faceGroupIndexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void Check()
        {
            if (string.IsNullOrWhiteSpace(IndexCode))
            {
                throw new ArgumentNullException(nameof(IndexCode));
            }
            if (string.IsNullOrWhiteSpace(FaceGroupIndexCode))
            {
                throw new ArgumentNullException(nameof(FaceGroupIndexCode));
            }
        }
    }

}
