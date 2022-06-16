using Stylet;
using StyletIoC;
using System.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Ia.Managers.Eaas;
using Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine;
using Xc.HiKVisionSdk.Isc.Managers.Acs;
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

                //var r = await resourceApiManagerV2.AcsDoorAdvanceAcsDoorListAsync(new Managers.Resource.Models.Acs.AcsDoorAdvanceAcsDoorListRequest
                //{

                //    PageNo = 1,
                //    PageSize = 10

                //});

                var result = await resourceApiManagerV2.PersonListV2Async(new PersonListV2Request(1, 1000)
               );

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
                //Xc.HiKVisionSdk.Ia.Managers.EventService.IHikEventServiceApiManager hikEventServiceApiManager = Container.Get<Xc.HiKVisionSdk.Ia.Managers.EventService.IHikEventServiceApiManager>();
                //var x = await hikEventServiceApiManager.EventsSearchAsync(new Ia.Managers.EventService.Models.EventsSearchRequest { PageNo = 1, PageSize = 1000 });
                //IHikAcsApiManager _hikAcsApiManager = Container.Get<IHikAcsApiManager>();

                //var requestDto1 = new Xc.HiKVisionSdk.Isc.Managers.Acs.Models.DoorEventsV2Request
                //{
                //    PageSize = 1000,
                //    PageNo = 1,
                //    StartTime = $"{new DateTime(2022, 6, 23, 0, 0, 0):yyyy-MM-ddTHH:mm:ss}+08:00",
                //    EndTime = $"{new DateTime(2022, 6, 23, 23, 0, 0):yyyy-MM-ddTHH:mm:ss}+08:00",
                //    Order = "asc",
                //    Sort = "eventTime",
                //};
                //var result1 = await _hikAcsApiManager.DoorEventsV2Async(requestDto1);

                //var r = result1.Data.List.Where(u => u.PersonId == "10000001").ToList();


                IHikResourceApiManager resourceApiManagerV2 = Container.Get<IHikResourceApiManager>();


                var result1 = await resourceApiManagerV2.AdvanceCameraListAsync(new Managers.Resource.Models.Camera.AdvanceCameraListRequest
                {
                    PageNo = 1,
                    PageSize = 100,

                });




                IHikAcsApiManager hikEaasServiceApiManager = Container.Get<IHikAcsApiManager>();

                //var x = await hikEaasServiceApiManager.AttendanceBatchSearchAsync(new Ia.Managers.Eaas.Attendance.AttendanceBatchSearchRequest(1, 1000));
                var requestDto = new Xc.HiKVisionSdk.Isc.Managers.Acs.Models.DoorEventsV2Request
                {
                    PageSize = 1000,
                    PageNo = 1,
                    StartTime = $"2022-03-25T00:00:00+08:00",
                    EndTime = $"2022-03-26T00:00:00+08:00",
                    Order = "asc",
                    Sort = "eventTime",
                    PersonName = "蒋伟东"
                };
                var result = await hikEaasServiceApiManager.DoorEventsV2Async(requestDto);
            }
            catch (Exception ex)
            {
            }



            //try
            //{
            //    IHikEaasApiManager hikEaasServiceApiManager = Container.Get<IHikEaasApiManager>();

            //    //var x = await hikEaasServiceApiManager.AttendanceBatchSearchAsync(new Ia.Managers.Eaas.Attendance.AttendanceBatchSearchRequest(1, 1000));
            //    var x = await hikEaasServiceApiManager.AttendanceResultListAsync(new Ia.Managers.Eaas.Attendance.AttendanceResultListRequest(1, 10)
            //        //.AddFieldOption("create_time", "2022-03-13 06:00:00", "gte")
            //        //.AddFieldOption("date", "2022-03-13 00:00:00", "eq")
            //        .AddSort("date", "desc")
            //        );
            //}
            //catch (Exception ex)
            //{
            //}


            //try
            //{
            //    IHikResourceApiManager hikEaasServiceApiManager = Container.Get<IHikResourceApiManager>();

            //    var x = await hikEaasServiceApiManager.OrgBatchDeleteAsync(new Managers.Resource.Models.Org.OrgBatchDeleteRequest("8cd881aa-d348-45ea-9ab0-0b606f9215dc"));
            //}
            //catch (Exception ex)
            //{
            //}
            //try
            //{
            //    IHikResourceApiManager hikEaasServiceApiManager = Container.Get<IHikResourceApiManager>();

            //    var x = await hikEaasServiceApiManager.OrgSingleUpdateAsync(new Managers.Resource.Models.Org.OrgSingleUpdateRequest("7257b84f-2dd6-491e-af76-68d6ba7ec82c", "bba"));
            //}
            //catch (Exception ex)
            //{
            //}

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

                var result = await resourceApiManager.CardInfoAsync(new Managers.Irds.Models.CardInfoRequest("1314307314")
               );

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
