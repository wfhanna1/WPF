using Prism.Commands;
using Prism.Regions;
using SampleWPF.Common;
using SampleWPF.Common.Interfaces;
using SampleWPF.Common.Models;
using SampleWPF.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Module.ViewModels
{
    public class UniversityViewModel : BaseViewModel
    {
        private IMockData _mockData { get; set; }
        private IRegionManager _regionManager { get; set; }
        private string backButton;

        public string BackButtonText
        {
            get => backButton;
            set => SetProperty(ref backButton, value);
        }
        public List<Person> Personal { get; set; }
        public DelegateCommand BackButtonCommand { get; }

        public UniversityViewModel(IMockData mockData, IRegionManager regionManager)
        {
            NullChecker.IsObjectInitialized(mockData);
            NullChecker.IsObjectInitialized(regionManager);

            _mockData = mockData;
            _regionManager = regionManager;

            Title = "Sample Universties";
            Personal = _mockData.GetPeople();
            backButton = "Back";
            BackButtonCommand = new DelegateCommand(GoBack);
        }

        private void GoBack()
        {
            _regionManager.RequestNavigate("ContentRegion", "Welcome");
        }
    }
}
