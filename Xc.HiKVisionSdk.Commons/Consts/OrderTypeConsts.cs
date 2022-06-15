namespace Xc.HiKVisionSdk.Consts
{
    /// <summary>
    /// 排序方式
    /// </summary>
    public static class OrderTypeConsts
    {
        /// <summary>
        /// 升序
        /// </summary>
        public const string ASC = "asc";

        /// <summary>
        /// 降序
        /// </summary>
        public const string DESC = "desc";

        /// <summary>
        /// 获得排序方式
        /// </summary>
        /// <param name="isAsc">是升序</param>
        /// <returns>升序或降序</returns>
        public static string GetOrderType(bool isAsc)
        {
            return isAsc ? ASC : DESC;
        }

    }
}
