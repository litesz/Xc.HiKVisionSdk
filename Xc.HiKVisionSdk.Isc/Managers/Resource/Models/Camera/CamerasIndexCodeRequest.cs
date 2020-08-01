namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 根据编号获取监控点详细信息请求
    /// </summary>
    public class CamerasIndexCodeRequest
    {
        /// <summary>
        /// 监控点编号，
        /// 可通过分页获取监控点资源获取
        /// </summary>
        public string cameraIndexCode { get; set; }
    }
}
