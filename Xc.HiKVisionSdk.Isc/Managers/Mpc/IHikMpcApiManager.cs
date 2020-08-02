using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Mpc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc
{
    /// <summary>
    /// 园区卡口api
    /// </summary>
    public interface IHikMpcApiManager
    {
        /// <summary>
        /// 批量添加车辆黑名单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>批量添加车辆黑名单，该车辆布控为黑名单后，当有过车事件上报时，会产生对应的黑名单事件，一次添加最大不超过400个车辆黑名单。</remarks>
        Task<AlarmBlackAddResponse> AlarmBlackAdd(AlarmBlackAddRequest model);
    }
}
