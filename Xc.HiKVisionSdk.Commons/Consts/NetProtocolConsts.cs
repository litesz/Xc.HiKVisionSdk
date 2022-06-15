namespace Xc.HiKVisionSdk.Consts
{
    /// <summary>
    /// 网络协议
    /// </summary>
    public static class NetProtocolConsts
    {
        /// <summary>
        /// http
        /// </summary>
        public const string HTTP = "http";

        /// <summary>
        /// https
        /// </summary>
        public const string HTTPS = "https";

        /// <summary>
        /// 获得协议
        /// </summary>
        /// <param name="useSsl">使用ssl</param>
        /// <returns></returns>
        public static string GetNetProtocol(bool useSsl)
        {
            return useSsl ? HTTPS : HTTP;
        }

        /// <summary>
        /// 检查协议名称
        /// </summary>
        /// <param name="netProtocol">协议名</param>
        /// <returns></returns>
        public static bool Check(string netProtocol)
        {
            return netProtocol == HTTP || netProtocol == HTTPS;
        }
    }
}
