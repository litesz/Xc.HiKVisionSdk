namespace Xc.HiKVisionSdk.Isc.Models.Common
{
    /// <summary>
    /// 分页
    /// </summary>
    public interface IPagedQuery
    {
        /// <summary>
        /// 页容量
        /// </summary>
        int PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        int PageNo { get; set; }
    }

}
