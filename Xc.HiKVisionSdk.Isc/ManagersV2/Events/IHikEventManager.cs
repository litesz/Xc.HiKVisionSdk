using System;
using System.Collections.Generic;
using System.Text;
using Xc.HiKVisionSdk.Isc.Managers;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events
{
    /// <summary>
    /// 事件
    /// </summary>
    public interface IHikEventManager
    {
    }

    /// <summary>
    /// 事件
    /// </summary>
    public class HikEventManager : IHikEventManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 人员及照片管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEventManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

    }
}
