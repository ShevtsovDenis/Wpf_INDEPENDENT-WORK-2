using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf_INDEPENDENT_WORK_2.Models
{
    class Calculation
    {
        public static string GetResult(string str)
        {
            return new DataTable().Compute(str, null).ToString();
        }
    }
}
