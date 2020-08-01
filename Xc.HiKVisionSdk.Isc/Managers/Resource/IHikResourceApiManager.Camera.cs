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
    }
}
