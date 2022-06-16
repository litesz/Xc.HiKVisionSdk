using System.Threading.Tasks;
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
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<AdvanceCameraListResponse> AdvanceCameraListAsync(AdvanceCameraListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvanceCameraListRequest, AdvanceCameraListResponse>("/api/resource/v1/camera/advance/cameraList", request, VersionConsts.V1);
        }

        /// <summary>
        /// 查询监控点列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<CameraSearchV2Response> CamerSearchV2Async(CameraSearchV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraSearchV2Request, CameraSearchV2Response>("/api/resource/v2/camera/search", model, VersionConsts.V1_4);

        }

        /// <summary>
        /// 分页获取监控点资源
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CamerasResponse> CamerasAsync(CamerasRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CamerasRequest, CamerasResponse>("/api/resource/v1/cameras", request, VersionConsts.V1);
        }

        /// <summary>
        /// 根据编号获取监控点详细信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CamerasIndexCodeResponse> CamerasIndexCodeAsync(CamerasIndexCodeRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CamerasIndexCodeRequest, CamerasIndexCodeResponse>("/api/resource/v1/cameras/indexCode", request, VersionConsts.V1);
        }

        /// <summary>
        /// 根据区域编号获取下级监控点列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<RegionIndexCodeCamerasResponse> RegionIndexCodeCamerasAsync(RegionIndexCodeCamerasRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<RegionIndexCodeCamerasRequest, RegionIndexCodeCamerasResponse>("/api/resource/v1/regions/regionIndexCode/cameras", request, VersionConsts.V1);
        }

        ///// <summary>
        ///// 增量获取监控点数据
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //public Task<CameraTimeRangeResponse> CameraTimeRangeAsync(CameraTimeRangeRequest request)
        //{
        //    return _hikVisionApiManager.PostAndGetAsync<CameraTimeRangeRequest, CameraTimeRangeResponse>("/api/resource/v1/camera/timeRange", request, VersionConsts.V1_4);
        //}
    }
}
