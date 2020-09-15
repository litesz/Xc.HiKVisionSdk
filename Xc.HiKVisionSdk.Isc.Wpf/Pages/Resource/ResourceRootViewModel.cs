using Stylet;
using StyletIoC;
using System.Linq;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.Resource
{
    public class ResourceRootViewModel : Conductor<IScreen>.Collection.OneActive
    {

        public ResourceRootViewModel(IContainer container)
        {
            Items.Add(container.Get<PersonViewModel>());

            ActiveItem = Items.FirstOrDefault();

            DisplayName = "资源目录";
        }
    }
}
