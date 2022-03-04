using Newtonsoft.Json;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Ia.Enums;
using Xc.HiKVisionSdk.Ia.Models.Reponse;

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas.Attendance
{
    /// <summary>
    /// 批量查询员工考勤数据结果数据
    /// </summary>
    public class AttendanceResultListResponseData
    {
        /// <summary>
        /// 数据唯一标识
        /// </summary>
        [JsonProperty(PropertyName = "model_data_id")]
        public string ModelDataId { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty(PropertyName = "create_time")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty(PropertyName = "update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 人员标识
        /// </summary>
        [JsonProperty(PropertyName = "person_id")]
        public string PersonId { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        [JsonProperty(PropertyName = "person_name")]
        public string PersonName { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [JsonProperty(PropertyName = "job_no")]
        public string JobNo { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Sex { get; set; }
        /// <summary>
        /// 拼音
        /// </summary>
        public string Pinyin { get; set; }
        /// <summary>
        /// 员工级别
        /// </summary>
        [JsonProperty(PropertyName = "emp_level")]
        public string EmpLevel { get; set; }

        /// <summary>
        /// 员工种类
        /// </summary>
        [JsonProperty(PropertyName = "emp_type")]
        public string EmpType { get; set; }
        /// <summary>
        /// 工作地点
        /// </summary>
        [JsonProperty(PropertyName = "work_place")]
        public string WorkPlace { get; set; }
        /// <summary>
        /// 组织id
        /// </summary>
        [JsonProperty(PropertyName = "org_id")]
        public string OrgId { get; set; }
        /// <summary>
        /// 组织名称
        /// </summary>
        [JsonProperty(PropertyName = "org_name")]
        public string OrgName { get; set; }
        /// <summary>
        /// 组织名称1
        /// </summary>
        [JsonProperty(PropertyName = "org_name1")]
        public string OrgName1 { get; set; }
        /// <summary>
        /// 组织名称2
        /// </summary>
        [JsonProperty(PropertyName = "org_name2")]
        public string OrgName2 { get; set; }
        /// <summary>
        /// 组织名称3
        /// </summary>
        [JsonProperty(PropertyName = "org_name3")]
        public string OrgName3 { get; set; }
        /// <summary>
        /// 组织名称4
        /// </summary>
        [JsonProperty(PropertyName = "org_name4")]
        public string OrgName4 { get; set; }
        /// <summary>
        /// 组织名称5
        /// </summary>
        [JsonProperty(PropertyName = "org_name5")]
        public string OrgName5 { get; set; }
        /// <summary>
        /// 组织名称6
        /// </summary>
        [JsonProperty(PropertyName = "org_name6")]
        public string OrgName6 { get; set; }
        /// <summary>
        /// 考勤组id
        /// </summary>
        [JsonProperty(PropertyName = "time_group_id")]
        public string TimeGroupId { get; set; }
        /// <summary>
        /// 考勤组名称
        /// </summary>
        [JsonProperty(PropertyName = "group_name")]
        public string GroupName { get; set; }
        /// <summary>
        /// 当日日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 日期类型
        /// </summary>
        [JsonProperty(PropertyName = "date_type")]
        public DateType DateType { get; set; }
        /// <summary>
        /// 是否应出勤
        /// </summary>
        [JsonProperty(PropertyName = "is_should_attendance")]
        public YesOrNo IsShouldAttendance { get; set; }

        /// <summary>
        ///是否替班
        /// </summary>
        [JsonProperty(PropertyName = "is_alter_schedule")]
        public YesOrNo IsAlterSchedule { get; set; }

        /// <summary>
        /// 是否补签
        /// </summary>
        [JsonProperty(PropertyName = "is_supply_clock")]
        public YesOrNo IsSupplyClock { get; set; }

        /// <summary>
        /// 排班类型
        /// </summary>
        [JsonProperty(PropertyName = "schedule_type")]
        public int ScheduleType { get; set; }

        /// <summary>
        /// 工作计划id
        /// </summary>
        [JsonProperty(PropertyName = "work_plan_id")]
        public string WorkPlanId { get; set; }

        /// <summary>
        /// 工作计划名称
        /// </summary>
        [JsonProperty(PropertyName = "plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 班次id
        /// </summary>
        [JsonProperty(PropertyName = "shift_id")]
        public string ShiftId { get; set; }

        /// <summary>
        /// 班次名称
        /// </summary>
        [JsonProperty(PropertyName = "shift_name")]
        public string ShiftName { get; set; }

        /// <summary>
        /// 班次类型
        /// </summary>
        [JsonProperty(PropertyName = "shift_type")]
        public int ShiftType { get; set; }

        /// <summary>
        /// 应休息时长
        /// </summary>
        [JsonProperty(PropertyName = "should_rest_time")]
        public int ShouldRestTime { get; set; }

        /// <summary>
        /// 实际休息时长
        /// </summary>
        [JsonProperty(PropertyName = "actual_rest_time")]
        public int ActualRestTime { get; set; }

        /// <summary>
        /// 应出勤时长
        /// </summary>
        [JsonProperty(PropertyName = "should_attendance_time")]
        public int ShouldAttendanceTime { get; set; }

        /// <summary>
        /// 实际出勤时长
        /// </summary>
        [JsonProperty(PropertyName = "actual_attendance_time")]
        public string ActualAttendanceTime { get; set; }

        /// <summary>
        /// 出勤状态
        /// </summary>
        [JsonProperty(PropertyName = "attendance_state")]
        public AttendanceState AttendanceState { get; set; }

        /// <summary>
        /// 是否正常
        /// </summary>
        [JsonProperty(PropertyName = "is_normal")]
        public YesOrNo IsNormal { get; set; }

        /// <summary>
        /// 是否迟到
        /// </summary>
        [JsonProperty(PropertyName = "is_late")]
        public YesOrNo IsLate { get; set; }

        /// <summary>
        /// 是否旷工
        /// </summary>
        [JsonProperty(PropertyName = "is_absent")]
        public YesOrNo IsAbsent { get; set; }

        /// <summary>
        /// 迟到时长
        /// </summary>
        [JsonProperty(PropertyName = "late_time")]
        public int LateTime { get; set; }

        /// <summary>
        /// 早退时长
        /// </summary>
        [JsonProperty(PropertyName = "early_time")]
        public int EarlyTime { get; set; }

        /// <summary>
        /// 旷工时长
        /// </summary>
        [JsonProperty(PropertyName = "absent_time")]
        public int AbsentTime { get; set; }

        /// <summary>
        /// 是否加班
        /// </summary>
        [JsonProperty(PropertyName = "is_overtime")]
        public YesOrNo IsOvertime { get; set; }

        /// <summary>
        /// 加班时长
        /// </summary>
        [JsonProperty(PropertyName = "overtime_time")]
        public int OvertimeTime { get; set; }

        /// <summary>
        /// 是否加班转调休
        /// </summary>
        [JsonProperty(PropertyName = "is_turn_off_vacation")]
        public YesOrNo IsTurnOffVacation { get; set; }

        /// <summary>
        /// 加班转调休时长
        /// </summary>
        [JsonProperty(PropertyName = "overtime_by_rest_time")]
        public int OvertimeByRestTime { get; set; }

        /// <summary>
        /// 是否加班转加班费
        /// </summary>
        [JsonProperty(PropertyName = "is_turn_off_money")]
        public YesOrNo IsTurnOffMoney { get; set; }

        /// <summary>
        /// 加班费金额
        /// </summary>
        [JsonProperty(PropertyName = "overtime_by_money_count")]
        public int OvertimeByMoneyCount { get; set; }


        /// <summary>
        /// 是否餐补
        /// </summary>
        [JsonProperty(PropertyName = "is_meal_allowance")]
        public YesOrNo IsMealAllowance { get; set; }

        /// <summary>
        /// 餐补金额
        /// </summary>
        [JsonProperty(PropertyName = "meal_allowance")]
        public int MealAllowance { get; set; }


        /// <summary>
        /// 是否交补
        /// </summary>
        [JsonProperty(PropertyName = "is_transportation_allowance")]
        public YesOrNo IsTransportationAllowance { get; set; }

        /// <summary>
        /// 交补金额
        /// </summary>
        [JsonProperty(PropertyName = "transportation_allowance")]
        public int TransportationAllowance { get; set; }
        /// <summary>
        /// 是否出差
        /// </summary>
        [JsonProperty(PropertyName = "is_special_attendance")]
        public YesOrNo IsSpecialAttendance { get; set; }
        /// <summary>
        /// 是否全天出差
        /// </summary>
        [JsonProperty(PropertyName = "is_special_attendance")]

        public YesOrNo IsSpecialAttendanceAllDay { get; set; }
        /// <summary>
        /// 出差时长
        /// </summary>
        [JsonProperty(PropertyName = "special_attendance_time")]
        public int SpecialAttendanceTime { get; set; }


        /// <summary>
        /// 是否因公外出
        /// </summary>
        [JsonProperty(PropertyName = "is_be_away_on_business")]
        public YesOrNo IsBeAwayOnBusiness { get; set; }


        /// <summary>
        /// 是否培训
        /// </summary>
        [JsonProperty(PropertyName = "is_trained")]
        public YesOrNo IsTrained { get; set; }
        /// <summary>
        /// 是否外派
        /// </summary>
        [JsonProperty(PropertyName = "is_expatriate")]
        public YesOrNo IsExpatriate { get; set; }
        /// <summary>
        /// 是否出差
        /// </summary>
        [JsonProperty(PropertyName = "is_business")]
        public YesOrNo IsBusiness { get; set; }
        /// <summary>
        /// 因公外出时长
        /// </summary>
        [JsonProperty(PropertyName = "be_away_on_business_time")]
        public int BeAwayOnBusinessTime { get; set; }
        /// <summary>
        /// 培训时长
        /// </summary>
        [JsonProperty(PropertyName = "trained_time")]
        public int TrainedTime { get; set; }

        /// <summary>
        /// 外派时长
        /// </summary>
        [JsonProperty(PropertyName = "expatriate_time")]
        public int ExpatriateTime { get; set; }


        /// <summary>
        /// 出差时长
        /// </summary>
        [JsonProperty(PropertyName = "business_time")]
        public int BusinessTime { get; set; }
        /// <summary>
        ///  	是否请假
        /// </summary>
        [JsonProperty(PropertyName = "is_leave")]
        public YesOrNo IsLeave { get; set; }

        /// <summary>
        /// 请假时长
        /// </summary>
        [JsonProperty(PropertyName = "leave_duration")]
        public int LeaveDuration { get; set; }
        /// <summary>
        /// 是否全天请假
        /// </summary>
        [JsonProperty(PropertyName = "is_leave_all_day")]
        public YesOrNo IsLeaveAllDay { get; set; }

        /// <summary>
        /// 调休假时长
        /// </summary>
        [JsonProperty(PropertyName = "time_off_in_lieu")]
        public int TimeOffInLieu { get; set; }
        /// <summary>
        /// 病假时长
        /// </summary>
        [JsonProperty(PropertyName = "sick_leave")]
        public int SickLeave { get; set; }
        /// <summary>
        /// 事假时长
        /// </summary>
        [JsonProperty(PropertyName = "personal_leave")]
        public int PersonalLeave { get; set; }
        /// <summary>
        /// 产假时长
        /// </summary>
        [JsonProperty(PropertyName = "maternity_leave")]
        public int MaternityLeave { get; set; }
        /// <summary>
        /// 陪产假时长
        /// </summary>
        [JsonProperty(PropertyName = "paternity_leave")]
        public int PaternityLeave { get; set; }
        /// <summary>
        /// 工伤假时长
        /// </summary>
        [JsonProperty(PropertyName = "injury_leave")]
        public int InjuryLeave { get; set; }
        /// <summary>
        /// 婚假时长
        /// </summary>
        [JsonProperty(PropertyName = "marriage_leave")]
        public int MarriageLeave { get; set; }
        /// <summary>
        /// 丧假时长
        /// </summary>
        [JsonProperty(PropertyName = "funeral_leave")]
        public int FuneralLeave { get; set; }
        /// <summary>
        /// 年假时长
        /// </summary>
        [JsonProperty(PropertyName = "annual_leave")]
        public int AnnualLeave { get; set; }
        /// <summary>
        /// 哺乳假时长
        /// </summary>
        [JsonProperty(PropertyName = "breastfeeding_leave")]
        public int BreastfeedingLeave { get; set; }


        /// <summary>
        /// 产检假时长
        /// </summary>
        [JsonProperty(PropertyName = "maternity_check_leave")]
        public int MaternityCheckLeave { get; set; }

        /// <summary>
        /// 第一次上班打卡时间
        /// </summary>
        [JsonProperty(PropertyName = "first_go_work_clock_time")]
        public string FirstGoWorkClockTime { get; set; }

        /// <summary>
        /// 第一次下班打卡时间
        /// </summary>
        [JsonProperty(PropertyName = "first_out_wor_clock_time")]
        public string FirstOutWorClockTime { get; set; }


        /// <summary>
        /// 第二次上班打卡时间
        /// </summary>
        [JsonProperty(PropertyName = "second_go_work_clock_time")]
        public string SecondGoWorkClockTime { get; set; }

        /// <summary>
        /// 第二次下班打卡时间
        /// </summary>
        [JsonProperty(PropertyName = "second_out_work_clock_time")]
        public string SecondOutWorClockTime { get; set; }


        /// <summary>
        /// 最早打卡时间
        /// </summary>
        [JsonProperty(PropertyName = "early_clock_time")]
        public string EarlyClockTime { get; set; }

        /// <summary>
        /// 最晚打卡时间
        /// </summary>
        [JsonProperty(PropertyName = "late_clock_time")]
        public string LateClockTime { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 季度
        /// </summary>
        public int Quarter { get; set; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// 周
        /// </summary>
        public int Week { get; set; }
        /// <summary>
        /// 日
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty(PropertyName = "certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 当天几次上下班
        /// </summary>
        [JsonProperty(PropertyName = "clock_times")]
        public int ClockTimes { get; set; }



    }
}
