namespace Xc.HiKVisionSdk.Isc.Callbacks.Pms
{
    /// <summary>
    /// 放行结果信息
    /// </summary>
    public class RlsResult
    {
        /// <summary>
        /// 放行权限
        /// </summary>
        public int ReleaseAuth { get; set; }
        /// <summary>
        /// 放行结果
        /// </summary>
        public int ReleaseResult { get; set; }
        /// <summary>
        /// 新体系放行结果
        /// </summary>
        public int ReleaseReason { get; set; }
        /// <summary>
        /// 放行原因
        /// </summary>
        public int ReleaseResultEx { get; set; }
        /// <summary>
        /// 放行方式
        /// </summary>
        public int ReleaseWay { get; set; }

    }
}
