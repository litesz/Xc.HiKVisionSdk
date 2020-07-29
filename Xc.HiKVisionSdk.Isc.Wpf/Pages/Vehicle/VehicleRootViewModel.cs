using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.Vehicle
{
    public class VehicleRootViewModel : Conductor<IScreen>.Collection.OneActive
    {

        public VehicleRootViewModel(IContainer container)
        {
            Items.Add(container.Get<CarParkViewModel>());

            ActiveItem = Items.FirstOrDefault();

            DisplayName = "车辆管控";
        }
    }
}
