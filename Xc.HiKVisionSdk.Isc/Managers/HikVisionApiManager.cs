using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    /// <summary>
    /// 
    /// </summary>
    public class HikVisionApiManager : IHikVisionApiManager
    {
        private readonly int _timeout = 3000;
        private readonly IscSdkOption _option;

        static HikVisionApiManager()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(RemoteCertificateValidate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public HikVisionApiManager(IscSdkOption option)
        {
            _option = option;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public HikVisionApiManager(IOptions<IscSdkOption> options) : this(options.Value)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ak"></param>
        /// <param name="sk"></param>
        /// <param name="address"></param>
        /// <param name="ver"></param>
        public HikVisionApiManager(string ak, string sk, string address, decimal ver) : this(new IscSdkOption
        {
            Ak = ak.Trim(),
            Sk = sk.Trim(),
            BaseUrl = address.Trim(),
            Ver = ver
        })
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public string GetString(string url, decimal ver)
        {
            Check(ver);
            var header = InitHeaderInfo(url);
            var req = new HttpRequestBuilder($"{_option.BaseUrl}{url}").WithHeader(header).WithTimeOut(_timeout).Build();

            return req.ReadAsString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public Task<string> GetStringAsync(string url, decimal ver)
        {
            Check(ver);
            var header = InitHeaderInfo(url);
            var req = new HttpRequestBuilder($"{_option.BaseUrl}{url}").WithHeader(header).WithTimeOut(_timeout).Build();

            return Task.Run(() =>
            {
                return req.ReadAsString();
            });
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
            Check(ver);

            var header = InitHeaderInfo(url, bodyStr, true);

            var req = new HttpRequestBuilder($"{_option.BaseUrl}{url}").WithHeader(header).IsPost().WithTimeOut(_timeout).Build();

            if (!req.WriteBody(bodyStr))
            {
                return null;
            }

            return req.ReadAsString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="bodyStr"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public Task<string> PostAndGetStringAsync(string url, string bodyStr, decimal ver)
        {
            Check(ver);

            var header = InitHeaderInfo(url, bodyStr, true);

            var req = new HttpRequestBuilder($"{_option.BaseUrl}{url}").WithHeader(header).IsPost().WithTimeOut(_timeout).Build();

            return Task.Run(() =>
            {

                if (!req.WriteBody(bodyStr))
                {
                    return null;
                }

                return req.ReadAsString();
            });

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public byte[] GetImageBytes(string url)
        {
            Check(1);

            var req = new HttpRequestBuilder(url).WithTimeOut(_timeout).Build();

            return req.ReadAsBytes();
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

            if (_timeout <= 0)
            {
                throw new ArgumentOutOfRangeException("timeout必须大于0");
            }

            if (ver > _option.Ver)
            {
                throw new ArgumentOutOfRangeException($"调用接口为{ver},设置版本为{_option.Ver}");

            }

        }

        private Dictionary<string, string> InitHeaderInfo(string url, string body = "", bool isPost = false)
        {

            Dictionary<string, string> header = new Dictionary<string, string>
            {

                // Accept                
                { Const.Accept, "application/json" },

                // ContentType  
                { Const.ContentType, "application/json" }
            };

            //if (isPost)
            //{
            //    // content-md5，be careful it must be lower case.
            //    string contentMd5 = ComputeBodyMd5(body);
            //    header.Add("content-md5", contentMd5);
            //}

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


        /// <summary>
        /// 远程证书验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cert"></param>
        /// <param name="chain"></param>
        /// <param name="error"></param>
        /// <returns>验证是否通过，始终通过</returns>
        private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
    }
}
