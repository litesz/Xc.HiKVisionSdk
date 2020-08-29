using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Pms.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms
{
    /// <summary>
    /// 停车场api
    /// </summary>
    public class HikPmsApiManager : IHikPmsApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikPmsApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<ParkRemainSpaceNumResponse> ParkRemainSpaceNumAsync(ParkRemainSpaceNumRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<ParkRemainSpaceNumRequest, ParkRemainSpaceNumResponse>("/api/pms/v1/park/remainSpaceNum", model, Const.V1_0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmCarAdditionResponse> AlarmCarAdditionAsync(AlarmCarAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmCarAdditionRequest, AlarmCarAdditionResponse>("/api/pms/v1/alarmCar/addition", model, Const.V1_2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmCarDeletionResponse> AlarmCarDeletionAsync(AlarmCarDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmCarDeletionRequest, AlarmCarDeletionResponse>("/api/pms/v1/alarmCar/deletion", model, Const.V1_2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmCarPageResponse> AlarmCarPageAsync(AlarmCarPageRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmCarPageRequest, AlarmCarPageResponse>("/api/pms/v1/alarmCar/page", model, Const.V1_2);
        }
    }
}
