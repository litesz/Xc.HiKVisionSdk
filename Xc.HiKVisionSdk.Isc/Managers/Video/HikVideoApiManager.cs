namespace Xc.HiKVisionSdk.Isc.Managers.Video
{
    /// <summary>
    /// 视频api
    /// </summary>
    public partial class HikVideoApiManager : IHikVideoApiManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikVideoApiManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }





    }
}
