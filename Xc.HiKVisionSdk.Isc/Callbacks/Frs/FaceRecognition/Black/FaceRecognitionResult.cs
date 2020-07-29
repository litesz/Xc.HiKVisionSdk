namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition.Black
{
    /// <summary>
    /// 识别结果
    /// </summary>
    public class FaceRecognitionResult
    {
        /// <summary>
        /// 抓拍信息
        /// </summary>
        public Snap Snap { get; set; }
        /// <summary>
        /// 识别到的目标信息
        /// </summary>
        public FaceMatchItem[] FaceMatch { get; set; }
    }

}
