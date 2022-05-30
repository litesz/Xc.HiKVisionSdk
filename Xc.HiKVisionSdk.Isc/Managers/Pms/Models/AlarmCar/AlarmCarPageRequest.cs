using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 查询布控车辆
    /// </summary>
    public class AlarmCarPageRequest : PagedRequest
    {
        /// <summary>
        /// 车牌号/卡号
        /// </summary>
        public string SearchKey { get; set; }
        /// <summary>
        /// 查询布控车辆
        /// </summary>
        public AlarmCarPageRequest() { }
        /// <summary>
        /// 查询布控车辆
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public AlarmCarPageRequest(int pageNo, int pageSize) : base(pageNo, pageSize) { }

        /// <summary>
        /// 查询布控车辆
        /// </summary>
        /// <param name="searchKey">车牌号/卡号</param>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public AlarmCarPageRequest(string searchKey, int pageNo, int pageSize) : this(pageNo, pageSize)
        {
            SearchKey = searchKey;
        }
    }
}
