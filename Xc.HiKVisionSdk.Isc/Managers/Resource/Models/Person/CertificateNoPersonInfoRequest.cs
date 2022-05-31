using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 根据证件号码获取单个人员信息请求
    /// </summary>
    public class CertificateNoPersonInfoRequest : BaseRequest
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CertificateNo { get; set; }
        /// <summary>
        /// 证件类型
        /// 111:身份证
        /// 414:护照
        /// 113:户口簿
        /// 335:驾驶证
        /// 131:工作证
        /// 133:学生证
        /// 990:其他
        /// 平台上人员信息实名标识选择为身份证件时必填
        /// </summary>
        public int CertificateType { get; set; }

        /// <summary>
        /// 根据证件号码获取单个人员信息请求
        /// </summary>
        /// <param name="certificateNo">证件号码</param>
        /// <param name="certificateType">证件类型</param>
        public CertificateNoPersonInfoRequest(string certificateNo, int certificateType)
        {
            CertificateNo = certificateNo;
            CertificateType = certificateType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {

            if (string.IsNullOrWhiteSpace(CertificateNo))
            {
                throw new ArgumentNullException(nameof(CertificateNo));
            }

        }

    }

}
