using System.Net.Http;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Commons.Managers;
using Xc.HiKVisionSdk.Models.Request;
using Xc.HiKVisionSdk.Models.Responses;

namespace Xc.HiKVisionSdk
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
        public static TResult PostAndGet<T, TResult>(this IHikVisionApiManager manager, string url, T body, decimal ver)
            where T : class, IBaseRequest
            where TResult : HiKVisionResponse
        {
            body.CheckParams();
            string bodyStr = body.ToString();
            var result = manager.PostAndGetString(url, bodyStr, ver);

            var output = Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(result);

            if (output.Status != 0)
            {
                throw new HttpRequestException(result);
            }

            return output;
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
        public static async Task<TResult> PostAndGetAsync<T, TResult>(this IHikVisionApiManager manager, string url, T body, decimal ver)
            where T : class, IBaseRequest
              where TResult : HiKVisionResponse
        {
            body.CheckParams();
            //string bodyStr = body?.SerializeByCamelCase();
            string bodyStr = body.ToString();
            var result = await manager.PostAndGetStringAsync(url, bodyStr, ver);

            var output = Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(result);

            if (output.Status != 0)
            {
                //output.Code = output.Status.ToString();
                //output
                throw new HttpRequestException(result);
            }
            return output;
        }

        public static async Task<TResult> GetAsync<TResult>(this IHikVisionApiManager manager, string url, decimal ver)
              where TResult : HiKVisionResponse
        {
            var result = await manager.GetAsync(url, ver);

            if (string.IsNullOrWhiteSpace(result))
            {
                return default;
            }

            var output = Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(result);

            if (output.Status != 0)
            {
                throw new HttpRequestException(result);
            }

            return output;
        }
    }
}
