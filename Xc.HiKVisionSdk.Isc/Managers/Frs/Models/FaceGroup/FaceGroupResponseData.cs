namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件查询人脸分组结果数据
    /// </summary>
    public class FaceGroupResponseData
    {
        /// <summary>
        /// 人脸分组的唯一标识,由人脸监控应用服务生成
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 人脸分组的名称,人脸分组的名称是唯一的
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 人脸分组的描述
        /// </summary>
        public string Description { get; set; }
    }
}
