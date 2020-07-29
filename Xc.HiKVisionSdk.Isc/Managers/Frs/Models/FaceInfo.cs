namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸信息对象
    /// </summary>
    public class FaceInfo
    {
        /// <summary>
        /// 人脸的名称,1~32个字符；不能包含 ’ / \ : * ? " < >
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 人脸的性别信息，
        /// 1-男性，
        /// 2-女性，
        /// UNKNOWN-未知
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 人脸的证件类别，
        /// 111-身份证，
        /// OTHER-其它证件
        /// </summary>
        public string CertificateType { get; set; }
        /// <summary>
        /// 人脸的证件号码信。1~20个数字、字母。
        /// </summary>
        public string CertificateNum { get; set; }

    }

}
