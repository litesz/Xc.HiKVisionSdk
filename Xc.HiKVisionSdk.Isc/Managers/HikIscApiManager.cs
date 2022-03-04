using Microsoft.Extensions.Options;
using System.Net.Http;
using Xc.HiKVisionSdk.Commons.Managers;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers
{

    /// <summary>
    /// 
    /// </summary>
    public class HikVisionIscApiManager : HikVisionApiManager, IHikVisionIscApiManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="option"></param>
        public HikVisionIscApiManager(HttpClient client, IOptions<IscSdkOption> option) : base(client, option.Value)
        {

        }

    }
}
