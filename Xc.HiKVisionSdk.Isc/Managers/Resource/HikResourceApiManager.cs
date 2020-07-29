namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    public partial class HikResourceApiManager : IHikResourceApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        public HikResourceApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }





    }
}
