using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private string welcome;
        private string nextButtonText;

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

        public ShellViewModel()
        {
            Title = "Shell Window";
            welcome = "Welcome to the sample app";
            nextButtonText = "Next Screen";
        }
    }
}
