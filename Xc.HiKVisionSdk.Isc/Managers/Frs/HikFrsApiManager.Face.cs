using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    public partial class HikFrsApiManager
    {
        public Task<FaceSingleAdditionResponse> FaceSingleAdditionAsync(FaceSingleAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceSingleAdditionRequest, FaceSingleAdditionResponse>("/artemis/api/frs/v1/face/single/addition", model, Const.V1_2);
        }

        public Task<FaceBatchAdditionResponse> FaceBatchAdditionAsync(FaceBatchAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceBatchAdditionRequestItem[], FaceBatchAdditionResponse>("/artemis/api/frs/v1/face/batch/addition", model.Items, Const.V1_2);
        }

        public Task<FaceBatchDeletionResponse> FaceBatchDeletionAsync(FaceBatchDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceBatchDeletionRequest, FaceBatchDeletionResponse>("/artemis/api/frs/v1/face/deletion", model, Const.V1_2);
        }

        public Task<FaceSingleUpdateResponse> FaceSingleUpdateAsync(FaceSingleUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceSingleUpdateRequest, FaceSingleUpdateResponse>("/artemis/api/frs/v1/face/single/update", model, Const.V1_2);
        }

        public Task<FaceResponse> FaceAsync(FaceRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceRequest, FaceResponse>("/artemis/api/frs/v1/face", model, Const.V1_2);
        }

        public Task<FaceBatchCopyResponse> FaceBatchCopyAsync(FaceBatchCopyRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceBatchCopyRequest, FaceBatchCopyResponse>("/artemis/api/frs/v1/face/batch/copy", model, Const.V1_2);
        }
    }
}
