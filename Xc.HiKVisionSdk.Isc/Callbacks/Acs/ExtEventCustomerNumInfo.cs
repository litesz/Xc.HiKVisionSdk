namespace Xc.HiKVisionSdk.Isc.Callbacks.Acs
{
    public class ExtEventCustomerNumInfo
    {
        /// <summary>
        /// 通道号
        /// </summary>
        public int AccessChannel { get; set; }
        /// <summary>
        /// 进人数
        /// </summary>
        public int EntryTimes { get; set; }
        /// <summary>
        /// 出人数
        /// </summary>
        public int ExitTimes { get; set; }
        /// <summary>
        /// 总通行人数
        /// </summary>
        public int TotalTimes { get; set; }
    }
}
