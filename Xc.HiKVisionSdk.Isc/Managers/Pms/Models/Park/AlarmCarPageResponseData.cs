namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 查询布控车辆结果数据
    /// </summary>
    public class AlarmCarPageResponseData
    {
        // <summary>
        /// 布控车辆唯一标识
        /// </summary>
        public string AlarmSyscode { get; set; }

        /// <summary>
        /// 车牌号码
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
    }
}
