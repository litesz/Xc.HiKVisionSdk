using System.Collections.Generic;
using System.Net;
using Xc.HiKVisionSdk.Consts;

namespace Xc.HiKVisionSdk.Commons.Managers
{
    /// <summary>
    /// 请求建造者
    /// </summary>
    internal class HttpRequestBuilder
    {
        private readonly string _address;
        private int _timeout = 3000;
        private Dictionary<string, string> _header;
        private string _method = SignConsts.Get;
        private bool _keepAlive = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        public HttpRequestBuilder(string address)
        {
            _address = address;
        }

        /// <summary>
        /// 超时
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public HttpRequestBuilder WithTimeOut(int timeout)
        {
            _timeout = timeout;
            return this;
        }

        /// <summary>
        /// 头
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public HttpRequestBuilder WithHeader(Dictionary<string, string> header)
        {
            _header = header;
            return this;
        }

        /// <summary>
        /// 是post
        /// </summary>
        /// <returns></returns>
        public HttpRequestBuilder IsPost()
        {
            _method = SignConsts.Post;
            return this;
        }

        /// <summary>
        /// 长连接
        /// </summary>
        /// <returns></returns>
        public HttpRequestBuilder IsKeepAlive()
        {
            _keepAlive = true;
            return this;
        }


        /// <summary>
        /// 构造请求
        /// </summary>
        /// <returns></returns>
        public HttpWebRequest Build()
        {
            // 创建POST请求
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"{_address}");
            req.KeepAlive = _keepAlive;
            req.ProtocolVersion = HttpVersion.Version11;
            req.AllowAutoRedirect = false;   // 不允许自动重定向
            req.Method = _method;
            req.Timeout = _timeout;    // 传入是秒，需要转换成毫秒
            if (_header != null)
            {
                req.Accept = _header[SignConsts.Accept];
                req.ContentType = _header[SignConsts.ContentType];

                foreach (string headerKey in _header.Keys)
                {
                    if (headerKey.Contains(SignConsts.XCa))
                    {
                        req.Headers.Add(headerKey + ":" + _header[headerKey]);
                    }
                }
            }
            return req;
        }

    }
}
