using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    /// <summary>
    /// 
    /// </summary>
    public class HikVisionApiManager : IHikVisionApiManager
    {
        private readonly IscSdkOption _option;
        private readonly HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="option"></param>
        public HikVisionApiManager(HttpClient client, IOptions<IscSdkOption> option)
        {
            _httpClient = client;
            _option = option.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bodyStr"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public string PostAndGetString(string url, string bodyStr, decimal ver)
        {
            return PostAndGetStringAsync(url, bodyStr, ver).Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bodyStr"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public async Task<string> PostAndGetStringAsync(string url, string bodyStr, decimal ver)
        {
            Check(ver);

            var bodyJson = new StringContent(string.IsNullOrWhiteSpace(bodyStr) ? "" : bodyStr, Encoding.UTF8, "application/json");
            var header = InitHeaderInfo($"/artemis{url}", true);
            foreach (string headerKey in header.Keys)
            {
                if (headerKey.Contains(Const.XCa))
                {
                    bodyJson.Headers.Add(headerKey, header[headerKey]);
                }
            }

            var response = await _httpClient.PostAsync($"{_option.BaseUrl}/artemis{url}", bodyJson);

            return await response.Content.ReadAsStringAsync();
        }


  


        private void Check(decimal ver)
        {
            if (string.IsNullOrWhiteSpace(_option.BaseUrl))
            {
                throw new ArgumentNullException("address");
            }

            if (string.IsNullOrWhiteSpace(_option.Ak))
            {
                throw new ArgumentNullException("ak");
            }
            if (string.IsNullOrWhiteSpace(_option.Sk))
            {
                throw new ArgumentNullException("sk");
            }



            if (ver > _option.Ver)
            {
                throw new ArgumentOutOfRangeException($"调用接口为{ver},设置版本为{_option.Ver}");

            }

        }

        private Dictionary<string, string> InitHeaderInfo(string url, bool isPost = false)
        {

            Dictionary<string, string> header = new Dictionary<string, string>
            {
                // Accept                
                { Const.Accept, "application/json" },

                // ContentType  
                { Const.ContentType, "application/json; charset=utf-8" }
            };

            // x-ca-timestamp
            string timestamp = ((DateTime.Now.Ticks - TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 0, 0, 0, 0), TimeZoneInfo.Local).Ticks) / 1000).ToString();
            header.Add(Const.XCaTimeStamp, timestamp);

            // x-ca-nonce
            header.Add(Const.XCaNonce, Guid.NewGuid().ToString());

            // x-ca-key
            header.Add(Const.XCaKey, _option.Ak);

            // build string to sign
            string strToSign = Utils.BuildSignString(isPost ? "POST" : "GET", url, header);

            string signedStr = Utils.ComputeForHMACSHA256(strToSign, _option.Sk);

            // x-ca-signature
            header.Add(Const.XCaSignature, signedStr);

            return header;
        }


    }
}
