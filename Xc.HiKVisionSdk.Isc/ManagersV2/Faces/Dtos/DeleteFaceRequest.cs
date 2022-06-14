using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Faces.Dtos
{
    /// <summary>
    /// 删除人脸请求
    /// </summary>
    public class DeleteFaceRequest : BaseRequest
    {
        /// <summary>
        /// 人脸图片Id ，        添加人脸 接口返回报文中的faceId字段，或获取人员列表v2 接口返回报文中的personPhotoIndexCode字段
        /// </summary>
        public string FaceId { get; }
        /// <summary>
        /// 修改人脸结果
        /// </summary>
        /// <param name="faceId">人脸图片Id ，        添加人脸 接口返回报文中的faceId字段，或获取人员列表v2 接口返回报文中的personPhotoIndexCode字段</param>
        public DeleteFaceRequest(string faceId)
        {
            if (string.IsNullOrWhiteSpace(faceId))
            {
                throw new ArgumentNullException(nameof(faceId));
            }
            FaceId = faceId;
        }


    }
}
