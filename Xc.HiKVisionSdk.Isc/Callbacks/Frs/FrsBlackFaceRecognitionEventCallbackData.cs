using Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition;
using Xc.HiKVisionSdk.Isc.Callbacks.Frs.FaceRecognition.Black;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs
{

    /// <summary>
    /// 重点人员识别数据
    /// </summary>
    public class FrsBlackFaceRecognitionEventCallbackData
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        public FaceRecognitionResult FaceRecognitionResult { get; set; }
        /// <summary>
        /// 源事件的唯一标识，即转自的人脸比对事件的唯一标识
        /// </summary>
        public string SrcEventId { get; set; }
        /// <summary>
        /// 触发重点人员识别事件的报警的抓拍点的信息
        /// </summary>
        public ResInfoItem[] ResInfo { get; set; }
    }

}
