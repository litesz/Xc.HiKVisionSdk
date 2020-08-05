using Stylet;
using StyletIoC;
using System.IO;
using System.Linq;
using Xc.HiKVisionSdk.Isc.Models;
using Xc.HiKVisionSdk.Isc.Wpf;
using Xc.HiKVisionSdk.Isc.Wpf.Pages.EventService;
using Xc.HiKVisionSdk.Isc.Wpf.Pages.Frs;
using Xc.HiKVisionSdk.Isc.Wpf.Pages.OmnipotentCard;
using Xc.HiKVisionSdk.Isc.Wpf.Pages.Resource;
using Xc.HiKVisionSdk.Isc.Wpf.Pages.Vehicle;

namespace Company.WpfApplication1.Pages
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {

        public string Title => $"海康安防平台接口测试工具" + AppConst.Version;
        public string Address
        {
            get => IscSdkOption.BaseUrl;

            set
            {
                IscSdkOption.BaseUrl = value;
                SaveConfig();
            }
        }

        public string Ak
        {
            get => IscSdkOption.Ak;

            set
            {
                IscSdkOption.Ak = value;
                SaveConfig();
            }
        }
        public string Sk
        {
            get => IscSdkOption.Sk;

            set
            {
                IscSdkOption.Sk = value;
                SaveConfig();
            }
        }
        public decimal SelectedVer
        {
            get => IscSdkOption.Ver;
            set
            {
                IscSdkOption.Ver = value;
                SaveConfig();
            }
        }

        public decimal[] Versions => new[] { 1, 1.1m, 1.2m, 1.3m, 1.4m };

        public bool IsRun { get; set; }

        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), AppConst.JsonName);

        private readonly IWindowManager _windowManager;
        private readonly IContainer _container;

        private IscSdkOption IscSdkOption => _container.Get<IscSdkOption>();
        public ShellViewModel(IWindowManager windowManager, IContainer container)
        {
            _windowManager = windowManager;
            _container = container;
            DisplayName = "海康接口测试";
            LoadOrInitConfig();

            Items.Add(container.Get<ResourceRootViewModel>());
            Items.Add(container.Get<VehicleRootViewModel>());
            Items.Add(container.Get<OmnipotentCardRootViewModel>());
            Items.Add(container.Get<FrsRootViewModel>());
            Items.Add(container.Get<EventServiceRootViewModel>());

            ActiveItem = Items.FirstOrDefault();


        }


        private void LoadOrInitConfig()
        {
            if (File.Exists(_filePath))
            {
                var str = File.ReadAllText(_filePath);
                if (string.IsNullOrEmpty(str))
                {
                    return;
                }
                var temp = Newtonsoft.Json.JsonConvert.DeserializeObject<IscSdkOption>(str);
                if (temp != null)
                {
                    IscSdkOption.Ak = temp.Ak;
                    IscSdkOption.Sk = temp.Sk;
                    IscSdkOption.BaseUrl = temp.BaseUrl;
                    IscSdkOption.Ver = temp.Ver;

                }
            }

        }
        private void SaveConfig()
        {
            File.WriteAllText(_filePath, Newtonsoft.Json.JsonConvert.SerializeObject(IscSdkOption));

        }





    }
}
