using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 根据编号获取监控点详细信息请求
    /// </summary>
    public class CamerasIndexCodeRequest : BaseRequest
    {
        /// <summary>
        /// 监控点编号，
        /// 可通过分页获取监控点资源获取
        /// </summary>
        public string CameraIndexCode { get; set; }

        /// <summary>
        /// 根据编号获取监控点详细信息请求
        /// </summary>
        /// <param name="cameraIndexCode">监控点编号</param>
        public CamerasIndexCodeRequest(string cameraIndexCode)
        {
            CameraIndexCode = cameraIndexCode;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(CameraIndexCode))
            {
                throw new ArgumentNullException(nameof(CameraIndexCode));
            }
        }
    }
}
