namespace Xc.HiKVisionSdk.Isc.Callbacks.Pms
{
    /// <summary>
    /// 事件号
    /// </summary>
    public enum EventCmd
    {
        /// <summary>
        /// 压线
        /// </summary>
        LinePressing = 1,
        /// <summary>
        /// 上传图片
        /// </summary>
        UploadPic = 2,
        /// <summary>
        /// 入场
        /// </summary>
        Entrance = 3,
        /// <summary>
        /// 出场
        /// </summary>
        Leave = 4,
        /// <summary>
        /// 车牌矫正
        /// </summary>
        LicensePlateCorrection = 5,
        /// <summary>
        /// 重新上传图片
        /// </summary>
        ReUploadPic = 6
    }
}
