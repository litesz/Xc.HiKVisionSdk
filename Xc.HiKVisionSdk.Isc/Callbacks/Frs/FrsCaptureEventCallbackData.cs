using System.Collections.Generic;
using Xc.HiKVisionSdk.Isc.Callbacks.Frs.Capture;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs
{
    /// <summary>
    /// 人脸抓拍事件数据
    /// </summary>
    public class FrsCaptureEventCallbackData
    {
        /// <summary>
        /// 抓拍结果
        /// </summary>
        public List<CaptureResult> CaptureLibResult { get; set; }
        /// <summary>
        /// 抓拍这张图片的监控点的通道号
        /// </summary>
        public int ChannelID { get; set; }
        /// <summary>
        /// 事件类别，人脸比对的事件类别为faceMatch
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 事件来源的地址，人脸抓拍的事件来源为抓拍机的地址。
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// 事件来源的端口
        /// </summary>
        public int PortNo { get; set; }

    }

}
