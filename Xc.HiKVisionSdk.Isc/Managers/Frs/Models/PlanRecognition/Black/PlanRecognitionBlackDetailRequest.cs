using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个查询重点人员识别计划详情请求
    /// </summary>
    public class PlanRecognitionBlackDetailRequest : PagedRequest
    {
        /// <summary>
        /// 识别计划的唯一标识，可从查询重点人员识别计划获取
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 单个查询重点人员识别计划详情请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="indexCode"></param>
        public PlanRecognitionBlackDetailRequest(int pageNo, int pageSize, string indexCode) : base(pageNo, pageSize)
        {
            IndexCode = indexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(IndexCode))
            {
                throw new ArgumentNullException(nameof(IndexCode));
            }

            base.CheckParams();
        }

    }
}
