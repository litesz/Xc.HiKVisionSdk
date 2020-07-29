namespace Xc.HiKVisionSdk.Isc.Managers.Mpc.Models
{
    public class AlarmBlackAddRequestData
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
    }
}
