using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Common
{
    public class NullChecker
    {
        public static bool IsObjectInitialized(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException($"Null reference to {nameof(obj)}");
            }
            return true;
        }
    }
}
