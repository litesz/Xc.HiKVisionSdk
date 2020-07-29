using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{

    public partial class HikFrsApiManager : IHikFrsApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        public HikFrsApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        #region resource

        public Task<RecognitionResponse> ResourceRecognitionAsync(RecognitionRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<RecognitionRequest, RecognitionResponse>("/artemis/api/frs/v1/resource/recognition", model, Const.V1_2);
        }

        #endregion


       
    }
}
