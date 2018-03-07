using SampleWPF.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Common.Interfaces
{
    public interface IMockData
    {
        List<Person> GetPeople();
    }
}
