

using System.Threading.Tasks;
using Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile;

namespace Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine

{
    /// <summary>
    /// 配置api
    /// </summary>
    public partial class HikEattendanceEngineApiManager : IHikEattendanceEngineApiManager
    {
        private readonly IHikVisionIaApiManager _hikVisionApiManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEattendanceEngineApiManager(IHikVisionIaApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }


        /// <summary>
        /// 查询是否是指定打卡地点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<QueryIsCardResponse> QueryIsCardAsync(QueryIsCardRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<QueryIsCardRequest, QueryIsCardResponse>("/api/eattendance-engine/v1/mobile/card/query/is/card", model, VersionConsts.V1_0);
        }

        /// <summary>
        /// 查询高德授权密钥
        /// </summary>
        /// <returns></returns>
        public Task<QueryGaoDeKeyResponse> QueryGaoDeKeyAsync()
        {
            return _hikVisionApiManager.GetAsync<QueryGaoDeKeyResponse>("/api/eattendance-engine/v1/mobile/card/query/gaoDe/key", VersionConsts.V1_0);
        }

        /// <summary>
        /// 获取移动考勤有效打卡地点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<QueryMobileCardResponse> QueryMobileCardAsync(QueryMobileCardRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<QueryMobileCardRequest, QueryMobileCardResponse>("/api/eattendance-engine/v1/mobile/card/query/mobile/card", model, VersionConsts.V1_0);
        }


    }
}
