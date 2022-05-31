using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras
{
    /// <summary>
    /// 获取监控点预览取流URLv2请求
    /// </summary>
    public class CameraPreviewURLsV2Request : BaseRequest
    {
        /// <summary>
        /// 监控点唯一标识，分页获取监控点资源接口获取返回参数cameraIndexCode
        /// </summary>
        public string CameraIndexCode { get; set; }

        /// <summary>
        /// 码流类型，0:主码流
        /// 1:子码流
        /// 2:第三码流
        /// 参数不填，默认为主码流
        /// </summary>
        public StreamType StreamType { get; set; } = StreamType.Main;
        /// <summary>
        /// 取流协议（应用层协议），
        /// “hik”:HIK私有协议，使用视频SDK进行播放时，传入此类型；
        /// “rtsp”:RTSP协议；
        /// “rtmp”:RTMP协议（RTMP协议只支持海康SDK协议、EHOME协议、ONVIF协议接入的设备；只支持H264视频编码和AAC音频编码）；
        /// “hls”:HLS协议（HLS协议只支持海康SDK协议、EHOME协议、ONVIF协议接入的设备；只支持H264视频编码和AAC音频编码）；
        /// “ws”:Websocket协议（一般用于H5视频播放器取流播放）。
        /// 参数不填，默认为HIK协议
        /// </summary>
        public string Protocol { get; set; } = "hik";

        /// <summary>
        /// 传输协议（传输层协议），0:UDP
        /// 1:TCP
        /// 默认是TCP
        /// 注：GB28181 2011及以前版本只支持UDP传输
        /// </summary>
        public Transmode Transmode { get; set; } = Transmode.TCP;
        /// <summary>
        /// 标识扩展内容，格式：key=value，
        /// 调用方根据其播放控件支持的解码格式选择相应的封装类型；
        /// 多个扩展时，以<![CDATA["&"]]>隔开；
        /// 支持的内容详见附录F expand扩展内容说明
        /// </summary>
        public string Expand { get; set; }
        /// <summary>
        /// 输出码流转封装格式，“ps”:PS封装格式、“rtp”:RTP封装协议。当protocol=rtsp时生效，且不传值时默认为RTP封装协议。
        /// </summary>
        public string Streamform { get; set; }

        /// <summary>
        /// 获取监控点预览取流URLv2请求
        /// </summary>
        /// <param name="cameraIndexCode">监控点唯一标识</param>
        /// <param name="protocol">取流协议（应用层协议）</param>
        /// <param name="expand">标识扩展内容</param>
        public CameraPreviewURLsV2Request(string cameraIndexCode, string protocol = "hik", string expand = "")
        {
            CameraIndexCode = cameraIndexCode;
            Protocol = protocol.ToLower();
            Expand = expand;
        }

        /// <summary>
        /// 使用UDP
        /// </summary>
        /// <returns></returns>
        public CameraPreviewURLsV2Request UseUdp()
        {
            Transmode = Transmode.UDP;
            return this;
        }

        /// <summary>
        /// 使用子码
        /// </summary>
        /// <returns></returns>
        public CameraPreviewURLsV2Request SubStreamType()
        {
            StreamType = StreamType.Sub;
            return this;
        }

        /// <summary>
        /// 使用第三码流
        /// </summary>
        /// <returns></returns>
        public CameraPreviewURLsV2Request OtherStreamType()
        {
            StreamType = StreamType.Other;
            return this;
        }

        /// <summary>
        /// hls
        /// </summary>
        /// <param name="expand">
        /// 标识扩展内容，格式：key=value，
        /// 调用方根据其播放控件支持的解码格式选择相应的封装类型；
        /// 多个扩展时，以<![CDATA["&"]]>隔开；
        /// 支持的内容详见附录F expand扩展内容说明
        /// </param>
        /// <param name="streamform">输出码流转封装格式</param>
        /// <returns></returns>
        public CameraPreviewURLsV2Request UseHls(string expand = "", string streamform = "")
        {
            Protocol = "hls";
            Expand = expand;
            Streamform = streamform;
            return this;
        }

        /// <summary>
        /// rtsp
        /// </summary>
        /// <param name="expand">
        /// 标识扩展内容，格式：key=value，
        /// 调用方根据其播放控件支持的解码格式选择相应的封装类型；
        /// 多个扩展时，以<![CDATA["&"]]>隔开；
        /// 支持的内容详见附录F expand扩展内容说明
        /// </param>
        /// <param name="streamform">输出码流转封装格式</param>
        /// <returns></returns>
        public CameraPreviewURLsV2Request UseRtsp(string expand = "", string streamform = "")
        {
            Protocol = "hls";
            Expand = expand;
            Streamform = streamform;
            return this;
        }
        /// <summary>
        /// rtmp
        /// </summary>
        /// <param name="expand">
        /// 标识扩展内容，格式：key=value，
        /// 调用方根据其播放控件支持的解码格式选择相应的封装类型；
        /// 多个扩展时，以<![CDATA["&"]]>隔开；
        /// 支持的内容详见附录F expand扩展内容说明
        /// </param>
        /// <param name="streamform">输出码流转封装格式</param>
        /// <returns></returns>
        public CameraPreviewURLsV2Request UseRtmp(string expand = "", string streamform = "")
        {
            Protocol = "hls";
            Expand = expand;
            Streamform = streamform;
            return this;
        }
        /// <summary>
        /// Websocket协议
        /// </summary>
        /// <param name="expand">
        /// 标识扩展内容，格式：key=value，
        /// 调用方根据其播放控件支持的解码格式选择相应的封装类型；
        /// 多个扩展时，以<![CDATA["&"]]>隔开；
        /// 支持的内容详见附录F expand扩展内容说明
        /// </param>
        /// <param name="streamform">输出码流转封装格式</param>
        /// <returns></returns>
        public CameraPreviewURLsV2Request UseWs(string expand = "", string streamform = "")
        {
            Protocol = "hls";
            Expand = expand;
            Streamform = streamform;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (Protocol != "hik" || Protocol != "rtsp" || Protocol != "rtmp" || Protocol != "his" || Protocol != "ws")
            {
                throw new System.ArgumentOutOfRangeException(nameof(Protocol), "仅支持 hik,rtsp,rtmp,hls,ws");
            }
        }

    }

}
