namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 车位剩余结果数据
    /// </summary>
    public class ParkRemainSpaceNumResponseData
    {
        /// <summary>
        /// 停车库唯一标识码
        /// </summary>
        public string ParkSyscode { get; set; }
        /// <summary>
        /// 停车库名称
        /// </summary>
        public string ParkName { get; set; }
        /// <summary>
        /// 父停车库唯一标识
        /// </summary>
        public string ParentParkSyscode { get; set; }
        /// <summary>
        /// 停车库车位总数
        /// </summary>
        public int TotalPlace { get; set; }
        /// <summary>
        /// 停车库固定车位总数
        /// </summary>
        public int TotalPermPlace { get; set; }
        /// <summary>
        /// 停车库预约车位总数
        /// </summary>
        public int TotalReservePlace { get; set; }
        /// <summary>
        /// 停车库车位剩余数
        /// </summary>
        public int LeftPlace { get; set; }
        /// <summary>
        /// 停车库固定车位剩余数
        /// </summary>
        public int LeftPermPlace { get; set; }
        /// <summary>
        /// 停车库预约车位剩余数
        /// </summary>
        public int LeftReservePlace { get; set; }
    }
}
