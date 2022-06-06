namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 生成卡片二维码结果数据
    /// </summary>
    public class GenerateBarCodeResponseData
    {
        /// <summary>
        /// 二维码，将访客二维码内容转成二维码图片即可使用。二维码图片的生成采用QRCode编码、纠错等级为L，版本大于等于5
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
    }
}
