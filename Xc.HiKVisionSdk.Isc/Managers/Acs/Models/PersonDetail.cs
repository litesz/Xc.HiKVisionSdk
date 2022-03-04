
using Xc.HiKVisionSdk.Enums;

namespace Xc.HiKVisionSdk.Isc.Managers.Acs.Models
{
    /// <summary>
    /// 人员信息详情
    /// </summary>
    public class PersonDetail
    {
        /// <summary>
        /// 学院
        /// </summary>
        public string Academy { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Birthplace { get; set; }
        /// <summary>
        /// 户籍
        /// </summary>
        public string CensusRegister { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertNo { get; set; }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 楼栋
        /// </summary>
        public string Dormitory { get; set; }
        /// <summary>
        /// 学历，参考附录A.12 学历类型
        /// </summary>
        public int? EducationBackground { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 行政职务
        /// </summary>
        public string EmployeePost { get; set; }
        /// <summary>
        /// 与户主关系
        /// </summary>
        public string HouseHolderRel { get; set; }
        /// <summary>
        /// 用户自定义输入字符串
        /// </summary>
        public string IdentityType { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// 是否住校
        /// </summary>
        public int? Lodge { get; set; }
        /// <summary>
        /// 婚姻状况,参考附录A.58 婚姻状况
        /// </summary>
        public int? Marriaged { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 民族,参考附录A.13 民族类型
        /// </summary>
        public string Nation { get; set; }
        /// <summary>
        /// 人员所属组织ID
        /// </summary>
        public string OrgId { get; set; }
        /// <summary>
        /// 人员唯一编码
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 人员名称
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string PoliticalStatus { get; set; }
        /// <summary>
        /// 岗位类别， 用户自定义输入
        /// </summary>
        public string PostType { get; set; }
        /// <summary>
        /// 专业
        /// </summary>
        public string Profession { get; set; }
        /// <summary>
        /// 宗教信仰
        /// </summary>
        public string Religion { get; set; }
        /// <summary>
        /// 性别
        /// 0: 未知
        /// 1: 男
        /// 2: 女
        /// </summary>
        public Gender? Sex { get; set; }
        /// <summary>
        /// 职工性质
        /// </summary>
        public string StaffProperty { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public string StuClass { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string StuGrade { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string StudentId { get; set; }
        /// <summary>
        /// 证件类型:
        /// 111: 身份证
        /// 414：护照
        /// 335: 驾驶证
        /// 131: 工作证
        /// 133: 学生证
        /// 113: 户口簿
        /// 990: 其他
        /// </summary>
        public int? CertType { get; set; }
    }

}
