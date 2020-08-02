namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个添加人脸结果数据
    /// </summary>
    public class FaceSingleAdditionResponseData
    {
        /// <summary>
        /// 人脸的唯一标识
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 人脸所属的人脸分组的唯一标识
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
