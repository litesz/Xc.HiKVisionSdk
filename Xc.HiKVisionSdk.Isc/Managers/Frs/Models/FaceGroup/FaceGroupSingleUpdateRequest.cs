namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸分组更新
    /// </summary>
    public class FaceGroupSingleUpdateRequest
    {
        /// <summary>
        /// 人脸分组的唯一标识,可从按条件查询人脸分组获取
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 人脸分组的名称,1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 人脸分组的描述，1~128个字符
        /// </summary>
        public string Description { get; set; }
    }
}
