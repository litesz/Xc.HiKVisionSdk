using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Mpc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc
{
    public class HikMpcApiManager : IHikMpcApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        public HikMpcApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }


        public Task<AlarmBlackAddResponse> AlarmBlackAdd(AlarmBlackAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmBlackAddRequest, AlarmBlackAddResponse>("/artemis/api/mpc/v1/alarm/black/add", model, Const.V1_4);
        }


    }
}
