namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs
{
    public class AcsDoorAdvanceAcsDoorListResponseData
    {
        /// <summary>
        /// 门禁点唯一标识
        /// </summary>
        public string DoorIndexCode { get; set; }
        /// <summary>
        /// 门禁点名称
        /// </summary>
        public string DoorName { get; set; }
        /// <summary>
        /// 门禁点序号
        /// </summary>
        public string DoorNo { get; set; }
        /// <summary>
        /// 所属门禁设备唯一标识
        /// </summary>
        public string AcsDevIndexCode { get; set; }
        /// <summary>
        /// 所属区域唯一标识
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 通道类型, 参考附录A.8 门禁设备通道类型
        /// </summary>
        public string ChannelType { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public string ChannelNo { get; set; }
        /// <summary>
        /// 安装位置
        /// communityPerimeter：小区周界
        /// communityEntrance：小区出入口
        /// fireChannel：消防通道
        /// landscapePool：景观池
        /// outsideBuilding：住宅楼外
        /// parkEntrance：停车场（库）出入口
        /// parkArea：停车场区
        /// equipmentRoom：设备房（机房、配电房、泵房）
        /// monitorCenter：监控中心
        /// stopArea：禁停区
        /// vault：金库
        /// </summary>
        public string InstallLocation { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }
    }
}
