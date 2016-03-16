using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    public class BaseSCEmp:CommisionEmp
    {
       // double grosssales { get; set; }
        //double commsionrate { get; set; }
        double basesalary { get; set; }
        // double Btotal { get; set; }
        public BaseSCEmp(string first, string last,
 string ssn, double sales, double rate, double salary)
 : base( first, last, ssn, sales, rate )
 {
            basesalary = salary; // validate base salary via property
 }
        public double BaseSalary
 {
 get
 {
 return basesalary;
 }
            set
 {
                 basesalary = (value >= 0) ? value : 0; // validation
                 } 
             }

    public override double CalculateTotal()
        {
            return basesalary + base.CalculateTotal();
        }
        public override string ToString()
{
 return string.Format( "base-salaried {0}; base salary: {1:C}",
 base.ToString(), BaseSalary );
 }
}
}
