namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 修改人员请求
    /// </summary>
    public class PersonSingleUpdateRequest : PersonRequestBase
    {

        /// <summary>
        /// 修改人员请求
        /// </summary>
        public PersonSingleUpdateRequest()
        {

        }

        /// <summary>
        /// 修改人员请求
        /// </summary>
        /// <param name="personId">人员id</param>
        public PersonSingleUpdateRequest(string personId)
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
