using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Acs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Acs
{
    /// <summary>
    /// 门禁api
    /// </summary>
    public class HikAcsApiManager : IHikAcsApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikAcsApiManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DoorEventsResponse> DoorEventsAsync(DoorEventsRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<DoorEventsRequest, DoorEventsResponse>("/api/acs/v1/door/events", model, VersionConsts.V1_0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DoorEventsV2Response> DoorEventsV2Async(DoorEventsV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<DoorEventsV2Request, DoorEventsV2Response>("/api/acs/v2/door/events", model, VersionConsts.V1_41);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DoorSearchV2Response> DoorSearchV2Async(DoorSearchV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<DoorSearchV2Request, DoorSearchV2Response>("/api/resource/v2/door/search", model, VersionConsts.V1_4);
        }


    }
}
