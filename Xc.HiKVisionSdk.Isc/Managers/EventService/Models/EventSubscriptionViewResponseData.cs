﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    /// <summary>
    /// 查询事件订阅信息结果数据
    /// </summary>
    public class EventSubscriptionViewResponseData
    {
        /// <summary>
        /// 详细数据
        /// </summary>
        public EventSubscriptionViewResponseDataDetail[] Detail { get; set; }
    }

}
