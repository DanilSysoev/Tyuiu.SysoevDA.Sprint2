using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint2;
using System.Threading.Tasks;

namespace Tyuiu.SysoevDA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double func = (Math.Pow(x, 2) - 2);
            if ((func == y) || ((Math.Abs(func) - Math.Abs(y) <= 1) && (Math.Abs(func) - Math.Abs(y) > 0)) || (Math.Abs(x) == y))
            {
                if (Math.Abs(x) >= 1.5)
                {
                    if (y < 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
