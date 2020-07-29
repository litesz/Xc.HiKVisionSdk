using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.EventService
{
    public class EventServiceRootViewModel : Conductor<IScreen>.Collection.OneActive
    {

        public EventServiceRootViewModel(IContainer container)
        {
            Items.Add(container.Get<EventServiceViewModel>());

            ActiveItem = Items.FirstOrDefault();

            DisplayName = "事件服务";
        }
    }
}
