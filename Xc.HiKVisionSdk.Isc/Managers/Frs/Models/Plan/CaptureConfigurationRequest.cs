namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 抓拍计划配置
    /// </summary>
    public class CaptureConfigurationRequest
    {
        /// <summary>
        /// 开启或者关闭平台的抓拍计划:
        /// true:开启,
        /// false:关闭
        /// </summary>
        public bool EventSwitch { get; set; }
    }
}
