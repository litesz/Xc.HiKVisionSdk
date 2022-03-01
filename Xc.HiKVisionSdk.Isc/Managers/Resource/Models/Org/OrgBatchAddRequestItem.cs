namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 批量添加人员请求详细
    /// </summary>
    public class OrgBatchAddRequestItem
    {
        /// <summary>
        /// 调用方指定标识，接口执行成功后将服务端生成的标识与此标识绑定后返回
        /// 所以建议每次接口调用，clientid保持唯一。1~10个字符，只支持数字。
        /// 注释：ISC不对clientid做校验和存储
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
        /// 父组织唯一标识码
        /// </summary>
        public string ParentIndexCode { get; set; } = "root000000";
        /// <summary>
        /// 组织编码，当添加小区节点时必填，编码使用01101开头的8位数字编码，当添加楼栋单元时必填，编码使用01101开头的20位数字编码，        其它场景下改值无效
        /// </summary>
        public string OrgCode { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        /// <param name="orgName">组织名称，1~32个字符；不能包含 ’ / \ : * ? "</param>
        /// <param name="clientId">调用方指定标识，接口执行成功后将服务端生成的标识与此标识绑定后返回</param>
        public OrgBatchAddRequestItem(string orgName, int clientId = 0)
        {
            OrgName = orgName;
            ClientId = clientId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgName">组织名称，1~32个字符；不能包含 ’ / \ : * ? "</param>
        /// <param name="orgIndexCode">组织唯一标志，不允许与其它组织唯一标志重复，包括已删除的组织，值为空或者不传此字段系统自动生成唯一标志</param>
        /// <param name="parentIndexCode">父组织唯一标识码</param>
        /// <param name="clientId">调用方指定标识，接口执行成功后将服务端生成的标识与此标识绑定后返回</param>
        /// <param name="orgCode">组织编码，当添加小区节点时必填，编码使用01101开头的8位数字编码，当添加楼栋单元时必填，编码使用01101开头的20位数字编码</param>
        public OrgBatchAddRequestItem(string orgName, string orgIndexCode, string parentIndexCode = "root000000", int clientId = 0, string orgCode = "") : this(orgName, clientId)
        {
            OrgIndexCode = orgIndexCode;
            ParentIndexCode = parentIndexCode;
            OrgCode = orgCode;
        }


    }
}
