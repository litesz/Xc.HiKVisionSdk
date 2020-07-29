namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition.Black
{
    /// <summary>
    /// 识别到的目标信息
    /// </summary>
    public class FaceMatchItem
    {
        /// <summary>
        /// 目标所属的人脸分组的唯一标识
        /// </summary>
        public string FaceGroupCode { get; set; }
        /// <summary>
        /// 目标所属的人脸分组的名称
        /// </summary>
        public string FaceGroupName { get; set; }
        /// <summary>
        /// 目标对应的人脸的唯一标识
        /// </summary>
        public string FaceInfoCode { get; set; }
        /// <summary>
        /// 目标对应的人脸的名称
        /// </summary>
        public string FaceInfoName { get; set; }
        /// <summary>
        /// 目标对应的人脸的性别
        /// </summary>
        public string FaceInfoSex { get; set; }
        /// <summary>
        /// 目标对应的人脸的证件号码
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// 目标对应的人脸的证件类型
        /// 111：身份证
        /// officerID：军官证
        /// 其余为其它证件
        /// </summary>
        public string CertificateType { get; set; }
        /// <summary>
        /// 目标人脸和抓拍人脸的相似度
        /// </summary>
        public double Similarity { get; set; }
        /// <summary>
        /// 目标人脸的图片
        /// 存储于超脑上则为完整的URL，存储于asw上则为不带IP、PORT的URI，调用人脸服务图片下载 获取图片数据
        /// </summary>
        public string FacePicUrl { get; set; }
    }

}
