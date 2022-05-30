using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸信息对象
    /// </summary>
    public class FaceInfo : ICheckRequestItem
    {
        /// <summary>
        /// 人脸的名称,1~32个字符；不能包含 ’ / \ : * ? " 
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

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void Check()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
            if (!string.IsNullOrWhiteSpace(Sex))
            {
                if (Sex != "1" || Sex != "2" || Sex.ToUpper() != "UNKNOWN")
                {
                    throw new ArgumentOutOfRangeException(nameof(Sex), "性别可选项为1,2,UNKNOWN");
                }
            }
            if (!string.IsNullOrWhiteSpace(CertificateNum))
            {
                if (CertificateNum.Length > 20)
                {
                    throw new ArgumentOutOfRangeException(nameof(CertificateNum), "长度为1-20个数字、字母");
                }
            }
        }
    }

}
