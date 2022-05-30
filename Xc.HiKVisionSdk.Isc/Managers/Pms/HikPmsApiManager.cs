using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Pms.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms
{
    /// <summary>
    /// 停车场api
    /// </summary>
    public class HikPmsApiManager : IHikPmsApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikPmsApiManager(IHikVisionIscApiManager hikVisionApiManager)
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
            return _hikVisionApiManager.PostAndGetAsync<ParkRemainSpaceNumRequest, ParkRemainSpaceNumResponse>("/api/pms/v1/park/remainSpaceNum", model, VersionConsts.V1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmCarAdditionResponse> AlarmCarAdditionAsync(AlarmCarAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmCarAdditionRequest, AlarmCarAdditionResponse>("/api/pms/v1/alarmCar/addition", model, VersionConsts.V1_2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmCarDeletionResponse> AlarmCarDeletionAsync(AlarmCarDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmCarDeletionRequest, AlarmCarDeletionResponse>("/api/pms/v1/alarmCar/deletion", model, VersionConsts.V1_2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmCarPageResponse> AlarmCarPageAsync(AlarmCarPageRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmCarPageRequest, AlarmCarPageResponse>("/api/pms/v1/alarmCar/page", model, VersionConsts.V1_2);
        }
    }
}
