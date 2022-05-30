using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras;

namespace Xc.HiKVisionSdk.Isc.Managers.Video
{
    /// <summary>
    /// 视频api
    /// </summary>
    public partial interface IHikVideoApiManager
    {

        /// <summary>
        /// 获取监控点预览取流URLv2
        /// </summary>
        /// <param name="model">请求</param>
        /// <returns></returns>
        /// <remarks>
        /// 1.平台正常运行；平台已经添加过设备和监控点信息。
        /// 2.平台需要安装mgc取流服务。
        /// 3.通过openAPI获取到监控点数据，依据自身业务开发监控点导航界面。
        /// 4.根据监控点编号调用本接口获取预览取流URL，协议类型包括：hik、rtsp、rtmp、hls、ws。
        /// 5.通过开放平台的开发包进行实时预览或者使用标准的GUI播放工具进行实时预览。
        /// 6.为保证数据的安全性，取流URL设有有效时间，有效时间为5分钟。
        /// </remarks>
        Task<CameraPreviewURLsV2Response> PreviewURLsV2Async(CameraPreviewURLsV2Request model);


        /// <summary>
        /// 获取监控点回放取流URLv2
        /// </summary>
        /// <param name="model">请求</param>
        /// <returns></returns>
        /// <remarks>
        /// 1.平台正常运行；平台已经添加过设备和监控点信息。
        /// 2.平台需要安装mgc取流服务。
        /// 3.通过openAPI获取到监控点数据，依据自身业务开发监控点导航界面。
        /// 4.根据监控点编号和回放起止时间调用本接口获取回放取流URL，协议类型包括：hik、rtsp、rtmp、hls（只支持云存储）。
        /// 5.通过开放平台的开发包进行录像回放或者使用标准的GUI播放工具进行录像回放。（开发包使用说明参考开发包的使用说明文档）。
        /// </remarks>
        Task<CameraPlaybackURLsV2Response> PlaybackURLsV2Async(CameraPlaybackURLsV2Request model);
    }
}
