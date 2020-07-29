using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    public class PlanRecognitionBlackDetailRequest : PagedQuery
    {
        /// <summary>
        /// 识别计划的唯一标识，可从查询重点人员识别计划获取
        /// </summary>
        public string IndexCodes { get; set; }

    }
}
