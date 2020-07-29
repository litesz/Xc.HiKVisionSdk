namespace Xc.HiKVisionSdk.Isc.Callbacks.Acs
{
    public class AcsEventCallbackData
    {
        /// <summary>
        /// 人员通道号
        /// </summary>
        public int ExtAccessChannel { get; set; }
        /// <summary>
        /// 报警输入/防区通道
        /// </summary>
        public int ExtEventAlarmInID { get; set; }
        /// <summary>
        /// 报警输出通道
        /// </summary>
        public int ExtEventAlarmOutID { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string ExtEventCardNo { get; set; }
        /// <summary>
        /// 事件输入通道
        /// </summary>
        public int ExtEventCaseID { get; set; }
        /// <summary>
        ///  	事件类型代码
        /// </summary>
        public int ExtEventCode { get; set; }
        /// <summary>
        /// 通道事件信息
        /// </summary>
        public ExtEventCustomerNumInfo ExtEventCustomerNumInfo { get; set; }
        /// <summary>
        /// 门编号
        /// </summary>
        public int ExtEventDoorID { get; set; }
        /// <summary>
        /// 身份证图片地址
        /// </summary>
        public string ExtEventIDCardPictureURL { get; set; }
        /// <summary>
        /// 人员身份证信息
        /// </summary>
        public ExtEventIdentityCardInfo ExtEventIdentityCardInfo { get; set; }
        /// <summary>
        /// 进出方向
        /// </summary>
        public int ExtEventInOut { get; set; }
        /// <summary>
        /// 就地控制器id
        /// </summary>
        public int ExtEventLocalControllerID { get; set; }
        /// <summary>
        /// 主设备拨码
        /// </summary>
        public int ExtEventMainDevID { get; set; }
        /// <summary>
        /// 人员编号
        /// </summary>
        public string ExtEventPersonNo { get; set; }
        /// <summary>
        /// 图片的url
        /// </summary>
        public string ExtEventPictureURL { get; set; }
        /// <summary>
        /// 读卡器id
        /// </summary>
        public int ExtEventReaderID { get; set; }
        /// <summary>
        /// 读卡器类别
        /// 0-无效
        /// 1-IC读卡器
        /// 2-身份证读卡器
        /// 3-二维码读卡器
        /// 4-指纹头
        /// </summary>
        public ExtEventReaderKind ExtEventReaderKind { get; set; }
        /// <summary>
        /// 报告上传通道
        /// 1-布防上传
        /// 2-中心组1上传
        /// 3-中心组2上传
        /// 为0无效
        /// </summary>
        public int ExtEventReportChannel { get; set; }
        /// <summary>
        /// 群组编号
        /// </summary>
        public int ExtEventRoleID { get; set; }
        /// <summary>
        /// 分控制器硬件ID
        /// </summary>
        public int ExtEventSubDevID { get; set; }
        /// <summary>
        /// 刷卡次数
        /// </summary>
        public int ExtEventSwipNum { get; set; }
        /// <summary>
        /// 事件类型
        /// 事件类型，如普通门禁事件为0,身份证信息事件为1，客流量统计为2
        /// </summary>
        public int ExtEventType { get; set; }
        /// <summary>
        /// 多重认证序号
        /// </summary>
        public int ExtEventVerifyID { get; set; }
        /// <summary>
        /// 白名单单号,1-8，为0无效
        /// </summary>
        public int ExtEventWhiteListNo { get; set; }
        /// <summary>
        /// 接收时间戳
        /// </summary>
        public string ExtReceiveTime { get; set; }
        /// <summary>
        /// 序列
        /// </summary>
        public int Seq { get; set; }
        /// <summary>
        /// 用户类
        /// </summary>
        public UserType UserType { get; set; }
        /// <summary>
        ///  	String 图片服务器唯一编码
        /// </summary>
        public string SvrIndexCode { get; set; }
    }
}
