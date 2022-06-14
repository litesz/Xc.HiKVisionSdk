using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Faces.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Faces
{
    /// <summary>
    /// 人脸管理
    /// </summary>
    public class HikFaceManager : IHikFaceManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 人员及照片管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikFaceManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<AddFaceResponse> AddAsync(AddFaceRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<AddFaceRequest, AddFaceResponse>("/api/resource/v1/face/single/add", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 修改人脸
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<UpdateFaceResponse> UpdateAsync(UpdateFaceRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<UpdateFaceRequest, UpdateFaceResponse>("/api/resource/v1/face/single/update", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 删除人脸
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<DeleteFaceResponse> DeleteAsync(DeleteFaceRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<DeleteFaceRequest, DeleteFaceResponse>("/api/resource/v1/face/single/delete", request, VersionConsts.V1_5);
        }

    }
}
