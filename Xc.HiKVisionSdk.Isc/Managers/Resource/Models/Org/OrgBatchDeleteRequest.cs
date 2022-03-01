namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 批量删除组织
    /// </summary>
    public class OrgBatchDeleteRequest
    {
        /// <summary>
        /// 待删除的组织indexCode列表，单次提交上限为1000条        从获取组织列表 接口获取返回参数orgIndexCode
        /// </summary>
        public string[] IndexCodes { get; set; }
    }
}
