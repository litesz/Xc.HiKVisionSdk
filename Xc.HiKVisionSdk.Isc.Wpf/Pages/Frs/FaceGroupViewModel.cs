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
    public class FaceGroupViewModel : BaseScreenViewModel
    {

        public FaceGroupViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "人脸分组";
        }

        public bool IsRun { get; set; }

        public async Task FaceGroup()
        {

            try
            {
                IsRun = false;

                IHikFrsApiManager api = Container.Get<IHikFrsApiManager>();

                var result = await api.FaceGroupAsync(new Managers.Frs.Models.FaceGroupRequest { });

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Length}个人脸分组");
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
