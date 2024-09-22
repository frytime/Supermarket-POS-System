using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
    class OperatorFunction
    {



        public static double Add(double result, double value)
        {

            double answer = result + value;

            return answer;

        }


        public static double Subtract(double result, double value)
        {

            double answer = result - value;

            return answer;

        }

        public static double Multiply(double result, double value)
        {

            double answer = result * value;

            return answer;

        }

        public static double Divide(double result, double value)
        {

            double answer = result / value;

            return answer;

        }

        public static double Power(double result, double value)
        {

            double answer = Math.Pow(result, value);

            return answer;

        }

        public static double Root(double result)
        {

            double answer = Math.Sqrt(result);

            return answer;

        }

    }
}
