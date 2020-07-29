using Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition.HighFrequency;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs
{

    /// <summary>
    /// 高频人员识别数据
    /// </summary>
    public class FrsHighFrequencyFaceRecognitionEventCallbackData
    {
        /// <summary>
        /// 图片url认证方式
        /// digest-摘要认证（这个针对设备本地存储返回URL的方式，设备例如NVR/DVR）
        /// </summary>
        public string URLCertificationType { get; set; }
        /// <summary>
        /// 事件触发次数
        /// </summary>
        public int ActivePostCount { get; set; }
        /// <summary>
        /// 设备通道号
        /// 设备通道号，默认1开始
        /// </summary>
        public int ChannelID { get; set; }
        /// <summary>
        /// 数据模型标识
        /// 由IAC添加
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 数据触发时间
        /// 由设备产生
        /// </summary>
        public string DateTime { get; set; }
        /// <summary>
        /// 事件描述
        /// </summary>
        public string EventDescription { get; set; }
        /// <summary>
        /// 事件状态
        /// </summary>
        public string EventState { get; set; }
        /// <summary>
        /// 事件类型
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// 识别结果
        /// </summary>
        public FaceCapture[] FaceCapture { get; set; }
        /// <summary>
        /// 设备的IP地址
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// Mac地址
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// 设备端口号
        /// </summary>
        public int PortNo { get; set; }
        /// <summary>
        /// 协议类型
        /// </summary>
        public string Protocol { get; set; }
        /// <summary>
        /// 数据接收时间
        /// 由IAC添加
        /// </summary>
        public string RecvTime { get; set; }
        /// <summary>
        /// 数据发送时间
        /// 由IAC添加
        /// </summary>
        public string SendTime { get; set; }

    }



}
