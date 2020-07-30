using System.ComponentModel;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models
{

    /// <summary>
    /// 证件类型
    /// </summary>
    public enum CertificateType
    {
        /// <summary>
        /// 身份证
        /// </summary>
        [Description("身份证")]
        IdentityCard = 111,
        /// <summary>
        /// 护照
        /// </summary>
        [Description("护照")]
        Passport = 414,
        /// <summary>
        /// 户口簿
        /// </summary>
        [Description("户口簿")]
        ResidenceBooklet = 113,
        /// <summary>
        /// 驾驶证
        /// </summary>
        [Description("驾驶证")]
        DriversLicense = 335,
        /// <summary>
        /// 工作证
        /// </summary>
        [Description("工作证")]
        EmployeeCard = 131,
        /// <summary>
        /// 学生证
        /// </summary>
        [Description("学生证")]
        StudentIDCard = 133,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 990,
    }
}
