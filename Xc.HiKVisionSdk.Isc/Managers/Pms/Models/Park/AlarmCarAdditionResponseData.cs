namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 车辆布控结果数据
    /// </summary>
    public class AlarmCarAdditionResponseData
    {
        /// <summary>
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
    }



}
