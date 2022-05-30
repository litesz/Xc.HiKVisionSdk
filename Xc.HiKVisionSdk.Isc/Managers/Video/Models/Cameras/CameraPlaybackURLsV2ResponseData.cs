namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras
{
    /// <summary>
    /// 获取监控点回放取流URLv2数据
    /// </summary>
    public class CameraPlaybackURLsV2ResponseData
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 录像片段大小（byte）
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// 查询录像的锁定类型，0-全部录像；1-未锁定录像；2-已锁定录像。
        /// </summary>
        public LockType LockType { get; set; }
    }
}
