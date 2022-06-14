using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Faces.Dtos
{
    /// <summary>
    /// 修改人脸请求
    /// </summary>
    public class UpdateFaceRequest : BaseRequest
    {
        /// <summary>
        /// 人员Id
        /// </summary>
        public string PersonId { get; }
        /// <summary>
        /// 人脸图片base64编码后的字符数据
        /// </summary>
        public string FaceData { get; }


        /// <summary>
        /// 修改人脸请求
        /// </summary>
        /// <param name="personId">人员Id</param>
        /// <param name="faceData">人脸图片base64编码后的字符数据</param>
        public UpdateFaceRequest(string personId, string faceData)
        {
            if (string.IsNullOrWhiteSpace(personId))
            {
                throw new ArgumentNullException(nameof(personId));
            }

            if (string.IsNullOrWhiteSpace(faceData))
            {
                throw new ArgumentNullException(nameof(faceData));
            }
            PersonId = personId;
            FaceData = faceData;
        }
    }
}
