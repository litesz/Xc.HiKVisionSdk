namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 时间段数组，一天可以有多个时间段
    /// </summary>
    public class TimeRange
    {

        /// <summary>
        /// 开始时间，时分，如“00:00”
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，时分，如“00:00”
        /// </summary>
        public string EndTime { get; set; }

    }

}
