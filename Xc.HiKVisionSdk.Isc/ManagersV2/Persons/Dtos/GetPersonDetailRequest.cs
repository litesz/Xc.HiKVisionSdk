using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 根据人员唯一字段获取人员详细信息请求
    /// </summary>
    public class GetPersonDetailRequest : BaseRequest
    {

        /// <summary>
        /// 参数名        certificateNo：证件号码，从获取人员列表v2接口返回报文中的certificateNo字段        personId：人员Id，从获取人员列表v2接口返回报文中的personId字段；phoneNo：手机号码，从获取人员列表v2接口返回报文中的phoneNo字段；jobNo：工号，从获取人员列表v2接口返回报文中的jobNo字段。
        /// </summary>
        public string ParamName { get; }

        /// <summary>
        /// 根据入参传对应的值，最大1000个
        /// </summary>
        public string[] ParamValue { get; }

        /// <summary>
        /// 根据人员唯一字段获取人员详细信息请求
        /// </summary>
        /// <param name="paramName">参数名  certificateNo：证件号码，从获取人员列表v2接口返回报文中的certificateNo字段        personId：人员Id，从获取人员列表v2接口返回报文中的personId字段；phoneNo：手机号码，从获取人员列表v2接口返回报文中的phoneNo字段；jobNo：工号，从获取人员列表v2接口返回报文中的jobNo字段。</param>
        /// <param name="paramValue">根据入参传对应的值，最大1000个</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public GetPersonDetailRequest(string paramName, params string[] paramValue)
        {

            if (string.IsNullOrWhiteSpace(paramName))
            {
                throw new ArgumentNullException(nameof(paramName));
            }

            paramName = paramName.ToLower().Trim();

            if (paramName != "certificateNo" && paramName != "personId" && paramName != "phoneNo" && paramName != "jobNo")
            {
                throw new ArgumentOutOfRangeException(nameof(paramName), paramName, "只能是 certificateNo,personId,phoneNo,jobNo 之一");
            }

            if (paramValue == null || paramValue.Length == 0)
            {
                throw new ArgumentNullException(nameof(paramValue));
            }

            if (paramValue.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(paramValue), paramValue.Length, "最大1000个");
            }


            ParamName = paramName;
            ParamValue = paramValue;
        }

    }


}
