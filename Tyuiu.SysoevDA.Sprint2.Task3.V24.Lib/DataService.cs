using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint2;
using System.Threading.Tasks;

namespace Tyuiu.SysoevDA.Sprint2.Task3.V24.Lib
{
    public class DataService : ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double res;
            if (x == 0)
            {
                res = (Math.Cos(x) + (12 / Math.Pow(x, 2)));
            }
            else if (x > 0)
            {
                res = (x * Math.Pow((10 + Math.Sin(Math.Sqrt(x + 1))/ x),x));
            }
            else if ((x < 0 ) && (x > -28))
            {
                res = (Math.Pow((1 + (1 / Math.Pow(x, 2))),x));
            }
            else
            {
                res = (Math.Pow(x, 2) + 10 * x - (1 / x));
            }
            return Math.Round(res, 3);
        }
    }
}
