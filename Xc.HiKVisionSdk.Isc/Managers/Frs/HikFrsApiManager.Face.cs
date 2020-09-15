using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HikFrsApiManager
    {
        /// <summary>
        /// 单个添加人脸
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceSingleAdditionResponse> FaceSingleAdditionAsync(FaceSingleAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceSingleAdditionRequest, FaceSingleAdditionResponse>("/api/frs/v1/face/single/addition", model, Const.V1_2);
        }

        /// <summary>
        /// 批量添加人脸
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceBatchAdditionResponse> FaceBatchAdditionAsync(FaceBatchAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceBatchAdditionRequestItem[], FaceBatchAdditionResponse>("/api/frs/v1/face/batch/addition", model.Items, Const.V1_2);
        }

        /// <summary>
        /// 批量删除人脸
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceBatchDeletionResponse> FaceBatchDeletionAsync(FaceBatchDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceBatchDeletionRequest, FaceBatchDeletionResponse>("/api/frs/v1/face/deletion", model, Const.V1_2);
        }

        /// <summary>
        /// 单个修改人脸
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceSingleUpdateResponse> FaceSingleUpdateAsync(FaceSingleUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceSingleUpdateRequest, FaceSingleUpdateResponse>("/api/frs/v1/face/single/update", model, Const.V1_2);
        }

        /// <summary>
        /// 按条件批量查询人脸
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceResponse> FaceAsync(FaceRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceRequest, FaceResponse>("/api/frs/v1/face", model, Const.V1_2);
        }

        /// <summary>
        /// 批量拷贝人脸到人脸分组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceBatchCopyResponse> FaceBatchCopyAsync(FaceBatchCopyRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceBatchCopyRequest, FaceBatchCopyResponse>("/api/frs/v1/face/batch/copy", model, Const.V1_2);
        }
    }
}
