using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources
{
    /// <summary>
    /// 人员及照片管理
    /// </summary>
    public class HikResourcesManager : IHikResourcesManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 人员及照片管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikResourcesManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 获取资源属性
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPropertiesResponse> GetPropertiesAsync(GetPropertiesRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetPropertiesRequest, GetPropertiesResponse>("/api/resource/v1/resource/properties", request, VersionConsts.V1_3);
        }
    }
}
