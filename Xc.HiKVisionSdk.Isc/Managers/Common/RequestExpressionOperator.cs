namespace Xc.HiKVisionSdk.Isc.Managers
{
    /// <summary>
    /// 操作符
    /// </summary>
    public enum RequestExpressionOperator
    {

        /// <summary>
        /// 等于
        /// </summary>
        Equal = 0,
        /// <summary>
        /// 大于等于
        /// </summary>
        NotLessThen = 1,
        /// <summary>
        /// 小于等于
        /// </summary>
        NotMoreThen = 2,
        /// <summary>
        /// in
        /// </summary>
        In = 3,
        /// <summary>
        /// not in
        /// </summary>
        NotIn = 4,
        /// <summary>
        /// between
        /// </summary>
        Between = 5,
        /// <summary>
        /// like
        /// </summary>
        Like = 6,
        /// <summary>
        /// pre like
        /// </summary>
        PreLike = 7,
        /// <summary>
        /// suffix like
        /// </summary>
        SuffixLike = 8


    }
}
