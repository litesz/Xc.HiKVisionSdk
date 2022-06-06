using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 获取单个卡片信息请求
    /// </summary>
    public class GetInfoRequest : BaseRequest
    {
        /// <summary>
        /// 卡片号码，卡片号码和卡片ID两者同时只能传一种参数
        /// 获取卡片列表接口获取返回参数cardNo
        /// </summary>
        public string CardNo { get; }

        /// <summary>
        /// 卡号ID，卡片号码和卡片ID两者同时只能传一种参数
        /// 获取卡片列表接口获取返回参数cardId
        /// </summary>
        public string CardId { get; }

        /// <summary>
        /// 获取单个卡片信息请求
        /// </summary>
        /// <param name="content">请求内容</param>
        /// <param name="isCardId">是卡片ID还是卡片号码</param>
        public GetInfoRequest(string content, bool isCardId = false)
        {
            if (isCardId)
            {
                CardId = content;
            }
            else
            {
                CardNo = content;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(CardNo) && string.IsNullOrWhiteSpace(CardId))
            {
                throw new ArgumentNullException("CardNo 或者 CardId", "卡片号码和卡片ID二选一");
            }

        }

    }
}
