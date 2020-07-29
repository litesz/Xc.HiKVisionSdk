namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition
{
    /// <summary>
    /// 抓拍信息
    /// </summary>
    public class Snap
    {
        /// <summary>
        /// 年龄段，见附录附录A.34 设备年龄段类型
        /// </summary>
        public string AgeGroup { get; set; }
        /// <summary>
        /// 背景图片URL
        /// 位于超脑上则为完整的URL，位于asw上则为不带IP、PORT的URI，调用人脸服务图片下载 获取图片数据
        /// </summary>
        public string BkgUrl { get; set; }
        /// <summary>
        /// 抓拍图片的时间
        /// </summary>
        public string FaceTime { get; set; }
        /// <summary>
        /// 人脸图片URI
        /// 位于超脑上则为完整的URL，位于asw上则为不带IP、PORT的URI，调用人脸服务图片下载 获取图片数据
        /// </summary>
        public string FaceUrl { get; set; }
        /// <summary>
        /// 性别，见数据字典设备性别类型
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 是否戴眼镜，见数据字典设备戴眼镜类别
        /// </summary>
        public string Glass { get; set; }
    }
}
