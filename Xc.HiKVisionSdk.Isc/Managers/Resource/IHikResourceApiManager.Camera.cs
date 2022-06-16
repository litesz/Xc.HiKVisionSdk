using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 资源api
    /// </summary>
    public partial interface IHikResourceApiManager
    {

        /// <summary>
        /// 查询监控点列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>查询监控点列表接口可以根据监控点唯一标识集、监控点名称、编码设备唯一标识、区域唯一标识、是否级联这些查询条件来进行高级查询；若不指定查询条件，即全量获取所有的监控点信息。返回结果分页展示。
        /// 注：若指定多个查询条件，表示将这些查询条件进行”与”的组合后进行精确查询。
        /// 根据”监控点名称cameraName”查询为模糊查询。</remarks>
        Task<AdvanceCameraListResponse> AdvanceCameraListAsync(AdvanceCameraListRequest model);

        /// <summary>
        /// 查询监控点列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据条件查询目录下有权限的监控点列表。        当返回字段对应的值为空时，该字段不返回。</remarks>
        Task<CameraSearchV2Response> CamerSearchV2Async(CameraSearchV2Request model);


        /// <summary>
        /// 分页获取监控点资源
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>获取监控点列表接口可用来全量同步监控点信息，返回结果分页展示。</remarks>
        Task<CamerasResponse> CamerasAsync(CamerasRequest model);

        /// <summary>
        /// 根据编号获取监控点详细信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>获取单个监控点信息是指根据监控点唯一标识来获取指定的监控点信息。</remarks>
        Task<CamerasIndexCodeResponse> CamerasIndexCodeAsync(CamerasIndexCodeRequest model);

        /// <summary>
        /// 根据区域编号获取下级监控点列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据指定的区域编号获取该区域下的监控点列表信息，返回结果分页展示。        注：返回的监控点不包括下级区域的。</remarks>
        Task<RegionIndexCodeCamerasResponse> RegionIndexCodeCamerasAsync(RegionIndexCodeCamerasRequest model);

        ///// <summary>
        ///// 增量获取监控点数据
        ///// </summary>
        ///// <param name="request">请求</param>
        ///// <returns></returns>
        ///// <remarks>根据资源类型、时间段增量获取资源，包含已删除数据。其中开始日期与结束日期的时间差必须在1-48小时内。        当返回字段对应的值为空时，该字段不返回。</remarks>
        //Task<CameraTimeRangeResponse> CameraTimeRangeAsync(CameraTimeRangeRequest request);
    }
}
