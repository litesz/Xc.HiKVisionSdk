using System.Collections.Generic;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Capture
{
    /// <summary>
    /// 抓拍结果
    /// </summary>
    public class CaptureResult
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        public FaceInfo[] Faces { get; set; }
        /// <summary>
        /// 目标属性
        /// </summary>
        public TargetAttrs TargetAttrs { get; set; }
    }

}
