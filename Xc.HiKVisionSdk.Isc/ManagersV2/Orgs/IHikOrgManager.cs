using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs
{
    /// <summary>
    /// 组织管理
    /// </summary>
    public interface IHikOrgManager
    {
        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据组织编号修改组织信息。其它扩展属性按照定义以 key：value 上传即可，根据获取资源属性接口查询平台已配置的资源属性</remarks>

        Task<UpdateOrgResponse> UpdateAsync(UpdateOrgRequest request);

        /// <summary>
        /// 批量删除组织
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>仅支持删除无子结点且组织下不存在人员的组织。</remarks>
        Task<BatchDeleteOrgsResponse> BatchDeleteAsync(BatchDeleteOrgsRequest request);

        /// <summary>
        /// 批量添加组织
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>支持三方指定组织唯一标识， 也支持ISC独立生成组织唯一标识。</remarks>
        Task<BatchAddOrgsResponse> BatchAddAsync(BatchAddOrgsRequest request);

        /// <summary>
        /// 获取根组织
        /// </summary>
        /// <returns></returns>
        /// <remarks>获取根组织接口用来获取组织的根节点。</remarks>
        Task<GetRootOrgResponse> GetRootAsync();

        /// <summary>
        /// 获取组织列表
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据该接口全量同步组织信息,不作权限过滤，返回结果分页展示。</remarks>
        Task<GetOrgListResponse> GetListAsync(GetOrgListRequest request);

        /// <summary>
        /// 获取组织列表v2
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据不同的组织属性分页查询组织信息。        查询组织列表接口可以根据组织唯一标识集、组织名称、组织状态等查询条件来进行高级查询。</remarks>
        Task<GetOrgListByParametersV2Response> GetListByParametersV2Async(GetOrgListByParametersV2Request request);

        /// <summary>
        /// 根据父组织编号获取下级组织列表
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据父组织编号获取下级组织列表，主要用于逐层获取父组织的下级组织信息，返回结果分页展示</remarks>
        Task<GetSubOrgListResponse> GetSubListAsync(GetSubOrgListRequest request);

        /// <summary>
        /// 增量获取组织数据
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据查询条件查询组织列表信息，主要根据时间段分页获取组织数据，包含已删除数据。其中开始日期与结束日期的时间差必须在1-48小时内。</remarks>
        Task<GetOrgListByTimeRangeResponse> GetListByTimeRangeAsync(GetOrgListByTimeRangeRequest request);

        /// <summary>
        /// 根据组织编号获取组织详细信息
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        /// <remarks>根据组织编号orgIndexCode列表获取指定的组织信息，如存在多组织则返回总条数及多组织信息。</remarks>
        Task<GetOrgListByIndexCodesResponse> GetListByIndexCodesAsync(GetOrgListByIndexCodesRequest request);
    }
}
