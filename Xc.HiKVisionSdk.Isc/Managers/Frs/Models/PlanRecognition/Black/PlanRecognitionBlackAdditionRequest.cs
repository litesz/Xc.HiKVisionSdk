namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 重点监控人员添加识别计划请求
    /// </summary>
    public class PlanRecognitionBlackAdditionRequest
    {
        /// <summary>
        /// 识别计划名称,1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 人脸分组唯一标识的集合，非空，人脸监控应用服务会校验标识的有效性，
        /// 可从按条件查询人脸分组获取
        /// </summary>
        public string[] FaceGroupIndexCodes { get; set; }
        /// <summary>
        /// 抓拍点通道唯一标识的集合，非空，人脸监控应用服务会校验抓拍点标识的有效性，
        /// 可通过分页获取监控点资源获取
        /// </summary>
        public string[] CameraIndexCodes { get; set; }
        /// <summary>
        /// 识别资源唯一标识的集合。人脸监控应用服务会校验识别资源标识的有效性，若有重复、无效的标识，校验不通过。识别资源类型为深眸时，可以为空。
        /// 可从按条件查询识别资源获取
        /// </summary>
        public string[] RecognitionResourceIndexCodes { get; set; }
        /// <summary>
        /// 识别资源类型，
        /// SUPER_BRAIN 超脑，
        /// FACE_RECOGNITION_SERVER 脸谱，
        /// COMPARISON 深眸
        /// </summary>
        public string RecognitionResourceType { get; set; }
        /// <summary>
        /// 识别计划描述，1~128个字符
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 识别计划的阈值，重点人员是指相似度超过该值时报警，范围[1, 100)
        /// </summary>
        public int Threshold { get; set; }
        /// <summary>
        /// 时间计划模板，不填默认全天候
        /// </summary>
        public TimeBlock[] TimeBlockList { get; set; }
    }
}
