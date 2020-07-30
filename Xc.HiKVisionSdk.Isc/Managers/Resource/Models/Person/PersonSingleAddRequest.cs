namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 添加人员请求
    /// </summary>
    public class PersonSingleAddRequest : PersonRequestBase
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        public FaceInfo[] Faces { get; set; }
    }
}
