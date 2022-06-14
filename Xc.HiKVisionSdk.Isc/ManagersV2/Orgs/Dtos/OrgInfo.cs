using System;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 根组织信息
    /// </summary>
    public class OrgInfo
    {
        /// <summary>
        /// 组织唯一标识码
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 组织编号
        /// </summary>
        public string OrgNo { get; set; }
        /// <summary>
        /// 组织名称，如默认部门
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 组织路径，例如：默认部门/综合安防/开发小组
        /// </summary>
        public string OrgPath { get; set; }
        /// <summary>
        /// 父组织唯一标识码
        /// </summary>
        public string ParentOrgIndexCode { get; set; }
        /// <summary>
        /// 父组织名称
        /// </summary>
        public string ParentOrgName { get; set; }
        /// <summary>
        /// 更新时间 要求遵守ISO8601标准
        /// 如2018-07-26T21:30:08.000+08:00 表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public DateTimeOffset? UpdateTime { get; set; }

    }
}
