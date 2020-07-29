using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{

    public partial class HikResourceApiManager : IHikResourceApiManager
    {

        public Task<OrgIndexCodePersonListV2Response> PersonIdPersonInfoAsync(OrgIndexCodePersonListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OrgIndexCodePersonListV2Request, OrgIndexCodePersonListV2Response>("/artemis/api/resource/v2/person/orgIndexCode/personList", model, Const.V1_3);
        }

        public Task<PersonIdPersonInfoResponse> PersonIdPersonInfoAsync(PersonIdPersonInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonIdPersonInfoRequest, PersonIdPersonInfoResponse>("/artemis/api/resource/v1/person/personId/personInfo", model, Const.V1_0);
        }

        public Task<CertificateNoPersonInfoResponse> CertificateNoPersonInfoAsync(CertificateNoPersonInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<CertificateNoPersonInfoRequest, CertificateNoPersonInfoResponse>("/artemis/api/resource/v1/person/certificateNo/personInfo", model, Const.V1_0);
        }

        public Task<PhoneNoPersonInfoResponse> PhoneNoPersonInfoAsync(PhoneNoPersonInfoRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PhoneNoPersonInfoRequest, PhoneNoPersonInfoResponse>("/artemis/api/resource/v1/person/phoneNo/personInfo", model, Const.V1_0);
        }


        public Task<PersonListV2Response> PersonListV2Async(PersonListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonListV2Request, PersonListV2Response>("/artemis/api/resource/v2/person/personList", model, Const.V1_3);
        }

        public Task<AdvancePersonListV2Response> AdvancePersonListV2Async(AdvancePersonListV2Request model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AdvancePersonListV2Request, AdvancePersonListV2Response>("/artemis/api/resource/v2/person/advance/personList", model, Const.V1_3);
        }

        public Task<PersonSingleAddResponse> PersonSingleAddAsync(PersonSingleAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonSingleAddRequest, PersonSingleAddResponse>("/artemis/api/resource/v1/person/single/add", model, Const.V1_3);
        }

        public Task<PersonBatchAddResponse> PersonBatchAddAsync(PersonBatchAddRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonBatchAddRequestItem[], PersonBatchAddResponse>("/artemis/api/resource/v1/person/batch/add", model.Items, Const.V1_3);
        }

        public Task<PersonSingleUpdateResponse> PersonSingleUpdateAsync(PersonSingleUpdateRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonSingleUpdateRequest, PersonSingleUpdateResponse>("/artemis/api/resource/v1/person/single/update", model, Const.V1_3);
        }


        public Task<PersonBatchDeleteResponse> PersonBatchDeleteAsync(PersonBatchDeleteRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<PersonBatchDeleteRequest, PersonBatchDeleteResponse>("/artemis/api/resource/v1/person/batch/delete", model, Const.V1_3);
        }


    }
}
