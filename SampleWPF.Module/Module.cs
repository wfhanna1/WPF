using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using SampleWPF.Common;
using SampleWPF.Module.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Module
{
    public class Module : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public Module(RegionManager regionManager, IUnityContainer container)
        {
            NullChecker.IsObjectInitialized(regionManager);
            NullChecker.IsObjectInitialized(container);
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(Welcome));
            _container.RegisterTypeForNavigation<University>();
            _container.RegisterTypeForNavigation<Welcome>();
        }
    }
}
