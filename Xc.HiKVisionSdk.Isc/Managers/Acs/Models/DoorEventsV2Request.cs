using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Acs.Models
{
    /// <summary>
    /// 查询门禁事件V2请求
    /// </summary>
    public class DoorEventsV2Request : PagedQuery
    {
        /// <summary>
        /// 门禁点唯一标识数组，最大支持10个门禁点，查询门禁点列表v2接口获取返回报文中的doorIndexCode字段
        /// </summary>
        public string[] DoorIndexCodes { get; set; }

        /// <summary>
        /// 门禁点名称，支持模糊查询，从查询门禁点列表v2接口获取返回报文中的name字段
        /// </summary>
        public string DoorName { get; set; }

        /// <summary>
        /// 读卡器唯一标识数组，最大支持50个读卡器，查询门禁读卡器列表接口获取返回报文中的indexCode字段
        /// </summary>
        public string[] ReaderDevIndexCodes { get; set; }

        /// <summary>
        /// 开始时间（事件开始时间，采用ISO8601时间格式，与endTime配对使用，不能单独使用，时间范围最大不能超过3个月），参考附录B ISO8601时间格式说明
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间（事件结束时间，采用ISO8601时间格式，最大长度32个字符，与startTime配对使用，不能单独使用，时间范围最大不能超过3个月），参考附录B ISO8601时间格式说明
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 入库开始时间，采用ISO8601时间格式，与receiveEndTime配对使用，不能单独使用，时间范围最大不能超过3个月，参考附录B ISO8601时间格式说明
        /// </summary>
        public string ReceiveStartTime { get; set; }

        /// <summary>
        /// 入库结束时间，采用ISO8601时间格式，最大长度32个字符，与receiveStartTime配对使用，不能单独使用，时间范围最大不能超过3个月，参考附录B ISO8601时间格式说明
        /// </summary>
        public string ReceiveEndTime { get; set; }

        /// <summary>
        /// 门禁点所在区域，查询区域列表v2接口获取返回参数indexCode
        /// </summary>
        public string DoorRegionIndexCode { get; set; }

        /// <summary>
        /// 事件类型，参考附录D2.1 门禁事件
        /// </summary>
        public int[] EventTypes { get; set; }

        /// <summary>
        /// 人员姓名(支持中英文字符，不能包含 ’ / \ : * ? " 
        /// </summary>
        public string PersonName { get; set; }

        /// <summary>
        /// 排序字段（支持personName、doorName、eventTime填写排序的字段名称）
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 升/降序（指定排序字段是使用升序（asc）还是降序（desc）
        /// </summary>
        public string Order { get; set; }
    }
}
