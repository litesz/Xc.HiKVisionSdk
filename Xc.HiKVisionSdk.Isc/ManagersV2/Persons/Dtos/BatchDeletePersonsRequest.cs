using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 批量删除人员请求
    /// </summary>
    public class BatchDeletePersonsRequest : BaseRequest
    {
        /// <summary>
        /// 人员Id，单次操作上限为1000条。
        /// 获取人员列表v2 接口获取返回参数personId
        /// </summary>
        public string[] PersonIds { get; }

        /// <summary>
        /// 批量删除人员请求
        /// </summary>
        /// <param name="personIds">人员Id，单次操作上限为1000条</param>
        public BatchDeletePersonsRequest(params string[] personIds)
        {
            PersonIds = personIds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (PersonIds == null)
            {
                throw new System.ArgumentNullException(nameof(PersonIds));
            }
            if (PersonIds.Length == 0 || PersonIds.Length > 1000)
            {
                throw new System.ArgumentOutOfRangeException(nameof(PersonIds), PersonIds.Length, "单次操作上限为1000条");

            }
        }
    }
}
