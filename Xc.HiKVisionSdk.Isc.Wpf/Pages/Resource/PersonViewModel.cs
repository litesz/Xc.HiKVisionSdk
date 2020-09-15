using Stylet;
using StyletIoC;
using System;
using System.IO;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Irds;
using Xc.HiKVisionSdk.Isc.Managers.Resource;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Card;
using Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.Resource
{
    public class PersonViewModel : BaseScreenViewModel
    {

        public PersonViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "人员信息接口";
        }

        public bool IsRun { get; set; }

        public async Task PersonList()
        {

            try
            {
                IsRun = false;

                IHikResourceApiManager resourceApiManagerV2 = Container.Get<IHikResourceApiManager>();

                var result = await resourceApiManagerV2.PersonListV2Async(new PersonListV2Request
                {
                    PageSize = 10,
                    PageNo = 1
                });

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "PersonList.json");
                File.WriteAllText(path, JsonExtensions.Serialize(result));
                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Total}个人员信息");
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




        public async Task OrgList()
        {

            try
            {
                IsRun = false;

                IHikResourceApiManager resourceApiManager = Container.Get<IHikResourceApiManager>();

                var orgList = await resourceApiManager.OrgListAsync(new Managers.Resource.Models.Org.OrgListRequest
                {
                    PageSize = 10,
                    PageNo = 1
                });

                if (orgList.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{orgList.Code}\r\n消息:${orgList.Msg}");
                    return;
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "OrgList.json");
                File.WriteAllText(path, JsonExtensions.Serialize(orgList));

                WindowManager.ShowMessageBox($"查询成功，共有{orgList.Data.Total}个组织");
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

        public async Task CardList()
        {
            try
            {
                IsRun = false;

                IHikResourceApiManager resourceApiManager = Container.Get<IHikResourceApiManager>();

                var result = await resourceApiManager.CardListAsync(new CardListRequest
                {
                    PageNo = 1,
                    PageSize = 10
                });

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "CardList.json");
                File.WriteAllText(path, JsonExtensions.Serialize(result));


                WindowManager.ShowMessageBox($"查询成功:{result.Data.Total}张卡");
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

        public async Task CardInfo()
        {

            try
            {
                IsRun = false;

                IHikIrdsApiManager resourceApiManager = Container.Get<IHikIrdsApiManager>();

                var result = await resourceApiManager.CardInfoAsync(new Managers.Irds.Models.CardInfoRequest
                {
                    CardNo = "1314307314"
                });

                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }

                WindowManager.ShowMessageBox($"查询成功:{result.Data.PersonName}-{result.Data.PersonId}");
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
