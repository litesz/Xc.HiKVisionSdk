namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition.HighFrequency
{
    /// <summary>
    /// 目标属性
    /// </summary>
    public class TargetAttrs
    {
        /// <summary>
        /// 抓拍图片的完整原图
        /// 调用人脸服务图片下载 获取图片数据
        /// </summary>
        public string BkgUrl { get; set; }
        /// <summary>
        /// 抓拍这张图片的监控点的唯一标识
        /// </summary>
        public string CameraIndexCode { get; set; }
        /// <summary>
        /// 抓拍这张图片的监控点所属的设备的唯一标识
        /// </summary>
        public string DeviceIndexCode { get; set; }
        /// <summary>
        /// 设备通道号
        /// </summary>
        public int DeviceChannel { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// 抓拍这张图片时的时间
        /// </summary>
        public string FaceTime { get; set; }
        /// <summary>
        /// 图片服务唯一标志
        /// </summary>
        public string PicServerIndexCode { get; set; }
        /// <summary>
        /// 图片服务编号
        /// 若云存储配置服务编码则有该字段
        /// </summary>
        public string ImageServerCode { get; set; }
    }



}
