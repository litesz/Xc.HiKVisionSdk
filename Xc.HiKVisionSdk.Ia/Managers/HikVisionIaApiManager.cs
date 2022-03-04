using Microsoft.Extensions.Options;
using System.Net.Http;
using Xc.HiKVisionSdk.Commons.Managers;
using Xc.HiKVisionSdk.Ia.Models;

namespace Xc.HiKVisionSdk.Ia.Managers
{

    /// <summary>
    /// 
    /// </summary>
    public class HikVisionIaApiManager : HikVisionApiManager, IHikVisionIaApiManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="option"></param>
        public HikVisionIaApiManager(HttpClient client, IOptions<IaSdkOption> option) : base(client, option.Value)
        {
        }

    }
}
