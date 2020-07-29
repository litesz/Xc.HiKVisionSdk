using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    public partial class HikFrsApiManager
    {
        public Task<FaceGroupSingleAdditionResponse> FaceGroupSingleAdditionAsync(FaceGroupSingleAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupSingleAdditionRequest, FaceGroupSingleAdditionResponse>("/artemis/api/frs/v1/face/group/single/addition", model, Const.V1_2);
        }

        public Task<FaceGroupBatchDeletionResponse> FaceGroupBatchDeletionAsync(FaceGroupBatchDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupBatchDeletionRequest, FaceGroupBatchDeletionResponse>("/artemis/api/frs/v1/face/group/batch/deletion", model, Const.V1_2);
        }

        public Task<FaceGroupSingleUpdateResponse> FaceGroupSingleUpdateAsync(FaceGroupSingleUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupSingleUpdateRequest, FaceGroupSingleUpdateResponse>("/artemis/api/frs/v1/face/group/single/update", model, Const.V1_2);
        }

        public Task<FaceGroupResponse> FaceGroupAsync(FaceGroupRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupRequest, FaceGroupResponse>("/artemis/api/frs/v1/face/group", model, Const.V1_2);
        }
    }
}
