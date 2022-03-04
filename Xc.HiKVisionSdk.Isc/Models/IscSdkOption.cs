using Xc.HiKVisionSdk.Options;

namespace Xc.HiKVisionSdk.Isc.Models
{

    /// <summary>
    /// 配置选项
    /// </summary>
    public class IscSdkOption : HiKVisionOptions
    {
        /// <summary>
        /// 节点名称
        /// </summary>
        public const string Position = "Hikvision.Isc";

        /// <summary>
        /// 
        /// </summary>
        public bool DownloadImg { get; set; }
    }
}
