using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards
{
    /// <summary>
    /// 人员卡片管理
    /// </summary>
    public class HikCardManager : IHikCardManager
    {

        private readonly IHikVisionIscApiManager _hikVisionApiManager;

        /// <summary>
        /// 人员卡片接口
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikCardManager(IHikVisionIscApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 获取卡片列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetCardListResponse> GetListAsync(GetCardListRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetCardListRequest, GetCardListResponse>("/api/resource/v1/card/cardList", request, VersionConsts.V1_2);
        }


        /// <summary>
        /// 增量获取卡片数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetCardListByTimeRangeResponse> GetListByTimeRangeAsync(GetCardListByTimeRangeRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetCardListByTimeRangeRequest, GetCardListByTimeRangeResponse>("/api/resource/v1/card/timeRange", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 获取单个卡片信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetCardResponse> GetInfoAsync(GetCardRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetCardRequest, GetCardResponse>("/api/irds/v1/card/cardInfo", request, VersionConsts.V1_2);
        }



        /// <summary>
        /// 查询卡片列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetCardListByParametersResponse> GetListByParametersAsync(GetCardListByParametersRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GetCardListByParametersRequest, GetCardListByParametersResponse>("/api/irds/v1/card/advance/cardList", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 生成卡片二维码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GenerateBarCodeResponse> GenerateBarCodeAsync(GenerateBarCodeRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<GenerateBarCodeRequest, GenerateBarCodeResponse>("/api/cis/v1/card/barCode", request, VersionConsts.V1_4);
        }


        /// <summary>
        /// 批量开卡
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BindingCardsResponse> BindingAsync(BindingCardsRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<BindingCardsRequest, BindingCardsResponse>("/api/cis/v1/card/bindings", request, VersionConsts.V1_5);
        }

        /// <summary>
        /// 卡片退卡
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<DeletionCardResponse> DeletionAsync(DeletionCardRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<DeletionCardRequest, DeletionCardResponse>("/api/cis/v1/card/deletion", request, VersionConsts.V1_2);
        }

        /// <summary>
        /// 批量挂失
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<AddCardsLossResponse> AddLossAsync(AddCardsLossRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<AddCardsLossRequest, AddCardsLossResponse>("/api/cis/v1/card/batch/loss", request, VersionConsts.V1_4);
        }

        /// <summary>
        /// 批量解挂
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<DeleteCardsLossResponse> DeleteLossAsync(DeleteCardsLossRequest request)
        {
            return _hikVisionApiManager.PostAndGetAsync<DeleteCardsLossRequest, DeleteCardsLossResponse>("/api/cis/v1/card/batch/unloss", request, VersionConsts.V1_4);
        }
    }

}
