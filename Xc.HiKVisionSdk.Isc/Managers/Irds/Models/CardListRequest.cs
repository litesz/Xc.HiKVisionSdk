using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Irds.Models
{
    /// <summary>
    /// 获取卡片列表请求
    /// </summary>
    public class CardListRequest : PagedRequest
    {
        /// <summary>
        /// 获取卡片列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public CardListRequest(int pageNo, int pageSize) : base(pageNo, pageSize) { }
    }
}
