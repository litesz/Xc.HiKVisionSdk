namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 查询重点人员识别计划结果数据
    /// </summary>
    public class PlanRecognitionBlackResponseData
    {

        /// <summary>
        /// 识别计划的唯一标识
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 识别计划的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 人脸分组唯一标识的集合，非空，人脸监控应用服务会校验标识的有效性，
        /// </summary>
        public string[] FaceGroupIndexCodes { get; set; }

        /// <summary>
        /// 抓拍点通道唯一标识的集合，非空，人脸监控应用服务会校验抓拍点标识的有效性，
        /// </summary>
        public string[] CameraIndexCodes { get; set; }

        /// <summary>
        /// 识别资源唯一标识的集合。人脸监控应用服务会校验识别资源标识的有效性，若有重复、无效的标识，校验不通过。识别资源类型为深眸时，可以为空。
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
        /// 识别计划的状态,参考附录A.33
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否启用,true:启用,false:禁用
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// 识别计划开始下发的时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 识别计划下发已经用的时间
        /// </summary>
        public string UsingTime { get; set; }

        /// <summary>
        /// 识别计划的阈值，重点人员是指相似度超过该值时报警，范围[1, 100)
        /// </summary>
        public int Threshold { get; set; }
    }
}
