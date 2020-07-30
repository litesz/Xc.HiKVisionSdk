namespace Xc.HiKVisionSdk.Isc.Callbacks
{
    /// <summary>
    /// 回调事件参数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EventCallbackParam<T>
    {
        /// <summary>
        /// 事件从接收者（如设备接入框架）发出的时间，格式 YYYY-mm-dd hh:MM:ss
        /// </summary>
        public string SendTime { get; set; }
        /// <summary>
        /// 事件类别，如视频事件、门禁事件
        /// </summary>
        public string Ability { get; set; }
        ///// <summary>
        /////指定的事件接收用户列表，
        /////用于事件源发起组件指定接收用户，
        /////如指定用户接收手动事件、
        /////在部分应用中可以设置事件到指定用户接收
        ///// </summary>
        //public string Uids { get; set; }
        /// <summary>
        ///事件信息
        /// </summary>
        public EventCallbackParamEvent<T>[] Events { get; set; }
    }



}
