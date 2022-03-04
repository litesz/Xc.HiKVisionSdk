using System.ComponentModel.DataAnnotations;
using Xc.HiKVisionSdk.Enums;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 人员信息请求
    /// </summary>
    public abstract class PersonRequestBase
    {

        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string PersonName { get; set; }
        /// <summary>
        /// 性别
        /// 1：男
        /// 2：女
        /// 0：未知
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 所属组织唯一标识码
        /// </summary>
        [Required]
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNo { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 证件类型
        /// 111:身份证
        /// 414:护照
        /// 113:户口簿
        /// 335:驾驶证
        /// 131:工作证
        /// 133:学生证
        /// 990:其他
        /// </summary>
        public CertificateType CertificateType { get; set; }
        /// <summary> 
        /// 证件号码
        /// 一串数字字符串
        /// </summary>
        public string CertificateNo { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string Birthday { get; set; }
    }
}
