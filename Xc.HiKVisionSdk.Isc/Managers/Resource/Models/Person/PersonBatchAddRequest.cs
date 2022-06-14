using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 批量添加人员请求
    /// </summary>
    public class PersonBatchAddRequest : BaseRequest
    {
        /// <summary>
        /// 批量添加人员信息
        /// </summary>
        public PersonBatchAddRequestItem[] Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public PersonBatchAddRequest(params PersonBatchAddRequestItem[] items)
        {
            Items = items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (Items == null)
            {
                throw new System.ArgumentNullException(nameof(Items));
            }
            if (Items.Length > 1000 || Items.Length == 0)
            {
                throw new System.ArgumentOutOfRangeException(nameof(Items), Items.Length, "单次操作上限为1000条");
            }
            foreach (var item in Items)
            {
                item.Check();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Items.SerializeByCamelCase();
        }
    }
}
