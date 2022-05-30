using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 分页获取监控点资源请求
    /// </summary>
    public class CamerasRequest : PagedRequest
    {

        /// <summary>
        /// 分页获取监控点资源请求
        /// </summary>
        public CamerasRequest() { }

        /// <summary>
        /// 分页获取监控点资源请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public CamerasRequest(int pageNo, int pageSize) : base(pageNo, pageSize) { }

    }
}
