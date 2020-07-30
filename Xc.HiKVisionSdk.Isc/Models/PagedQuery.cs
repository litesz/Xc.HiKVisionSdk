using Xc.HiKVisionSdk.Isc.Models.Common;

namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 分页查询
    /// </summary>
    public class PagedQuery : IRequestModel, IPagedQuery
    {
        /// <summary>
        /// 尺寸
        /// </summary>
        public int PageSize { get; set; } = 1;
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNo { get; set; } = 1;
    }




}
