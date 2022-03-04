using System;
using System.Collections.Generic;
using System.Text;
using Xc.HiKVisionSdk.Ia.Utils;

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

    /// <summary>
    /// 查询参数
    /// </summary>
    public class FieldOption
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldName">查询字段名称</param>
        /// <param name="fieldValue">查询字段值</param>
        /// <param name="type">查询类型</param>
        public FieldOption(string fieldName, string fieldValue, string type)
        {
            if (string.IsNullOrEmpty(fieldName))
            {
                throw new ArgumentNullException(nameof(fieldName));
            }

            if (string.IsNullOrEmpty(fieldValue))
            {
                throw new ArgumentNullException(nameof(fieldName));
            }

            FieldTypeValidator.Vaild(type);

            FieldName = fieldName;
            FieldValue = fieldValue;
            Type = type;
        }

        /// <summary>
        /// 查询字段名称
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// 查询字段值
        /// </summary>
        public string FieldValue { get; }

        /// <summary>
        /// 查询类型:
        /// eq相等,like相似，lt小于，gt大于,lte小于等于，gte大于等于，in范围（不超过32767个），isNull为空，notNull不为空，neq不等于，notIn不在范围。
        /// 注：时间类型时，以下几种时间格式均支持：2020-11-10 11:00:00、2020-11-10T05:50:26Z
        /// </summary>
        public string Type { get; }


    }
}
