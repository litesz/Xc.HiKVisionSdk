using Xc.HiKVisionSdk.Isc.Enums.Pms;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Pms
{
    /// <summary>
    /// 停车场进出事件
    /// </summary>
    public class ParkingInOrOutEventCallbackData
    {
        /// <summary>
        /// 是否黑名单标识（1-黑名单 0-非黑名单）
        /// </summary>
        public InBlackList? AlarmCar { get; set; }
        /// <summary>
        /// 车辆属性名称
        /// </summary>
        public string CarAttributeName { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 事件号
        /// </summary>
        public EventCmd EventCmd { get; set; }
        /// <summary>
        /// 事件编号
        /// </summary>
        public string EventIndex { get; set; }
        /// <summary>
        /// 出入口编号
        /// </summary>
        public string GateIndex { get; set; }
        /// <summary>
        /// 出入口名称
        /// </summary>
        public string GateName { get; set; }
        /// <summary>
        /// 进出场类型，0：进场，1：出场
        /// </summary>
        public InOrOutType InoutType { get; set; }
        /// <summary>
        /// 车辆主品牌
        /// </summary>
        public int? MainLogo { get; set; }
        /// <summary>
        /// 停车库编号
        /// </summary>
        public string ParkIndex { get; set; }
        /// <summary>
        /// 停车库名称
        /// </summary>
        public string ParkName { get; set; }
        /// <summary>
        /// 车牌置信度
        /// </summary>
        public int PlateBelieve { get; set; }
        /// <summary>
        /// 车牌颜色
        /// </summary>
        public PlateColorType PlateColor { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNo { get; set; }
        /// <summary>
        /// 车牌类型
        /// </summary>
        public PlateType PlateType { get; set; }
        /// <summary>
        /// 车道编号
        /// </summary>
        public string RoadwayIndex { get; set; }
        /// <summary>
        /// 车道名称
        /// </summary>
        public string RoadwayName { get; set; }
        /// <summary>
        /// 车道类型
        /// </summary>
        public RoadwayType RoadwayType { get; set; }
        /// <summary>
        /// 车辆子品牌
        /// </summary>
        public int? SubLogo { get; set; }
        /// <summary>
        /// 子品牌年款
        /// </summary>
        public int? SubModel { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// 车辆分类信息
        /// </summary>
        public int VehicleClass { get; set; }
        /// <summary>
        /// 车辆颜色
        /// </summary>
        public int VehicleColor { get; set; }
        /// <summary>
        /// 车辆类型
        /// </summary>
        public int VehicleType { get; set; }

        /// <summary>
        /// 进场结果
        /// </summary>
        public InResult InResult { get; set; }

        /// <summary>
        /// 出场结果
        /// </summary>
        public OutResult OutResult { get; set; }
    }
}
