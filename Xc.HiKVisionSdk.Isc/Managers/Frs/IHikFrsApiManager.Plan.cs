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
        /// 获取人脸及分组关联关系
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>
        /// a)已经配置了一条或多条识别计划。
        /// b)调用方获取到人脸比对事件后，可通过调用该接口获取关联关系，将人脸比对事件报文中的人脸编号、分组编号和人脸监控应用服务中相对应。
        /// c)调用方可在识别计划下发完成后调用该接口获取关联关系。
        /// d)严禁在事件接收时调用此接口，避免造成接口性能不佳。
        /// </remarks>
        Task<GetFaceRelationResponse> GetFaceRelationAsync(GetFaceRelationRequest model);

        /// <summary>
        /// 抓拍计划配置
        /// </summary>
        /// <param name="model"></param>
        /// <returns>
        /// a)配置平台的抓拍计划，目前支持开启和关闭两种操作。
        /// b)当抓拍计划关闭后，也就无法从消息队列中获取到人脸抓拍事件了。
        /// c)关闭抓拍计划不会影响到识别计划，因此人脸比对报警、重点人员识别报警、陌生人识别报警，仍旧会上报。
        /// d)关闭抓拍计划的接口，是为了在部分场景下，去除无用的抓拍事件。这样可以释放消息队列、事件服务和人脸监控的压力，将性能用在更需要的地方。
        /// e)重复的开启或者关闭，接口会返回成功。
        /// </returns>
        Task<GetFaceRelationResponse> CaptureConfigurationAsync(CaptureConfigurationRequest model);
    }
}
