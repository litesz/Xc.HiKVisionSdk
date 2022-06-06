using System;
using Xc.HiKVisionSdk.Isc.Enums.Irds;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 卡片信息
    /// </summary>
    public class CardInfo
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
        public string PersonId { get; set; }
        /// <summary>
        /// 持卡人名称
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 使用状态标记
        /// </summary>
        public UseStatus UseStatus { get; set; }
        /// <summary>
        ///  生效日期，遵守ISO8601标准，如2018-07-26T21:30:08.000+08:00表示北京时间2017年7月26日21时30分08秒
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
      
    }
}
