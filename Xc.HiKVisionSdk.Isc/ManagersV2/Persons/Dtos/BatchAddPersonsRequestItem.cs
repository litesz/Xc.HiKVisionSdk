using System;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Isc.Enums.Resource;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 批量添加人员请求详细
    /// </summary>
    public class BatchAddPersonsRequestItem : ICheckRequestItem
    {
        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get;private set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string PersonName { get; private set; }
        /// <summary>
        /// 性别
        /// 1：男
        /// 2：女
        /// 0：未知
        /// </summary>
        public Gender Gender { get; private set; }
        /// <summary>
        /// 所属组织唯一标识码
        /// </summary>
        public string OrgIndexCode { get; private set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string Birthday { get; private set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNo { get; private set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNo { get; private set; }
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
        public CertificateType CertificateType { get; private set; }
        /// <summary> 
        /// 证件号码
        /// 一串数字字符串
        /// </summary>
        public string CertificateNo { get; private set; }
        /// <summary>
        /// 人员临时标志，
        /// 当调用方未指定personId时，clientId作为人员标志，在返回值中标志每个人员的添加结果。
        /// 所以每次接口调用，每个人员的clientid需保持唯一，1~10个字符，只支持数字。
        /// 注：clientid只对本次调用有效
        /// </summary>
        public int ClientId { get; private set; }


        /// <summary>
        /// 添加人员v2请求
        /// </summary>
        /// <param name="personName">姓名<![CDATA[1~32个字符；不能包含 ’ / \ : * ? " < >]]></param>
        /// <param name="gender">性别</param>
        /// <param name="orgIndexCode">所属组织标识，必须是已存在组织，从获取组织列表接口获取返回参数orgIndexCode</param>
        /// <param name="clientId">人员临时标志，当调用方未指定personId时，clientId作为人员标志，在返回值中标志每个人员的添加结果。        所以每次接口调用，每个人员的clientid需保持唯一，1~10个字符，只支持数字。注：clientid只对本次调用有效</param>
        /// <param name="personId">人员ID，可以指定人员personId，不允许与其他人员personId重复，包括已删除的人员。 为空时平台自动生成人员ID</param>
        /// <param name="birthday">出生日期</param>
        /// <param name="email">邮箱</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public BatchAddPersonsRequestItem(string personName, Gender gender, string orgIndexCode, int? clientId = null, string personId = "", DateTime? birthday = null, string email = "")
        {
            if (string.IsNullOrWhiteSpace(personName))
            {
                throw new ArgumentNullException(nameof(personName));
            }
            if (personName.Length > 32)
            {
                throw new ArgumentOutOfRangeException(nameof(personName), personName, "人员名称，1~32个字符；不能包含 ’ / \\ : * ? \" < > ");

            }
            PersonName = personName;
            Gender = gender;
            if (string.IsNullOrWhiteSpace(orgIndexCode))
            {
                throw new ArgumentNullException(nameof(orgIndexCode));
            }
            OrgIndexCode = orgIndexCode;
            PersonId = personId;
            if (birthday.HasValue)
            {
                Birthday = birthday.Value.ToString("yyyy-MM-dd");
            }
            Email = email;
            if (clientId.HasValue)
            {
                ClientId = clientId.Value;
            }
        }

        /// <summary>
        /// 使用身份证
        /// </summary>
        /// <param name="certificateType"></param>
        /// <param name="certificateNo"></param>
        /// <returns></returns>
        public BatchAddPersonsRequestItem UseCertificate(CertificateType certificateType, string certificateNo)
        {
            if (string.IsNullOrWhiteSpace(certificateNo))
            {
                throw new ArgumentNullException(nameof(certificateNo));
            }
            CertificateType = certificateType;
            CertificateNo = certificateNo;
            return this;
        }

        /// <summary>
        /// 使用手机号
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public BatchAddPersonsRequestItem UsePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentNullException(nameof(phone));
            }
            if (phone.Length > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(phone));
            }
            PhoneNo = phone;
            return this;
        }


        /// <summary>
        /// 使用工号
        /// </summary>
        /// <param name="jobNo">工号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public BatchAddPersonsRequestItem UseJobNo(string jobNo)
        {
            if (string.IsNullOrWhiteSpace(jobNo))
            {
                throw new ArgumentNullException(nameof(jobNo));
            }
            JobNo = jobNo;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public void Check()
        {
            if (string.IsNullOrWhiteSpace(PersonName))
            {
                throw new System.ArgumentNullException(nameof(PersonName));
            }
            if (PersonName.Length > 32)
            {
                throw new System.ArgumentOutOfRangeException(nameof(PersonName), PersonName, "1~32个字符；不能包含 ’ / \\ : * ? \" < > ");
            }

            if (string.IsNullOrWhiteSpace(OrgIndexCode))
            {
                throw new System.ArgumentNullException(nameof(OrgIndexCode));
            }
        }
    }
}
