using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 单个修改重点人员识别计划请求
    /// </summary>
    public class PlanRecognitionBlackUpdateRequest : BaseRequest
    {


        /// <summary>
        /// 识别计划唯一标识，可从查询重点人员识别计划获取
        /// </summary>
        public string IndexCode { get; set; }

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
        /// 单个修改重点人员识别计划请求
        /// </summary>
        /// <param name="indexCode">识别计划唯一标识</param>
        /// <param name="name">识别计划名称</param>
        /// <param name="recognitionResourceIndexCodes">识别资源唯一标识的集合</param>
        /// <param name="threshold">阈值</param>
        /// <param name="faceGroupIndexCodes">人脸分组唯一标识的集合</param>
        /// <param name="cameraIndexCodes">抓拍点通道唯一标识的集合</param>
        public PlanRecognitionBlackUpdateRequest(string indexCode, string name, string[] recognitionResourceIndexCodes, int threshold, string[] faceGroupIndexCodes, string[] cameraIndexCodes)
        {
            IndexCode = indexCode;
            Name = name;
            FaceGroupIndexCodes = faceGroupIndexCodes;
            CameraIndexCodes = cameraIndexCodes;
            RecognitionResourceIndexCodes = recognitionResourceIndexCodes;
            Threshold = threshold;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(nameof(Name));
            }


            if (Threshold < 1 || Threshold > 99)
            {
                throw new ArgumentOutOfRangeException(nameof(Threshold), "在 1 到 99 之间");
            }

            if (RecognitionResourceIndexCodes == null)
            {
                throw new ArgumentNullException(nameof(RecognitionResourceIndexCodes));
            }
            if (RecognitionResourceIndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(RecognitionResourceIndexCodes), "最少一个计划");
            }

            if (FaceGroupIndexCodes == null)
            {
                throw new ArgumentNullException(nameof(FaceGroupIndexCodes));
            }
            if (FaceGroupIndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(FaceGroupIndexCodes), "最少一个人脸资源");
            }
            if (CameraIndexCodes == null)
            {
                throw new ArgumentNullException(nameof(CameraIndexCodes));
            }
            if (CameraIndexCodes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CameraIndexCodes), "最少一个摄像头资源");
            }
        }

    }

}
