using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 卡片退卡请求
    /// </summary>
    public class DeletionCardRequest : BaseRequest
    {
        /// <summary>
        /// 卡片退卡请求
        /// </summary>
        /// <param name="cardNumber">卡号</param>
        /// <param name="personId">人员Id</param>
        public DeletionCardRequest(string cardNumber, string personId)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                throw new ArgumentNullException(nameof(cardNumber));
            }

            if (string.IsNullOrWhiteSpace(personId))
            {
                throw new ArgumentNullException(nameof(personId));
            }

            CardNumber = cardNumber;
            PersonId = personId;
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { get; }
        /// <summary>
        /// 人员Id
        /// </summary>
        public string PersonId { get; }
    }
}
