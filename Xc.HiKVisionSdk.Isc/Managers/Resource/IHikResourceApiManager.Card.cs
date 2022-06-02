using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 资源api
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

        /// <summary>
        /// 增量获取卡片数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>
        /// 根据查询条件查询卡片列表信息，主要根据时间段分页获取卡片信息，包含已删除数据。其中开始日期与结束日期的时间差必须在48小时内。
        /// </remarks>
        Task<CardTimeRangeResponse> CardTimeRangeAsync(CardTimeRangeRequest request);
    }
}
