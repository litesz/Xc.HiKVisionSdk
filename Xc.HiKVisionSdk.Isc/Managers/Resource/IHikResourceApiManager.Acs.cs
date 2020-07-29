using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    public partial interface IHikResourceApiManager
    {
      
        /// <summary>
        /// 查询门禁点列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>查询门禁点列表接口可以根据门禁点唯一标识集、门禁点名称、门禁设备唯一标识、所属区域唯一标识这些查询条件来进行高级查询；若不指定查询条件，即全量获取所有的门禁点信息。返回结果分页展示。
        /// 注：若指定多个查询条件，表示将这些查询条件进行”与”的组合后进行精确查询。
        /// 根据”门禁点名称doorName”查询为模糊查询。</remarks>
        Task<AcsDoorAdvanceAcsDoorListResponse> AcsDoorAdvanceAcsDoorListAsync(AcsDoorAdvanceAcsDoorListRequest model);

    }
}
