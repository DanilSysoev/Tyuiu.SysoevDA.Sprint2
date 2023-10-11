using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint2;
using System.Threading.Tasks;

namespace Tyuiu.SysoevDA.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x > -3) && (x <= 13) && (y >= 3) && (y <= 13))
            { 
                if ((x >= 6) && (x <= 8) && (y >= 3) && (y <=4))
                {
                    return false;
                }
                else
                {
                    if ((x >= 3) && (x <= 6) && (y >= 6) && (y <= 8))
                    {
                        return false;
                    }
                    else
                    {
                        if ((x >= 5) && (x <= 6) && (y >= 10) && (y <= 13))
                        {
                            return false;
                        }
                        else
                        {
                            if ((x >= 9) && (x <= 10) && (y >= 9) && (y <= 13))
                            {
                                return false;
                            }
                            else
                            {
                                if ((x >= 11) && (x <= 13) && (y >= 4) && (y <= 5))
                                {
                                    return false;
                                }
                                else
                                {
                                    if (((x == 13) && (y == 3)) || ((x == 3) && (y == 9)) || ((x == 3) && (y == 10)) || ((x == 3) && (y == 12)) || ((x == 3) && (y == 13)) || ((x == 8) && (y == 13)) || ((x == 13) && (y == 9)) || ((x == 13) && (y == 10)))
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
