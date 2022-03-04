using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件批量查询人脸
    /// </summary>
    public class FaceRequest : PagedQuery
    {
        /// <summary>
        /// 通过人脸的唯一标识集合查询指定的人脸集合
        /// </summary>
        public string[] IndexCodes { get; set; }
        /// <summary>
        /// 根据人脸所属的分组搜索该分组下符合条件的人脸
        /// </summary>
        public string FaceGroupIndexCode { get; set; }

        /// <summary>
        /// 人脸名称模糊查询
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
        /// 人脸的证件号码模糊查询
        /// </summary>
        public string CertificateNum { get; set; }


    }

}
