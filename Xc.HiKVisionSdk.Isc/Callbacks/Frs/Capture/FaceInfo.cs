namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Capture
{
    /// <summary>
    /// 人脸信息
    /// </summary>
    public class FaceInfo
    {
        /// <summary>
        /// 抓拍到的人脸图片的URL，可能位于设备或ASW服务上。
        /// 调用人脸服务图片下载 获取图片数据
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// 年龄信息
        /// </summary>
        public Age Age { get; set; }
        /// <summary>
        /// 人脸坐标
        /// </summary>
        public FaceRect FaceRect { get; set; }
        /// <summary>
        /// 人脸评分参数
        /// </summary>
        public FaceScore FaceScore { get; set; }
        /// <summary>
        /// 性别，见数据字典设备性别类型
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 眼镜
        /// </summary>
        public Glass Glass { get; set; }
    }

}
