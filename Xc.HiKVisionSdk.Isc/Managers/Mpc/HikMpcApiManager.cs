﻿using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Mpc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc
{
    /// <summary>
    /// 园区卡口api
    /// </summary>
    public class HikMpcApiManager : IHikMpcApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikMpcApiManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 批量添加车辆黑名单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AlarmBlackAddResponse> AlarmBlackAdd(AlarmBlackAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AlarmBlackAddRequest, AlarmBlackAddResponse>("/api/mpc/v1/alarm/black/add", model, VersionConsts.V1_4);
        }


    }
}
