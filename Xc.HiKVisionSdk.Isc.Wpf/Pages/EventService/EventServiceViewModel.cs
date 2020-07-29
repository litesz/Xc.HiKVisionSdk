using Stylet;
using StyletIoC;
using System;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.EventService;
using Xc.HiKVisionSdk.Isc.Managers.Pms;
using Xc.HiKVisionSdk.Isc.Managers.Pms.Models;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.EventService
{
    public class EventServiceViewModel : BaseScreenViewModel
    {
        public EventServiceViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "事件服务";
        }



        public async Task EventSubscriptionView()
        {

            try
            {

                IHikEventServiceApiManager apiManagerV1 = Container.Get<IHikEventServiceApiManager>();

                var result = await apiManagerV1.EventSubscriptionViewAsync();


                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Detail?.Length ?? 0}个事件");
            }
            catch (Exception ex)
            {
                WindowManager.ShowMessageBox($"查询失败\r\n" + ex);

            }
            finally
            {

            }

        }

    }
}
