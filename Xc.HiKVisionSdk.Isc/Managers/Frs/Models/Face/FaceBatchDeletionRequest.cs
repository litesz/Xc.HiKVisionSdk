namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 批量删除人脸请求
    /// </summary>
    public class FaceBatchDeletionRequest
    {
        /// <summary>
        /// 人脸的唯一标识集合，可从按条件批量查询人脸获取
        /// </summary>
        public string[] IndexCodes { get; set; }

        /// <summary>
        /// 人脸分组的唯一标识，可从按条件查询人脸分组获取
        /// </summary>
        public string FaceGroupIndexCode { get; set; }
    }
}
