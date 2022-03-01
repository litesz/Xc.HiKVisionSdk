using Xc.HiKVisionSdk.Isc.Models.Common;

namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 分页查询
    /// </summary>
    public class PagedQuery : IRequestModel, IPagedQuery
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        public PagedQuery()
        {
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        public PagedQuery(int pageNo, int pageSize)
        {
            if (pageNo < 0)
            {
                PageNo = 1;
            }
            else
            {
                PageNo = pageNo;
            }

            if (pageSize < 0)
            {
                PageSize = 1;
            }
            else if (pageSize > 1000)
            {
                PageSize = 1000;
            }
            else
            {
                PageSize = pageSize;
            }
        }


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
