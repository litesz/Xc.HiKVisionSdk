using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Mpc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc
{
    /// <summary>
    /// 园区卡口api
    /// </summary>
    public class HikMpcApiManager : IHikMpcApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikMpcApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 批量添加车辆黑名单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmBlackAddResponse> AlarmBlackAdd(AlarmBlackAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmBlackAddRequest, AlarmBlackAddResponse>("/artemis/api/mpc/v1/alarm/black/add", model, Const.V1_4);
        }


    }
}
