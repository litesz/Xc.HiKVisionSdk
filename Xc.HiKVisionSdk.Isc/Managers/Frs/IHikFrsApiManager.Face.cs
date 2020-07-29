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
        /// 单个添加人脸
        /// </summary>
        /// <remarks>
        /// a)一次性添加一张人脸，返回结果为添加成功的人脸。
        /// b)添加的人脸图片，目前支持URL方式和二进制数据方式。URL方式时，人脸监控应用服务会通过HTTP协议的GET方式下载图片，校验图片，最后重新上传图片；二进制数据是指图片的字节流经过Base64编码后得到的字符串。
        /// c)该URL能通过HTTP协议的GET方式能下载获取到即可，若包含认证，由调用方在URL中加上认证信息，保证URL能成功访问。
        /// d)人脸监控应用服务会根据图片存储位置配置，将图片上传到图片存储服务器中，返回的URL为图片存储服务器上的相对地址。
        /// e)图片大小和格式均有要求，上传大小在10KB到200KB见的图片，上传JPG格式的图片。
        /// f)若添加的人脸对应的人脸分组已经配置有识别计划，则新添加的人脸会被一并下发到设备上。
        /// g)该接口依赖于图片存储位置已配置完，请确保平台已经配置有人脸图片存储位置，否则添加必定失败。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceSingleAdditionResponse> FaceSingleAdditionAsync(FaceSingleAdditionRequest model);

        /// <summary>
        /// 批量添加人脸
        /// </summary>
        /// <remarks>
        /// a)本接口只支持将安保基础数据中人员的人脸图片导入到人脸监控的人脸分组中。
        /// b)一次性添加一批人脸，添加结果由接口同步返回成功还是失败。
        /// c)一次最多导入1000个人脸。
        /// d)若添加的人脸对应的人脸分组已经配置有识别计划，则新添加的人脸会被一并下发到设备上。
        /// e)入参和单个添加人脸的接口不相同，批量接口只需要传入安保基础数据人员indexCode和要加入的人脸分组indexCode。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceBatchAdditionResponse> FaceBatchAdditionAsync(FaceBatchAdditionRequest model);

        /// <summary>
        /// 批量删除人脸
        /// 
        /// </summary>
        /// <remarks>
        /// a)根据人脸删除条件删除一批人脸，返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)若删除的人脸对应的人脸分组已经配置有识别计划，则删除的人脸会被一并从设备上删除。
        /// c)该接口是从指定分组内删除指定人脸。
        /// d)人脸分组唯一标识和人脸的唯一标识集合均不能为空。
        /// e)一次性最多从一个分组内删除1000个人脸。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceBatchDeletionResponse> FaceBatchDeletionAsync(FaceBatchDeletionRequest model);

        /// <summary>
        /// 单个修改人脸
        /// 
        /// </summary>
        /// <remarks>
        /// a)修改单张人脸信息,返回的data为布尔类型，true代表操作成功，false代表操作失败。
        /// b)若修改的人脸对应的人脸分组已经配置有识别计划，则修改后的人脸会被重新下发到设备上。
        /// c)修改后的字段信息以修改时传入的字段为准，若不传字段或传入null字段，则该字段会被置为null。
        /// d)如果要修改人脸信息，则需要传递faceInfo对象。
        /// e)如果要修改人脸图片，则需要传递facePic对象。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceSingleUpdateResponse> FaceSingleUpdateAsync(FaceSingleUpdateRequest model);

        /// <summary>
        /// 按条件批量查询人脸
        /// 
        /// </summary>
        /// <remarks>
        /// a)根据查询条件，批量查询人脸信息，一次性最多查询1000条人脸。
        /// b)查询条件之间的关系为与，即所有条件同时生效。
        /// c)可以通过传入faceGroupIndexCode，查询指定人脸分组下的人脸。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceResponse> FaceAsync(FaceRequest model);

        /// <summary>
        /// 批量拷贝人脸到人脸分组
        /// </summary>
        /// <remarks>
        /// a)批量将若干人脸拷贝到若干分组内。
        /// b)这个接口可以实现将平台已经存在的人脸迁移到其它分组内。
        /// c)无论如何调用该接口，同一个分组内不会出现两个indexCode相同的人脸。
        /// d)若人脸已经在人脸分组内了，重复的迁移操作也会返回成功。
        /// e)拷贝一次性最多拷贝1000张图片，最多同时拷贝到16个分组内。
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<FaceBatchCopyResponse> FaceBatchCopyAsync(FaceBatchCopyRequest model);
    }
}
