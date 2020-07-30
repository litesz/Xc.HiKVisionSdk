namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 泛型data数组返回值
    /// T[] Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HiKVisionDataArrayResponse<T> : HiKVisionResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        public T[] Data { get; set; }
    }




}
