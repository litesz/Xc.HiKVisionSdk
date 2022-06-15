using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources
{
    /// <summary>
    /// 人员及照片管理
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
    }
}
