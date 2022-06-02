﻿using System;
using Xc.HiKVisionSdk.Isc.Enums.Events;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    /// <summary>
    /// 按事件类型订阅事件请求
    /// </summary>
    public class EventSubscriptionByEventTypesRequest : BaseRequest
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public int[] EventTypes { get; set; }
        /// <summary>
        /// 指定事件接收的地址，采用restful回调模式，支持http和https，
        /// 样式如下：http://ip:port/eventRcv或者      
        /// https://ip:port/eventRcv
        /// 不超过1024个字符，事件接收地址由应用方负责按指定的规范提供，事件接收接口不需要认证
        /// 三方客户收到消息，请注意立即返回HTTP/1.1 200 OK， 否则因为接收太慢，导致事件积压
        /// </summary>
        public string EventDest { get; set; }
        /// <summary>
        /// 订阅类型，0-订阅原始事件，1-联动事件，2-原始事件和联动事件，不填使用默认值0
        /// </summary>
        public SubType SubType { get; set; }
        /// <summary>
        ///  	事件等级，0-未配置，1-低，2-中，3-高
        ///  	此处事件等级是指在事件联动中配置的等级
        ///  	订阅类型为0时，此参数无效，使用默认值0
        ///  	在订阅类型为1时，不填使用默认值[1, 2, 3]
        ///  	在订阅类型为2时，不填使用默认值[0, 1, 2, 3]
        ///  	数组大小不超过32，事件等级大小不超过31
        /// </summary>
        public int[] EventLvl { get; set; }

        /// <summary>
        /// 按事件类型订阅事件请求
        /// </summary>
        public EventSubscriptionByEventTypesRequest() { }

        /// <summary>
        /// 按事件类型订阅事件请求
        /// </summary>
        /// <param name="eventDest"> 指定事件接收的地址</param>
        /// <param name="eventTypes">事件类型</param>
        public EventSubscriptionByEventTypesRequest(string eventDest, params int[] eventTypes)
        {
            EventDest = eventDest;
            EventTypes = eventTypes;
        }

        /// <summary>
        /// 按事件类型订阅事件请求
        /// </summary>
        /// <param name="eventTypes">事件类型</param>
        /// <param name="eventDest"> 指定事件接收的地址</param>
        /// <param name="subType">订阅类型，0-订阅原始事件，1-联动事件，2-原始事件和联动事件，不填使用默认值0</param>
        /// <param name="eventLvl">事件等级，0-未配置，1-低，2-中，3-高</param>
        public EventSubscriptionByEventTypesRequest(int[] eventTypes, string eventDest, SubType subType, int[] eventLvl) : this(eventDest, eventTypes)
        {
            SubType = subType;
            EventLvl = eventLvl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(EventDest))
            {
                throw new ArgumentNullException(nameof(EventDest));
            }
            if (EventDest.Length > 1024)
            {
                throw new IndexOutOfRangeException(nameof(EventDest));
            }
            if (EventTypes == null)
            {
                throw new ArgumentNullException(nameof(EventTypes));
            }
            if (EventTypes.Length == 0)
            {
                throw new IndexOutOfRangeException(nameof(EventTypes));
            }

        }
    }
}
