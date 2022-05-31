using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 抓拍计划配置
    /// </summary>
    public class CaptureConfigurationRequest : BaseRequest
    {
        /// <summary>
        /// 开启或者关闭平台的抓拍计划:
        /// true:开启,
        /// false:关闭
        /// </summary>
        public bool EventSwitch { get; set; }

        /// <summary>
        /// 抓拍计划配置
        /// </summary>
        /// <param name="eventSwitch">开启或者关闭平台的抓拍计划</param>
        /// true:开启,
        /// false:关闭
        public CaptureConfigurationRequest(bool eventSwitch = true)
        {
            EventSwitch = eventSwitch;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void CheckParams()
        {
        }
    }
}
