using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Acs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Acs
{
    /// <summary>
    /// 门禁api
    /// </summary>
    public interface IHikAcsApiManager
    {
        /// <summary>
        /// 查询门禁点事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>功能描述：该接口可以查询发生在门禁点上的人员出入事件，支持多个维度来查询，支持按时间、人员、门禁点、事件类型四个维度来查询；其中按事件类型来查询的方式，如果查询不到事件，存在两种情况，一种是该类型的事件没有发生过，所以查询不到，还有一种情况，该类型的事件发生过，但是由于门禁管理组件对该事件类型订阅配置处于关闭状态，所以不会存储该类型的事件，导致查询不到，对于这种情况，需要到门禁管理组件中，将该事件类型的订阅配置打开。</remarks>
        Task<DoorEventsResponse> DoorEventsAsync(DoorEventsRequest model);
        /// <summary>
        /// 查询门禁点事件v2
        /// </summary>
        /// <remarks>功能描述：该接口可以查询发生在门禁点上的人员出入事件，支持多个维度来查询，支持按时间、人员、门禁点、事件类型四个维度来查询；其中按事件类型来查询的方式，如果查询不到事件，存在两种情况，一种是该类型的事件没有发生过，所以查询不到，还有一种情况，该类型的事件发生过，但是由于门禁管理组件对该事件类型订阅配置处于关闭状态，所以不会存储该类型的事件，导致查询不到，对于这种情况，需要到门禁管理组件中，将该事件类型的订阅配置打开。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<DoorEventsV2Response> DoorEventsV2Async(DoorEventsV2Request model);

        /// <summary>
        /// 查询门禁点列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据条件查询目录下有权限的门禁点列表。当返回字段对应的值为空时，该字段不返回。</remarks>
        Task<DoorSearchV2Response> DoorSearchV2Async(DoorSearchV2Request model);

       
    }
}
