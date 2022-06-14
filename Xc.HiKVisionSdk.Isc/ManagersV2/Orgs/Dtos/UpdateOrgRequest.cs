using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 修改组织请求
    /// </summary>
    public class UpdateOrgRequest : BaseRequest
    {

        private readonly Dictionary<string, string> _parameters;

        /// <summary>
        /// 组织标识，必须保证已存在，        从获取组织列表 接口获取返回参数orgIndexCode。
        /// </summary>
        public string OrgIndexCode { get; }

        /// <summary>
        /// 组织名称，1~32个字符；不能包含<![CDATA[’ / \ : * ? " < >]]>
        /// </summary>
        public string OrgName { get; }


        /// <summary>
        /// 修改组织请求
        /// </summary>
        /// <param name="orgIndexCode">组织标识，必须保证已存在，        从获取组织列表 接口获取返回参数orgIndexCode。</param>
        /// <param name="orgName">组织名称，1~32个字符；不能包含<![CDATA[’ / \ : * ? " < >]]></param>
        /// <param name="parameters">其他扩展属性，键值对的方式</param>
        public UpdateOrgRequest(string orgIndexCode, string orgName = "", Dictionary<string, string> parameters = null)
        {
            if (string.IsNullOrWhiteSpace(orgIndexCode))
            {
                throw new ArgumentNullException(nameof(orgIndexCode));
            }
            OrgIndexCode = orgIndexCode;
            OrgName = orgName;
            _parameters = parameters;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string para = "";

            if (_parameters != null && _parameters.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var key in _parameters.Keys)
                {
                    if (string.IsNullOrWhiteSpace(key))
                    {
                        throw new ArgumentNullException("", "扩展属性键不能为空");
                    }
                    if (key.Length > 1)
                    {
                        sb.Append($",\"{key.First().ToString().ToLower()}{key.Substring(1)}\":\"{_parameters[key]}\"");
                    }
                    else
                    {
                        sb.Append($",\"{key.ToLower()}\":\"{_parameters[key]}\"");
                    }
                }

                para = sb.ToString();
            }


            return $"{{\"orgIndexCode\":\"{OrgIndexCode}\",\"orgName\":\"{OrgName}\"{para}}}";
        }

    }
}
