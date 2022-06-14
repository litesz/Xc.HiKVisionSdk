namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 挂失请求项
    /// </summary>
    public class CardNoAndPersonIdItem
    {
        /// <summary>
        /// 挂失请求项
        /// </summary>
        /// <param name="cardNumber">卡号</param>
        /// <param name="personId">人员唯一标示</param>
        public CardNoAndPersonIdItem(string cardNumber, string personId = "")
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                throw new System.ArgumentNullException(nameof(cardNumber));
            }

            CardNumber = cardNumber;
            PersonId = personId;
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { get; }
        /// <summary>
        /// 人员唯一标示
        /// </summary>
        public string PersonId { get; }
    }
}
