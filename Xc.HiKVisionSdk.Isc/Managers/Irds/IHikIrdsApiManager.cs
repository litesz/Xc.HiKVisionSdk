using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Irds.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Irds
{
    /// <summary>
    /// 卡片API
    /// </summary>
    public interface IHikIrdsApiManager
    {
        
        /// <summary>
        /// 获取单个卡片信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>获取卡片列表接口可用来全量同步卡片信息，返回结果分页展示，不作权限过滤。
        /// 注：卡号为精确查找</remarks>
        Task<CardInfoResponse> CardInfoAsync(CardInfoRequest request);
    }
}
