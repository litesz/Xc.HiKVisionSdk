﻿using Xc.HiKVisionSdk.Enums;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 基本人员信息
    /// </summary>
    public class PersonInfoData
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
        /// 1：男
        /// 2：女
        /// 0：未知
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 所属组织路径，@进行分割，例如 @root000000@
        /// </summary>
        public string OrgPath { get; set; }
        /// <summary>
        /// 所属组织名称，@进行分割，如@默认部门@
        /// </summary>
        public string OrgPathName { get; set; }
        /// <summary>
        /// 所属组织唯一标识码
        /// </summary>
        public string OrgIndexCode { get; set; }
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
        /// 更新时间        
        /// 要求遵守ISO8601标准，如2018-07-26T21:30:08.000+08:00
        /// 表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public string UpdateTime { get; set; }
        /// <summary>
        ///  	出生日期
        ///  	格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string Birthday { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNo { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 邮件
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Education { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }

        /// <summary>
        /// 人员图片信息
        /// </summary>
        public PersonPhoto PersonPhoto { get; set; }
    }

}
