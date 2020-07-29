namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    public class FaceGroupSingleAdditionRequest
    {
        /// <summary>
        /// 人脸分组的名称，1~32个字符；不能包含 ’ / \ : * ? " < >
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分组的描述，1~128个字符
        /// </summary>
        public string Description { get; set; }
    }
}
