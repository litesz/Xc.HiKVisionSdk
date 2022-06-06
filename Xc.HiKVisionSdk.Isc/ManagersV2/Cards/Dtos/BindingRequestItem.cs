using System;
using Xc.HiKVisionSdk.Isc.Enums.Resource;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 批量开卡请求项
    /// </summary>
    public class BindingRequestItem
    {
        /// <summary>
        /// 批量开卡请求项
        /// </summary>
        /// <param name="cardNo">卡号,8~20个字符，支持数字和大写字母</param>
        /// <param name="personId">人员ID</param>
        /// <param name="cardType">卡片类型</param>
        /// <param name="orgIndexCode">人员所属组织IndexCode，不传默认使用根组织</param>
        public BindingRequestItem(string cardNo, string personId, CardType cardType, string orgIndexCode = null)
        {
            if (string.IsNullOrWhiteSpace(cardNo))
            {
                throw new ArgumentNullException(nameof(cardNo));
            }

            if (cardNo.Length < 8 || cardNo.Length > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(cardNo), "卡号,8~20个字符");
            }

            if (string.IsNullOrWhiteSpace(personId))
            {
                throw new ArgumentNullException(nameof(personId));
            }

            CardNo = cardNo;
            PersonId = personId;
            OrgIndexCode = orgIndexCode;
            CardType = cardType;
        }
        /// <summary>
        /// 卡号,8~20个字符，支持数字和大写字母
        /// </summary>
        public string CardNo { get; }
        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; }
        /// <summary>
        /// 人员所属组织IndexCode，不传默认使用根组织
        /// </summary>
        public string OrgIndexCode { get; }
        /// <summary>
        /// 卡片类型
        /// </summary>
        public CardType CardType { get; }


    }
}
