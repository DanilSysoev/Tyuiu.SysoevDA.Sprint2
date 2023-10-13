using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint2;
using System.Threading.Tasks;

namespace Tyuiu.SysoevDA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res = "";
            int nextDay = 0;
            int nextMonth = 0;
            switch (m)
            {
                case 2:
                    if (n < 28)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else if (n == 28)
                    {
                        nextMonth = m + 1;
                        nextDay = 1;
                    }
                    else
                    {
                        throw new ArgumentException($"Неверная Дата");
                    }
                    break;

                case 4: case 6: case 9: case 11:
                    if (n < 30)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else if (n == 30)
                    {
                        nextMonth = m + 1;
                        nextDay = 1;
                    }
                    else
                    {
                        throw new ArgumentException($"Неверная Дата");
                    }
                    break;

                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (n < 31)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else if (n == 31)
                    {
                        if (m == 12)
                        {
                            nextMonth = 1;
                        }
                        else
                        {
                            nextMonth = m + 1;
                        }
                        nextDay = 1;
                    }
                    else
                    {
                        throw new ArgumentException($"Неверная Дата");
                    }
                    break;
                default:
                    throw new ArgumentException($"Неверная Дата");

            }
            if ((nextMonth > 0) || (nextMonth < 13))
            {
                switch (nextMonth)
                {
                    case 1:
                        res = "Января";
                        break;
                    case 2:
                        res = "Февраля";
                        break;
                    case 3:
                        res = "Марта";
                        break;
                    case 4:
                        res = "Апреля";
                        break;
                    case 5:
                        res = "Мая";
                        break;
                    case 6:
                        res = "Июня";
                        break;
                    case 7:
                        res = "Июля";
                        break;
                    case 8:
                        res = "Августа";
                        break;
                    case 9:
                        res = "Сентября";
                        break;
                    case 10:
                        res = "Октября";
                        break;
                    case 11:
                        res = "Ноября";
                        break;
                    case 12:
                        res = "Декабря";
                        break;
                    default:
                        return "Неверная Дата";

                }
            } 
            return $"{nextDay} {res}";
        }
    }
}
