namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    public class PersonBatchAddResponseData
    {
        /// <summary>
        /// 批量添加成功的记录
        /// </summary>
        public PersonBatchAddResponseSuccess[] Successes { get; set; }
        /// <summary>
        /// 批量添加失败的记录
        /// </summary>
        public PersonBatchAddResponseFailures[] Failures { get; set; }
    }
}
