using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个添加人脸请求
    /// </summary>
    public class FaceSingleAdditionRequest : BaseRequest
    {
        /// <summary>
        /// 指定人脸添加到的人脸分组的唯一标识,人脸监控应用服务会校验该值的有效性，可从按条件查询人脸分组获取
        /// </summary>
        public string FaceGroupIndexCode { get; set; }
        /// <summary>
        /// 人脸信息对象
        /// </summary>
        public FaceInfo FaceInfo { get; set; }
        /// <summary>
        /// 人脸图片对象
        /// </summary>
        public FacePic FacePic { get; set; }

        /// <summary>
        /// 单个添加人脸请求
        /// </summary>
        public FaceSingleAdditionRequest() { }

        /// <summary>
        /// 单个添加人脸请求
        /// </summary>
        /// <param name="faceGroupIndexCode"></param>
        /// <param name="faceInfo"></param>
        /// <param name="facePic"></param>
        public FaceSingleAdditionRequest(string faceGroupIndexCode, FaceInfo faceInfo, FacePic facePic)
        {
            FaceGroupIndexCode = faceGroupIndexCode;
            FaceInfo = faceInfo;
            FacePic = facePic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(FaceGroupIndexCode))
            {
                throw new ArgumentNullException(nameof(FaceGroupIndexCode));
            }

            if (FaceInfo == null)
            {
                throw new ArgumentNullException(nameof(FaceInfo));
            }

            if (FacePic == null)
            {
                throw new ArgumentNullException(nameof(FacePic));
            }
            FaceInfo.Check();
            FacePic.Check();


        }

    }

}
