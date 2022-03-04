using Xc.HiKVisionSdk.Ia.Models.Reponse;

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas.Attendance
{
    /// <summary>
    /// 批量查询员工考勤数据结果数据
    /// </summary>
    public class AttendanceBatchSearchResponseData
    {
        /// <summary>
        /// 考勤数据id
        /// </summary>
        public string AttendanceId { get; set; }
        /// <summary>
        /// 人员姓名
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 考勤组名称
        /// </summary>
        public string TimeGroupName { get; set; }
        /// <summary>
        /// 组织路径名称
        /// </summary>
        public string OrgPathName { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 班次日期集合数据
        /// </summary>
        public DayValueItem[] DayValue { get; set; }

    }
}
