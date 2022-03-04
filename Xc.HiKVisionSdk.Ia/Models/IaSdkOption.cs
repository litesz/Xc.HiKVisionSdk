using Xc.HiKVisionSdk.Options;

namespace Xc.HiKVisionSdk.Ia.Models
{

    /// <summary>
    /// 配置选项
    /// </summary>
    public class IaSdkOption : HiKVisionOptions
    {
        /// <summary>
        /// 节点名称
        /// </summary>
        public const string Position = "Hikvision.Ia";

        /// <summary>
        /// 
        /// </summary>
        public bool DownloadImg { get; set; }
    }
}
