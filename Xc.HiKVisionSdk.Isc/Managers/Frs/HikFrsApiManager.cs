using System;
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
        private readonly IHikVisionApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikFrsApiManager(IHikVisionApiManager hikVisionApiManager)
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
            return _hikVisionApiManager.PostAndGetAsync<RecognitionRequest, RecognitionResponse>("/artemis/api/frs/v1/resource/recognition", model, Const.V1_2);
        }



       
    }
}
