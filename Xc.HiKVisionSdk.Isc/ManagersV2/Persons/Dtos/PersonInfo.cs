using System;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Isc.Enums.Resource;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonInfo
    {
        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        ///  	所属组织唯一标识码
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        ///  	联系电话
        /// </summary>
        public string PhoneNo { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public CertificateType? CertificateType { get; set; }
        /// <summary>
        ///  	证件号码
        /// </summary>
        public string CertificateNo { get; set; }
        /// <summary>
        ///  	创建时间
        /// </summary>
        public DateTimeOffset? CreateTime { get; set; }
        /// <summary>
        ///  	更新时间
        /// </summary>
        public DateTimeOffset? UpdateTime { get; set; }
        /// <summary>
        /// 所属组织路径
        /// </summary>
        public string OrgPath { get; set; }
        /// <summary>
        /// 所属组织名称
        /// </summary>
        public string OrgPathName { get; set; }
        /// <summary>
        /// 人员图片信息
        /// </summary>
        public PersonPhoto PersonPhoto { get; set; }
    }
}
