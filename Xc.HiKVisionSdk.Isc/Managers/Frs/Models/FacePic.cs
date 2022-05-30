using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸图片对象
    /// </summary>
    public class FacePic : ICheckRequestItem
    {
        /// <summary>
        /// 人脸图片的URL。和faceBinaryData不能同时为空，同时存在时优先取faceBinaryData；图片的大小范围在10KB到200KB之间，只支持JGP格式图片。
        /// </summary>
        public string FaceUrl { get; set; }
        /// <summary>
        /// 人脸图片的二进制数据经过Base64编码后的字符串，和faceUrl不能同时为空，同时存在时优先取faceBinaryData。 图片的大小范围在10KB到200KB之间，只支持JGP格式图片。
        /// </summary>
        public string FaceBinaryData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void Check()
        {
            if (string.IsNullOrWhiteSpace(FaceUrl) && string.IsNullOrWhiteSpace(FaceBinaryData))
            {
                throw new ArgumentNullException("FaceUrl 或 FaceBinaryData", "FaceBinaryData 和 FaceUrl 不能同时为空");
            }
        }
    }
}
