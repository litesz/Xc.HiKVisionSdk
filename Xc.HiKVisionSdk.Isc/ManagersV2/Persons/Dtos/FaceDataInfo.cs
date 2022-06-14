namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 人脸信息
    /// </summary>
    public class FaceDataInfo
    {
        /// <summary>
        /// 人脸图片base64编码后的字符
        /// </summary>
        public string FaceData { get; }

        /// <summary>
        /// 人脸信息
        /// </summary>
        /// <param name="faceData">人脸图片base64编码后的字符</param>
        public FaceDataInfo(string faceData)
        {
            FaceData = faceData;
        }
    }
}
