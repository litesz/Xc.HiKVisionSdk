namespace Xc.HiKVisionSdk.Isc.Callbacks.Pms
{
    /// <summary>
    /// 是否在车辆黑名单
    /// </summary>
    public enum InBlackList
    {
        /// <summary>
        /// 不在黑名单
        /// </summary>
        NotIn = 0,
        /// <summary>
        /// 在黑名单
        /// </summary>
        In = 1
    }
    /// <summary>
    /// 车道类型
    /// </summary>
    public enum RoadwayType
    {
        /// <summary>
        /// 进场
        /// </summary>
        In = 1,
        /// <summary>
        /// 免费出场
        /// </summary>
        FreeOut,
        /// <summary>
        /// 收费出场
        /// </summary>
        Out,
        /// <summary>
        /// 中央缴费车道
        /// </summary>
        Central
    }
}
