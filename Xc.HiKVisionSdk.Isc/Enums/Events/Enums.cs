namespace Xc.HiKVisionSdk.Isc.Enums.Events
{
    /// <summary>
    /// 事件处理状态
    /// </summary>
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

    /// <summary>
    /// 事件级别
    /// </summary>
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

    /// <summary>
    /// 订阅类型
    /// </summary>
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
