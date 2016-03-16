using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll2
{
    public class HourlyEmp : Employee
    {
        double hourlywage { get; set; }
        double workhours { get; set; }
        double Htotal { get; set; }
        public HourlyEmp(string first, string last, string ssn,
 double hourlyWage, double hoursWorked)
 : base(first, last, ssn)
        {
            hourlywage = hourlyWage; // validate hourly wage via property
            workhours = hoursWorked; // validate hours worked via property
        }
        public double Wage
        {
            get
            {
                return hourlywage;
            }
            set
            {
                hourlywage = (value >= 0) ? value : 0; // validation
            } // end set
        }
        public double Hours
        {
            get
            {
                return workhours;
            } // end get
            set
            {
                workhours = ((value >= 0) && (value <= 168)) ?
 value : 0; // validation
            } // end set
        }

        public override double CalculateTotal()
        {

            return hourlywage * workhours;

        }
        public override string ToString()
        {
            return string.Format(
            "hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}",
            base.ToString(), "hourly wage", Wage, "hours worked", Hours);
        }

    }
}
