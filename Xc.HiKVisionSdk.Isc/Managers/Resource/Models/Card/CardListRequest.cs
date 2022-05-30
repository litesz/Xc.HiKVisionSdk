using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card
{

    /// <summary>
    /// 获取卡片列表请求
    /// </summary>
    public class CardListRequest : PagedRequest
    {

        /// <summary>
        /// 获取卡片列表请求
        /// </summary>
        public CardListRequest() { }

        /// <summary>
        /// 获取卡片列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public CardListRequest(int pageNo, int pageSize) : base(pageNo, pageSize) { }
    }
}
