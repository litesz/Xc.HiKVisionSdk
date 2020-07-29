using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 组织api
    /// </summary>
    public partial interface IHikResourceApiManager
    {
        /// <summary>
        /// 获取卡片列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>获取卡片列表接口可用来全量同步卡片信息，返回结果分页展示，不作权限过滤。</remarks>
        Task<CardListResponse> CardListAsync(CardListRequest request);
    }
}
