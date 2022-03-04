using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 查询布控车辆
    /// </summary>
    public class AlarmCarPageRequest : PagedQuery
    {
        /// <summary>
        /// 车牌号/卡号
        /// </summary>
        public string SearchKey { get; set; }
    }
}
