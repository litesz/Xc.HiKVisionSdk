using Xc.HiKVisionSdk.Models.Responses;

namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras
{
    /// <summary>
    /// 获取监控点回放取流URLv2结果
    /// </summary>

    public class CameraPlaybackURLsV2Response : HiKVisionResponse
    {

        /// <summary>
        /// 获取监控点回放取流URLv2结果数据
        /// </summary>
        public CameraPlaybackURLsV2PagedDataResponseData Data { get; set; }

    }
}
