using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个修改人脸分组请求
    /// </summary>
    public class FaceGroupSingleUpdateRequest : BaseRequest
    {
        /// <summary>
        /// 人脸分组的唯一标识,可从按条件查询人脸分组获取
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 人脸分组的名称,1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 人脸分组的描述，1~128个字符
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 单个修改人脸分组请求
        /// </summary>
        public FaceGroupSingleUpdateRequest() { }

        /// <summary>
        /// 单个修改人脸分组请求
        /// </summary>
        /// <param name="indexCode">人脸分组的唯一标识</param>
        /// <param name="name">人脸分组的名称</param>
        /// <param name="description">人脸分组的描述</param>
        public FaceGroupSingleUpdateRequest(string indexCode, string name, string description)
        {
            IndexCode = indexCode;
            Name = name;
            Description = description;
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(IndexCode))
            {
                throw new ArgumentNullException(nameof(IndexCode));
            }
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                throw new ArgumentNullException(nameof(Description));
            }
            if (Name.Length > 32)
            {
                throw new ArgumentOutOfRangeException(nameof(Name), "长度超过32个字符");

            }
            if (Description.Length > 128)
            {
                throw new ArgumentOutOfRangeException(nameof(Description), "长度超过128个字符");
            }
        }
    }
}
