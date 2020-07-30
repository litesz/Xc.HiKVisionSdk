using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource
{
    public partial interface IHikResourceApiManager
    {

        /// <summary>
        /// 获取组织下人员列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据组织编号获取组织下的人员信息列表，返回结果分页展示。
        /// 本接口支持自定义属性的返回， 通过获取资源属性接口获取平台已支持人员属性的说明。</remarks>
        Task<OrgIndexCodePersonListV2Response> OrgIndexCodePersonListV2Async(OrgIndexCodePersonListV2Request model);

        /// <summary>
        /// 根据手机号码获取单个人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据手机号码获取指定人员的信息。此接口不支持自定义属性</remarks>
        Task<PhoneNoPersonInfoResponse> PhoneNoPersonInfoAsync(PhoneNoPersonInfoRequest model);

        /// <summary>
        /// 根据证件号码获取单个人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据证件类型、证件号码获取指定人员的信息。此接口不支持自定义属性</remarks>
        Task<CertificateNoPersonInfoResponse> CertificateNoPersonInfoAsync(CertificateNoPersonInfoRequest model);

        /// <summary>
        /// 根据人员编号获取单个人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>根据人员ID获取指定人员的信息。此接口不支持自定义属性</remarks>
        Task<PersonIdPersonInfoResponse> PersonIdPersonInfoAsync(PersonIdPersonInfoRequest model);

        /// <summary>
        /// 获取人员列表v2
        /// </summary>
        /// <remarks>获取人员列表接口可用来全量同步人员信息，返回结果分页展示。
        /// 本接口支持自定义属性的返回， 通过获取资源属性接口获取平台已支持人员属性的说明。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PersonListV2Response> PersonListV2Async(PersonListV2Request model);

        /// <summary>
        /// 查询人员列表v2
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>查询人员列表接口可以根据人员ID集、人员姓名、人员性别、所属组织、证件类型、证件号码、人员状态这些查询条件来进行高级查询；若不指定查询条件，即全量获取所有的人员信息。返回结果分页展示。
        /// 注：若指定多个查询条件，表示将这些查询条件进行”与”的组合后进行精确查询。
        /// 根据”人员名称personName”查询为模糊查询。
        /// 本接口支持自定义属性的返回，及自定义属性进行查找， 通过获取资源属性接口获取平台已支持人员属性的说明。</remarks>
        Task<AdvancePersonListV2Response> AdvancePersonListV2Async(AdvancePersonListV2Request model);

        /// <summary>
        /// 添加人员
        /// </summary>
        /// <remarks>添加人员信息接口，注意，在安保基础数据配置的必选字段必须都包括在入参中。
        /// 人员添加的时候，可以指定人员personId，不允许与其他人员personId重复，包括已删除的人员。
        /// 本接口支持人员信息的扩展字段，按照属性定义key:value上传即可， 可通过获取资源属性接口，获取平台已启用的人员属性信息。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PersonSingleAddResponse> PersonSingleAddAsync(PersonSingleAddRequest model);

        /// <summary>
        /// 批量添加人员
        /// </summary>
        /// <remarks>
        /// 添加人员信息接口，注意，在安保基础数据配置的必选字段必须都包括在入参中。
        /// 批量添加仅支持人员基础属性。
        /// 人员批量添加的时候，可以指定人员personId，不允许与其他人员personId重复，包括已删除的人员。
        /// 如果用户不想指定personId，那么需要指定clientId，请求内的每一条数据的clientid必须唯一， 返回值会将平台生成的personid与clientid做绑定。
        /// 若personId和clientId都不指定，则无法准确判断哪部分人员添加成功。
        /// 本接口支持人员信息的扩展字段，按照属性定义key:value上传即可， 可通过获取资源属性接口，获取平台已启用的人员属性信息。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PersonBatchAddResponse> PersonBatchAddAsync(PersonBatchAddRequest model);
        /// <summary>
        /// 修改人员
        /// </summary>
        /// <remarks>根据人员编号修改人员信息。
        /// 本接口支持人员信息的扩展字段，按照属性定义key:value上传即可， 可通过获取资源属性接口，获取平台已启用的人员属性信息。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PersonSingleUpdateResponse> PersonSingleUpdateAsync(PersonSingleUpdateRequest model);
        /// <summary>
        /// 批量删除人员
        /// </summary>
        /// <remarks>根据编号删除人员，人员删除是软删除，可以在安保基础数据查询已删除人员。支持批量删除人员。删除人员将会同时删除人员关联的指纹和人脸信息。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PersonBatchDeleteResponse> PersonBatchDeleteAsync(PersonBatchDeleteRequest model);



    }
}
