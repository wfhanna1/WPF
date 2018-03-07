using Prism.Commands;
using Prism.Regions;
using SampleWPF.Common;
using SampleWPF.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Module.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        private string welcome;
        private string nextButtonText;
        private IRegionManager _regionManager;

        public string Welcome
        {
            get => welcome;
            set => SetProperty(ref welcome, value);
        }

        public string NextButtonText
        {
            get => nextButtonText;
            set => SetProperty(ref nextButtonText, value);
        }

        public DelegateCommand NextButtonDelegateCommand { get; }

        public WelcomeViewModel(IRegionManager regionManager)
        {
            NullChecker.IsObjectInitialized(regionManager);

            _regionManager = regionManager;

            welcome = "Welcome to the sample app";
            nextButtonText = "Next Screen";
            NextButtonDelegateCommand = new DelegateCommand(NextScreen);
        }

        private void NextScreen()
        {
            _regionManager.RequestNavigate("ContentRegion", "University");
        }
    }
}
