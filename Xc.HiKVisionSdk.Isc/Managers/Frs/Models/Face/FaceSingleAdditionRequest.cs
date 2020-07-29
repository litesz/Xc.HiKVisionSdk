namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    public class FaceSingleAdditionRequest
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
    }

}
