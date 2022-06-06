using Xc.HiKVisionSdk.Consts;
using Xc.HiKVisionSdk.Isc.Enums.Irds;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 查询卡片列表请求
    /// </summary>
    public class GetAdvanceListRequest : PagedRequest
    {
        /// <summary>
        /// 人员姓名,模糊查询
        /// </summary>
        public string PersonName { get; }
        /// <summary>
        /// 卡号,模糊查询， 根据获取卡片列表接口获取返回参数cardNo
        /// </summary>
        public string CardNo { get; }
        /// <summary>
        /// 人员ID集，多个值使用英文逗号分隔，不超过1000个， 根据获取人员列表v2接口获取返回参数personId
        /// </summary>
        public string PersonIds { get; private set; }
        /// <summary>
        /// 使用状态标记，1：正常.
        /// 2：挂失
        /// </summary>
        public UseStatus? UseStatus { get; }
        /// <summary>
        /// 排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; }
        /// <summary>
        /// 降序：desc.        升序：asc
        /// </summary>
        public string OrderType { get; }

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
        public GetAdvanceListRequest(int pageNo, int pageSize, string personName = "", string cardNo = "", bool? onlyLoss = null, string orderBy = "", bool isAsc = true) : base(pageNo, pageSize)
        {
            PersonName = personName;
            CardNo = cardNo;
            OrderBy = orderBy;
            OrderType = OrderTypeConsts.GetOrderType(isAsc);
            if (onlyLoss.HasValue)
            {
                UseStatus = onlyLoss.Value ? Enums.Irds.UseStatus.Loss : Enums.Irds.UseStatus.Normal;
            }
        }

        /// <summary>
        /// 使用人员ID集查询
        /// </summary>
        /// <param name="personIds">人员ID集</param>
        /// <returns></returns>
        public GetAdvanceListRequest UsePersonIds(params string[] personIds)
        {
            if (personIds == null || personIds.Length > 1000)
            {
                throw new System.ArgumentOutOfRangeException(nameof(personIds), "人员ID集，不超过1000个");
            }

            PersonIds = string.Join(",", personIds);
            return this;
        }


    }
}
