using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoadLibrary
{
    public static class CheckIntercalaryYear
    {
        public static bool CheckYear(int year)
        {
            if (DateTime.IsLeapYear(year)) return true;
            return false;
        }
    }
}
