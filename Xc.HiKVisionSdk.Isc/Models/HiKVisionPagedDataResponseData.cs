namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 分页信息,切勿直接继承
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class HiKVisionPagedDataResponseData<T>
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNo { get; set; }
        /// <summary>
        /// 尺寸
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 具体数据
        /// </summary>
        public T[] List { get; set; }
    }




}
