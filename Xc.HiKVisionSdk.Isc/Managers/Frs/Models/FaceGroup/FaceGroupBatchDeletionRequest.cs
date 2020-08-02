namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 删除人脸分组请求
    /// </summary>
    public class FaceGroupBatchDeletionRequest
    {
        /// <summary>
        /// 通过indexCode集合查询指定的识别资源集合
        /// </summary>
        public string[] IndexCodes { get; set; }
    }
}
