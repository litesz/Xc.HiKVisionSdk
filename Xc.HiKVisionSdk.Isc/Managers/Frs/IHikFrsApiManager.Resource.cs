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
        /// 按条件查询识别资源
        /// 
        /// </summary>
        /// <remarks>a)根据条件，查询识别资源。
        /// b)该接口和识别计划配置有关，识别计划配置时需要选择识别资源，通过该接口查询。
        /// c)查询接口之间的关系为与，若不传任何条件，为查询全部的识别资源。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<RecognitionResponse> ResourceRecognitionAsync(RecognitionRequest model);



    }
}
