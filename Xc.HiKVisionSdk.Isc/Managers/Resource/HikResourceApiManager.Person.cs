using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    /// <summary>
    /// 资源api
    /// </summary>
    public partial class HikResourceApiManager : IHikResourceApiManager
    {
        /// <summary>
        /// 获取组织下人员列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<OrgIndexCodePersonListV2Response> OrgIndexCodePersonListV2Async(OrgIndexCodePersonListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgIndexCodePersonListV2Request, OrgIndexCodePersonListV2Response>("/api/resource/v2/person/orgIndexCode/personList", model, VersionConsts.V1_3);
        }

        /// <summary>
        /// 根据人员编号获取单个人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PersonIdPersonInfoResponse> PersonIdPersonInfoAsync(PersonIdPersonInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonIdPersonInfoRequest, PersonIdPersonInfoResponse>("/api/resource/v1/person/personId/personInfo", model, VersionConsts.V1);
        }

        /// <summary>
        /// 根据证件号码获取单个人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<CertificateNoPersonInfoResponse> CertificateNoPersonInfoAsync(CertificateNoPersonInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CertificateNoPersonInfoRequest, CertificateNoPersonInfoResponse>("/api/resource/v1/person/certificateNo/personInfo", model, VersionConsts.V1);
        }

        /// <summary>
        /// 根据手机号码获取单个人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PhoneNoPersonInfoResponse> PhoneNoPersonInfoAsync(PhoneNoPersonInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PhoneNoPersonInfoRequest, PhoneNoPersonInfoResponse>("/api/resource/v1/person/phoneNo/personInfo", model, VersionConsts.V1);
        }

        /// <summary>
        /// 获取人员列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PersonListV2Response> PersonListV2Async(PersonListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonListV2Request, PersonListV2Response>("/api/resource/v2/person/personList", model, VersionConsts.V1_3);
        }

        /// <summary>
        /// 查询人员列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AdvancePersonListV2Response> AdvancePersonListV2Async(AdvancePersonListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvancePersonListV2Request, AdvancePersonListV2Response>("/api/resource/v2/person/advance/personList", model, VersionConsts.V1_3);
        }

        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PersonSingleAddResponse> PersonSingleAddAsync(PersonSingleAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonSingleAddRequest, PersonSingleAddResponse>("/api/resource/v1/person/single/add", model, VersionConsts.V1_3);
        }

        /// <summary>
        /// 批量添加人员
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PersonBatchAddResponse> PersonBatchAddAsync(PersonBatchAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonBatchAddRequest, PersonBatchAddResponse>("/api/resource/v1/person/batch/add", model, VersionConsts.V1_3);
        }

        /// <summary>
        /// 修改人员
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PersonSingleUpdateResponse> PersonSingleUpdateAsync(PersonSingleUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonSingleUpdateRequest, PersonSingleUpdateResponse>("/api/resource/v1/person/single/update", model, VersionConsts.V1_3);
        }

        /// <summary>
        /// 批量删除人员
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<PersonBatchDeleteResponse> PersonBatchDeleteAsync(PersonBatchDeleteRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonBatchDeleteRequest, PersonBatchDeleteResponse>("/api/resource/v1/person/batch/delete", model, VersionConsts.V1_3);
        }


    }
}
