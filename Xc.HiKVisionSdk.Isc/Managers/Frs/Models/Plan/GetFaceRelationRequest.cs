namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 获取人脸及分组关联关系
    /// </summary>
    public class GetFaceRelationRequest
    {
        /// <summary>
        /// 人脸唯一编号数组，，可从按条件批量查询人脸获取
        /// </summary>
        public string[] IndexCodes { get; set; }

    }
}
