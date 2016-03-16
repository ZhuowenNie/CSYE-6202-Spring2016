using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    public class CommisionEmp:Employee
    {
        double grosssales { get; set; }
        double commisionrate { get; set; }
        double Ctotal { get; set; }
        public CommisionEmp(string first, string last, string ssn,
  double sales, double rate) : base( first, last, ssn )
{
            grosssales = sales; // validate gross sales via property
            commisionrate = rate; // validate commission rate via property
 }
        public double CommissionRate
 {
 get
 {
 return commisionrate;
 }
            set
 {
                commisionrate = (value > 0 && value < 1) ?
                 value : 0; // validation
                 } // end set
             }

        public double GrossSales
 {
 get
 {
 return grosssales;
 } // end get
 set
 {
                grosssales = ( value >= 0 ) ? value : 0; // validation
 } // end set
 } 
    public override double CalculateTotal()
        {
            return grosssales* commisionrate;
             
            
        }
        public override string ToString()
 {
 return string.Format( "{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
 "commission employee", base.ToString(),
 "gross sales", GrossSales, "commission rate", CommissionRate );
 }
}
}
