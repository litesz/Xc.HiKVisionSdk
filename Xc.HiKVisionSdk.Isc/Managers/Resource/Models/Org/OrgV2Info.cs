namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    ///  组织请求数据
    /// </summary>
    public class OrgV2Info
    {
        /// <summary>
        /// 组织唯一标识码
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 组织编号
        /// </summary>
        public string OrganizationCode { get; set; }
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
        /// 更新时间 要求遵守ISO8601标准
        /// 如2018-07-26T21:30:08.000+08:00 表示北京时间2017年7月26日21时30分08秒
        /// </summary>
        public string UpdateTime { get; set; }

       
        /// <summary>
        /// 用于标识组织节点是否有权限操作，true：有权限，false：无权限
        /// </summary>
        public bool Available { get; set; }
        /// <summary>
        /// 标识组织节点是否叶子节点，true：为叶子结点，false：非叶子结点
        /// </summary>
        public bool Leaf { get; set; }
        /// <summary>
        /// 同级区域顺序，数据展示按照sort正序排列
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 创建时间，IOS8601格式
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 资源状态，小于0则代表资源已被删除，0代表有效资源
        /// </summary>
        public int Status { get; set; }


    }
}
