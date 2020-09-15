namespace Xc.HiKVisionSdk.Isc.Callbacks.Pms
{
    /// <summary>
    /// 事件出场结果
    /// </summary>
    public class OutResult
    {
        /// <summary>
        /// 账单编号
        /// </summary>
        public string ChargeIndex { get; set; }
        /// <summary>
        /// 出场实收金额
        /// </summary>
        public int RealCost { get; set; }
        /// <summary>
        /// 放行结果信息
        /// </summary>
        public RlsResult RlsResult { get; set; }
        /// <summary>
        /// 收费员ID
        /// </summary>
        public string TollerId { get; set; }
        /// <summary>
        /// 出场应收金额
        /// </summary>
        public int TotalCost { get; set; }
    }
}
