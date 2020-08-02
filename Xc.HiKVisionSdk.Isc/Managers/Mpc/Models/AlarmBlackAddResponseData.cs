namespace Xc.HiKVisionSdk.Isc.Managers.Mpc.Models
{
    /// <summary>
    /// 批量添加车辆黑名单结果数据
    /// </summary>
    public class AlarmBlackAddResponseData
    {
        /// <summary>
        /// 黑名单唯一编号
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNo { get; set; }
    }
}
