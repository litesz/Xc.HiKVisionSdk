namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Capture
{
    /// <summary>
    /// 人脸评分参数
    /// </summary>
    public class FaceScore
    {
        /// <summary>
        /// 是否开启功能
        /// </summary>
        public string Enable { get; set; }
        /// <summary>
        /// 人脸评分
        /// 人脸总评分：
        /// 综合所有评分项得到人脸总评分
        /// 数值越大
        /// 人脸质量越高
        /// float类型[0, 1]
        /// </summary>
        public double TotalScore { get; set; }
        /// <summary>
        /// 过滤类型
        /// 0-全部类型 
        /// 1-人脸抓拍图片过滤 
        /// 2-黑名单库 
        /// 3-白名单库
        /// </summary>
        public FaceScoreType Type { get; set; }
    }

}
