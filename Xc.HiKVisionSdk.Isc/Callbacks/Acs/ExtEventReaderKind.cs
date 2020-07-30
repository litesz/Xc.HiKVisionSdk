namespace Xc.HiKVisionSdk.Isc.Callbacks.Acs
{
    /// <summary>
    /// 读卡器类别
    /// </summary>
    public enum ExtEventReaderKind
    {
        /// <summary>
        /// 无
        /// </summary>
        None,
        /// <summary>
        /// ic卡
        /// </summary>
        Ic,
        /// <summary>
        /// 身份证
        /// </summary>
        Id,
        /// <summary>
        /// 二维码
        /// </summary>
        QrCode,
        /// <summary>
        /// 指纹
        /// </summary>
        Fingerprint
    }
}
