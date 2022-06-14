using System;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Isc.Enums.Resource;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonDetailInfo
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
        /// 所属组织路径
        /// </summary>
        public string OrgPath { get; set; }
        /// <summary>
        /// 所属组织名称
        /// </summary>
        public string OrgPathName { get; set; }

        /// <summary>
        ///  所属组织唯一标识码
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public CertificateType? CertificateType { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertificateNo { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 出生日期，例"1990-01-01"
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
        /// 人员图片信息
        /// </summary>
        public PersonPhoto PersonPhoto { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public int Education { get; set; }
        /// <summary>
        /// 人员姓氏
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 人员名称
        /// </summary>
        public string GivenName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// 职工性质
        /// </summary>
        public string StaffProperty { get; set; }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string EmployeePost { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string EmployeeNumber { get; set; }
        /// <summary>
        /// 岗位类别
        /// </summary>
        public string PostType { get; set; }
        /// <summary>
        /// 身份类型
        /// </summary>
        public string IdentityType { get; set; }
        /// <summary>
        /// 国籍
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Nation { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Birthplace { get; set; }
        /// <summary>
        /// 户籍
        /// </summary>
        public string CensusRegister { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public Marriaged? Marriaged { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string PoliticalStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Religion { get; set; }
        /// <summary>
        /// 房间号
        /// </summary>
        public string RoomNum { get; set; }
        /// <summary>
        /// 与户主关系
        /// </summary>
        public string HouseHolderRel { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string StudentId { get; set; }
        /// <summary>
        /// 学生入学时间
        /// </summary>
        public DateTimeOffset? StuStartTime { get; set; }
        /// <summary>
        /// 学生毕业时间
        /// </summary>
        public DateTimeOffset? StuEndTime { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string StuGrade { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public string StuClass { get; set; }
        /// <summary>
        /// 学院
        /// </summary>
        public string Academy { get; set; }
        /// <summary>
        /// 学生专业
        /// </summary>
        public string Profession { get; set; }
        /// <summary>
        /// 宿舍楼
        /// </summary>
        public string Dormitory { get; set; }

        /// <summary>
        /// 是否住校，1:是；2:否
        /// </summary>
        public int Lodge { get; set; }
        /// <summary>
        /// 人员描述
        /// </summary>
        public string PersonDesc { get; set; }
        /// <summary>
        /// 同步标志类型
        /// </summary>
        public int SyncFlag { get; set; }
        /// <summary>
        /// 拼音
        /// </summary>
        public string Pinyin { get; set; }
        /// <summary>
        /// 发证机构
        /// </summary>
        public string CertIssuer { get; set; }
        /// <summary>
        /// 发证地址
        /// </summary>
        public string CertAddr { get; set; }
        /// <summary>
        /// 证件有效期
        /// </summary>
        public DateTimeOffset? CertExpireTime { get; set; }
        /// <summary>
        /// 状态小于0则代表资源已被删除
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        ///  	创建时间
        /// </summary>
        public DateTimeOffset? CreateTime { get; set; }
        /// <summary>
        ///  	更新时间
        /// </summary>
        public DateTimeOffset? UpdateTime { get; set; }

        /// <summary>
        /// 已被删除
        /// </summary>
        public bool IsDeleted => Status < 0;
        /// <summary>
        /// 是否住校
        /// </summary>
        public bool IsLodge => Lodge == 1;

    }
}
