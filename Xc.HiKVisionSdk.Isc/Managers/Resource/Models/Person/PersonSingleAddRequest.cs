namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 添加人员请求
    /// </summary>
    public class PersonSingleAddRequest : PersonRequestBase
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        public FaceInfo[] Faces { get; set; }


        /// <summary>
        /// 添加人员请求
        /// </summary>
        public PersonSingleAddRequest() { }

        /// <summary>
        /// 添加人员请求
        /// </summary>
        /// <param name="personName">人员名称</param>
        /// <param name="orgIndexCode">所属组织标识</param>
        public PersonSingleAddRequest(string personName, string orgIndexCode)
        {
            PersonName = personName;
            OrgIndexCode = orgIndexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(PersonName))
            {
                throw new System.ArgumentNullException(nameof(PersonName));
            }
            if (PersonName.Length > 32)
            {
                throw new System.ArgumentOutOfRangeException(nameof(PersonName), "1~32个字符；不能包含 ’ / \\ : * ? \" < > ");
            }

            if (string.IsNullOrWhiteSpace(OrgIndexCode))
            {
                throw new System.ArgumentNullException(nameof(OrgIndexCode));
            }
        }

    }
}
