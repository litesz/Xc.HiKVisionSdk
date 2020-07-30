namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸批量拷贝
    /// </summary>
    public class FaceBatchCopyRequest
    {
        /// <summary>
        /// 待拷贝的若干人脸唯一标识集合，，可从按条件批量查询人脸获取
        /// </summary>
        public string[] IndexCodes { get; set; }
        /// <summary>
        /// 目标人脸分组的唯一标识集合，，可从按条件查询人脸分组获取
        /// </summary>
        public string[] FaceGroupIndexCodes { get; set; }
    }

}
