namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个修改人脸请求
    /// </summary>
    public class FaceSingleUpdateRequest
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
    }

}
