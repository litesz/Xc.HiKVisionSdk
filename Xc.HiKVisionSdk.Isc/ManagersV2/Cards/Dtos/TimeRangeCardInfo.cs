using System;
using Xc.HiKVisionSdk.Isc.Enums.Irds;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 增量获取卡片
    /// </summary>
    public class TimeRangeCardInfo
    {


        /// <summary>
        /// 卡片ID
        /// </summary>
        public string CardId { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 持卡人员id
        /// </summary>
        public string PersonIndexCode { get; set; }

        /// <summary>
        /// 使用状态标记
        /// </summary>
        public UseStatus UseStatus { get; set; }
        /// <summary>
        /// 生效日期，遵守ISO8601标准，如2018-07-26T21:30:08.000+08:00表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>
        /// 失效日期，遵守ISO8601标准，如2018-07-26T21:30:08.000+08:00表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary>
        /// 挂失时间，遵守ISO8601标准，如2018-07-26T21:30:08.000+08:00表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public DateTimeOffset? LossDate { get; set; }
        /// <summary>
        /// 解除挂失时间，遵守ISO8601标准，如2018-07-26T21:30:08.000+08:00表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public DateTimeOffset? UnlossDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTimeOffset CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTimeOffset? UpdateTime { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        public int CardType { get; set; }
        /// <summary>
        /// 所属组织
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 是否绑定指纹，1-绑定，2-未绑定
        /// </summary>
        public int IsBindFinger { get; set; }
        /// <summary>
        /// 是否绑定人脸，1-绑定，2-未绑定
        /// </summary>
        public int IsBindFace { get; set; }

        /// <summary>
        /// 资源状态，小于0则代表资源已被删除，0代表有效资源
        /// </summary>
        public int Status { get; set; }
    }
}
