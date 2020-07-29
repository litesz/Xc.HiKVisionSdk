namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    public class FaceBatchAdditionRequestItem
    {
        /// <summary>
        /// 人脸唯一标识，单次批量添加操作，不允许重复。
        /// </summary>
        public string IndexCode { get; set; }
        /// <summary>
        /// 指定人脸添加到的人脸分组的唯一标识,人脸监控应用服务会校验该值的有效性，可从按条件查询人脸分组获取
        /// </summary>
        public string FaceGroupIndexCode { get; set; }
    }

}
