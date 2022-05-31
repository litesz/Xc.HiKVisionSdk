namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Pictures
{
    /// <summary>
    /// 平台抓拍计划图片获取结果数据
    /// </summary>
    public class CameraPictureInfosResponseData
    {
        /// <summary>
        /// 图片唯一标识
        /// </summary>
        public string CaptureId { get; set; }
        /// <summary>
        /// 监控点唯一标识
        /// </summary>
        public string CameraIndexCode { get; set; }
        /// <summary>
        /// 监控点名称
        /// </summary>
        public string CameraName { get; set; }
        /// <summary>
        /// 通道类型。0-枪机；1-半球；2-球机；3-云台枪机
        /// </summary>
        public string CameraType { get; set; }
        /// <summary>
        /// 原图图片地址，24小时后失效
        /// </summary>
        public string CaptureUrl { get; set; }
        /// <summary>
        /// 缩略图图片地址，24小时后失效
        /// </summary>
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// 抓图时间（IOS8601格式：yyyy-MM-dd’T’HH:mm:ss.SSSzzz +当前时区，例如北京时间：2018-07-26T15:00:00.000+08:00）
        /// </summary>
        public string CaptureTime { get; set; }
    }
}
