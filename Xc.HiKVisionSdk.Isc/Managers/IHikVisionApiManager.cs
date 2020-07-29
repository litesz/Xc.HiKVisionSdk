using System.Threading.Tasks;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    public interface IHikVisionApiManager
    {
        /// <summary>
        /// get
        /// </summary>
        /// <param name="url"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        string GetString(string url, decimal ver);
        /// <summary>
        /// 异步get
        /// </summary>
        /// <param name="url"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        Task<string> GetStringAsync(string url, decimal ver);
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

        byte[] GetImageBytes(string url);
    }
}
