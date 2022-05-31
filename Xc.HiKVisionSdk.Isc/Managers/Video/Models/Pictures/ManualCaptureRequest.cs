using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Pictures
{
    /// <summary>
    /// 手动抓图请求
    /// </summary>
    public class ManualCaptureRequest : BaseRequest
    {
        /// <summary>
        /// 监控点唯一标识，        可通过分页获取监控点资源获取
        /// </summary>
        public string CameraIndexCode { get; set; }

        /// <summary>
        /// 手动抓图请求
        /// </summary>
        /// <param name="cameraIndexCode">监控点唯一标识，        可通过分页获取监控点资源获取</param>
        public ManualCaptureRequest(string cameraIndexCode)
        {
            CameraIndexCode = cameraIndexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(CameraIndexCode))
            {
                throw new System.ArgumentNullException(nameof(CameraIndexCode));
            }
        }
    }
}
