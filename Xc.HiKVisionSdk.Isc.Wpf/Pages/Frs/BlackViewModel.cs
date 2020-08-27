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
    public class BlackViewModel : BaseScreenViewModel
    {

        public BlackViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "重点人员识别计划";
        }

        public bool IsRun { get; set; }

        public async Task Black()
        {

            try
            {
                IsRun = false;

                IHikFrsApiManager api = Container.Get<IHikFrsApiManager>();

                var result = await api.PlanRecognitionBlackAsync(new Managers.Frs.Models.PlanRecognitionBlackRequest());

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Length}个重点人员识别计划");
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


        public async Task BlackSearch()
        {

            try
            {
                IsRun = false;

                IHikFrsApiManager api = Container.Get<IHikFrsApiManager>();

                var request = new Managers.Frs.Models.EventBlackSearchRequest
                {
                    StartTime = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-ddTHH:mm:ss") + ".000+08:00",
                    EndTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") + ".000+08:00",
                    PageSize = 1000
                };

                var result = await api.EventBlackSearch(request);

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，一个月内共有{result.Data.List.Length}个重点人员识别计划记录");
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
