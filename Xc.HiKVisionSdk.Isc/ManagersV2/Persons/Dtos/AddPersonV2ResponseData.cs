namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 成功添加的人员信息
    /// </summary>
    public class AddPersonV2ResponseData
    {
        /// <summary>
        /// 成功添加的人员Id
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 成功添加的人脸Id
        /// </summary>
        public string FaceId { get; set; }
    }
}
