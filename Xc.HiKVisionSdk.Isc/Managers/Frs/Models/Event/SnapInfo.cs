namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 重点人员事件抓拍信息
    /// </summary>
    public class SnapInfo
    {
        /// <summary>
        /// 抓拍背景图
        /// </summary>
        public string BkgUrl { get; set; }
        /// <summary>
        /// 抓拍小图
        /// </summary>
        public string SnapUrl { get; set; }
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        public string DeviceIndexcode { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// 监控点唯一标识
        /// </summary>
        public string CameraIndexcode { get; set; }
        /// <summary>
        /// 监控点名称
        /// </summary>
        public string CameraName { get; set; }
        /// <summary>
        /// 性别，male-男，female-女
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 年龄段，
        /// UNKNOWN-未知，
        /// INFANT-婴幼儿，
        /// KID-儿童，
        /// CHILD-少年，
        /// TEENAGER-青少年，
        /// YOUNG-青年，
        /// PRIME-壮年，
        /// MIDDLE-中年，
        /// MIDDLEAGED-中老年，
        /// OLD-老年
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 指定查询是否戴眼镜， yes 是， no 否
        /// </summary>
        public string Glass { get; set; }
        /// <summary>
        /// 事件时间
        /// </summary>
        public string EventTime { get; set; }
    }

}
