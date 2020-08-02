using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc.Models
{
    /// <summary>
    /// 批量添加车辆黑名单请求
    /// </summary>
    public class AlarmBlackAddRequest
    {
        /// <summary>
        /// 批量添加车辆黑名单详细
        /// </summary>
        public AlarmBlackAddRequestData[] Items { get; set; }
    }
}
