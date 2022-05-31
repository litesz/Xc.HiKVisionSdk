using System;
using Xc.HiKVisionSdk.Models.Request;
using Xc.HiKVisionSdk.Utils;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc.Models
{
    /// <summary>
    /// 批量添加车辆黑名单请求详细
    /// </summary>
    public class AlarmBlackAddRequestData : ICheckRequestItem
    {

        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNo { get; set; }
        /// <summary>
        /// 布控开始时间（格式：yyyy-MM-ddTHH:mm:ss.sss+当前时区）
        /// </summary>
        public string BeginTime { get; set; }
        /// <summary>
        /// 布控结束时间（格式：yyyy-MM-ddTHH:mm:ss.sss+当前时区）
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 车主姓名
        /// </summary>
        public string OwnerName { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 布控原因,1（被盗车），2（被抢车），3（嫌疑车），4（交通违法车），5（紧急查控车）
        /// </summary>
        public int Reason { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 批量添加车辆黑名单请求详细
        /// </summary>
        /// <param name="plateNo">车牌号</param>
        /// <param name="reason">布控原因,1（被盗车），2（被抢车），3（嫌疑车），4（交通违法车），5（紧急查控车）</param>
        /// <param name="end">布控结束时间</param>
        public AlarmBlackAddRequestData(string plateNo, int reason, DateTime end)
        {
            PlateNo = plateNo;
            Reason = reason;
            EndTime = DateTimeFormat.ToIOS8601(end);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Check()
        {
            if (string.IsNullOrWhiteSpace(PlateNo))
            {
                throw new ArgumentNullException(nameof(PlateNo));
            }
            if (Reason < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Reason), "最小为 1");
            }
        }
    }
}
