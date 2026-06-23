using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTypes
{
    internal class EmployeeTaxs
    {
        public String name;
        public double GrossSalary;
        public double tax;

        public double LiquidSalary()
        {
            return GrossSalary * (1 - tax);
        }
        public void BoostSalaray(double Boost)
        {
           GrossSalary = GrossSalary * Boost;
        }
    }
}
