namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 批量删除人员请求
    /// </summary>
    public class PersonBatchDeleteRequest
    {
        /// <summary>
        /// 人员Id，单次操作上限为1000条。
        /// 获取人员列表v2 接口获取返回参数personId
        /// </summary>
        public string[] PersonIds { get; set; }
    }
}
