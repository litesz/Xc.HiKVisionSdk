using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{

    public partial class HikFrsApiManager : IHikFrsApiManager
    {
        public Task<PlanRecognitionBlackAdditionResponse> PlanRecognitionBlackAdditionAsync(PlanRecognitionBlackAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackAdditionRequest, PlanRecognitionBlackAdditionResponse>("/artemis/api/frs/v1/plan/recognition/black/addition", model, Const.V1_2);

        }


        public Task<PlanRecognitionBlackDeletionResponse> PlanRecognitionBlackDeletionAsync(PlanRecognitionBlackDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackDeletionRequest, PlanRecognitionBlackDeletionResponse>("/artemis/api/frs/v1/plan/recognition/black/deletion", model, Const.V1_2);

        }

        public Task<PlanRecognitionBlackUpdateResponse> PlanRecognitionBlackUpdateAsync(PlanRecognitionBlackUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackUpdateRequest, PlanRecognitionBlackUpdateResponse>("/artemis/api/frs/v1/plan/recognition/black/update", model, Const.V1_2);
        }

        public Task<PlanRecognitionBlackDetailResponse> PlanRecognitionBlackDetailAsync(PlanRecognitionBlackDetailRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackDetailRequest, PlanRecognitionBlackDetailResponse>("/artemis/api/frs/v1/plan/recognition/black/detail", model, Const.V1_2);
        }

        public Task<PlanRecognitionBlackResponse> PlanRecognitionBlackAsync(PlanRecognitionBlackRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackRequest, PlanRecognitionBlackResponse>("/artemis/api/frs/v1/plan/recognition/black", model, Const.V1_2);
        }

        public Task<PlanRecognitionBlackRestartResponse> PlanRecognitionBlackRestartAsync(PlanRecognitionBlackRestartRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PlanRecognitionBlackRestartRequest, PlanRecognitionBlackRestartResponse>("/artemis/api/frs/v1/plan/recognition/black/restart", model, Const.V1_2);
        }
    }
}
