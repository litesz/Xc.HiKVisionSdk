using System;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos
{
    /// <summary>
    /// 在线记录
    /// </summary>
    public class OnlineHistroy
    {
        /// <summary>
        /// 状态采集时间，时间格式为ISO格式
        /// </summary>
        public DateTimeOffset? CollectTime { get; set; }

        /// <summary>
        /// 资源在线状态,0: 离线,1: 在线
        /// </summary>
        public int Online { get; set; }

        /// <summary>
        /// 资源在线
        /// </summary>
        public bool IsOnline => Online == 1;
    }
}
