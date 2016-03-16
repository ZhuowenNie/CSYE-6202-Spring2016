using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    public class SalariedEmp:Employee
    {
         double weeklysalary { set; get; }
        public SalariedEmp(string first, string last, string ssn,
  double salary) : base( first, last, ssn )
{
            weeklysalary = salary; // validate salary via property
 }
        public double WeeklySalary
        {
            get
            {
                return weeklysalary;
            }
            set
{
                weeklysalary = ((value >= 0) ? value : 0); // validation
                 }

            }

    public override double CalculateTotal()
        {
            //double stotal;

            return weeklysalary;
            
        }
        public override string ToString()
 {
 return string.Format( "salaried employee: {0}\n{1}: {2:C}",
 base.ToString(), "weekly salary", WeeklySalary );
 }
}
}
