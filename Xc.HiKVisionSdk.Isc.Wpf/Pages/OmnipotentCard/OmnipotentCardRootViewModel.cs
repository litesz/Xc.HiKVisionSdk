using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.OmnipotentCard
{
    public class OmnipotentCardRootViewModel : Conductor<IScreen>.Collection.OneActive
    {

        public OmnipotentCardRootViewModel(IContainer container)
        {
            Items.Add(container.Get<AcsViewModel>());

            ActiveItem = Items.FirstOrDefault();

            DisplayName = "一卡通";
        }
    }
}
