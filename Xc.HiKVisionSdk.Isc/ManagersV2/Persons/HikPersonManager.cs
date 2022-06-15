using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons
{
    /// <summary>
    /// 人员及照片管理
    /// </summary>
    public class HikPersonManager : IHikPersonManager
    {
        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 人员及照片管理
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikPersonManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 添加人员v2
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<AddPersonV2Response> AddV2Async(AddPersonV2Request request)
        {
            //TODO： 扩展
            return _hikVisionApiManager.PostAndGetAsync<AddPersonV2Request, AddPersonV2Response>("/api/resource/v2/person/single/add", request, VersionConsts.V1_5);
        }

        /// <summary>
        /// 批量添加人员
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BatchAddPersonsResponse> BatchAddAsync(BatchAddPersonsRequest request)
        {
            //TODO： 扩展
            return _hikVisionApiManager.PostAndGetAsync<BatchAddPersonsRequest, BatchAddPersonsResponse>("/api/resource/v1/person/batch/add", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 修改人员
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<UpdatePersonResponse> UpdateAsync(UpdatePersonRequest request)
        {
            //TODO： 扩展
            return _hikVisionApiManager.PostAndGetAsync<UpdatePersonRequest, UpdatePersonResponse>("/api/resource/v1/person/single/update", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 批量删除人员
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BatchDeletePersonsResponse> BatchDeleteAsync(BatchDeletePersonsRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<BatchDeletePersonsRequest, BatchDeletePersonsResponse>("/api/resource/v1/person/batch/delete", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 获取组织下人员列表v2
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPersonListByOrgV2Response> GetListByOrgV2Async(GetPersonListByOrgV2Request request)
        {
            //TODO: 扩展
            return _hikVisionApiManager.PostAndGetAsync<GetPersonListByOrgV2Request, GetPersonListByOrgV2Response>("/api/resource/v2/person/orgIndexCode/personList", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 获取人员列表v2
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPersonListV2Response> GetListV2Async(GetPersonListV2Request request)
        {
            //TODO: 扩展
            return _hikVisionApiManager.PostAndGetAsync<GetPersonListV2Request, GetPersonListV2Response>("/api/resource/v2/person/personList", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 查询人员列表v2
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPersonListByParametersV2Response> GetListByParametersV2Async(GetPersonListByParametersV2Request request)
        {
            //TODO: 扩展
            return _hikVisionApiManager.PostAndGetAsync<GetPersonListByParametersV2Request, GetPersonListByParametersV2Response>("/api/resource/v2/person/advance/personList", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 根据人员唯一字段获取人员详细信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPersonDetailResponse> GetDetailListAsync(GetPersonDetailRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetPersonDetailRequest, GetPersonDetailResponse>("/api/resource/v1/person/condition/personInfo", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 增量获取人员数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPersonListByTimeRangeResponse> GetListByTimeRangeAsync(GetPersonListByTimeRangeRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetPersonListByTimeRangeRequest, GetPersonListByTimeRangeResponse>("/api/resource/v1/person/personList/timeRange", request, VersionConsts.V1_4);
        }


        /// <summary>
        /// 提取人员图片
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<GetPictureResponse> GetPictureAsync(GetPictureRequest request)
        {
            var response = await _hikVisionApiManager.PostAsync("/api/resource/v1/person/picture", request, VersionConsts.V1);
            if (response.IsSuccessStatusCode)
            {
                return new GetPictureResponse
                {
                    Code = "0",
                    Data = response.Headers.GetValues("Location").First(),
                    Msg = "SUCCESS"
                };
            }
            string result = await response.Content.ReadAsStringAsync();
            var output = Newtonsoft.Json.JsonConvert.DeserializeObject<GetPictureResponse>(result);
            if (output.Status != 0)
            {
                //output.Code = output.Status.ToString();
                //output
                throw new HttpRequestException(result);
            }
            return output;
        }
    }
}
