using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 挂失请求
    /// </summary>
    public class AddCardsLossRequest : BaseRequest
    {
        /// <summary>
        /// 人卡关联结合数组(批量挂失数量不能超过200个)
        /// </summary>
        public CardNoAndPersonIdItem[] CardList { get; }

        /// <summary>
        /// 挂失请求
        /// </summary>
        /// <param name="cardList">人卡关联结合数组</param>
        public AddCardsLossRequest(params CardNoAndPersonIdItem[] cardList)
        {
            if (cardList == null)
            {
                throw new ArgumentNullException(nameof(cardList));
            }
            if (cardList.Length > 200)
            {
                throw new ArgumentOutOfRangeException(nameof(cardList), cardList.Length, "批量挂失数量不能超过200个");
            }
            CardList = cardList;
        }
    }
}
