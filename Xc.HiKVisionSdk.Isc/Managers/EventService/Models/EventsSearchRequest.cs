using System.ComponentModel.DataAnnotations;
using Xc.HiKVisionSdk.Isc.Models.Common;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService.Models
{
    public class EventsSearchRequest : IPaged
    {
        /// <summary>
        ///  事件规则id
        /// </summary>
        public string EventRuleId { get; set; }
        /// <summary>
        ///  事件分类，详见附录A.62
        /// </summary>
        public string Ability { get; set; }
        /// <summary>
        /// 区域编号
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 所属位置，详见附录A.81 安装位置
        /// </summary>
        public string[] LocationIndexCodes { get; set; }
        /// <summary>
        ///  事件源名称
        /// </summary>
        public string ResName { get; set; }
        /// <summary>
        /// 事件源编号
        /// </summary>
        public string[] ResIndexCodes { get; set; }
        /// <summary>
        ///  事件源类型，详见附录A.63
        /// </summary>
        public string[] ResTypes { get; set; }
        /// <summary>
        /// 事件类型，详见附录D
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// 事件等级，1-低，2-中，3-高
        /// </summary>
        public string[] EventLevels { get; set; }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        ///  处理状态，0-未处理，1-已处理
        /// </summary>
        public HandleStatus HandleStatus { get; set; }
        /// <summary>
        ///  开始时间,ISO8601时间
        /// </summary>
        [Required]
        public string StartTime { get; set; }
        /// <summary>
        /// 结束时间,ISO8601时间
        /// </summary>
        [Required]
        public string EndTime { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [Required]
        public int PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        [Required]
        public int PageNo { get; set; }
    }

}
