namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Compare
{
    /// <summary>
    /// 预留字段
    /// </summary>
    public class ReserveField
    {
        /// <summary>
        /// 出生日期，格式形如20000101
        /// </summary>
        public string BornTime { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertificateNumber { get; set; }
        /// <summary>
        /// 证件类型
        /// 见数据字典附录A.47 设备证件类型
        /// </summary>
        public string CertificateType { get; set; }
        /// <summary>
        /// 性别类型
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 人脸姓名
        /// </summary>
        public string Name { get; set; }
    }
}
