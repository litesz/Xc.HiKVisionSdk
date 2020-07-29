using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Acs;
using Xc.HiKVisionSdk.Isc.Managers.Resource;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.OmnipotentCard
{
    public class AcsViewModel : BaseScreenViewModel
    {


        public AcsViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "门禁";
        }

        public bool IsRun { get; set; }

        public async Task Events()
        {

            try
            {
                IsRun = false;

                IHikAcsApiManager resourceApiManagerV2 = Container.Get<IHikAcsApiManager>();

                var result = await resourceApiManagerV2.DoorEventsV2Async(new Managers.Acs.Models.DoorEventsV2Request());

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Total}个人门禁信息");
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
