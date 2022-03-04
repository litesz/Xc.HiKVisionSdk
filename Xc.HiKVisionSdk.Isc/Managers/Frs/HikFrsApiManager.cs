﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸识别api
    /// </summary>
    public partial class HikFrsApiManager : IHikFrsApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikFrsApiManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 按条件查询识别资源
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<RecognitionResponse> ResourceRecognitionAsync(RecognitionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<RecognitionRequest, RecognitionResponse>("/api/frs/v1/resource/recognition", model, VersionConsts.V1_2);
        }



       
    }
}
