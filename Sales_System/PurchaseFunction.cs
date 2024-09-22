using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
    class PurchaseFunction
    {

        public static double CalculatePurchase(double cost, double tax, double cash)
        {

            double change = (cash - tax - cost);


            return change;
        }

    }
}
