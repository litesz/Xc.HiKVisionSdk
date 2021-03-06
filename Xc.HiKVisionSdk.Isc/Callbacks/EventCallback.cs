﻿namespace Xc.HiKVisionSdk.Isc.Callbacks
{
    /// <summary>
    /// 回调事件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EventCallback<T>
    {
        /// <summary>
        /// 方法名，用于标识报文用途
        /// 事件固定OnEventNotify
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// 事件参数信息
        /// </summary>
        public EventCallbackParam<T> Params { get; set; }
    }



}
