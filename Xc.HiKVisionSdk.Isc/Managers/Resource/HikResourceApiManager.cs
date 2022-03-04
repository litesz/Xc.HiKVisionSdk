namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    /// <summary>
    /// 资源api
    /// </summary>
    public partial class HikResourceApiManager : IHikResourceApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikResourceApiManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }





    }
}
