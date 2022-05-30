using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras
{
    /// <summary>
    /// 获取监控点回放取流URLv2请求
    /// </summary>
    public class CameraPlaybackURLsV2Request : ISOTimeRangeRequest
    {
        /// <summary>
        /// 监控点唯一标识，分页获取监控点资源接口获取返回参数cameraIndexCode
        /// </summary>
        public string CameraIndexCode { get; set; }

        /// <summary>
        /// 存储类型,0：中心存储
        /// 1：设备存储
        /// 默认为中心存储
        /// </summary>
        public RecordLocation RecordLocation { get; set; }

        /// <summary>
        ///取流协议（应用层协议)，
        ///“hik”:HIK私有协议，使用视频SDK进行播放时，传入此类型；
        ///“rtsp”:RTSP协议；
        ///“rtmp”:RTMP协议（RTMP协议只支持海康SDK协议、EHOME协议、ONVIF协议接入的设备；只支持H264视频编码和AAC音频编码；RTMP回放要求录像片段连续，需要在URL后自行拼接<![CDATA[beginTime=20190902T100303&endTime=20190902T100400]]>，其中20190902T100303至20190902T100400为查询出有连续录像的时间段。对于不连续的录像，需要分段查询分段播放）；
        ///“hls”:HLS协议（HLS协议只支持海康SDK协议、EHOME协议、ONVIF协议接入的设备；只支持H264视频编码和AAC音频编码；hls协议只支持云存储，不支持设备存储，云存储版本要求v2.2.4及以上的2.x版本，或v3.0.5及以上的3.x版本；ISC版本要求v1.2.0版本及以上，需在运管中心-视频联网共享中切换成启动平台外置VOD）,
        ///“ws”:Websocket协议（一般用于H5视频播放器取流播放）。
        ///参数不填，默认为HIK协议
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// 传输协议（传输层协议），0:UDP
        /// 1:TCP
        /// 默认为TCP，在protocol设置为rtsp或者rtmp时有效
        /// 注：EHOME设备回放只支持TCP传输
        /// GB28181 2011及以前版本只支持UDP传输
        /// </summary>
        public Transmode Transmode { get; set; }

        /// <summary>
        /// 码流类型，0:主码流
        /// 1:子码流
        /// 2:第三码流
        /// 参数不填，默认为主码流
        /// </summary>
        public StreamType StreamType { get; set; }

        /// <summary>
        /// 分页查询id，上一次查询返回的uuid，用于继续查询剩余片段，默认为空字符串。当存储类型为设备存储时，该字段生效，中心存储会一次性返回全部片段。
        /// </summary>
        public string Uuid { get; set; }

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
        /// 查询录像的锁定类型，0-查询全部录像；1-查询未锁定录像；2-查询已锁定录像，不传默认值为0。通过录像锁定与解锁接口来进行录像锁定与解锁。
        /// </summary>
        public LockType LockType { get; set; }
    }

}
