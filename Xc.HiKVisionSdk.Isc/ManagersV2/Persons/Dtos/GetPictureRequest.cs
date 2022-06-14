using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 提取人员图片
    /// </summary>
    public class GetPictureRequest : BaseRequest
    {


        /// <summary>
        /// 图片相对URI        通过获取人员列表v2接口返回“picUri”字段
        /// </summary>
        public string PicUri { get; }
        /// <summary>
        /// 图片服务器唯一标识        通过获取人员列表v2接口返回“serverIndexCode”字段
        /// </summary>
        public string ServerIndexCode { get; }

        /// <summary>
        /// 提取人员图片
        /// </summary>
        /// <param name="picUri"> 图片相对URI        通过获取人员列表v2接口返回“picUri”字段</param>
        /// <param name="serverIndexCode">图片服务器唯一标识        通过获取人员列表v2接口返回“serverIndexCode”字段</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public GetPictureRequest(string picUri, string serverIndexCode)
        {
            if (string.IsNullOrWhiteSpace(picUri))
            {
                throw new System.ArgumentNullException(nameof(picUri));
            }
            if (string.IsNullOrWhiteSpace(serverIndexCode))
            {
                throw new System.ArgumentNullException(nameof(serverIndexCode));
            }
            PicUri = picUri;
            ServerIndexCode = serverIndexCode;
        }
    }
}
