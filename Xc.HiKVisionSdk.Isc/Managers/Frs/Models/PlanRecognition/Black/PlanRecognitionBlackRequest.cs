using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 查询重点人员识别计划请求
    /// </summary>
    public class PlanRecognitionBlackRequest : BaseRequest
    {
        /// <summary>
        /// 根据识别计划描述模糊搜索
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 根据人脸分组唯一标识集合搜索
        /// </summary>
        public string[] FaceGroupIndexCodes { get; set; }

        /// <summary>
        /// 根据识别计划名称模糊搜索
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 根据下发状态搜索，参考附录A.33
        /// </summary>
        public string Status { get; set; }

    }

}
