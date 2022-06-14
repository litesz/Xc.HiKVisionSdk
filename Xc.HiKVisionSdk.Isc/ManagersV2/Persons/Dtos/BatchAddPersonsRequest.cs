using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 批量添加人员请求
    /// </summary>
    public class BatchAddPersonsRequest : BaseRequest
    {
        /// <summary>
        /// 批量添加人员信息
        /// </summary>
        public BatchAddPersonsRequestItem[] Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public BatchAddPersonsRequest(params BatchAddPersonsRequestItem[] items)
        {
            if (items == null)
            {
                throw new System.ArgumentNullException(nameof(items));
            }
            if (items.Length > 1000 || items.Length == 0)
            {
                throw new System.ArgumentOutOfRangeException(nameof(items), items.Length, "单次操作上限为1000条");
            }
            Items = items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {

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
