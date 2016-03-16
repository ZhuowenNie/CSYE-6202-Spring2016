using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    public  abstract class Employee
    {
         string firstname { get; set; }
        string lastname { get; set; }
        string SSN { get; set; }
        private double total { get; set; }
        public Employee(string first, string last, string ssn)
 {
            firstname = first;
            lastname = last;
            SSN = ssn;
 }

    public abstract double CalculateTotal();
        public override string ToString()
{
 return string.Format( "{0} {1}\nsocial security number: {2}",
 firstname, lastname, SSN );
 }

}
   // protected double Total
    //{
     //   get { return total; }
       // set { total=value; }
    //}

}
