using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件查询重点人员事件请求
    /// </summary>
    public class EventBlackSearchRequest : ISOTimeRangeWithPagedRequest
    {
        /// <summary>
        /// 监控点唯一标志集合，若不指定，则查询所有的监控点
        /// </summary>
        public string[] CameraIndexCodes { get; set; }
        /// <summary>
        /// 指定查询的最小相似度, 最小为1，最大为100
        /// </summary>
        public int Similarity { get; set; } = 50;
        /// <summary>
        /// 指定查询的人员姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 指定查询的证件类型，ID-身份证，otherId-其他证件
        /// </summary>
        public string CertificateType { get; set; }
        /// <summary>
        /// 指定查询的证件号码
        /// </summary>
        public string CertificateNumber { get; set; }
        /// <summary>
        /// 指定查询的年龄段，
        /// kid-儿童，
        /// child-少年，
        /// teenager-青少年，
        /// young-青年，
        /// prime-壮年，
        /// middle-中年，
        /// middleAged-中老年，
        /// old-老年
        /// </summary>
        public string[] Age { get; set; }
        /// <summary>
        /// 定查询的性别，male-男，female-女
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 指定查询是否戴眼镜，
        /// yes是，
        /// no否
        /// </summary>
        public string Glass { get; set; }
        /// <summary>
        /// 指定查询的所属人脸分组集合，不指定则查询所有的人脸分组
        /// </summary>
        public string[] FaceGroupIndexcodes { get; set; }
        /// <summary>
        /// 排序字段。结果查询排序字段，0时间，1相似度，排序支持倒序排序，默认按照时间倒叙排序
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 按条件查询重点人员事件请求
        /// </summary>
        public EventBlackSearchRequest() { }

        /// <summary>
        /// 按条件查询重点人员事件请求
        /// </summary>
        /// <param name="similarity">指定查询的最小相似度, 最小为1，最大为100</param>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        public EventBlackSearchRequest(int similarity, int pageNo, int pageSize, DateTime startTime, DateTime endTime) : base(pageNo, pageSize, startTime, endTime)
        {
            Similarity = similarity;
        }
    }

}
