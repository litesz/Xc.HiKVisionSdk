using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸应用服务
    /// </summary>
    public partial interface IHikFrsApiManager
    {
        /// <summary>
        /// 按条件查询重点人员事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// a)按条件查询重点人员事件。
        /// b)检索出来的结果是分页的集合，分页参数由接口参数传入。
        /// </remarks>
        Task<EventBlackSearchResponse> EventBlackSearch(EventBlackSearchRequest model);

    }
}
