using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources
{
    /// <summary>
    /// 资源属性接口
    /// </summary>
    public class HikResourceManager : IHikResourceManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 人员及照片管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikResourceManager(IHikVisionIscApiManager hikVisionApiManager)
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

        /// <summary>
        /// 获取资源的历史在线记录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetOnlineHistoryResponse> GetOnlineHistoryAsync(GetOnlineHistoryRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetOnlineHistoryRequest, GetOnlineHistoryResponse>("/api/nms/v1/online/history_status", request, VersionConsts.V1_3);
        }
    }
}
