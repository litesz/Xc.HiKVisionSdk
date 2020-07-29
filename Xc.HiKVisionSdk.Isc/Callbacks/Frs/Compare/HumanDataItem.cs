
using Newtonsoft.Json;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Compare
{
    /// <summary>
    /// 人员数据
    /// </summary>
    public class HumanDataItem
    {
        /// <summary>
        /// 比对到的人脸的图片URL
        /// 可能位于设备或ASW服务上，调用人脸服务图片下载 获取图片数据
        /// </summary>
        [JsonProperty("face_picurl")]

        public string PicUrl { get; set; }
    }
}
