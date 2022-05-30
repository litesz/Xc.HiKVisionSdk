using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个修改人脸请求
    /// </summary>
    public class FaceSingleUpdateRequest : BaseRequest
    {
        /// <summary>
        /// 人脸的唯一标识，可从按条件批量查询人脸获取
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 人脸信息对象
        /// </summary>
        public FaceInfo FaceInfo { get; set; }
        /// <summary>
        /// 人脸图片对象
        /// </summary>
        public FacePic FacePic { get; set; }

        /// <summary>
        /// 单个修改人脸请求
        /// </summary>
        public FaceSingleUpdateRequest() { }

        /// <summary>
        /// 单个修改人脸请求
        /// </summary>
        /// <param name="indexCode">人脸的唯一标识</param>
        /// <param name="name">姓名</param>
        public FaceSingleUpdateRequest(string indexCode, string name)
        {
            IndexCode = indexCode;
            FaceInfo = new FaceInfo { Name = name };
        }

        /// <summary>
        /// 单个修改人脸请求
        /// </summary>
        /// <param name="indexCode">人脸的唯一标识</param>
        /// <param name="faceInfo">人脸信息对象</param>
        /// <param name="facePic">人脸图片对象</param>
        public FaceSingleUpdateRequest(string indexCode, FaceInfo faceInfo, FacePic facePic)
        {
            IndexCode = indexCode;
            FaceInfo = faceInfo;
            FacePic = facePic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(IndexCode))
            {
                throw new ArgumentNullException(nameof(IndexCode));
            }
            if (FaceInfo == null && FacePic == null)
            {
                throw new ArgumentNullException($"{nameof(FaceInfo)} 和 {nameof(FacePic)}", "不能都为空");

            }
        }
    }

}
