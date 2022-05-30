using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas.Attendance
{
    /// <summary>
    /// 批量查询员工考勤数据请求
    /// </summary>
    public class AttendanceBatchSearchRequest : PagedRequest
    {
        /// <summary>
        /// 人员工号
        /// </summary>
        public string JobNo { get; private set; }
        /// <summary>
        /// 人员姓名 支持中英文字符
        /// </summary>
        public string PersonName { get; private set; }
        /// <summary>
        /// 开始时间，如2021-10-01 00:00:00
        /// </summary>
        public string StartTime { get; private set; }
        /// <summary>
        /// 结束时间，如2021-10-31 23:59:59
        /// </summary>
        public string EndTime { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        public AttendanceBatchSearchRequest(int index, int size) : base(index, size) { }

        /// <summary>
        /// 设置工号
        /// </summary>
        /// <param name="jobNo"></param>
        /// <returns></returns>
        public AttendanceBatchSearchRequest SetJobNo(string jobNo)
        {
            JobNo = jobNo;
            return this;
        }
        /// <summary>
        /// 设置姓名
        /// </summary>
        /// <param name="personName"></param>
        /// <returns></returns>
        public AttendanceBatchSearchRequest SetPersonName(string personName)
        {
            PersonName = personName;
            return this;
        }

        /// <summary>
        /// 设置开始时间
        /// </summary>
        /// <param name="startTime"></param>
        /// <returns></returns>
        public AttendanceBatchSearchRequest SetStartTime(DateTime startTime)
        {
            StartTime = startTime.ToString("yyyy-MM-dd HH:mm:ss");
            return this;
        }

        /// <summary>
        /// 设置结束时间
        /// </summary>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public AttendanceBatchSearchRequest SetEndTime(DateTime endTime)
        {
            EndTime = endTime.ToString("yyyy-MM-dd HH:mm:ss");
            return this;
        }


    }
}
