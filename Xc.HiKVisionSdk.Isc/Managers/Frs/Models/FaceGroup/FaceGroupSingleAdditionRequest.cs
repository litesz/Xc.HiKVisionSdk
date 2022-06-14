using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸分组新增请求
    /// </summary>
    public class FaceGroupSingleAdditionRequest : BaseRequest
    {
        /// <summary>
        /// 人脸分组的名称，1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分组的描述，1~128个字符
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 人脸分组新增请求
        /// </summary>
        public FaceGroupSingleAdditionRequest() { }

        /// <summary>
        /// 人脸分组新增请求
        /// </summary>
        /// <param name="name">人脸分组的名称</param>
        /// <param name="description">分组的描述</param>
        public FaceGroupSingleAdditionRequest(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {

            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
            if (Name.Length > 32)
            {
                throw new ArgumentOutOfRangeException(nameof(Name), Name.Length, "长度不能超过32个字符");

            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                throw new ArgumentNullException(nameof(Description));
            }
            if (Description.Length > 128)
            {
                throw new ArgumentOutOfRangeException(nameof(Description), Description.Length, "长度不能超过128个字符");
            }
        }
    }
}
