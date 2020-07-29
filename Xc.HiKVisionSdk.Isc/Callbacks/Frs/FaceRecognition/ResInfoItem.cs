namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition
{
    /// <summary>
    /// 触发重点人员识别事件的报警的抓拍点的信息
    /// </summary>
    public class ResInfoItem
    {
        /// <summary>
        /// 资源类型
        /// 重点人员识别事件均为抓拍点报警，例如：camera
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// 资源的唯一标识
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 资源的名称
        /// </summary>
        public string Cn { get; set; }
    }

}
