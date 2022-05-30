using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras;

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
        /// <param name="model">请求</param>
        /// <returns></returns>
        public Task<CameraPreviewURLsV2Response> PreviewURLsV2Async(CameraPreviewURLsV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraPreviewURLsV2Request, CameraPreviewURLsV2Response>("/api/video/v2/cameras/previewURLs", model, VersionConsts.V1_4);
        }


        /// <summary>
        /// 获取监控点回放取流URLv2
        /// </summary>
        /// <param name="model">请求</param>
        /// <returns></returns>
        public Task<CameraPlaybackURLsV2Response> PlaybackURLsV2Async(CameraPlaybackURLsV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CameraPlaybackURLsV2Request, CameraPlaybackURLsV2Response>("/api/video/v2/cameras/playbackURLs", model, VersionConsts.V1_4);
        }
    }
}
