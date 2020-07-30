namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 包含分页的泛型返回值
    /// HiKVisionPagedDataResponseData Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HiKVisionPagedDataResponse<T> : HiKVisionResponse
    {
        /// <summary>
        /// 分页结果
        /// </summary>
        public HiKVisionPagedDataResponseData<T> Data { get; set; }
    }




}
