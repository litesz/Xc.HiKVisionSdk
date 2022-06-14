using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 批量开卡请求
    /// </summary>
    public class BindingCardsRequest : BaseRequest
    {
        /// <summary>
        /// 卡片最大截止有效时间
        /// </summary>
        private static readonly DateTime maxEndDate = new DateTime(2037, 12, 31);

        /// <summary>
        /// 卡片开始有效时间，时间格式：yyyy-MM-dd
        /// </summary>
        public string StartDate { get; }
        /// <summary>
        /// 卡片截止有效时间,时间格式：yyyy-MM-dd。        不能大于2037年12月31日
        /// </summary>
        public string EndDate { get; }
        /// <summary>
        /// 待开卡列表,最大支持50张卡
        /// </summary>
        public BindingCardsRequestItem[] CardList { get; }

        /// <summary>
        /// 批量开卡请求
        /// </summary>
        /// <param name="startDate">卡片开始有效时间</param>
        /// <param name="endDate">卡片截止有效时间,不能大于2037年12月31日</param>
        /// <param name="cardList">待开卡列表,最大支持50张卡</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public BindingCardsRequest(DateTime startDate, DateTime endDate, params BindingCardsRequestItem[] cardList)
        {
            if (endDate > maxEndDate)
            {
                throw new ArgumentOutOfRangeException(nameof(endDate), "卡片截止有效时间,不能大于2037年12月31日");
            }
            if (cardList == null)
            {
                throw new ArgumentNullException(nameof(cardList));
            }
            if (cardList.Length > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(cardList), "待开卡列表,最大支持50张卡");

            }
            StartDate = startDate.ToString("yyyy-MM-dd");
            EndDate = endDate.ToString("yyyy-MM-dd");
            CardList = cardList;
        }

    }
}
