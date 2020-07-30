using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Pms.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms
{
    /// <summary>
    /// 停车场api
    /// </summary>
    public interface IHikPmsApiManager
    {
        /// <summary>
        /// 查询停车库剩余车位数
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<ParkRemainSpaceNumResponse> ParkRemainSpaceNumAsync(ParkRemainSpaceNumRequest model);

        /// <summary>
        /// 车辆布控
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>简述：车辆被布控后，进出场时出入口岗亭会对车辆进行相应的布控措施，完善出入口管控场景；根据布控时间段进行管控，时间段为空时则全时段布控。        支持：支持通过车牌号或卡号进行车辆布控。</remarks>
        Task<AlarmCarAdditionResponse> AlarmCarAdditionAsync(AlarmCarAdditionRequest model);

        /// <summary>
        /// 取消车辆布控
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>简述：车辆取消布控后，进出场和普通车辆一样，不再被布控。
        /// 支持：支持通过布控车辆编号集合取消车辆布控。</remarks>
        Task<AlarmCarDeletionResponse> AlarmCarDeletionAsync(AlarmCarDeletionRequest model);

        /// <summary>
        /// 查询布控车辆
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<AlarmCarPageResponse> AlarmCarPageAsync(AlarmCarPageRequest model);
    }
}
