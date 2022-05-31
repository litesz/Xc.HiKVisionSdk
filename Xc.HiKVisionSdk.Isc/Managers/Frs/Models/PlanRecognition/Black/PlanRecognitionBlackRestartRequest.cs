using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 重新下发重点人员识别计划请求
    /// </summary>
    public class PlanRecognitionBlackRestartRequest : BaseRequest
    {
        /// <summary>
        /// 识别计划的唯一标识，可从查询重点人员识别计划获取
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 重新下发重点人员识别计划请求
        /// </summary>
        /// <param name="indexCode">识别计划的唯一标识</param>
        public PlanRecognitionBlackRestartRequest(string indexCode)
        {
            IndexCode = indexCode;
        }

    }
}
