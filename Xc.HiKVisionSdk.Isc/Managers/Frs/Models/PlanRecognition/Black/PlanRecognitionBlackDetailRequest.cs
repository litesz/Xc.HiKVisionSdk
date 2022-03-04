using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个查询重点人员识别计划详情请求
    /// </summary>
    public class PlanRecognitionBlackDetailRequest : PagedQuery
    {
        /// <summary>
        /// 识别计划的唯一标识，可从查询重点人员识别计划获取
        /// </summary>
        public string IndexCode { get; set; }

    }
}
