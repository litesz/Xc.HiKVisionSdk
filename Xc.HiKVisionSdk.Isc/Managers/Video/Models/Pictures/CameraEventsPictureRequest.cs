using Xc.HiKVisionSdk.Consts;
using Xc.HiKVisionSdk.Models.Request;


namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Pictures
{
    /// <summary>
    /// 视频图片查询请求
    /// </summary>
    public class CameraEventsPictureRequest : BaseRequest
    {

        /// <summary>
        /// 图片存储服务器唯一标识，提供picUri处会提供此字段
        /// </summary>
        public string SvrIndexCode { get; }
        /// <summary>
        /// 图片的相对地址
        /// </summary>
        public string PicUri { get; }

        /// <summary>
        /// 网络协议：
        /// “http”:HTTP协议
        /// “https”:HTTPS协议
        /// 参数不填，优先返回https协议
        /// </summary>
        public string NetProtocol { get; }

        /// <summary>
        /// 视频图片查询请求
        /// </summary>
        /// <param name="svrIndexCode">图片存储服务器唯一标识</param>
        /// <param name="picUri">图片的相对地址</param>
        /// <param name="useSsl">使用https请求</param>
        public CameraEventsPictureRequest(string svrIndexCode, string picUri, bool useSsl = true)
        {
            SvrIndexCode = svrIndexCode;
            PicUri = picUri;
            NetProtocol = NetProtocolConsts.GetNetProtocol(useSsl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(SvrIndexCode))
            {
                throw new System.ArgumentNullException(nameof(SvrIndexCode));
            }

            if (string.IsNullOrWhiteSpace(PicUri))
            {
                throw new System.ArgumentNullException(nameof(PicUri));
            }
            if (!NetProtocolConsts.Check(NetProtocol))
            {
                throw new System.ArgumentOutOfRangeException(nameof(NetProtocol), "只能使用 http 或 https");
            }
        }
    }





}
