using Xc.HiKVisionSdk.Consts;
using Xc.HiKVisionSdk.Isc.Enums.Irds;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Irds.Models
{
    /// <summary>
    /// 查询卡片列表请求
    /// </summary>
    public class AdvanceCardListRequest : PagedRequest
    {
        /// <summary>
        /// 人员姓名,模糊查询
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 卡号,模糊查询， 根据获取卡片列表接口获取返回参数cardNo
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 人员ID集，多个值使用英文逗号分隔，不超过1000个， 根据获取人员列表v2接口获取返回参数personId
        /// </summary>
        public string PersonIds { get; set; }
        /// <summary>
        /// 使用状态标记，1：正常.
        /// 2：挂失
        /// </summary>
        public UseStatus UseStatus { get; set; }
        /// <summary>
        /// 排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// 降序：desc.        升序：asc
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 查询卡片列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="personName">人员姓名</param>
        /// <param name="cardNo">卡号</param>
        /// <param name="onlyLoss">只看挂失</param>
        /// <param name="orderBy">排序字段必须是查询条件</param>
        /// <param name="isAsc">使用升序</param>
        public AdvanceCardListRequest(int pageNo, int pageSize, string personName = "", string cardNo = "", bool onlyLoss = false, string orderBy = "", bool isAsc = true) : base(pageNo, pageSize)
        {
            PersonName = personName;
            CardNo = cardNo;
            UseStatus = onlyLoss ? UseStatus.Loss : UseStatus.Normal;
            OrderBy = orderBy;
            OrderType = OrderTypeConsts.GetOrderType(isAsc);
        }

        /// <summary>
        /// 使用人员ID集
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public AdvanceCardListRequest UserPersonIds(params string[] personId)
        {
            PersonIds = string.Join(",", personId);
            return this;
        }


    }
}
