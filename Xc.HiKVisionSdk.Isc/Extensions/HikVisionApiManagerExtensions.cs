using System.Threading.Tasks;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    public static class HikVisionApiManagerExtensions
    {
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
