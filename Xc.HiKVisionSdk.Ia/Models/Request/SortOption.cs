namespace Xc.HiKVisionSdk.Ia.Models.Request
{
    /// <summary>
    /// 排序参数
    /// </summary>
    public class SortOption
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortField"></param>
        /// <param name="sortType"></param>
        public SortOption(string sortField, string sortType)
        {
            SortField = sortField;
            SortType = sortType;
        }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string SortField { get; set; }
        /// <summary>
        /// 排序类型：esc、desc
        /// </summary>
        public string SortType { get; set; }
    }
}
