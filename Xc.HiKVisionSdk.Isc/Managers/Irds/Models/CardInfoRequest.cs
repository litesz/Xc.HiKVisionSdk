namespace Xc.HiKVisionSdk.Isc.Managers.Irds.Models
{
    /// <summary>
    /// 获取单个卡片信息请求
    /// </summary>
    public class CardInfoRequest
    {
        /// <summary>
        /// 卡片号码，卡片号码和卡片ID两者同时只能传一种参数
        /// 获取卡片列表接口获取返回参数cardNo
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 卡号ID，卡片号码和卡片ID两者同时只能传一种参数
        /// 获取卡片列表接口获取返回参数cardId
        /// </summary>
        public string CardId { get; set; }
    }
}
