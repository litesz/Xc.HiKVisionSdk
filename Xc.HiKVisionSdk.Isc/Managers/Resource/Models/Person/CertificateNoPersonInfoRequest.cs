namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    public class CertificateNoPersonInfoRequest
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
    }

}
