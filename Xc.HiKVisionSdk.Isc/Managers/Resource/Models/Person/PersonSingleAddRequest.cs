namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    public class PersonSingleAddRequest : PersonRequestBase
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        public FaceInfo[] Faces { get; set; }
    }
}
