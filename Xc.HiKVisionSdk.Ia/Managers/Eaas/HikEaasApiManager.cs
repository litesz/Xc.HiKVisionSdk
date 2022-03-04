

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas
{
    /// <summary>
    /// 资源api
    /// </summary>
    public partial class HikEaasApiManager : IHikEaasApiManager
    {
        private readonly IHikVisionIaApiManager _hikVisionApiManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEaasApiManager(IHikVisionIaApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }





    }
}
