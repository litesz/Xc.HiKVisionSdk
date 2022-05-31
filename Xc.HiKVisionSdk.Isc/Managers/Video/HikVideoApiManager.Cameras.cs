using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras;
using Xc.HiKVisionSdk.Isc.Managers.Video.Models.Pictures;

namespace Xc.HiKVisionSdk.Isc.Managers.Video
{
    /// <summary>
    /// 视频api
    /// </summary>
    public partial class HikVideoApiManager : IHikVideoApiManager
    {



        /// <summary>
        /// 获取监控点预览取流URLv2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        public Task<CameraPreviewURLsV2Response> CameraPreviewURLsV2Async(CameraPreviewURLsV2Request request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraPreviewURLsV2Request, CameraPreviewURLsV2Response>("/api/video/v2/cameras/previewURLs", request, VersionConsts.V1_4);
        }


        /// <summary>
        /// 获取监控点回放取流URLv2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        public Task<CameraPlaybackURLsV2Response> CameraPlaybackURLsV2Async(CameraPlaybackURLsV2Request request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraPlaybackURLsV2Request, CameraPlaybackURLsV2Response>("/api/video/v2/cameras/playbackURLs", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 视频图片查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CameraEventsPictureResponse> CameraEventsPictureAsync(CameraEventsPictureRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraEventsPictureRequest, CameraEventsPictureResponse>("/api/video/v1/events/picture", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 平台抓拍计划图片获取
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<CameraPictureInfosResponse> CameraPictureInfosAsync(CameraPictureInfosRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraPictureInfosRequest, CameraPictureInfosResponse>("/api/video/v1/pictureInfos", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 手动抓图
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ManualCaptureResponse> ManualCaptureResponse(ManualCaptureRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<ManualCaptureRequest, ManualCaptureResponse>("/api/video/v1/manualCapture", request, VersionConsts.V1_2);
        }
    }
}
