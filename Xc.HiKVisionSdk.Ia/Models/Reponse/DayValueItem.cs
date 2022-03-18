using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Ia.Models.Reponse
{
    /// <summary>
    /// 班次日期数据
    /// </summary>
    public class DayValueItem
    {
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 班次名称
        /// </summary>
        public string ShiftName { get; set; }
        /// <summary>
        /// 班次id
        /// </summary>
        public string ShiftId { get; set; }
        /// <summary>
        /// 打卡id
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// 考勤状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 是否补签
        /// </summary>
        public bool IsSignStatus { get; set; }
        /// <summary>
        /// 是否请假
        /// </summary>
        public bool IsLeaveStatus { get; set; }
    }
}
