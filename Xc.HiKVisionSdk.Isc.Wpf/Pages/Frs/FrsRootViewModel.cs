using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.Frs
{
    public class FrsRootViewModel : Conductor<IScreen>.Collection.OneActive
    {

        public FrsRootViewModel(IContainer container)
        {
            Items.Add(container.Get<FaceGroupViewModel>());
            Items.Add(container.Get<FaceViewModel>());
            Items.Add(container.Get<BlackViewModel>());

            ActiveItem = Items.FirstOrDefault();

            DisplayName = "人脸应用";
        }
    }
}
