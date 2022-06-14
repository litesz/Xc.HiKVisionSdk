using System;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Isc.Enums.Resource;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 修改人员请求
    /// </summary>
    public class UpdatePersonRequest : BaseRequest
    {
        /// <summary>
        /// 修改人员请求
        /// </summary>
        /// <param name="personId">人员id 获取人员列表v2 接口获取返回参数personId</param>
        /// <param name="personName">姓名<![CDATA[1~32个字符；不能包含 ’ / \ : * ? " < >]]></param>
        /// <param name="orgIndexCode">所属组织标识，必须是已存在组织，从获取组织列表接口获取返回参数orgIndexCode</param>
        /// <param name="gender">性别</param>
        /// <param name="phoneNo">手机号</param>
        /// <param name="jobNo">工号</param>
        /// <param name="certificateType">证件类型</param>
        /// <param name="certificateNo">证件号码，1-20位数字字母</param>
        /// <param name="email">邮箱</param>
        /// <param name="birthday">出生日期</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public UpdatePersonRequest(string personId, string personName, string orgIndexCode, Gender? gender, string phoneNo = "", string jobNo = "", CertificateType? certificateType = null, string certificateNo = "", string email = "", DateTime? birthday = null)
        {

            if (string.IsNullOrWhiteSpace(personId))
            {
                throw new ArgumentNullException(nameof(personId));
            }
            if (!string.IsNullOrWhiteSpace(personName) && personName.Length > 32)
            {
                throw new ArgumentOutOfRangeException(nameof(personName), personName, "人员名称，1~32个字符；不能包含 ’ / \\ : * ? \" < > ");
            }

            if (!string.IsNullOrWhiteSpace(jobNo) && jobNo.Length > 32)
            {
                throw new ArgumentOutOfRangeException(nameof(jobNo), jobNo, "工号，1-32个字符");
            }
            if (!string.IsNullOrWhiteSpace(phoneNo) && phoneNo.Length > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(phoneNo), phoneNo, "手机号，1-20位数字");
            }

            if (string.IsNullOrWhiteSpace(orgIndexCode))
            {
                throw new ArgumentNullException(nameof(orgIndexCode));
            }

            PersonId = personId;
            PersonName = personName;
            if (gender.HasValue)
            {
                Gender = gender.Value;
            }
            OrgIndexCode = orgIndexCode;
            PhoneNo = phoneNo;
            JobNo = jobNo;
            if (certificateType.HasValue)
            {
                CertificateType = certificateType.Value;
                if (string.IsNullOrWhiteSpace(certificateNo))
                {
                    throw new ArgumentNullException(nameof(certificateNo));
                }
                if (certificateNo.Length > 20)
                {
                    throw new ArgumentOutOfRangeException(nameof(certificateNo), certificateNo, "证件号码，1-20位数字字母");

                }
            }

            Email = email;
            if (birthday.HasValue)
            {
                Birthday = birthday.Value.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; private set; }
        /// <summary>
        /// 姓名<![CDATA[1~32个字符；不能包含 ’ / \ : * ? " < >]]>
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
        /// 联系电话
        /// </summary>
        public string PhoneNo { get; private set; }
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
        /// 邮箱
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string Birthday { get; private set; }
    }
}
