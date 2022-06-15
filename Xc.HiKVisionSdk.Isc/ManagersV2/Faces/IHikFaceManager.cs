using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.ManagersV2.Faces.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Faces
{
    /// <summary>
    /// 人脸管理
    /// <list type="bullet">
    /// <item>
    /// <term>AddAsync</term>
    /// <description>添加人脸</description>
    /// </item>
    /// <item>
    /// <term>UpdateAsync</term>
    /// <description>修改人脸</description>
    /// </item>
    /// <item>
    /// <term>DeleteAsync</term>
    /// <description>删除人脸</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IHikFaceManager
    {
        /// <summary>
        /// 添加人脸
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>添加人脸信息。</remarks>
        Task<AddFaceResponse> AddAsync(AddFaceRequest request);

        /// <summary>
        /// 修改人脸
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据人脸Id修改人脸。</remarks>
        Task<UpdateFaceResponse> UpdateAsync(UpdateFaceRequest request);

        /// <summary>
        /// 删除人脸
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据人脸Id删除人脸。</remarks>
        Task<DeleteFaceResponse> DeleteAsync(DeleteFaceRequest request);
    }
}
