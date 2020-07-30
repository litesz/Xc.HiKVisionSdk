namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 泛型data返回值
    /// T Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HiKVisionDataResponse<T> : HiKVisionResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        public T Data { get; set; }
    }




}
