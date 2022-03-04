using Microsoft.Extensions.Options;
using Xc.HiKVisionSdk.Ia.Models;
using Xc.HiKVisionSdk.Isc.Models;

namespace Company.WpfApplication1
{
    public class SdkOption : IOptions<IscSdkOption>
    {

        public IscSdkOption Value => new IscSdkOption
        {
            Ak = this.Ak,
            BaseUrl = this.BaseUrl,
            DownloadImg = this.DownloadImg,
            Sk = this.Sk,
            Ver = this.Ver
        };

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
        /// <summary>
        /// 
        /// </summary>
        public bool DownloadImg { get; set; }
    }


    public class IaOption : IOptions<IaSdkOption>
    {

        public IaSdkOption Value => new IaSdkOption
        {
            Ak = this.Ak,
            BaseUrl = this.BaseUrl,
            DownloadImg = this.DownloadImg,
            Sk = this.Sk,
            Ver = this.Ver
        };

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
        /// <summary>
        /// 
        /// </summary>
        public bool DownloadImg { get; set; }
    }

}
