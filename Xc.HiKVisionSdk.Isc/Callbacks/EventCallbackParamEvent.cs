namespace Xc.HiKVisionSdk.Isc.Callbacks
{
    /// <summary>
    /// 回调事件参数项
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EventCallbackParamEvent<T>
    {
        /// <summary>
        /// 事件Id，
        /// 唯一标识事件的一次发生，
        /// 同一事件发送多次需要ID相同
        /// </summary>
        public string EventId { get; set; }
        /// <summary>
        /// 事件源编号，物理设备是资源编号
        /// </summary>
        public int EventType { get; set; }
        /// <summary>
        /// 事件发生时间
        /// </summary>
        public string HappenTime { get; set; }
        /// <summary>
        /// 事件源编号，
        /// 物理设备是资源编号
        /// </summary>
        public string SrcIndex { get; set; }
        /// <summary>
        /// 事件源名称，utf8
        /// </summary>
        public string SrcName { get; set; }
        /// <summary>
        /// 事件发生的事件源父设备，无-空字符串
        /// </summary>
        public string SrcParentIndex { get; set; }
        /// <summary>
        /// 事件源类型
        /// </summary>
        public string SrcType { get; set; }
        /// <summary>
        /// 事件状态, 0-瞬时 1-开始 2-停止 3-事件脉冲 4-事件联动结果更新 5-异步图片上传
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 事件等级：0-未配置 1-低 2-中 3-高，注意，此处事件等级是指在事件联动中配置的等级
        /// </summary>
        public int EventLvl { get; set; }
        /// <summary>
        /// 脉冲超时时间，一个持续性的事件，上报的间隔
        /// </summary>
        public int Timeout { get; set; }
        /// <summary>
        /// 事件其它扩展信息
        /// </summary>
        public T Data { get; set; }
    }

}
