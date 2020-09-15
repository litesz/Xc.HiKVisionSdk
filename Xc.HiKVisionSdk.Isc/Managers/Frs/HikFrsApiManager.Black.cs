using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸api
    /// </summary>
    public partial class HikFrsApiManager : IHikFrsApiManager
    {
        /// <summary>
        /// 单个添加重点人员识别计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PlanRecognitionBlackAdditionResponse> PlanRecognitionBlackAdditionAsync(PlanRecognitionBlackAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackAdditionRequest, PlanRecognitionBlackAdditionResponse>("/api/frs/v1/plan/recognition/black/addition", model, Const.V1_2);

        }

        /// <summary>
        /// 删除重点人员识别计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PlanRecognitionBlackDeletionResponse> PlanRecognitionBlackDeletionAsync(PlanRecognitionBlackDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackDeletionRequest, PlanRecognitionBlackDeletionResponse>("/api/frs/v1/plan/recognition/black/deletion", model, Const.V1_2);

        }

        /// <summary>
        /// 单个修改重点人员识别计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PlanRecognitionBlackUpdateResponse> PlanRecognitionBlackUpdateAsync(PlanRecognitionBlackUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackUpdateRequest, PlanRecognitionBlackUpdateResponse>("/api/frs/v1/plan/recognition/black/update", model, Const.V1_2);
        }

        /// <summary>
        /// 单个查询重点人员识别计划详情
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PlanRecognitionBlackDetailResponse> PlanRecognitionBlackDetailAsync(PlanRecognitionBlackDetailRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackDetailRequest, PlanRecognitionBlackDetailResponse>("/api/frs/v1/plan/recognition/black/detail", model, Const.V1_2);
        }

        /// <summary>
        /// 查询重点人员识别计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PlanRecognitionBlackResponse> PlanRecognitionBlackAsync(PlanRecognitionBlackRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackRequest, PlanRecognitionBlackResponse>("/api/frs/v1/plan/recognition/black", model, Const.V1_2);
        }

        /// <summary>
        /// 重新下发重点人员识别计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PlanRecognitionBlackRestartResponse> PlanRecognitionBlackRestartAsync(PlanRecognitionBlackRestartRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackRestartRequest, PlanRecognitionBlackRestartResponse>("/api/frs/v1/plan/recognition/black/restart", model, Const.V1_2);
        }
    }
}
