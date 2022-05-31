using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras;
using Xc.HiKVisionSdk.Isc.Managers.Video.Models.Pictures;

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
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>
        /// 1.平台正常运行；平台已经添加过设备和监控点信息。
        /// 2.平台需要安装mgc取流服务。
        /// 3.通过openAPI获取到监控点数据，依据自身业务开发监控点导航界面。
        /// 4.根据监控点编号调用本接口获取预览取流URL，协议类型包括：hik、rtsp、rtmp、hls、ws。
        /// 5.通过开放平台的开发包进行实时预览或者使用标准的GUI播放工具进行实时预览。
        /// 6.为保证数据的安全性，取流URL设有有效时间，有效时间为5分钟。
        /// </remarks>
        Task<CameraPreviewURLsV2Response> CameraPreviewURLsV2Async(CameraPreviewURLsV2Request request);


        /// <summary>
        /// 获取监控点回放取流URLv2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>
        /// 1.平台正常运行；平台已经添加过设备和监控点信息。
        /// 2.平台需要安装mgc取流服务。
        /// 3.通过openAPI获取到监控点数据，依据自身业务开发监控点导航界面。
        /// 4.根据监控点编号和回放起止时间调用本接口获取回放取流URL，协议类型包括：hik、rtsp、rtmp、hls（只支持云存储）。
        /// 5.通过开放平台的开发包进行录像回放或者使用标准的GUI播放工具进行录像回放。（开发包使用说明参考开发包的使用说明文档）。
        /// </remarks>
        Task<CameraPlaybackURLsV2Response> CameraPlaybackURLsV2Async(CameraPlaybackURLsV2Request request);


        /// <summary>
        /// 视频图片查询
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>通过该接口根据输入的图片的相对Uri地址，可以获取到具体的图片数据。</remarks>
        Task<CameraEventsPictureResponse> CameraEventsPictureAsync(CameraEventsPictureRequest request);

        /// <summary>
        /// 平台抓拍计划图片获取
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>支持根据输入的监控点编号集合，分页获取通过平台配置抓图计划抓取的图片信息；或根据图片唯一标识获取单张图片信息。若监控点编号集合和图片唯一标识均不传入，则分页查询出所有配置了抓图计划的监控点图片信息。同时按照调用方指定的排序方式对图片进行排序。进行图片查询操作的用户需要配置相应监控点的图片查询权限，该接口会根据传入的userId对数据进行权限过滤。        建议：使用本接口前请先进行校时，确保本地时间与当前系统时间保持一致。全量查询时，结束时间请在当前时间的基础上至少提前一天，确保数据分页的准确性。</remarks>
        Task<CameraPictureInfosResponse> CameraPictureInfosAsync(CameraPictureInfosRequest request);

        /// <summary>
        /// 手动抓图
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>该接口用于手动触发设备抓图，返回图片的地址，抓图前请确保平台上已配置图片存储信息。抓图时间为触发手动抓图命令的时间。</remarks>
        Task<ManualCaptureResponse> ManualCaptureResponse(ManualCaptureRequest request);
    }
}
