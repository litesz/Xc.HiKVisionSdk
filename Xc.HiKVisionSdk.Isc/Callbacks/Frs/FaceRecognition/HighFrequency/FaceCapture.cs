namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition.HighFrequency
{
    /// <summary>
    /// 识别结果
    /// </summary>
    public class FaceCapture
    {
        /// <summary>
        /// 
        /// </summary>
        public FaceInfo[] Faces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RecordDataIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TargetAttr TargetAttrs { get; set; }
    }



}
