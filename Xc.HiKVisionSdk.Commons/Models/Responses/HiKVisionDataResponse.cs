namespace Xc.HiKVisionSdk.Models.Responses
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

    /// <summary>
    /// 空data返回值
    /// </summary>
    public class HiKVisionDataResponse : HiKVisionResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        public string Data { get; set; }
    }


}
