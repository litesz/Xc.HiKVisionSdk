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
        /// 按条件查询重点人员事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<GetFaceRelationResponse> GetFaceRelationAsync(GetFaceRelationRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetFaceRelationRequest, GetFaceRelationResponse>("/api/frs/v1/plan/getFaceRelation", model, Const.V1_2);
        }


        /// <summary>
        /// 抓拍计划配置
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<GetFaceRelationResponse> CaptureConfigurationAsync(CaptureConfigurationRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CaptureConfigurationRequest, GetFaceRelationResponse>("/api/frs/v1/plan/capture/configuration", model, Const.V1_2);
        }

    }
}
