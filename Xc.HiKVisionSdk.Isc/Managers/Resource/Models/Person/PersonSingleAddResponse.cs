using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    public class PersonSingleAddResponse : HiKVisionResponse
    {
        /// <summary>
        /// 成功添加的人员的Id
        /// </summary>
        public string Data { get; set; }
    }
}
