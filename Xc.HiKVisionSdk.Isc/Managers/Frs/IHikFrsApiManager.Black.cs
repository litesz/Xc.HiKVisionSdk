using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs
{
    /// <summary>
    /// 人脸应用服务
    /// </summary>
    public partial interface IHikFrsApiManager
    {

        /// <summary>
        /// 单个添加重点人员识别计划
        /// </summary>
        /// <remarks>
        /// a)该接口可以新增一条重点人员识别计划，以实现将若干抓拍点抓拍到的人脸，通过若干识别资源同若干分组内的人脸比较，并将命中结果以事件形式上报。
        /// b)配置一条识别计划需要人脸分组集合（通过”按条件查询人脸分组”接口获取），抓拍点集合（通过LDAP服务获取监控点，并通过型号确定抓拍点），识别资源集合（通过”按条件查询识别资源”接口获取）。
        ///c)一条重点人员识别计划只能配置一种识别资源类别：深眸或脸谱或超脑。
        ///d)一条重点人员识别计划，可以配置多个超脑作为识别资源或一个脸谱作为识别资源。
        ///e)一条重点人员识别计划如果配置深眸作为识别资源，则recognitionResourceIndexCodes可以传空。因为深眸的抓拍点就是识别资源本身，人脸监控应用服务会根据抓拍点自动匹配正确的识别资源。
        ///f)人脸监控应用服务会校验抓拍点的有效性。校验规则如下：超脑作为识别资源时，抓拍点必须是超脑的通道；脸谱作为识别资源时，脸谱作为识别资源时，抓拍点一般为深眸或其他人脸抓拍机通道；深眸作为识别资源时，抓拍点必须是深眸的通道；一个通道是否是深眸/超脑/抓拍机的通道，取决于通道所属设备的型号，详见附录I 人脸监控应用服务支持设备型号列表。
        ///g)重点人员识别计划配置有以下限制，这些限制会在添加时作为特殊错误返回：超脑的一个通道只能配置一次重点人员识别计划；同一个抓拍点不能同时配置在多个脸谱上；抓拍点或识别资源没有同步到IAC前，无法配置识别计划。
        ///h)识别计划的配置为异步过程，调用接口成功后，人脸监控应用服务会在后台自动下发人脸分组并执行布控操作，可以通过接口”单个查询重点人员识别计划详情”查询该识别计划的下发结果。
        ///i) 识别计划支持配置时间计划模板，当时间计划参数不传时，默认全天候。当传入此参数时，时间计划规则如下：按周计划进行配置，每一天的时间段上限为8，每一个时间段的开始时间必须小于结束时间。
        ///j)同一个深眸支持配置多个识别计划。
        ///k)若设备上人脸分组达到上限，则有可能导致下发失败。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PlanRecognitionBlackAdditionResponse> PlanRecognitionBlackAdditionAsync(PlanRecognitionBlackAdditionRequest model);

        /// <summary>
        /// 删除重点人员识别计划
        /// </summary>
        /// <remarks>
        /// a)根据重点人员识别计划的唯一标识,删除若干重点人员识别计划，返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)删除识别计划后，会异步删除识别计划中下发到设备上的人脸分组、人脸、布控信息。因此调用接口成功的时候，可以观察到识别资源上的分组还是存在的，需要等一段时间后才会删除。
        /// c)请勿在识别计划正在下发时，调用删除识别计划的接口。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PlanRecognitionBlackDeletionResponse> PlanRecognitionBlackDeletionAsync(PlanRecognitionBlackDeletionRequest model);

        /// <summary>
        /// 单个修改重点人员识别计划
        /// </summary>
        /// <remarks>
        /// a)修改指定的重点人员识别计划信息，返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)修改识别计划时，传入的信息和添加一致，不需要修改的字段也要传过来，但是部分不支持修改的字段不需要传，详情请以入参说明为准。
        /// c)修改识别计划的接口校验同添加一致，请见单个添加重点人员识别计划中的接口说明。
        /// d)识别计划修改后，会自动重新下发。
        /// e)脸谱作为识别资源的识别计划，不支持更换识别资源。深眸、超脑作为识别资源时不支持修改识别资源的类型。
        /// f) 识别计划支持配置时间计划模板，当时间计划参数不传时，默认全天候。当传入此参数时，时间计划规则如下：按周计划进行配置，每一天的时间段上限为8，每一个时间段的开始时间必须小于结束时间。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PlanRecognitionBlackUpdateResponse> PlanRecognitionBlackUpdateAsync(PlanRecognitionBlackUpdateRequest model);

        /// <summary>
        /// 单个查询重点人员识别计划详情
        /// </summary>
        /// <remarks>a)根据重点人员识别计划的唯一标识，查询单个重点人员识别计划的下发状态和结果详情。
        /// b)返回的结果中包含了识别计划的所有信息和下发状态。还包含了人脸分组、人脸、通道布控的结果，其中人脸下发结果以分页方式返回。
        /// c)通道布控的结果，在超脑作为识别资源的识别计划中才会返回；脸谱和深眸作为识别资源时，该字段为空集合。
        /// d)调用方可以通过定时调用该接口，获取识别计划的下发情况和具体每张人脸的下发结果。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PlanRecognitionBlackDetailResponse> PlanRecognitionBlackDetailAsync(PlanRecognitionBlackDetailRequest model);

        /// <summary>
        /// 查询重点人员识别计划
        /// </summary>
        /// <remarks>a)根据查询条件，查询符合条件的重点人员识别计划的集合。
        /// b)查询条件之间的关系为与，即所有条件同时生效，不传任何条件代表查询所有。
        /// c)这里的人脸分组集合作为查询条件，如果传多个分组，则识别计划只要包含其中任意一个分组，就会被查询出来。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PlanRecognitionBlackResponse> PlanRecognitionBlackAsync(PlanRecognitionBlackRequest model);

        /// <summary>
        /// 重新下发重点人员识别计划
        /// </summary>
        /// <remarks>a)重新下发指定的重点人员识别计划，返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)重新下发只能针对状态为下发失败的识别计划操作，且重新下发只会下发失败的部分，对于已经成功的部分不会重复下发。
        /// c)重新下发的结果可以通过单个查询重点人员识别计划详情查看。</remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<PlanRecognitionBlackRestartResponse> PlanRecognitionBlackRestartAsync(PlanRecognitionBlackRestartRequest model);
    }
}
