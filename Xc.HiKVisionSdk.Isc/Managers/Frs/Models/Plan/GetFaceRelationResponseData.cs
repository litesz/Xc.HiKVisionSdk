namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 获取人脸及分组关联关系
    /// </summary>
    public class GetFaceRelationResponseData
    {
        /// <summary>
        /// 人脸监控应用服务人脸编号
        /// </summary>
        public string FaceIndexCode { get; set; }

        /// <summary>
        /// 人脸监控应用服务人脸分组唯一编号
        /// </summary>
        public string FaceGroupIndexCode { get; set; }

        /// <summary>
        /// 识别资源上人脸的唯一编号
        /// </summary>
        public string ResFaceIndexCode { get; set; }

        /// <summary>
        /// 识别资源上人脸库的唯一编号
        /// </summary>
        public string ResFaceGroupIndexCode { get; set; }

        /// <summary>
        /// 识别资源的唯一编号
        /// </summary>
        public string ResIndexCode { get; set; }
    }
}
