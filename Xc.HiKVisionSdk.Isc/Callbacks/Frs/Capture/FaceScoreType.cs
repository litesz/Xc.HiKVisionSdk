namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Capture
{
    /// <summary>
    /// 过滤类型
    /// 0-全部类型 
    /// 1-人脸抓拍图片过滤 
    /// 2-黑名单库 
    /// 3-白名单库
    /// </summary>
    public enum FaceScoreType
    {
        /// <summary>
        /// 全部类型
        /// </summary>
        All,
        /// <summary>
        /// 人脸抓拍图片过滤
        /// </summary>
        Capture,
        /// <summary>
        /// 黑名单库
        /// </summary>
        Black,
        /// <summary>
        /// 白名单库
        /// </summary>
        White
    }

}
