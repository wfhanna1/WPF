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
        public List<Person> Personal { get; set; }
        public UniversityViewModel(IMockData mockData)
        {
            NullChecker.IsObjectInitialized(mockData);
            _mockData = mockData;

            Title = "Sample Universties";
            Personal = _mockData.GetPeople();
        }
    }
}
