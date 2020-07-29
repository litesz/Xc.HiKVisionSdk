using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Frs;
using Xc.HiKVisionSdk.Isc.Managers.Resource;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.Frs
{
    public class FaceViewModel : BaseScreenViewModel
    {

        public FaceViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "人脸";
        }

        public bool IsRun { get; set; }

        public async Task Face()
        {

            try
            {
                IsRun = false;

                IHikFrsApiManager api = Container.Get<IHikFrsApiManager>();

                var result = await api.FaceAsync(new Managers.Frs.Models.FaceRequest());

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Total}个人脸");
            }
            catch (Exception ex)
            {
                WindowManager.ShowMessageBox($"查询失败\r\n" + ex);

            }
            finally
            {
                IsRun = true;
            }
        }


        public async Task Recognition()
        {
            try
            {
                IsRun = false;

                IHikFrsApiManager api = Container.Get<IHikFrsApiManager>();

                var result = await api.ResourceRecognitionAsync(new Managers.Frs.Models.RecognitionRequest());

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Length}个人脸资源");
            }
            catch (Exception ex)
            {
                WindowManager.ShowMessageBox($"查询失败\r\n" + ex);

            }
            finally
            {
                IsRun = true;
            }

        }



    }
}
