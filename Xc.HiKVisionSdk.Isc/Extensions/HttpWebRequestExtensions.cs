using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Managers
{
    public static class HttpWebRequestExtensions
    {

        internal static bool WriteBody(this HttpWebRequest req, string body)
        {
            if (string.IsNullOrWhiteSpace(body))
            {
                return true;

            }
            byte[] postBytes = Encoding.UTF8.GetBytes(body);
            req.ContentLength = postBytes.Length;
            Stream reqStream = null;

            try
            {
                reqStream = req.GetRequestStream();
                reqStream.Write(postBytes, 0, postBytes.Length);
                reqStream.Close();
            }
            catch (Exception ex)
            {
                if (reqStream != null)
                {
                    reqStream.Close();
                }

                throw ex;
            }
            return true;

        }

        internal static string ReadAsString(this HttpWebRequest req)
        {
            HttpWebResponse rsp = null;

            try
            {
                rsp = (HttpWebResponse)req.GetResponse();
                if (HttpStatusCode.OK == rsp.StatusCode)
                {
                    Stream rspStream = rsp.GetResponseStream();
                    StreamReader sr = new StreamReader(rspStream);
                    return sr.ReadToEnd();
                }
                else if (HttpStatusCode.Found == rsp.StatusCode || HttpStatusCode.Moved == rsp.StatusCode)  // 302/301 redirect
                {
                    return rsp.Headers["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (rsp != null)
                {
                    rsp.Close();
                }
                if (req != null)
                {
                    req.Abort();
                }
            }
            return string.Empty;
        }

        internal static byte[] ReadAsBytes(this HttpWebRequest req)
        {
            HttpWebResponse rsp = null;
            try
            {
                rsp = (HttpWebResponse)req.GetResponse();
                Stream rspStream = rsp.GetResponseStream();
                long streamLength = rsp.ContentLength;
                int offset = 0;
                byte[] response = new byte[streamLength];
                while (streamLength > 0)
                {
                    int n = rspStream.Read(response, offset, (int)streamLength);
                    if (0 == n)
                    {
                        break;
                    }

                    offset += n;
                    streamLength -= n;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (rsp != null)
                {
                    rsp.Close();
                }
                if (req != null)
                {
                    req.Abort();
                }
            }

        }
    }
}
