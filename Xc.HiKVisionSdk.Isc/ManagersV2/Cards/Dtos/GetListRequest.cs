using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{

    /// <summary>
    /// 获取卡片列表请求
    /// </summary>
    public class GetListRequest : PagedRequest
    {
        /// <summary>
        /// 获取卡片列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public GetListRequest(int pageNo, int pageSize) : base(pageNo, pageSize) { }
    }
}
