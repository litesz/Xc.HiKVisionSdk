using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    public enum HandleStatus
    {
        /// <summary>
        /// 未处理
        /// </summary>
        UnProcessed,
        /// <summary>
        /// 已处理
        /// </summary>
        Processed
    }

    public enum EventLevel
    {
        /// <summary>
        /// 低
        /// </summary>
        Low = 1,
        /// <summary>
        /// 中
        /// </summary>
        Middle,
        /// <summary>
        /// 高
        /// </summary>
        Height

    }

    public enum SubType
    {
        /// <summary>
        /// 原始事件
        /// </summary>
        Raw,
        /// <summary>
        /// 联动事件
        /// </summary>
        Linkage,
        /// <summary>
        /// 原始事件和联动事件
        /// </summary>
        RawAndLinkage
    }
}
