using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸应用服务
    /// </summary>
    public partial interface IHikFrsApiManager
    {
        /// <summary>
        /// 单个添加人脸分组
        /// 
        /// </summary>
        /// <remarks>一次性添加一个人脸分组，返回结果为添加成功的人脸分组。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceGroupSingleAdditionResponse> FaceGroupSingleAdditionAsync(FaceGroupSingleAdditionRequest model);

        /// <summary>
        /// 删除人脸分组
        /// 
        /// </summary>
        /// <remarks>a)根据删除条件，删除一批人脸分组,最大1000个，返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)已经配置有识别计划的人脸分组，不允许删除，由特定错误码标识。
        /// c)根据唯一标识删除时，会校验唯一标识的有效性，若任意分组唯一标识无效，则返回错误。传入的唯一标识重复，做去重处理。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceGroupBatchDeletionResponse> FaceGroupBatchDeletionAsync(FaceGroupBatchDeletionRequest model);

        /// <summary>
        /// 单个修改人脸分组
        /// 
        /// </summary>
        /// <remarks>a)修改单个人脸分组，返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)修改后的字段信息以修改时传入的字段为准，若不传字段或传入null字段，则该字段会被置为null。
        /// c)若该人脸分组已经被配置到识别计划中，则修改人脸分组后，会将修改后的信息，一并下发到设备上。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceGroupSingleUpdateResponse> FaceGroupSingleUpdateAsync(FaceGroupSingleUpdateRequest model);

        /// <summary>
        /// 按条件查询人脸分组
        ///
        /// </summary>
        /// <remarks> a)根据查询条件，查询人脸分组集合。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceGroupResponse> FaceGroupAsync(FaceGroupRequest model);
      
    }
}
