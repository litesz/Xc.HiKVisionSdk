using System.Collections.Generic;
using System.Net;

namespace Xc.HiKVisionSdk.Isc
{
    internal class HttpRequestBuilder
    {
        private readonly string _address;
        private int _timeout = 3000;
        private Dictionary<string, string> _header;
        private string _method = Const.Get;
        private bool _keepAlive = false;

        public HttpRequestBuilder(string address)
        {
            _address = address;
        }


        public HttpRequestBuilder WithTimeOut(int timeout)
        {
            _timeout = timeout;
            return this;
        }

        public HttpRequestBuilder WithHeader(Dictionary<string, string> header)
        {
            _header = header;
            return this;
        }

        public HttpRequestBuilder IsPost()
        {
            _method = Const.Post;
            return this;
        }

        public HttpRequestBuilder IsKeepAlive()
        {
            _keepAlive = true;
            return this;
        }



        public HttpWebRequest Build()
        {
            // 创建POST请求
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create($"{_address}");
            req.KeepAlive = _keepAlive;
            req.ProtocolVersion = HttpVersion.Version11;
            req.AllowAutoRedirect = false;   // 不允许自动重定向
            req.Method = _method;
            req.Timeout = _timeout;    // 传入是秒，需要转换成毫秒
            if (_header != null)
            {
                req.Accept = _header[Const.Accept];
                req.ContentType = _header[Const.ContentType];

                foreach (string headerKey in _header.Keys)
                {
                    if (headerKey.Contains(Const.XCa))
                    {
                        req.Headers.Add(headerKey + ":" + _header[headerKey]);
                    }
                }
            }
            return req;
        }

    }
}
