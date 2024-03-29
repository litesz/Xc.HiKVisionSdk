﻿namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Cameras
{
    /// <summary>
    /// 
    /// </summary>
    public class CameraPlaybackURLsV2PagedDataResponseData
    {
        /// <summary>
        /// 分页标记        标记本次查询的全部标识符，用于查询分片时的多次查询
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// 取流短url，注：rtsp的回放url后面要指定?playBackMode=1 在vlc上才能播放
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 具体数据
        /// </summary>
        public CameraPlaybackURLsV2ResponseData[] List { get; set; }

    }
}
