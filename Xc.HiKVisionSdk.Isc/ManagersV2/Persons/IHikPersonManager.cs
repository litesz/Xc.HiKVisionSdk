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
    public interface IHikPersonManager
    {

        /// <summary>
        /// 添加人员v2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>添加人员信息接口，注意，在安保基础数据配置的必选字段必须都包括在入参中。        人员添加的时候，可以指定人员personId，不允许与其他人员personId重复，
        /// 包括已删除的人员。本接口支持人员信息的扩展字段，按照属性定义key:value上传即可， 可通过获取资源属性接口，获取平台已启用的人员属性信息</remarks>
        Task<AddPersonV2Response> AddV2Async(AddPersonV2Request request);


        /// <summary>
        /// 批量添加人员
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>添加人员信息接口，注意，在安保基础数据配置的必选字段必须都包括在入参中。        批量添加仅支持人员基础属性。人员批量添加的时候，可以指定人员personId，不允许与其他人员personId重复，包括已删除的人员。如果用户不想指定personId，那么需要指定clientId，请求内的每一条数据的clientid必须唯一， 返回值会将平台生成的personid与clientid做绑定。若personId和clientId都不指定，则无法准确判断哪部分人员添加成功。本接口支持人员信息的扩展字段，按照属性定义key:value上传即可， 可通过获取资源属性接口，获取平台已启用的人员属性信息。</remarks>
        Task<BatchAddPersonsResponse> BatchAddAsync(BatchAddPersonsRequest request);
        /// <summary>
        /// 修改人员
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据人员编号修改人员信息。        本接口支持人员信息的扩展字段，按照属性定义key:value上传即可， 可通过获取资源属性接口，获取平台已启用的人员属性信息。</remarks>
        Task<UpdatePersonResponse> UpdateAsync(UpdatePersonRequest request);

        /// <summary>
        /// 批量删除人员
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据编号删除人员，人员删除是软删除，可以在安保基础数据查询已删除人员。支持批量删除人员。删除人员将会同时删除人员关联的指纹和人脸信息。</remarks>
        Task<BatchDeletePersonsResponse> BatchDeleteAsync(BatchDeletePersonsRequest request);

        /// <summary>
        /// 获取组织下人员列表v2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据组织编号获取组织下的人员信息列表，返回结果分页展示。        本接口支持自定义属性的返回， 通过获取资源属性接口获取平台已支持人员属性的说明。</remarks>
        Task<GetPersonListByOrgV2Response> GetListByOrgV2Async(GetPersonListByOrgV2Request request);

        /// <summary>
        /// 获取人员列表v2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>获取人员列表接口可用来全量同步人员信息，返回结果分页展示。        本接口支持自定义属性的返回， 通过获取资源属性接口获取平台已支持人员属性的说明。</remarks>
        Task<GetPersonListV2Response> GetListV2Async(GetPersonListV2Request request);

        /// <summary>
        /// 查询人员列表v2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>查询人员列表接口可以根据人员ID集、人员姓名、人员性别、所属组织、证件类型、证件号码、人员状态这些查询条件来进行高级查询；若不指定查询条件，即全量获取所有的人员信息。返回结果分页展示。        注：若指定多个查询条件，表示将这些查询条件进行”与”的组合后进行精确查询。根据”人员名称personName”查询为模糊查询。本接口支持自定义属性的返回，及自定义属性进行查找， 通过获取资源属性接口获取平台已支持人员属性的说明。</remarks>
        Task<GetPersonListByParametersV2Response> GetPersonListByParametersV2Async(GetPersonListByParametersV2Request request);

        /// <summary>
        /// 根据人员唯一字段获取人员详细信息
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>获取人员信息接口，可以根据实名标识(证件号码、人员ID、手机号码、工号)来精确查询人员信息，并返回总数量。</remarks>
        Task<GetPersonDetailResponse> GetDetailAsync(GetPersonDetailRequest request);

        /// <summary>
        /// 增量获取人员数据
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据查询条件查询人员列表信息，主要用于根据时间段分页获取人员信息，包含已删除数据。其中开始日期与结束日期的时间差必须在48小时内。返回信息中只有基础数据，没有人员照片信息。</remarks>
        Task<GetPersonListByTimeRangeResponse> GetListByTimeRangeAsync(GetPersonListByTimeRangeRequest request);

        /// <summary>
        /// 提取人员图片
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据获取人员信息的接口中拿到的图片URI和图片服务器唯一标识，通过该接口得到完整的URL，可以直接从图片服务下载图；        此接口返回重定向请求redirect：picUrl</remarks>
        Task<GetPictureResponse> GetPictureAsync(GetPictureRequest request);
    }

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
        public Task<GetPersonListByParametersV2Response> GetPersonListByParametersV2Async(GetPersonListByParametersV2Request request)
        {
            //TODO: 扩展
            return _hikVisionApiManager.PostAndGetAsync<GetPersonListByParametersV2Request, GetPersonListByParametersV2Response>("/api/resource/v2/person/advance/personList", request, VersionConsts.V1_3);
        }

        /// <summary>
        /// 根据人员唯一字段获取人员详细信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetPersonDetailResponse> GetDetailAsync(GetPersonDetailRequest request)
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
