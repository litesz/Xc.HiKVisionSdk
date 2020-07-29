namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Compare
{
    /// <summary>
    /// 识别信息
    /// </summary>
    public class IdentifyItem
    {
        /// <summary>
        /// 比对到的目标人脸
        /// 有几个对象代表比对到了几张人脸
        /// </summary>
        public CandidateItem[] Candidate { get; set; }

        /// <summary>
        /// 比对到的所有人脸和抓拍到的人脸相似度最高的那个值
        /// </summary>
        public double Maxsimilarity { get; set; }
    }
}
