namespace Xc.HiKVisionSdk.Isc.Managers.Acs.Models
{
    /// <summary>
    /// 查询门禁点事件V2结果数据
    /// </summary>
    public class DoorEventsV2ResponseData
    {

        /// <summary>
        /// 事件ID，唯一标识这个事件
        /// </summary>
        public string EventId { get; set; }
        /// <summary>
        /// 事件名称
        /// </summary>
        public string EventName { get; set; }
        /// <summary>
        /// 事件产生时间，参考附录B ISO8601时间格式说明
        /// </summary>
        public string EventTime { get; set; }
        /// <summary>
        /// 人员唯一编码
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 人员名称
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 人员所属组织编码
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 人员所属组织名称
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 门禁点名称
        /// </summary>
        public string DoorName { get; set; }
        /// <summary>
        /// 门禁点编码
        /// </summary>
        public string DoorIndexCode { get; set; }
        /// <summary>
        /// 门禁点所在区域编码
        /// </summary>
        public string DoorRegionIndexCode { get; set; }
        /// <summary>
        /// 抓拍图片地址，通过接口获取门禁事件的图片接口获取门禁事件的图片数据
        /// </summary>
        public string PicUri { get; set; }
        /// <summary>
        /// 图片存储服务的唯一标识
        /// </summary>
        public string SvrIndexCode { get; set; }
        /// <summary>
        /// 事件类型，参考附录D2.1 门禁事件
        /// </summary>
        public int EventType { get; set; }
        /// <summary>
        /// 进出类型(1：进
        /// 0：出
        /// -1:未知
        /// 要求：进门读卡器拨码设置为1，出门读卡器拨码设置为2)
        /// </summary>
        public InAndOutType InAndOutType { get; set; }
        /// <summary>
        /// 读卡器IndexCode
        /// </summary>
        public string ReaderDevIndexCode { get; set; }
        /// <summary>
        /// 读卡器名称
        /// </summary>
        public string ReaderDevName { get; set; }
        /// <summary>
        /// 控制器设备IndexCode
        /// </summary>
        public string DevIndexCode { get; set; }
        /// <summary>
        /// 控制器名称
        /// </summary>
        public string DevName { get; set; }
        /// <summary>
        /// 身份证图片uri，它是一个相对地址，可以通过获取门禁事件的图片接口，获取到图片的数据
        /// </summary>
        public string IdentityCardUri { get; set; }
        /// <summary>
        /// 事件入库时间，参考附录B ISO8601时间格式说明
        /// </summary>
        public string ReceiveTime { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string StudentId { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertNo { get; set; }
    }

}
