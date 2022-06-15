using System.Net.Http;
using System.Threading.Tasks;

namespace Xc.HiKVisionSdk.Commons.Managers
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHikVisionApiManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bodyStr"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostAsync(string url, string bodyStr, decimal ver);

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

        /// <summary>
        /// get
        /// </summary>
        /// <param name="url"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        Task<string> GetAsync(string url, decimal ver);
    }
}
