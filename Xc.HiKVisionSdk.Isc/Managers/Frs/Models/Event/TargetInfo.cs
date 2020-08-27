namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 重点人员事件目标图信息集
    /// </summary>
    public class TargetInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 相似度
        /// </summary>
        public string Similarity { get; set; }
        /// <summary>
        /// 证件类型，111-身份证，OTHER-其他证件
        /// </summary>
        public string CertificateType { get; set; }
        /// <summary>
        /// 性别，1-男，2-女，UNKNOWN-未知
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 证件号
        /// </summary>
        public string CertificateNumber { get; set; }
        /// <summary>
        /// 人脸唯一标识
        /// </summary>
        public string FaceInfoIndexcode { get; set; }
        /// <summary>
        /// 人脸分组唯一标识
        /// </summary>
        public string FaceGroupIndexcode { get; set; }
        /// <summary>
        /// 人脸分组名称
        /// </summary>
        public string FaceGroupName { get; set; }
        /// <summary>
        ///  	人脸图片url
        /// </summary>
        public string FaceUrl { get; set; }
    }

}
