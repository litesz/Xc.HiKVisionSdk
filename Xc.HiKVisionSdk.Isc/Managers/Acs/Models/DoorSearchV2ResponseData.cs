namespace Xc.HiKVisionSdk.Isc.Managers.Acs.Models
{
    /// <summary>
    /// 查询门禁点V2结果数据
    /// </summary>
    public class DoorSearchV2ResponseData
    {
        /// <summary>
        /// 资源唯一编码
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 资源类型，详见附录A.2 资源类型
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 门禁点编号
        /// </summary>
        public string DoorNo { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public string ChannelNo { get; set; }
        /// <summary>
        /// 父级资源编号
        /// </summary>
        public string ParentIndexCode { get; set; }
        /// <summary>
        /// 一级控制器id
        /// </summary>
        public string ControlOneId { get; set; }
        /// <summary>
        /// 二级控制器id
        /// </summary>
        public string ControlTwoId { get; set; }
        /// <summary>
        /// 读卡器1
        /// </summary>
        public string ReaderInId { get; set; }
        /// <summary>
        /// 读卡器2
        /// </summary>
        public string ReaderOutId { get; set; }
        /// <summary>
        /// 接入协议，详见附录A.6 编码设备接入协议
        /// </summary>
        public string TreatyType { get; set; }
        /// <summary>
        /// 门序号
        /// </summary>
        public int? DoorSerial { get; set; }
        /// <summary>
        /// 所属区域
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 所属区域路径,以@符号分割，包含本节点
        /// </summary>
        public string RegionPath { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 通道类型，door：门禁点
        /// </summary>
        public string ChannelType { get; set; }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// 所属区域路径名，符号"/"进行分隔
        /// </summary>
        public string RegionPathName { get; set; }
        /// <summary>
        /// 安装位置，详见附录附录A.81 安装位置
        /// </summary>
        public string InstallLocation { get; set; }


    }
}
