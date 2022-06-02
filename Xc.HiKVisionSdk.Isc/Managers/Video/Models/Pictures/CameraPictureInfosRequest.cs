using System;
using Xc.HiKVisionSdk.Consts;
using Xc.HiKVisionSdk.Isc.Enums.Video;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Video.Models.Pictures
{
    /// <summary>
    /// 平台抓拍计划图片获取请求
    /// </summary>
    public class CameraPictureInfosRequest : IOSTimeRangeWithPagedRequest
    {
        /// <summary>
        /// 监控点编号集合，一次性最多传入5个监控点编号进行查询。与captureId取交集，两个参数都不传时返回所有配置了抓图计划的监控点的图片信息。
        /// </summary>
        public string[] CameraIndexCodes { get; private set; }
        /// <summary>
        /// 图片唯一标识，与cameraIndexCodes取交集，主要用于本接口全量查询后通过获取的图片唯一标识查询单张图片信息。
        /// </summary>
        public string CaptureId { get; private set; }
        /// <summary>
        /// 网络协议。“http”:HTTP协议、“https”:HTTPS协议。参数不填，优先返回https协议
        /// </summary>
        public string NetProtocol { get; }
        /// <summary>
        /// 图片排序方式。0-按监控点排序，根据监控点名称ASCII码顺序排序。同一监控点的图片按照时间倒序排序；1-按时间排序，根据抓图时间倒序排序，
        /// 最新的图片排在最前边。相同时间按监控点名称顺序排序。参数不填，默认按0-监控点排序。
        /// </summary>
        public CameraPictureInfoSortType Sort { get; private set; }
        /// <summary>
        /// 图片质量压缩比。标识返回缩略图的图片质量压缩比。通过修改图片压缩比来改变图片大小（图片占用字节数），不会改变图片尺寸。取值范围为0-99，不传时默认为50，取值越小，表示压缩更多，图片失真越严重。
        /// </summary>
        public int CompressRatio { get; private set; } 

        /// <summary>
        /// 平台抓拍计划图片获取请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="compressRatio">图片质量压缩比</param>
        /// <param name="useSsl">使用https</param>
        /// <param name="captureId">图片唯一标识</param>
        public CameraPictureInfosRequest(int pageNo, int pageSize, DateTime start, DateTime end, int compressRatio = 50, bool useSsl = true, string captureId = "")
            : base(pageNo, pageSize, start, end, true)
        {
            NetProtocol = NetProtocolConsts.GetNetProtocol(useSsl);
            CompressRatio = compressRatio;
            CaptureId = captureId;
        }

        /// <summary>
        /// 传入监控点编号集合
        /// </summary>
        /// <param name="cameraIndexCodes"></param>
        /// <returns></returns>
        public CameraPictureInfosRequest UseCameras(params string[] cameraIndexCodes)
        {
            CameraIndexCodes = cameraIndexCodes;
            return this;
        }

        /// <summary>
        /// 按时间排序图片
        /// </summary>
        /// <returns></returns>
        public CameraPictureInfosRequest UseOrderByTime()
        {
            Sort = CameraPictureInfoSortType.OrderByTime;
            return this;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (CameraIndexCodes != null && CameraIndexCodes.Length > 5)
            {
                throw new System.ArgumentOutOfRangeException(nameof(CameraIndexCodes), "一次性最多传入5个监控点编号");
            }

            if (CompressRatio < 0 || CompressRatio > 99)
            {
                throw new System.ArgumentOutOfRangeException(nameof(CompressRatio), "取值范围为0-99 ");
            }
            if (!NetProtocolConsts.Check(NetProtocol))
            {
                throw new System.ArgumentOutOfRangeException(nameof(NetProtocol), "只能使用 http 或 https");
            }
            base.CheckParams();
        }

    }
}
