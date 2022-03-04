using System.Threading.Tasks;
using Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile;

namespace Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine
{
    /// <summary>
    /// 配置api
    /// </summary>
    public partial interface IHikEattendanceEngineApiManager
    {


        /// <summary>
        /// 查询是否是指定打卡地点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>查询是否是指定打卡地点,移动端调用此接口，可识别员工是否需要在指定区域进行打卡</remarks>
        Task<QueryIsCardResponse> QueryIsCardAsync(QueryIsCardRequest model);

        /// <summary>
        /// 查询高德授权密钥
        /// </summary>
        /// <returns></returns>
        Task<QueryGaoDeKeyResponse> QueryGaoDeKeyAsync();

        /// <summary>
        /// 获取移动考勤有效打卡地点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>获取移动考勤有效打卡地点</remarks>
        Task<QueryMobileCardResponse> QueryMobileCardAsync(QueryMobileCardRequest model);
    }
}
