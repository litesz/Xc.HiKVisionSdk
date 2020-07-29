namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 时间计划模板，不填默认全天候
    /// </summary>
    public class TimeBlock
    {
        /// <summary>
        /// 星期几，1-7分别表示周一至周七
        /// </summary>
        public string DayOfWeek { get; set; }

        /// <summary>
        /// 时间段数组，一天可以有多个时间段
        /// </summary>
        public TimeRange[] TimeRange { get; set; }
    }

}
