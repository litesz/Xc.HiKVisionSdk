using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 重点监控人员添加识别计划请求
    /// </summary>
    public class PlanRecognitionBlackAdditionRequest : BaseRequest
    {
        /// <summary>
        /// 识别计划名称,1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 人脸分组唯一标识的集合，非空，人脸监控应用服务会校验标识的有效性，
        /// 可从按条件查询人脸分组获取
        /// </summary>
        public string[] FaceGroupIndexCodes { get; set; }
        /// <summary>
        /// 抓拍点通道唯一标识的集合，非空，人脸监控应用服务会校验抓拍点标识的有效性，
        /// 可通过分页获取监控点资源获取
        /// </summary>
        public string[] CameraIndexCodes { get; set; }
        /// <summary>
        /// 识别资源唯一标识的集合。人脸监控应用服务会校验识别资源标识的有效性，若有重复、无效的标识，校验不通过。识别资源类型为深眸时，可以为空。
        /// 可从按条件查询识别资源获取
        /// </summary>
        public string[] RecognitionResourceIndexCodes { get; set; }
        /// <summary>
        /// 识别资源类型，
        /// SUPER_BRAIN 超脑，
        /// FACE_RECOGNITION_SERVER 脸谱，
        /// COMPARISON 深眸
        /// </summary>
        public string RecognitionResourceType { get; set; }
        /// <summary>
        /// 识别计划描述，1~128个字符
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 识别计划的阈值，重点人员是指相似度超过该值时报警，范围[1, 100)
        /// </summary>
        public int Threshold { get; set; }
        /// <summary>
        /// 时间计划模板，不填默认全天候
        /// </summary>
        public TimeBlock[] TimeBlockList { get; set; }

        /// <summary>
        /// 重点监控人员添加识别计划请求
        /// </summary>
        public PlanRecognitionBlackAdditionRequest() { }

        /// <summary>
        /// 重点监控人员添加识别计划请求
        /// </summary>
        /// <param name="name">识别计划名称</param>
        /// <param name="recognitionResourceType">识别资源类型，SUPER_BRAIN 超脑，FACE_RECOGNITION_SERVER 脸谱，COMPARISON 深眸</param>
        /// <param name="threshold">识别计划的阈值</param>
        /// <param name="faceGroupIndexCodes">人脸分组唯一标识的集合</param>
        /// <param name="cameraIndexCodes">抓拍点通道唯一标识的集合</param>
        public PlanRecognitionBlackAdditionRequest(string name, string recognitionResourceType, int threshold, string[] faceGroupIndexCodes, string[] cameraIndexCodes)
        {
            Name = name;
            RecognitionResourceType = recognitionResourceType;
            Threshold = threshold;
            FaceGroupIndexCodes = faceGroupIndexCodes;
            CameraIndexCodes = cameraIndexCodes;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }
            if (string.IsNullOrWhiteSpace(RecognitionResourceType))
            {
                throw new ArgumentNullException(nameof(RecognitionResourceType));
            }
            if (Threshold < 1 || Threshold > 99)
            {
                throw new ArgumentOutOfRangeException(nameof(Threshold), Threshold, "在 1 到 99 之间");
            }
            if (FaceGroupIndexCodes == null)
            {
                throw new ArgumentNullException(nameof(FaceGroupIndexCodes));
            }
            if (FaceGroupIndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(FaceGroupIndexCodes), FaceGroupIndexCodes.Length, "最少一个人脸资源");
            }
            if (CameraIndexCodes == null)
            {
                throw new ArgumentNullException(nameof(CameraIndexCodes));
            }
            if (CameraIndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CameraIndexCodes), CameraIndexCodes.Length, "最少一个摄像头资源");
            }
        }
    }
}
