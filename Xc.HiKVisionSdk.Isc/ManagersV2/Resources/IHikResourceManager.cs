using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources
{
    /// <summary>
    /// 资源属性接口
    /// <list type="bullet">
    /// <item>
    /// <term>GetPropertiesAsync</term>
    /// <description>获取资源属性</description>
    /// </item>
    /// <item>
    /// <term>GetOnlineHistoryAsync</term>
    /// <description>获取资源的历史在线记录</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IHikResourceManager
    {
        /// <summary>
        /// 获取资源属性
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>查询当前平台指定资源已定义的属性信息集合， 适用于平台资源自定义属性的场景， 部分接口需要使用这部分自定义属性。</remarks>
        Task<GetPropertiesResponse> GetPropertiesAsync(GetPropertiesRequest request);

        /// <summary>
        /// 获取资源的历史在线记录
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>获取资源的历史在线记录接口</remarks>
        Task<GetOnlineHistoryResponse> GetOnlineHistoryAsync(GetOnlineHistoryRequest request);
    }
}
