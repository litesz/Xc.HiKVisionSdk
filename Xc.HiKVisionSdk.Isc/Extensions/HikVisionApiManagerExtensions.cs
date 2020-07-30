using System.Threading.Tasks;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    /// <summary>
    /// POST扩展
    /// </summary>
    public static class HikVisionApiManagerExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="manager"></param>
        /// <param name="url"></param>
        /// <param name="body"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        internal static TResult PostAndGet<T, TResult>(this IHikVisionApiManager manager, string url, T body, decimal ver) where T : class
        {
            string bodyStr = body?.SerializeByCamelCase();
            var result = manager.PostAndGetString(url, bodyStr, ver);

            if (string.IsNullOrWhiteSpace(result))
            {
                return default;
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(result);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="manager"></param>
        /// <param name="url"></param>
        /// <param name="body"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        internal static async Task<TResult> PostAndGetAsync<T, TResult>(this IHikVisionApiManager manager, string url, T body, decimal ver) where T : class
        {
            string bodyStr = body?.SerializeByCamelCase();

            var result = await manager.PostAndGetStringAsync(url, bodyStr, ver);

            if (string.IsNullOrWhiteSpace(result))
            {
                return default;
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(result);
        }





    }
}
