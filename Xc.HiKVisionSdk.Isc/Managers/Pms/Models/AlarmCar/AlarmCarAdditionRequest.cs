using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 车辆布控请求
    /// </summary>
    public class AlarmCarAdditionRequest : BaseRequest
    {
        /// <summary>
        /// 车牌号码（车牌、卡号二选一）
        /// </summary>
        public string PlateNo { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 驾驶员名称
        /// </summary>
        public string Driver { get; set; }

        /// <summary>
        /// 驾驶员电话
        /// </summary>
        public string DriverPhone { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 布控结束时间,ISO8601格式：
        /// yyyy-MM-ddTHH:mm:ss+当前时区，例如北京时间：
        /// 2018-07-26T15:00:00+08:00
        /// </summary>
        public string EndTime { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(PlateNo) && string.IsNullOrWhiteSpace(CardNo))
            {
                throw new ArgumentNullException("PlateNo 或者 CardNo", "车牌、卡号二选一")；
            }
        }

    }
}
