using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
    class CalculateFunction
    {

        public static double CalculateTax(double cost)
        {

            const double taxrate = 3.6;


            double tax = (((cost * taxrate) / 100));

            return tax;


        }



        public static double CalculateTotal(double cost)
        {

            const double taxrate = 3.6;


      
            double total = ((cost * taxrate) / 100) + cost;

            return total;


        }












    }
}
