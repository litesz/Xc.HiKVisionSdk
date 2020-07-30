using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 配置选项
    /// </summary>
    public class IscSdkOption
    {
        /// <summary>
        /// 节点名称
        /// </summary>
        public const string Position = "Hikvision.Isc";
        /// <summary>
        /// ak
        /// </summary>
        public string Ak { get; set; }
        /// <summary>
        /// sk
        /// </summary>
        public string Sk { get; set; }
        /// <summary>
        /// 海康平台地址
        /// </summary>
        public string BaseUrl { get; set; }
        /// <summary>
        /// 平台版本号
        /// </summary>
        public decimal Ver { get; set; } = 1;
    }
}
