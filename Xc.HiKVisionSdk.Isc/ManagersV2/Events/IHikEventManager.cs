using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events
{
    /// <summary>
    /// 事件
    /// <list type="bullet">
    /// <item>
    /// <term>GetEventsListAsync</term>
    /// <description>获取联动事件列表</description>
    /// </item>
    /// <item>
    /// <term>SubscriptionByEventTypesAsync</term>
    /// <description>按事件类型订阅事件</description>
    /// </item>
    /// <item>
    /// <term>GetEventSubscriptionViewAsync</term>
    /// <description>查询事件订阅信息</description>
    /// </item>
    /// <item>
    /// <term>UnSubscriptionByEventTypesAsync</term>
    /// <description>按事件类型取消订阅</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IHikEventManager
    {
        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>通过查询条件获取l联动事件信息列表，返回结果分页展示。</remarks>
        Task<GetEventsListResponse> GetEventsListAsync(GetEventsListRequest request);

        /// <summary>
        /// 按事件类型订阅事件
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>该接口用于满足应用方按事件类型码订阅事件，同一个用户重复订阅相同的事件，接口内部逻辑自动去重，确保不重复投递事件。        事件订阅接口， 支持订阅平台的所有业务的各种事件类型，具体参考附录D        本接口要求，三方订阅的时候，要求三方指定的http/https接收事件的服务地址。后续平台产生对应的事件，会推送到此http/https服务地址。</remarks>
        Task<SubscriptionByEventTypesResponse> SubscriptionByEventTypesAsync(SubscriptionByEventTypesRequest request);

        /// <summary>
        /// 查询事件订阅信息
        /// </summary>
        /// <returns></returns>
        /// <remarks>应用方根据用户查询事件订阅详情。</remarks>
        Task<GetSubscriptionViewResponse> GetEventSubscriptionViewAsync();
        /// <summary>
        /// 按事件类型取消订阅
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>应用方指定事件类型取消订阅。</remarks>
        Task<UnSubscriptionByEventTypesResponse> UnSubscriptionByEventTypesAsync(UnSubscriptionByEventTypesRequest request);
    }
}
