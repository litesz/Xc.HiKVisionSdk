using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Consts
{
    public static class NetProtocolConsts
    {

        public const string HTTP = "http";
        public const string HTTPS = "https";

        public static string GetNetProtocol(bool useSsl)
        {
            return useSsl ? HTTPS : HTTP;
        }

        public static bool Check(string netProtocol)
        {
            return netProtocol == HTTP || netProtocol == HTTPS;
        }
    }
}
