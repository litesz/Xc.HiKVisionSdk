namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 批量添加人员请求详细
    /// </summary>
    public class OrgBatchAddRequestItem
    {
        /// <summary>
        /// 人员临时标志，
        /// 当调用方未指定personId时，clientId作为人员标志，在返回值中标志每个人员的添加结果。
        /// 所以每次接口调用，每个人员的clientid需保持唯一，1~10个字符，只支持数字。
        /// 注：clientid只对本次调用有效
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// 组织唯一标志，不允许与其它组织唯一标志重复，包括已删除的组织，值为空或者不传此字段系统自动生成唯一标志
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 组织名称，1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        ///  	父组织唯一标识码
        /// </summary>
        public string ParentIndexCode { get; set; }
        /// <summary>
        /// 组织编码，当添加小区节点时必填，编码使用01101开头的8位数字编码，当添加楼栋单元时必填，编码使用01101开头的20位数字编码，        其它场景下改值无效
        /// </summary>
        public string OrgCode { get; set; }
    }
}
