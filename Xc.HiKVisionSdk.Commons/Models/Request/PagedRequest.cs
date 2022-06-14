namespace Xc.HiKVisionSdk.Models.Request
{




    /// <summary>
    /// 分页查询
    /// </summary>
    public class PagedRequest : BaseRequest, IBaseRequest, IPagedRequest
    {
        /// <summary>
        /// 尺寸
        /// </summary>
        public int PageSize { get; set; } = 1;
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNo { get; set; } = 1;

        /// <summary>
        /// 分页查询
        /// </summary>
        public PagedRequest()
        {
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        public PagedRequest(int pageNo, int pageSize)
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


        public override void CheckParams()
        {
            if (PageSize < 1 || PageSize > 1000)
            {
                throw new System.ArgumentOutOfRangeException(nameof(PageSize), PageSize, "不能小于1或者大于1000");
            }

            if (PageNo < 1)
            {
                throw new System.ArgumentOutOfRangeException(nameof(PageNo), PageNo, "不能小于1");
            }
        }
    }


}
