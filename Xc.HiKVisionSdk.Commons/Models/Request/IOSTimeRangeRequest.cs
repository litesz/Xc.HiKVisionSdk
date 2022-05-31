using System;
using Xc.HiKVisionSdk.Utils;

namespace Xc.HiKVisionSdk.Models.Request
{
    /// <summary>
    /// 开始时间 - 结束时间
    /// </summary>
    public class IOSTimeRangeRequest : BaseRequest
    {

        /// <summary>
        /// 设置StartTime和EndTime为必填项
        /// </summary>
        protected bool DateIsRequired = true;
        /// <summary>
        /// 开始时间（事件开始时间，采用ISO8601时间格式，与endTime配对使用，不能单独使用，时间范围最大不能超过3个月），参考附录B ISO8601时间格式说明
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间（事件结束时间，采用ISO8601时间格式，最大长度32个字符，与startTime配对使用，不能单独使用，时间范围最大不能超过3个月），参考附录B ISO8601时间格式说明
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 开始时间 - 结束时间
        /// </summary>
        /// <param name="dateIsRequired">设置StartTime和EndTime为必填项</param>
        public IOSTimeRangeRequest(bool? dateIsRequired = null)
        {
            if (dateIsRequired.HasValue)
            {
                DateIsRequired = dateIsRequired.Value;
            }
        }


        /// <summary>
        /// 开始时间 - 结束时间
        /// </summary>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        public IOSTimeRangeRequest(DateTime startTime, DateTime endTime) : this(true)
        {
            StartTime = DateTimeFormat.ToIOS8601(startTime);
            EndTime = DateTimeFormat.ToIOS8601(endTime);
        }


        public override void CheckParams()
        {
            if (!DateIsRequired)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(StartTime))
            {
                throw new System.ArgumentNullException(nameof(StartTime));
            }
            if (string.IsNullOrWhiteSpace(EndTime))
            {
                throw new System.ArgumentNullException(nameof(EndTime));
            }

        }
    }

}
