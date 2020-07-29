namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 下发结果
    /// </summary>
    public class IssuedResult
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 下发项的类型,
        /// FACE-人脸
        /// FACE_GROUP-人脸分组
        /// CHANNEL-监控点通道
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 下发项的结果
        /// </summary>
        public string ErrorCode { get; set; }


    }

}
