using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 取消车辆布控
    /// </summary>
    public class AlarmCarDeletionRequest : BaseRequest
    {
        /// <summary>
        /// 布控车辆唯一标识集合(编号间用‘,’分隔)
        /// </summary>
        public string AlarmSyscodes { get; set; }

        /// <summary>
        /// 取消车辆布控
        /// </summary>
        public AlarmCarDeletionRequest() { }

        /// <summary>
        /// 取消车辆布控
        /// </summary>
        /// <param name="codes">布控车辆唯一标识集合</param>
        public AlarmCarDeletionRequest(params string[] codes)
        {
            AlarmSyscodes = string.Join(",", codes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void CheckParams()
        {
            if (string.IsNullOrEmpty(AlarmSyscodes))
            {
                throw new ArgumentNullException(nameof(AlarmSyscodes));
            }
        }
    }
}
