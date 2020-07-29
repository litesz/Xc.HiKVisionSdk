namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 人员图片信息
    /// </summary>
    public class PersonPhoto
    {
        /// <summary>
        /// 人脸图片唯一标示
        /// </summary>
        public string PersonPhotoIndexCode { get; set; }
        /// <summary>
        /// 图片相对url, 通过提取人员图片接口获取图片数据
        /// </summary>
        public string PicUri { get; set; }
        /// <summary>
        /// 图片服务器唯一标示        提取人员图片接口必要参数
        /// </summary>
        public string ServerIndexCode { get; set; }
        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; set; }


    }


}
