namespace Xc.HiKVisionSdk.Isc.ManagersV2.Faces.Dtos
{
    /// <summary>
    /// 人脸结果数据
    /// </summary>
    public class FaceResponseData
    {
        /// <summary>
        ///  	人脸Id
        /// </summary>
        public string FaceId { get; set; }
        /// <summary>
        /// 人脸图片Url
        /// </summary>
        public string FaceUrl { get; set; }
        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; set; }
    }
}
