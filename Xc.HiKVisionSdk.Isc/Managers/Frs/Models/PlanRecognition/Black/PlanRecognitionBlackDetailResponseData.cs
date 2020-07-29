namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    public class PlanRecognitionBlackDetailResponseData
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
        /// 识别计划的类型，
        /// BLACK_LIST-重点人员识别计划
        /// WHITE_LIST-陌生人识别计划
        /// </summary>
        public string RecognitionPlanType { get; set; }

        /// <summary>
        /// 识别计划开始下发的时间,遵循ISO8601的时间格式
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 识别计划下发已经用的时间,单位:秒
        /// </summary>
        public int UsingTime { get; set; }

        /// <summary>
        /// 识别计划的状态,，参考附录A.33
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 每个人脸分组的下发结果集合
        /// </summary>
        public IssuedResult[] FaceGroupIssuedResults { get; set; }

        /// <summary>
        /// 每个通道的布控结果集合
        /// </summary>
        public IssuedResult[] CameraControlResults { get; set; }

        /// <summary>
        /// 每张人脸的下发情况分页结果
        /// </summary>
        public FaceIssuedResultPage FaceIssuedResultPage { get; set; }
    }

  
}
