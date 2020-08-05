using Stylet;
using StyletIoC;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages
{
    public class BaseScreenViewModel : Screen
    {

        protected readonly IWindowManager WindowManager;
        protected readonly IContainer Container;

        public BaseScreenViewModel(IWindowManager windowManager, IContainer container)
        {
            WindowManager = windowManager;
            Container = container;
        }
    }
}
