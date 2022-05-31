using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 根据手机号码获取单个人员信息
    /// </summary>
    public class PhoneNoPersonInfoRequest : BaseRequest
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        public string PhoneNo { get; set; }

        /// <summary>
        /// 根据手机号码获取单个人员信息
        /// </summary>
        /// <param name="phoneNo">电话号码</param>
        public PhoneNoPersonInfoRequest(string phoneNo)
        {
            PhoneNo = phoneNo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {

            if (string.IsNullOrWhiteSpace(PhoneNo))
            {
                throw new System.ArgumentNullException(nameof(PhoneNo));
            }

            if (PhoneNo.Length != 11)
            {
                throw new System.ArgumentOutOfRangeException(nameof(PhoneNo), "手机号长度为 11 位");
            }

        }
    }

}
