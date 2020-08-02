namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件查询识别资源结果数据
    /// </summary>
    public class RecognitionResponseData {
        /// <summary>
        /// 识别计划的唯一标识
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 识别计划的名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 根据识别资源的类型搜索，SUPER_BRAIN 超脑，FACE_RECOGNITION_SERVER 脸谱，COMPARISON 深眸
        /// </summary>
        public string RecognitionResourceType { get; set; }
    }
}
