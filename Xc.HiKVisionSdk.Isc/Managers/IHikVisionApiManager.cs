using System.Threading.Tasks;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    /// <summary>
    /// 网络实现
    /// </summary>
    public interface IHikVisionApiManager
    {
        /// <summary>
        /// post
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bodyStr"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        string PostAndGetString(string url, string bodyStr, decimal ver);

        /// <summary>
        /// 异步post
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bodyStr"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        Task<string> PostAndGetStringAsync(string url, string bodyStr, decimal ver);

    }
}
