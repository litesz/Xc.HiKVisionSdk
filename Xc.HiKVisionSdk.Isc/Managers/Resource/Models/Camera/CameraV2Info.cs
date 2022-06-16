using Xc.HiKVisionSdk.Isc.Enums.Resource;
using System;
using Xc.HiKVisionSdk.Isc.Enums.Video;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 
    /// </summary>
    public class CameraV2Info
    {
        /// <summary>
        /// 唯一编码
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        ///  	资源类型，camera：监控点
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// 监控点国标编号
        /// </summary>
        public string ExternalIndexCode { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 通道号，为级联监控点时，该字段为空；        本级监控点时，该字段非空
        /// </summary>
        public int ChanNum { get; set; }
        /// <summary>
        /// 级联编号
        /// </summary>
        public string CascadeCode { get; set; }
        /// <summary>
        /// 父级资源编号
        /// </summary>
        public string ParentIndexCode { get; set; }
        /// <summary>
        /// 经度，精确到小数点后8位
        /// </summary>
        public decimal Longitude { get; set; }
        /// <summary>
        /// 纬度，精确到小数点后8位
        /// </summary>
        public decimal Latitude { get; set; }
        /// <summary>
        /// 海拔高度，单位：米
        /// </summary>
        public string Elevation { get; set; }
        /// <summary>
        /// 监控点类型
        /// </summary>
        public CameraType CameraType { get; set; }
        /// <summary>
        /// 能力集
        /// </summary>
        public string Capability { get; set; }
        /// <summary>
        /// 录像存储位置
        /// </summary>
        public string RecordLocation { get; set; }
        /// <summary>
        /// 通道子类型
        /// </summary>
        public string ChannelType { get; set; }
        /// <summary>
        /// 所属区域
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        ///  	所属区域路径,以@符号分割，包含本节点
        /// </summary>
        public string RegionPath { get; set; }
        /// <summary>
        /// 传输协议
        /// </summary>
        public TransmodeType TransmodeType { get; set; }
        /// <summary>
        /// 接入协议
        /// </summary>
        public string TreatyType { get; set; }
        /// <summary>
        /// 安装位置
        /// </summary>
        public string InstallLocation { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTimeOffset? CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTimeOffset? UpdateTime { get; set; }
        /// <summary>
        /// 数据在界面上的显示顺序
        /// </summary>
        public int DisOrder { get; set; }
        /// <summary>
        /// 资源唯一编码
        /// </summary>
        public string ResourceIndexCode { get; set; }
        /// <summary>
        /// 解码模式
        /// </summary>
        public string DecodeTag { get; set; }
        /// <summary>
        /// 监控点关联对讲唯一标志
        /// </summary>
        public string CameraRelateTalk { get; set; }
        /// <summary>
        /// 所属区域路径，由唯一标示组成，最大10级，格式： @根节点@子区域1@子区域2@
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// 区域路径名称，"/"分隔
        /// </summary>
        public string RegionPathName { get; set; }
    }
}
