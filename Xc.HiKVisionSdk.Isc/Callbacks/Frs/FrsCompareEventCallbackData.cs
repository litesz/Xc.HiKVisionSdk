using Xc.HiKVisionSdk.Isc.Callbacks.Frs.Compare;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs
{

    /// <summary>
    /// 人脸对比事件数据
    /// </summary>

    public class FrsCompareEventCallbackData
    {
        /// <summary>
        /// 比对结果
        /// </summary>
        public AlarmResultItem[] AlarmResult { get; set; }
        /// <summary>
        /// 抓拍这张图片的监控点的通道号
        /// </summary>
        public int ChannelID { get; set; }
        /// <summary>
        /// 事件类别，人脸比对的事件类别为faceMatch
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 事件来源的地址
        /// 人脸比对的事件来源为识别资源的地址。
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// 事件来源的端口
        /// </summary>
        public int PortNo { get; set; }
    }

}
