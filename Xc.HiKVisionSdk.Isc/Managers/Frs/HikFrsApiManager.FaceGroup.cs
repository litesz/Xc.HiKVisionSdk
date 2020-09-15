using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸识别api
    /// </summary>
    public partial class HikFrsApiManager
    {
        /// <summary>
        /// 单个添加人脸分组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceGroupSingleAdditionResponse> FaceGroupSingleAdditionAsync(FaceGroupSingleAdditionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupSingleAdditionRequest, FaceGroupSingleAdditionResponse>("/api/frs/v1/face/group/single/addition", model, Const.V1_2);
        }

        /// <summary>
        /// 删除人脸分组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceGroupBatchDeletionResponse> FaceGroupBatchDeletionAsync(FaceGroupBatchDeletionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupBatchDeletionRequest, FaceGroupBatchDeletionResponse>("/api/frs/v1/face/group/batch/deletion", model, Const.V1_2);
        }

        /// <summary>
        /// 单个修改人脸分组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceGroupSingleUpdateResponse> FaceGroupSingleUpdateAsync(FaceGroupSingleUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupSingleUpdateRequest, FaceGroupSingleUpdateResponse>("/api/frs/v1/face/group/single/update", model, Const.V1_2);
        }

        /// <summary>
        /// 按条件查询人脸分组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<FaceGroupResponse> FaceGroupAsync(FaceGroupRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<FaceGroupRequest, FaceGroupResponse>("/api/frs/v1/face/group", model, Const.V1_2);
        }
    }
}
