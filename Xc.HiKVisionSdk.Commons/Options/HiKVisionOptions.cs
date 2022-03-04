namespace Xc.HiKVisionSdk.Options
{
    public class HiKVisionOptions
    {
        /// <summary>
        /// ak
        /// </summary>
        public string Ak { get; set; }
        /// <summary>
        /// sk
        /// </summary>
        public string Sk { get; set; }
        /// <summary>
        /// 海康平台地址
        /// </summary>
        public string BaseUrl { get; set; }
        /// <summary>
        /// 平台版本号
        /// </summary>
        public decimal Ver { get; set; } = 1;
    }
}
