using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    /// <summary>
    /// 资源API
    /// </summary>
    public partial class HikResourceApiManager : IHikResourceApiManager
    {
        /// <summary>
        /// 查询监控点列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AdvanceCameraListResponse> AdvanceCameraListAsync(AdvanceCameraListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvanceCameraListRequest, AdvanceCameraListResponse>("/api/resource/v1/camera/advance/cameraList", model, Const.V1_0);
        }

        /// <summary>
        /// 分页获取监控点资源
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<CamerasResponse> CamerasAsync(CamerasRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CamerasRequest, CamerasResponse>("/api/resource/v1/cameras", model, Const.V1_0);
        }

        /// <summary>
        /// 根据编号获取监控点详细信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<CamerasIndexCodeResponse> CamerasIndexCodeAsync(CamerasIndexCodeRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CamerasIndexCodeRequest, CamerasIndexCodeResponse>("/api/resource/v1/cameras/indexCode", model, Const.V1_0);
        }

    }
}
