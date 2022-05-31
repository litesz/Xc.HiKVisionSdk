using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 根据人员编号获取单个人员信息请求
    /// </summary>
    public class PersonIdPersonInfoRequest : BaseRequest
    {
        /// <summary>
        /// 人员ID, 获取人员列表v2 接口获取
        /// </summary>
        public string PersonId { get; set; }

        /// <summary>
        /// 根据人员编号获取单个人员信息请求
        /// </summary>
        /// <param name="personId"> 人员ID</param>
        public PersonIdPersonInfoRequest(string personId)
        {
            PersonId = personId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        public override void CheckParams()
        {

            if (string.IsNullOrWhiteSpace(PersonId))
            {
                throw new System.ArgumentNullException(nameof(PersonId));
            }
        }
    }

}
