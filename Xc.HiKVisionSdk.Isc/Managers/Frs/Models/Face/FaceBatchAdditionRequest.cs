using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸批量添加请求
    /// </summary>
    public class FaceBatchAdditionRequest : BaseRequest
    {
        /// <summary>
        /// 请求内容
        /// </summary>
        public FaceBatchAdditionRequestItem[] Items { get; set; }

        /// <summary>
        /// 人脸批量添加请求
        /// </summary>
        public FaceBatchAdditionRequest() { }

        /// <summary>
        /// 人脸批量添加请求
        /// </summary>
        /// <param name="items"></param>
        public FaceBatchAdditionRequest(params FaceBatchAdditionRequestItem[] items)
        {
            Items = items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected override void CheckParams()
        {
            if (Items == null)
            {
                throw new ArgumentNullException(nameof(Items));
            }
            foreach (var item in Items)
            {
                item.Check();
            }

        }
    }
}
