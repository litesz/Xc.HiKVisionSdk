using Xc.HiKVisionSdk.Isc.Enums.Resource;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 查询监控点列表结果数据
    /// </summary>
    public class CameraInfo
    {
        /// <summary>
        /// 海拔
        /// </summary>
        public string Altitude { get; set; }
        /// <summary>
        /// 监控点唯一标识
        /// </summary>
        public string CameraIndexCode { get; set; }
        /// <summary>
        /// 监控点名称
        /// </summary>
        public string CameraName { get; set; }
        /// <summary>
        /// 摄像机类型
        /// </summary>
        public int CameraType { get; set; }
        /// <summary>
        /// 监控点类型说明
        /// </summary>
        public string CameraTypeName { get; set; }
        /// <summary>
        /// 参考附录A.22 能力集
        /// </summary>
        public string CapabilitySet { get; set; }
        /// <summary>
        /// 能力集说明
        /// </summary>
        public string CapabilitySetName { get; set; }
        /// <summary>
        ///  	智能分析能力集，扩展字段，暂不使用
        /// </summary>
        public string IntelligentSet { get; set; }
        /// <summary>
        ///  	智能分析能力集说明，扩展字段，暂不使用
        /// </summary>
        public string IntelligentSetName { get; set; }
        /// <summary>
        /// 通道编号
        /// </summary>
        public string ChannelNo { get; set; }
        /// <summary>
        /// 通道类型附录A.5 视频通道类型
        /// </summary>
        public string ChannelType { get; set; }
        /// <summary>
        /// 通道类型说明
        /// </summary>
        public string channelTypeName { get; set; }
        /// <summary>
        /// 创建时间，采用ISO8601标准，如2018-07-26T21:30:08+08:00 表示北京时间2018年7月26日21时30分08秒
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 所属编码设备唯一标识
        /// </summary>
        public string EncodeDevIndexCode { get; set; }
        /// <summary>
        /// 所属设备类型，扩展字段，暂不使用
        /// </summary>
        public string EncodeDevResourceType { get; set; }
        /// <summary>
        /// 所属设备类型说明，扩展字段，暂不使用
        /// </summary>
        public string EncodeDevResourceTypeName { get; set; }
        /// <summary>
        /// 监控点国标编号，即外码编号externalIndexCode
        /// </summary>
        public string GbIndexCode { get; set; }
        /// <summary>
        /// 安装位置：
        /// communityPerimeter：小区周界,communityEntrance：小区出入口,fireChannel：消防通道,andscapePool：景观池,outsideBuilding：住宅楼外,parkEntrance：停车场（库）出入口,parkArea：停车场区,equipmentRoom：设备房（机房、配电房、泵房）,monitorCenter：监控中心,stopArea：禁停区,vault：金库
        /// </summary>
        public string InstallLocation { get; set; }
        /// <summary>
        /// 键盘控制码
        /// </summary>
        public string KeyBoardCode { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }
        /// <summary>
        /// 摄像机像素（1-普通像素，2-130万高清，3-200万高清，4-300万高清），扩展字段，暂不使用
        /// </summary>
        public string Pixel { get; set; }
        /// <summary>
        /// 云镜类型（1-全方位云台（带转动和变焦），2-只有变焦,不带转动，3-只有转动，不带变焦，4-无云台，无变焦），扩展字段，暂不使用
        /// </summary>
        public string Ptz { get; set; }
        /// <summary>
        /// 云镜类型说明，扩展字段，暂不使用
        /// </summary>
        public string PtzName { get; set; }
        /// <summary>
        ///  	云台控制(1-DVR，2-模拟矩阵，3-MU4000，4-NC600)，扩展字段，暂不使用
        /// </summary>
        public string PtzController { get; set; }
        /// <summary>
        ///  	云台控制说明，扩展字段，暂不使用
        /// </summary>
        public string PtzControllerName { get; set; }
        /// <summary>
        /// 录像存储位置
        /// </summary>
        public string RecordLocation { get; set; }
        /// <summary>
        /// 录像存储位置说明
        /// </summary>
        public string RecordLocationName { get; set; }
        /// <summary>
        ///  	所属区域唯一标识
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 是否被删除
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 状态说明
        /// </summary>
        public string StatusName { get; set; }
        /// <summary>
        /// 传输协议，参考附录A.40 传输协议
        /// </summary>
        public TransType TransType { get; set; }
        /// <summary>
        ///  	传输协议类型说明
        /// </summary>
        public string TransTypeName { get; set; }
        /// <summary>
        ///  	接入协议，参考附录A.6 编码设备接入协议
        /// </summary>
        public string TreatyType { get; set; }
        /// <summary>
        /// 接入协议类型说明
        /// </summary>
        public string TreatyTypeName { get; set; }
        /// <summary>
        ///  	可视域相关（JSON格式），扩展字段，暂不使用
        /// </summary>
        public string Viewshed { get; set; }
        /// <summary>
        /// 更新时间 
        /// 采用ISO8601标准，如2018-07-26T21:30:08+08:00 
        /// 表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public string UpdateTime { get; set; }



        /// <summary>
        /// 数据在界面上显示的顺序
        /// </summary>
        public int DisOrder { get; set; }
    }
}
