using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Acs.Models
{
    /// <summary>
    /// 查询门禁事件
    /// </summary>
    public class DoorEventsRequest : IOSTimeRangeWithPagedRequest
    {
        /// <summary>
        /// 事件类型，参考附录D2.1 门禁事件
        /// </summary>
        public int EventType { get; set; }
        /// <summary>
        /// 人员姓名(支持中英文字符，不能包含 ’ / \ : * ? " ）
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 人员数组，获取人员列表v2接口可以获取到
        /// </summary>
        public string[] PersonIds { get; set; }
        /// <summary>
        /// 门禁点名称，查询门禁点列表接口可以获取
        /// </summary>
        public string DoorName { get; set; }
        /// <summary>
        /// 门禁点唯一标识，查询门禁点列表接口可以获取，最大支持10个门禁点
        /// </summary>
        public string[] DoorIndexCodes { get; set; }
        /// <summary>
        /// 门禁点所在区域，分页获取区域列表接口可以获取
        /// </summary>
        public string DoorRegionIndexCode { get; set; }
        /// <summary>
        /// 支持personName、doorName、eventTime填写排序的字段名称，例如：”personName”
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 指定排序字段是使用升序（asc）还是降序（desc），例如：”asc”
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// 查询门禁事件
        /// </summary>
        public DoorEventsRequest() : base(false) { }

        /// <summary>
        /// 查询门禁事件
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        public DoorEventsRequest(int pageNo, int pageSize, DateTime startTime, DateTime endTime) : base(pageNo, pageSize, startTime, endTime, false) { }

    }
}
