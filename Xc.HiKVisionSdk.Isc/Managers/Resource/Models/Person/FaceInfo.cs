using System.ComponentModel.DataAnnotations;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 人脸数据
    /// </summary>
    public class FaceInfo
    {
        /// <summary>
        /// 人脸图片base64编码后的字符
        /// </summary>
        [Required]
        public string FaceDate { get; set; }
    }
}
